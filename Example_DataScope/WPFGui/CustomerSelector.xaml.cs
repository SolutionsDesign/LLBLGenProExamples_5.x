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
using Northwind.DAL.HelperClasses;

namespace Northwind.WPFGui
{
	/// <summary>
	/// Interaction logic for CustomerSelector.xaml
	/// </summary>
	public partial class CustomerSelector : Window
	{
		private EntityCollection<CustomerEntity> _allCustomers;

		public CustomerSelector()
		{
			InitializeComponent();

			// get all customers
			_allCustomers = new EntityCollection<CustomerEntity>();
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				adapter.FetchEntityCollection(_allCustomers, null);
			}
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			System.Windows.Data.CollectionViewSource customerEntityViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerEntityViewSource")));
			// Load data by setting the CollectionViewSource.Source property:
			customerEntityViewSource.Source = _allCustomers;
			if(_allCustomers.Count > 0)
			{
				// there are customers, enable select button
				_selectButton.IsEnabled = true;
				// select first row.
				_customersGrid.SelectedIndex=0;
			}
		}

		private void _selectButton_Click(object sender, RoutedEventArgs e)
		{

			this.DialogResult = true;
		}

		private void _cancelButton_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = false;
			this.Close();
		}


		public CustomerEntity SelectedCustomer
		{
			get 
			{
				return _customersGrid.SelectedItem as CustomerEntity;
			}	
		}
	}
}
