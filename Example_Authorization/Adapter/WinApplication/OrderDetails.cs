using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SD.LLBLGen.Pro.Examples.Authorization.DatabaseSpecific;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;
using SD.LLBLGen.Pro.Examples.Authorization.EntityClasses;
using System.Configuration;

namespace SD.LLBLGen.Pro.Examples.Authorization.GUI
{
    public partial class OrdersDetails : Form
    {
        private int _pageNumber;
        private EntityCollection<OrderDetailsEntity> _entitiesToDelete;
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public OrdersDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form Load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            // Initialize the to be deleted entity collection.
            _entitiesToDelete = new EntityCollection<OrderDetailsEntity>();

            // Get the Page size from the App Settings.
            _pageSize.Value = Convert.ToInt32(ConfigurationManager.AppSettings["DefaultPageSize"]);

            // Load the first page of entities.
            _pageNumber = 1;
            LoadData();

            tbComments.Text = "- Order Details can be viewed by members of \"Sales\", \"Marketing\" or \"Customer Relations\" groups.\r\n";
            tbComments.Text += "- \"Customer Relations\" members can not view the \"Discount\" data.\r\n"; 
            tbComments.Text += "- Only \"Sales\" members can Insert, Update or Delete Order Details.\r\n";
            tbComments.Text += "- Only Sales Managers can update the \"Discount\" data.(members of the \"Sales\" & \"Managers\" groups)";
        }

        /// <summary>
        /// Fetches a specific page of data from the database
        /// </summary>
        private void LoadData()
        {
            // Read the page size stored in a Form label.
            int pageSize = (int)_pageSize.Value;
            // Validate the _pageSize
            if (pageSize <= 0)
            {
                MessageBox.Show("Page size should not be less then 1.");
                return;
            }

            int totalPagesCount = 0;

            // Create an adapter object and keep the connection open.
            // A using statement makes sure the Adapter is Dispose.
            using (DataAccessAdapter adapter = new DataAccessAdapter(true))
            {
                // Get the total count of entities in the database
                int recordsCount = adapter.GetDbCount(_entities, null);
                // Validate the total number of entities in the database
                if (recordsCount <= 0)
                {
                    MessageBox.Show("No entities found in the database.");
                    return;
                }

                // If the total number of entities is less than or equal the page size
                // Then we only have one page to display.
                if (recordsCount <= pageSize)
                {
                    totalPagesCount = 1;
                    _pageNumber = totalPagesCount;
                }
                else
                {
                    // Compute the total number of pages.
                    int remainder = 0;
                    totalPagesCount = Math.DivRem(recordsCount, pageSize, out remainder);
                    if (remainder > 0)
                    {
                        totalPagesCount++;
                    }
                }

                // A _pageNumber smaller than 0 is specified to load the last page. 
                if (_pageNumber < 0)
                {
                    _pageNumber = totalPagesCount;
                }

                // Reflect the current page number on the Form.
                _currentPageNumber.Text = _pageNumber.ToString() + " of (" + totalPagesCount.ToString() + ")";

                // Clear the bound collection before fetching entities into it.
                _entities.Clear();
                // Fetch the specified page of records into the bound entityCollection.
                adapter.FetchEntityCollection(_entities, null, 0, null, _pageNumber, pageSize);
                // Close the connection.
                adapter.CloseConnection();
            }

            // Raise/Call the appropriate event/method to update the navigation buttons.
            // According to the current displayed page.
            if (totalPagesCount == 1)
            {
                OnSinglePage();
            }
            else if (_pageNumber == 1)
            {
                OnFirstPage();
            }
            else if (_pageNumber == totalPagesCount)
            {
                OnLastPage();
            }
            else if (_pageNumber > 1 && _pageNumber < totalPagesCount)
            {
                OnInBetweenPage();
            }
        }

        /// <summary>
        /// Event occurs when an entity is removed from the bound EntityCollection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Entities_EntityRemoved(object sender, SD.LLBLGen.Pro.ORMSupportClasses.CollectionChangedEventArgs e)
        {
            // Add the removed entity to the Collection of entities to be deleted.
            _entitiesToDelete.Add((OrderDetailsEntity)e.InvolvedEntity);
        }

        #region Buttons Handlers

        /// <summary>
        /// Handler of the Load button.
        /// Loads first page of data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            _pageNumber = 1;
            LoadData();
        }

        /// <summary>
        /// Handler of the Last button.
        /// Loads last page of data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLast_Click(object sender, EventArgs e)
        {
            _pageNumber = -1;
            LoadData();
        }

        /// <summary>
        /// Handler of the Next button.
        /// Loads next page of data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            _pageNumber++;
            LoadData();
        }

        /// <summary>
        /// Handler of the Previous button.
        /// Loads previous page of data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _pageNumber--;
            LoadData();
        }

        /// <summary>
        /// Handler of the First button.
        /// Loads first page of data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            _pageNumber = 1;
            LoadData();
        }

        /// <summary>
        /// Handler of the Submit button
        /// Persists changes to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int savedCount = 0;
            int deletedCount = 0;

            // A using statement makes sure the Adapter is Dispose.
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                // Start a Transaction
                adapter.StartTransaction(IsolationLevel.ReadCommitted, "OrderDetailssActions");
                try
                {
                    // Save changes of the bound collection to the database. (Inserts/Updates)
                    savedCount = adapter.SaveEntityCollection(_entities, true, false);

                    // Delete entities removed from the bound collection.                    
                    if (_entitiesToDelete.Count > 0)
                    {
                        deletedCount = adapter.DeleteEntityCollection(_entitiesToDelete);
                        _entitiesToDelete.Clear();
                    }

                    // Commit the Transaction
                    adapter.Commit();
                }
                catch
                {
                    // Rollback the Transaction.
                    adapter.Rollback();
                    throw;
                }
            }

            // Show a feedback message to the user.
            MessageBox.Show("Number of saved records = " + savedCount.ToString() + "\r\nNumber of deleted records = " + deletedCount.ToString());
        }
        #endregion

        #region Paging Handlers
        /// <summary>
        /// Called when the first page of the grid is displayed
        /// Enables forward navigation and disables backward navigation accordingly
        /// </summary>
        private void OnFirstPage()
        {
            // Disables backward navigation
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;

            // Enables forward navigation
            btnNext.Enabled = true;
            btnLast.Enabled = true;
        }

        /// <summary>
        /// Called when the last page of the grid is displayed
        /// Enables backward navigation and disables forward navigation accordingly
        /// </summary>
        private void OnLastPage()
        {
            // Enables backward navigation
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;

            // Disables forward navigation
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }

        /// <summary>
        /// Called when an intermediate page of the grid is displayed
        /// Enables backward & Forward navigation accordingly
        /// </summary>
        private void OnInBetweenPage()
        {
            // Enables backward navigation
            btnFirst.Enabled = true;
            btnPrevious.Enabled = true;

            // Enables forward navigation
            btnNext.Enabled = true;
            btnLast.Enabled = true;
        }

        /// <summary>
        /// Called when there is only one single page of entities to display.
        /// Disables backward and forward navigation.
        /// </summary>
        private void OnSinglePage()
        {
            // Enables backward navigation
            btnFirst.Enabled = false;
            btnPrevious.Enabled = false;

            // Disables forward navigation
            btnNext.Enabled = false;
            btnLast.Enabled = false;
        }

        #endregion
    }
}