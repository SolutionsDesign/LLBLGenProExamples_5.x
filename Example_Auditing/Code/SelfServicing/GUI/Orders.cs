using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    public partial class Orders : Form
    {
        private OrderCollection _ordersToDelete;

        public Orders()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // collection used to track the user deleted rows so  when user Save Changes
            // also deletes these entities.
            _ordersToDelete = new OrderCollection();

                       
            /// load initial data           
            
            // load data for combos
            _customersCollection.GetMulti(null);
            _employeesCollection.GetMulti(null);
            _shippersCollection.GetMulti(null);
            _auditActionTypeCollection.GetMulti(null);

            // load orders
            _ordersCollection.GetMulti(null);

            // load audit info
            _orderAuditInfoCollection.GetMulti(null);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load data again if user request that            
            _ordersCollection.GetMulti(null);

            // clean entities
            _ordersToDelete = new OrderCollection();

            // show message to user
            MessageBox.Show("Orders loaded.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // persist changes to DB
            _ordersCollection.SaveMulti();

            // persist user deletion to DB
            _ordersToDelete.DeleteMulti();

            // show message to user
            MessageBox.Show("Changes saved.");
        }       

        private void _ordersGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // track the user delete entity so later we can persist such deletion
            OrderEntity orderSelected = ((OrderEntity)e.Row.DataBoundItem);
            _ordersToDelete.Add(orderSelected);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // done
            this.Close();
        }

        private void btnAuditInfoRefesh_Click(object sender, EventArgs e)
        {
            // refresh order auditInfo
            _orderAuditInfoCollection.GetMulti(null);            
        }


    }
}