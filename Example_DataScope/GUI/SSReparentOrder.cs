using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Northwind.BO;
using Northwind.SSDAL.EntityClasses;

namespace Northwind.GUI
{
	public partial class SSReparentOrder : Form
	{
		#region Class Member Declarations
		private SSEmployeesWithOrdersDataScope _datascope;
		#endregion


		public SSReparentOrder()
		{
			InitializeComponent();
		}


		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			_datascope = new SSEmployeesWithOrdersDataScope();
			_datascope.FetchData();
			_employeesFromBindingSource.DataSource = _datascope.Employees;
			_employeesToBindingSource.DataSource = _datascope.Employees;
			_datascope.ContainedDataChanged += new EventHandler(_datascope_ScopedDataChanged);
		}

		private void _fromOrdersGrid_SelectionChanged(object sender, EventArgs e)
		{
			_moveSelectedButton.Enabled = (_fromOrdersGrid.SelectedRows.Count > 0);
		}

		private void _moveSelectedButton_Click(object sender, EventArgs e)
		{
			if(_fromOrdersGrid.SelectedRows.Count <= 0)
			{
				return;
			}
			var entityToMove = _fromOrdersGrid.SelectedRows[0].DataBoundItem as OrderEntity;
			if(entityToMove == null)
			{
				return;
			}
			var toEmployee = _employeesToBindingSource.Current as EmployeeEntity;
			// just add it to the new collection. It will be de-referenced due to the add from the other entity.
			toEmployee.Orders.Add(entityToMove);
		}


		private void _datascope_ScopedDataChanged(object sender, EventArgs e)
		{
			_saveChangesButton.Enabled = true;
		}

		private void _saveChangesButton_Click(object sender, EventArgs e)
		{
			_datascope.CommitChanges();
		}
	}
}
