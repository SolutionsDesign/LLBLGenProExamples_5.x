using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.DAL.DatabaseSpecific;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace Northwind.BO
{
	/// <summary>
	/// Class which is used to transport some statistics data to the client for the main screen.
	/// </summary>
	public class NWStatistics
	{
		/// <summary>
		/// Loads the statistics data from the DB into this object.
		/// </summary>
		/// <returns>filled NWStatistics object</returns>
		public void LoadData(IDataAccessAdapter adapter)
		{
			if(adapter == null)
			{
				throw new ArgumentNullException("adapter");
			}
			var qf = new QueryFactory();
			this.NumberOfCustomers = adapter.FetchScalar<int>(qf.Create().Select(qf.Customer.CountRow()));

			// calculate average order price in the DB.
			var avgQ = qf.Create()
							.Select(() => new { AvgPrice = qf.Field("OrderPrice").Source("T").Avg().As("AvgPrice").ToValue<Decimal>() })
							.From(qf.Create("T")
										.Select(OrderDetailFields.OrderId,
												(OrderDetailFields.Quantity * OrderDetailFields.UnitPrice).Sum().As("OrderPrice"))
										.GroupBy(OrderDetailFields.OrderId));
			var avgResults = adapter.FetchQuery(avgQ);
			this.AverageOrderPrice = avgResults[0].AvgPrice;

			// calculate max, the orderid with that max, the customer of that order in 1 query on the DB using a desc order + limit 1 query.
			var maxQ = qf.Create()
							.Select(() => new
							{
								OrderPrice = qf.Field("OrderPrice").Source("T").ToValue<decimal>(),
								CustomerId = CustomerFields.CustomerId.ToValue<string>(),
								CompanyName = CustomerFields.CompanyName.ToValue<string>()
							})
							.From(qf.Create("T")
										.Select(OrderDetailFields.OrderId,
												(OrderDetailFields.Quantity * OrderDetailFields.UnitPrice).Sum().As("OrderPrice"))
										.GroupBy(OrderDetailFields.OrderId)
									.InnerJoin(qf.Order).On(OrderFields.OrderId == OrderDetailFields.OrderId.Source("T"))
									.InnerJoin(qf.Customer).On(CustomerFields.CustomerId == OrderFields.CustomerId))
							.OrderBy(qf.Field("OrderPrice").Source("T").Descending())
							.Limit(1);

			var maxResults = adapter.FetchFirst(maxQ);
			this.MaxOrderPrice = maxResults.OrderPrice;
			this.MaxOrderCustomerCustomerId = maxResults.CustomerId;
			this.MaxOrderCustomerCompanyName = maxResults.CompanyName;

			// get number of max orders of one customer + the customerid of that customer in 1 query on the DB.
			var mostOrdersQ = qf.Create()
								.Select(() => new
								{
									NumberOfOrders = qf.Field("NumberOfOrders").Source("T").ToValue<int>(),
									CustomerId = CustomerFields.CustomerId.ToValue<string>(),
									CompanyName = CustomerFields.CompanyName.ToValue<string>()
								})
								.From(qf.Create("T")
											.Select(OrderFields.CustomerId, Functions.CountRow().As("NumberOfOrders"))
											.GroupBy(OrderFields.CustomerId)
										.InnerJoin(qf.Customer).On(OrderFields.CustomerId.Source("T") == CustomerFields.CustomerId))
								.OrderBy(qf.Field("NumberOfOrders").Source("T").Descending())
								.Limit(1);

			var mostOrdersResults = adapter.FetchFirst(mostOrdersQ);
			this.MostOrdersCustomerCustomerId = mostOrdersResults.CustomerId;
			this.MostOrdersCustomerCompanyName = mostOrdersResults.CompanyName;
			this.MostOrdersForOneCustomer = mostOrdersResults.NumberOfOrders;
		}

		#region Properties
		public int NumberOfCustomers { get; set; }
		public decimal MaxOrderPrice { get; set; }
		public string MaxOrderCustomerCompanyName { get; set; }
		public string MaxOrderCustomerCustomerId { get; set; }
		public decimal AverageOrderPrice { get; set; }
		public string MostOrdersCustomerCustomerId { get; set; }
		public string MostOrdersCustomerCompanyName { get; set; }
		public int MostOrdersForOneCustomer { get; set; }
		#endregion
	}
}
