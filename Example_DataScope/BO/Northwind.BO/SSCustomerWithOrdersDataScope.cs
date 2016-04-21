using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.SelfServicing;
using Northwind.SSDAL.EntityClasses;
using Northwind.SSDAL.FactoryClasses;
using Northwind.SSDAL;
using Northwind.SSDAL.HelperClasses;
using Northwind.SSDAL.CollectionClasses;


namespace Northwind.BO
{
	/// <summary>
	/// SelfServicing specific version of the customer scope
	/// </summary>
	public class SSCustomerWithOrdersDataScope : DataScope
	{
		#region Class Member Declarations
		private CustomerEntity _customer;
		private string _customerID;
		#endregion

		/// <summary>
		/// Initializes a new instance of the <see cref="SSCustomerWithOrdersDataScope"/> class.
		/// </summary>
		public SSCustomerWithOrdersDataScope()
		{
			_customerID = string.Empty;
		}


		/// <summary>
		/// Adds the specified entity
		/// </summary>
		/// <param name="toAdd">To add.</param>
		/// <returns></returns>
		public CustomerEntity Add(CustomerEntity toAdd)
		{
			if(toAdd != null)
			{
				_customer = toAdd;
				this.Attach(toAdd);
			}
			return toAdd;
		}


		/// <summary>
		/// Called when this scope is reset.
		/// </summary>
		protected override void OnReset()
		{
			base.OnReset();
			// reset all navigator aspects of all collection navigators
			//this.OverrideDefaultNavigatorAspects(NavigatorAspectType.None);
			//// set the navigator aspects of Order.OrderDetails.
			//this.SetNavigatorAspects<OrderEntity>(OrderEntity.MemberNames.OrderDetails,
			//                                      NavigatorAspectType.AllowNew | NavigatorAspectType.AllowEdit | NavigatorAspectType.AllowRemove);
		}


		/// <summary>
		/// The implementation of the fetch method. In this method, fetch the data for the scope. Use the TrackQuery methods to make sure
		/// all entities fetched in this method are tracked by the scope.
		/// </summary>
		/// <returns>
		/// true if the fetch was successful, false otherwise
		/// </returns>
		protected override bool FetchDataImpl(params object[] fetchMethodParameters)
		{
			// use DI scope here to set the injectables during fetch.
			// Fetch using a query, which is tracked
			_customer = this.TrackQuery(CreateCustomerFetchQuery()).GetFirst();

			//// or alternatively, fetch it using a normal non-tracked query or obtain it from a service
			//_customer = CreateCustomerFetchQuery().GetFirst();
			//// ... and attach it. All entities reachable from _customer are attached as well. 
			//AttachEntity(_customer);
			return _customer != null;
		}


		/// <summary>
		/// Creates the customer fetch query.
		/// </summary>
		/// <returns></returns>
		private EntityQuery<CustomerEntity> CreateCustomerFetchQuery()
		{
			var qf = new QueryFactory();
			return qf.Customer
						.Where(CustomerFields.CustomerId == this.CustomerID)
						.WithPath(CustomerEntity.PrefetchPathOrders.WithSubPath(
											OrderEntity.PrefetchPathOrderDetails.WithSubPath(OrderDetailEntity.PrefetchPathProduct), 
											OrderEntity.PrefetchPathEmployee));
		}


		/// <summary>
		/// Called when toDelete is about to be deleted. Use this method to specify work to be done by the scope to avoid FK constraint issues.
		/// workData is meant to collect this work. It can either be additional entities to delete prior to 'toDelete', or a list of
		/// relations which are used to create cascading delete actions executed prior to the delete action of toDelete.
		/// </summary>
		/// <param name="toDelete">To delete.</param>
		/// <param name="workData">The work data.</param>
		protected override void OnEntityDelete(IEntityCore toDelete, WorkDataCollector workData)
		{
			switch((EntityType)toDelete.LLBLGenProEntityTypeValue)
			{
				case EntityType.OrderEntity:
					// only add edge for entities not already in the graph. All order details are in the graph. 
					workData.Add(OrderEntity.Relations.OrderAuditInfoEntityUsingOrderId);
					// alternatively, we could opt for fetching the data to delete.
					//var qf = new QueryFactory();
					//var q = qf.OrderAuditInfo.Where(OrderAuditInfoFields.OrderId == ((OrderEntity)toDelete).OrderId);
					//workData.Add(new OrderAuditInfoCollection().GetMulti(q));
					break;
				case EntityType.CustomerEntity:
					workData.Add(CustomerEntity.Relations.CustomerCustomerDemoEntityUsingCustomerId);
					workData.Add(CustomerEntity.Relations.OrderEntityUsingCustomerId);
					workData.Add(OrderEntity.Relations.OrderDetailEntityUsingOrderId);
					workData.Add(OrderEntity.Relations.OrderAuditInfoEntityUsingOrderId);
					break;
			}
		}


		#region Class Property Declarations
		public string CustomerID
		{
			get { return _customer == null ? null : _customer.CustomerId; }
			set
			{
				if(_customer == null)
				{
					_customerID = value;
				}
			}
		}

		public CustomerEntity Customer
		{
			get { return _customer; }
		}
		

		public OrderCollection Orders
		{
			get { return _customer==null ? null : _customer.Orders; }
		}
		#endregion
	}
}
