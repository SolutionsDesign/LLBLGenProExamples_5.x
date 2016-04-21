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
using SD.LLBLGen.Pro.Examples.CollectionClasses;
using SD.LLBLGen.Pro.Examples.FactoryClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.RelationClasses;
using SD.LLBLGen.Pro.Examples;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGenPro.Examples.GUI
{
    public partial class ProductForm : Form
    {
        // collect the delete requests
        ProductCollection _productsToDelete = new ProductCollection();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductForm"/> class.
        /// </summary>
        public ProductForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the frmProducts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void frmProducts_Load(object sender, EventArgs e)
        {
            // fetch the collections used by gridview comboboxes, sorted by the displayed name.
            _categoriesCollection.GetMulti(null, 0, new SortExpression(CategoryFields.CategoryName | SortOperator.Ascending));
            _suppliersCollection.GetMulti(null, 0, new SortExpression(SupplierFields.CompanyName | SortOperator.Ascending));

            // fetch products collection
            _productsCollection.GetMulti(null);
        }

        /// <summary>
        /// Handles the Click event of the btnSaveAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            // use transaction to commit toDetele and toUpdate items at once
            Transaction transactionManager = new Transaction(IsolationLevel.ReadCommitted, "ProductsTrans");

            try
            {
                // save products
                transactionManager.Add(_productsCollection);
                _productsCollection.SaveMulti();

                // delete products
                transactionManager.Add(_productsToDelete);
                _productsToDelete.DeleteMulti();

                // save the whole transaction
                transactionManager.Commit();

                // no errors... clean the toDetele collection
                _productsToDelete.Clear();

                // successfully message
                MessageBox.Show("Data was saved successfully!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // there are errors. Rollback the transaction and show the errors to the user.
            catch (Exception ex)
            {

                transactionManager.Rollback();
                MessageBox.Show(ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancelAll control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnCancelAll_Click(object sender, EventArgs e)
        {
            // refetch the collection
            _productsCollection.GetMulti(null);

            // clean the detele requests 
            _productsToDelete.Clear();

            // successfully message
            MessageBox.Show("All changes since last Save were canceled!", "Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the Click event of the btnExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the UserDeletingRow event of the _productsGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.DataGridViewRowCancelEventArgs"/> instance containing the event data.</param>
        private void _productsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // add to the detele requests collection
            _productsToDelete.Add((ProductEntity)e.Row.DataBoundItem);
        }
    }
}