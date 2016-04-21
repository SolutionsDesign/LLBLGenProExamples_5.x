using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Northwind.BO;
using Northwind.DAL.DatabaseSpecific;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.WPFGui
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private CustomerEntity _customerWithHighestOrder, _customerWithMostOrders;

		public MainWindow()
		{
			InitializeComponent();
			this.Language = XmlLanguage.GetLanguage(Thread.CurrentThread.CurrentCulture.Name);
			CalculateStatistics();
		}

		/// <summary>
		/// Calculates the statistics for the Northwind database and shows them in the form, illustrating the
		/// direct database power LLBLGen Pro offers you through scalar functions, aggregates, group by and expressions.
		/// </summary>
		/// <remarks>No error checking is applied to this routine, it's for illustrating the framework functionality.</remarks>
		private void CalculateStatistics()
		{
			var statistics = new NWStatistics();
			using(var adapter = new DataAccessAdapter())
			{
				statistics.LoadData(adapter);
				_customerWithHighestOrder = adapter.FetchNewEntity<CustomerEntity>(
							new RelationPredicateBucket(CustomerFields.CustomerId == statistics.MaxOrderCustomerCustomerId));
				_customerWithMostOrders = adapter.FetchNewEntity<CustomerEntity>(
							new RelationPredicateBucket(CustomerFields.CustomerId == statistics.MostOrdersCustomerCustomerId));
			}
			_statsGroup.DataContext = statistics;
		}

		private void _exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void _openCustomersByProductListerButton_Click(object sender, RoutedEventArgs e)
		{
			var lister = new CustomersByProductLister();
			lister.ShowDialog();
		}

		private void _editHighestPriceCustomerButton_Click(object sender, RoutedEventArgs e)
		{
			var manager = new CustomerManager(_customerWithHighestOrder);
			manager.ShowDialog();
		}

		private void _editMostOrdersCustomerButton_Click(object sender, RoutedEventArgs e)
		{
			var manager = new CustomerManager(_customerWithMostOrders);
			manager.ShowDialog();
		}

		private void _openCustomerManagerButton_Click(object sender, RoutedEventArgs e)
		{
			var manager = new CustomerManager();
			manager.ShowDialog();
		}
	}
}
