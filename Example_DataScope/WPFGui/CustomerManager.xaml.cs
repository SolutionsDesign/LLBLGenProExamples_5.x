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
using Northwind.BO;
using Northwind.DAL.DatabaseSpecific;
using Northwind.DAL.EntityClasses;

namespace Northwind.WPFGui
{
	/// <summary>
	/// Interaction logic for CustomerManager.xaml
	/// </summary>
	public partial class CustomerManager : Window
	{
		#region Class Member Declarations
		private CustomerWithOrdersDataScope _customerScope;
		#endregion

		public CustomerManager()
		{
			InitializeComponent();
			_customerScope = new CustomerWithOrdersDataScope();
			_customerScope.ContainedDataChanged += new EventHandler(_customerScope_ScopedDataChanged);
		}


		public CustomerManager(CustomerEntity customer)
			: this()
		{
			SetCustomerAsCurrent(customer);
		}


		/// <summary>
		/// Binds the current set customer (in _currentCustomer) to the gui's controls so data entered is validated directly.
		/// </summary>
		private void BindCustomerToGui()
		{
			if(_customerScope == null)
			{
				return;
			}
			CollectionViewSource customerEntityViewSource = ((CollectionViewSource)(this.FindResource("customerEntityViewSource")));
			// Load data by setting the CollectionViewSource.Source property:
			customerEntityViewSource.Source = new List<CustomerEntity>() { _customerScope.Customer};
			_saveChangesButton.IsEnabled = false;
		}


		/// <summary>
		/// Sets the given customer as the current customer, adding values of the customer to the controls on the form and setting
		/// up eventhandlers so the gui is aware of changes of the customer or its contents.
		/// </summary>
		/// <param name="customer"></param>
		private void SetCustomerAsCurrent(CustomerEntity customer)
		{
			// set new customer object.
			_customerScope.Add(customer);
			_customerScope.FetchData();
			BindCustomerToGui();
		}


		private void SelectNewCustomer()
		{
			CustomerSelector selector = new CustomerSelector();
			var dialogResult = selector.ShowDialog() ?? false;
			if(!dialogResult)
			{
				return;
			}
			SetCustomerAsCurrent(selector.SelectedCustomer);
		}


		private void _customerScope_ScopedDataChanged(object sender, EventArgs e)
		{
			_saveChangesButton.IsEnabled = true;
		}

		private void _saveChangesButton_Click(object sender, RoutedEventArgs e)
		{
			// save the changes to the persistent storage.
			using(var adapter = new DataAccessAdapter())
			{
				bool succeeded = _customerScope.CommitChanges(adapter);
				if(succeeded)
				{
					MessageBox.Show("Save was succesful!", "Save result", MessageBoxButton.OK, MessageBoxImage.Information);
					_saveChangesButton.IsEnabled = false;
				}
				else
				{
					MessageBox.Show(this, "Save was NOT succesful!", "Save result", MessageBoxButton.OK, MessageBoxImage.Information);
				}
			}

		}

		private void _selectCustomerButton_Click(object sender, RoutedEventArgs e)
		{
			SelectNewCustomer();
		}
	}
}
