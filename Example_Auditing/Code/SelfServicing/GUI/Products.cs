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
    public partial class Products : Form
    {
        private ProductCollection _productsToDelete;

        public Products()
        {
            InitializeComponent();

            // look for SimpleTextAuditorTxtFileName setting at .config file
            AppSettingsReader appConfiguration = new AppSettingsReader();
            string outputAuditFileName = string.Empty;
            try
            {
                outputAuditFileName = (string)appConfiguration.GetValue("SimpleTextAuditorTxtFileName", typeof(string));
            }

            // SimpleTextAuditorTxtFileName not found! use default filename
            catch (InvalidOperationException)
            {
                outputAuditFileName = "c:\\noraudit.txt";
            }

            // show fileName to user
            lblFileName.Text = outputAuditFileName;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // collection used to track the user deleted rows so  when user Save Changes
            // also deletes these entities.
            _productsToDelete = new ProductCollection();

            // load initial data
            _categoriesCollection.GetMulti(null);
            _suppliersCollection.GetMulti(null);
            _productsCollection.GetMulti(null);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load data again if user request that
            _productsCollection.GetMulti(null);

            // clean entities
            _productsToDelete = new ProductCollection();

            // show message to user
            MessageBox.Show("Products loaded.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // persist changes to DB
            _productsCollection.SaveMulti();

            // persist user deletion to DB
            _productsToDelete.DeleteMulti();

            // show message to user
            MessageBox.Show("Changes saved.");
        }

        private void btnDirectUpdate_Click(object sender, EventArgs e)
        {
            /// Set Discontinued=True ALL products of category 'Sea Food' (8)
            /// This is for test the AuditDirectUpdateOfEntities of SimpleTextFileAuditor Class

            // category = seaFood
            IPredicateExpression filter = new PredicateExpression();
            filter.Add(ProductFields.CategoryId == 8);

            // set discontinued
            ProductEntity productUpdatedValues = new ProductEntity();
            productUpdatedValues.Discontinued = true;
            
            // perform update
            int updatedRows = (new ProductCollection()).UpdateMulti(productUpdatedValues, filter);

            // show message to user
            MessageBox.Show(string.Format("Updated rows: {0}", updatedRows));
        }

        private void _productsGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // track the user deletes an entity so later we can persist such deletion
            ProductEntity productToDelete = ((ProductEntity)e.Row.DataBoundItem);
            _productsToDelete.Add(productToDelete);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // done
            this.Close();
        }
    }
}