///////////////////////////////////////////////////////////////
// LLBLGen Pro v2.6 - Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 2.6
// (c) Solutions Design
//////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;
using SD.LLBLGen.Pro.Examples;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGenPro.Examples.GUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmCustomers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // fetch all customers
            _customersCollection.GetMulti(null);
            DisableEditControls();
        }

        /// <summary>
        /// Enables the edit controls.
        /// </summary>
        private void EnableEditControls()
        {
            gbxFields.Enabled = btnSave.Enabled = btnCancel.Enabled = true;
            btnEdit.Enabled = btnAdd.Enabled = btnExit.Enabled = _customersGrid.Enabled = false;
        }

        /// <summary>
        /// Disables the edit controls.
        /// </summary>
        private void DisableEditControls()
        {                       
            gbxFields.Enabled = btnSave.Enabled = btnCancel.Enabled = false;
            btnEdit.Enabled = btnAdd.Enabled = btnExit.Enabled = _customersGrid.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the btnAdd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _customersBinder.AddNew();
            EnableEditControls();            
        }

        /// <summary>
        /// Handles the Click event of the btnEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEditControls();
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // the current binder's customer to edit
            CustomerEntity customerToSave = (CustomerEntity)_customersBinder.Current;

            // there are errors, cancel the save until the user fixes them.
            if (customerToSave.GetEntityFieldsErrors() != string.Empty)
            {
                MessageBox.Show("There are errors in the entity. Please fix them prior to save.", "Please fix the errors.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // there are not field errors
            else
            {
                // save the current customer
                try
                {
                    customerToSave.Save();
                    DisableEditControls();
                }

                // there are entity errors. Show them to the user
                catch (ORMEntityValidationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // reset the IDataErrorInfo from the current customer
            // this method is placed at entity code (partial class), you can plase it at GUI too.
            ((CustomerEntity)_customersBinder.Current).ResetErrors();

            // cancel the binder edit operation
            _customersBinder.CancelEdit();

            // update the errors at GUI (at this moment there's not errors)
            _customersErrorProvider.UpdateBinding();

            DisableEditControls();            
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the UserDeletingRow event of the _customersGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DataGridViewRowCancelEventArgs"/> instance containing the event data.</param>
        private void _customersGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this customer?", "Delete customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // the user wants to delete the current customer
            if (res == DialogResult.Yes)
            {
                // delete the current customer
                try
                {
                    CustomerEntity customerToDelete = (CustomerEntity)e.Row.DataBoundItem;
                    customerToDelete.Delete();
                }

                // there are entity error on the delete action
                catch (ORMEntityValidationException ex)
                {
                    e.Cancel = true;
                    MessageBox.Show(ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // cancel the delete row operation
            else
            {
                e.Cancel = true;
            }
        }
    }
}