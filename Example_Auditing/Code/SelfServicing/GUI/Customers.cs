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
    public partial class Customers : Form
    {
        private CustomerCollection _customersToDelete;

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // collection used to track the user deleted rows so  when user Save Changes
            // also deletes these entities.
            _customersToDelete = new CustomerCollection();

            // load initial data           
            _customersCollection.GetMulti(null);
            _auditActionTypeCollection.GetMulti(null);
            _auditInfoCollection.GetMulti(null);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load data again if user request that            
            _customersCollection.GetMulti(null);

            // clean entities
            _customersToDelete = new CustomerCollection();

            // show message to user
            MessageBox.Show("Customers loaded.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // persist changes to DB
            _customersCollection.SaveMulti();

            // persist user deletion to DB
            _customersToDelete.DeleteMulti();

            // show message to user
            MessageBox.Show("Changes saved.");
        }       

        private void _customersGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // track the user delete entity so later we can persist such deletion
            CustomerEntity customerSelected = ((CustomerEntity)e.Row.DataBoundItem);
            _customersToDelete.Add(customerSelected);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // done
            this.Close();
        }

        private void btnAuditInfoRefesh_Click(object sender, EventArgs e)
        {
            // refresh auditInfo
            _auditInfoCollection.GetMulti(null);
        }


    }
}