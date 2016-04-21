using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Northwind.DAL.DatabaseSpecific;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.Linq;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace Northwind.WPFGui
{
	/// <summary>
	/// A general customer by product lister. It allows you to filter the customers based on a product.
	/// It uses the product to create a filter which spans multiple entities, illustrating filtering, relations and sorting.
	/// It also illustrates databinding and the usage of the collection classes.
	/// </summary>
	public partial class CustomersByProductLister : Window
	{
		public CustomersByProductLister()
		{
			InitializeComponent();

			// load products, sort them on ProductName asc. We're going to use QuerySpec for this.
			var qf = new QueryFactory();
			var q = qf.Product
						.OrderBy(ProductFields.ProductName.Ascending());
			using(var adapter = new DataAccessAdapter())
			{
				var products = adapter.FetchQuery(q);
				_productSelectComboBox.DataContext = products;
				_productSelectComboBox.SelectedIndex = 0;
			}

		}

		private void FillGrid()
		{
			// get the selected product
			ProductEntity selectedProduct = _productSelectComboBox.SelectedItem as ProductEntity;
			if(selectedProduct == null)
			{
				return;
			}

			// construct query for customers, based on this product. We're going to use Linq for this, to illustrate you
			// can write queries using any of the query systems provided by the runtime in your application, you don't have to 
			// choose for one system for all your queries. We fetched the products using QuerySpec, we're going to fetch the products
			// using Linq.
			using(var adapter = new DataAccessAdapter())
			{
				var metaData = new LinqMetaData(adapter);
				var q = from c in metaData.Customer
						join o in metaData.Order on c.CustomerId equals o.CustomerId
						join od in metaData.OrderDetail on o.OrderId equals od.OrderId
						join p in metaData.Product on od.ProductId equals p.ProductId
						where p.ProductId == selectedProduct.ProductId
						orderby c.CompanyName ascending
						select c;

				// select the customers. We're using ILLBLGenProQuery to get the entity collection so we can use its specific features:
				// we can obtain the default view and make sure addnew is false. 
				var customers = ((ILLBLGenProQuery)q).Execute<EntityCollection<CustomerEntity>>();
				customers.DefaultView.AllowNew = false;
				// bind them
				_customersGrid.DataContext = customers;

				// get scalar for amount of times this product is sold. We'll use the low-level API for this, to illustrate you can
				// use any of the query systems in your code. 
				object scalarValue = adapter.GetScalar(
						OrderDetailFields.Quantity, null, AggregateFunction.Sum, (OrderDetailFields.ProductId == selectedProduct.ProductId));
				_amountUnitsSoldTextBox.Text = (scalarValue == DBNull.Value ? 0 : (int)scalarValue).ToString();
			}
		}

		private void _productSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			FillGrid();
		}

		private void _exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
