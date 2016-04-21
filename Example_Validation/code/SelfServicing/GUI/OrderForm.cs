using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.CollectionClasses;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;
using SD.LLBLGen.Pro.Examples;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGenPro.Examples.GUI
{
    public partial class OrderForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForm"/> class.
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmOrders control.
        /// Fetch the collections envolved
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void frmOrders_Load(object sender, EventArgs e)
        {
            // fetch the collections needed for the comboboxes
            _customersCollection.GetMulti(null, 0, new SortExpression(CustomerFields.CompanyName | SortOperator.Ascending));
            _employeesCollection.GetMulti(null, 0, new SortExpression(EmployeeFields.FirstName | SortOperator.Ascending));
            _shippersCollection.GetMulti(null, 0, new SortExpression(ShipperFields.CompanyName | SortOperator.Ascending));
            _productsCollection.GetMulti(null, 0, new SortExpression(ProductFields.ProductName | SortOperator.Ascending));

            // fetch orders collection
            _ordersCollection.GetMulti(null);
        }

        /// <summary>
        /// Handles the Click event of the tsbEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            gbxOrder.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the btnSave control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // the current binder's customer to edit
            OrderEntity orderToSave = (OrderEntity)_ordersBinder.Current;

            // there are errors, cancel the save until the user fixes them.
            if (GetEntityFieldsErrors() != string.Empty)
            {
                MessageBox.Show("There are errors in the entity. Please fix them prior to save.", "Please fix the errors.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // there are not field errors
            else
            {                

                // save the current customer
                try
                {
                    orderToSave.Save(true);                    
                    gbxOrder.Enabled = false;
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
            ResetErrors();

            // cancel the binder edit operation
            _ordersBinder.CancelEdit();

            // update the errors at GUI (at this moment there's not errors)
            _ordersErrorProvider.UpdateBinding();

            gbxOrder.Enabled = false;

        }

        /// <summary>
        /// Gets the entity fields errors.
        /// </summary>
        /// <returns>A separater-by-semicolon errors in string representation of the 
        /// error (if exist).
        /// This could be useful if you want to obtain the errors list at some GUI.</returns>
        private string GetEntityFieldsErrors()
        {
            // current item
            OrderEntity currentItem = (OrderEntity)_ordersBinder.Current;

            // variables to construct the message
            StringBuilder sbErrors = new StringBuilder();
            string toReturn = string.Empty;

            // iterate over fields and get their errorInfo
            foreach (IEntityField field in currentItem.Fields)
            {
                /// IEntity implements IDataErrorInfo, and it contains a collections of field errors already set. 
                /// For more info read the docs (LLBLGen Pro Help -> Using generated code -> Validation per field or per entity -> IDataErrorInfo implementation).
                if (!string.IsNullOrEmpty(((System.ComponentModel.IDataErrorInfo)currentItem)[field.Name]))
                {
                    sbErrors.Append(((System.ComponentModel.IDataErrorInfo)currentItem)[field.Name] + ";");
                }
            }

            // determine if there was errors and cut off the extra ';'
            if (sbErrors.ToString() != string.Empty)
            {
                toReturn = sbErrors.ToString();
                toReturn = toReturn.Substring(0, toReturn.Length - 2);
            }

            return toReturn;
        }

        /// <summary>
        /// Resets the errors.
        /// Used to clean the IDataErrorInfo when GUI cancels an Insert/Update operation.
        /// </summary>
        private void ResetErrors()
        {
            // current item
            OrderEntity entityToReseterrors = (OrderEntity)_ordersBinder.Current;

            // reset the field errors
            foreach (EntityField field in entityToReseterrors.Fields)
            {
                entityToReseterrors.SetEntityFieldError(field.Name, string.Empty, false);
            }

            // reset entity error
            entityToReseterrors.SetEntityError(string.Empty);
        }


        private void _ordersBinderNav_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "bindingNavigatorAddNewItem")
            {
                gbxOrder.Enabled = true;
            }
        }
    }
}