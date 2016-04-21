///////////////////////////////////////////////////////////////
// LLBLGen Pro Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 5.x
// Powered by: Solutions Design.
//////////////////////////////////////////////////////////////

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using SD.LLBLGen.Pro.ORMSupportClasses;

using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.DatabaseSpecific;


namespace AdapterWebApp
{
    /// <summary>
    /// This page demonstrates how to work with validaton and LLBLGen Pro v2.5, this page works with ProductEntity instances.
    /// - This page uses a GridView as CRUD control.
    /// - Entity-side (field and entity) validation is implemented by validation routines inside ProductEntity class (look into its partial class).   
    /// - No System.Web.UI.IValidator controls are used. When LLBLGenProDataSource2 performs the work, validation routines return errors
    ///   (if exist) and are shown to the user in a BulletedList.
    /// </summary>
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the LLBLGenProDataSource PerformGetDbCount Event which is raised when LivePersistence is set to false and a GetDbCount has to be performed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ProductsDS_PerformGetDbCount(object sender, SD.LLBLGen.Pro.ORMSupportClasses.PerformGetDbCountEventArgs2 e)
        {
            // When enabling paging in the datasource, 
            // Don't get the entities count from the already fetched collection.
            // these would be only those belonging to the first page.
            // The following is the wrong code to use:
            // e.DbCount = e.ContainedCollection.Count;

            // Get the count of all entities in the database
            DataAccessAdapter adapter = new DataAccessAdapter();
            e.DbCount = adapter.GetDbCount(e.ContainedCollection, null);            
        }

        /// <summary>
        /// Handles the PerformSelect Event of the LLBLGenProDataSource, which is raised when LivePersistence is set to false.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ProductsDS_PerformSelect(object sender, SD.LLBLGen.Pro.ORMSupportClasses.PerformSelectEventArgs2 e)
        {
            //Use a prefetchPath to Category, to display each Product's Category Name .
            PrefetchPath2 prefetchPath = new PrefetchPath2((int)EntityType.ProductEntity);
            prefetchPath.Add(ProductEntity.PrefetchPathCategory);

            // build a list of fields to be excluded from the fetch.
            ExcludeIncludeFieldsList excludedFields = new ExcludeIncludeFieldsList(true);
            excludedFields.Add(ProductFields.UnitsInStock);
            excludedFields.Add(ProductFields.UnitsOnOrder);
            excludedFields.Add(ProductFields.ReorderLevel);
            excludedFields.Add(ProductFields.SupplierId);

            // use the DataAccessAdapter's FetchEntityCollection to fetch the contained collection
            // pass the filter and sorter passed in the PerformSelectEventArgs2
            // as well as the list of excluded fields.
            DataAccessAdapter adapter = new DataAccessAdapter();
            adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, prefetchPath, excludedFields, e.PageNumber, e.PageSize);         
        }

        /// <summary>
        /// Handles the LLBLGenProDataSource PerformWork Event which is raised when LivePersistence is set to false and an insert/update/delete has to be performed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ProductsDS_PerformWork(object sender, SD.LLBLGen.Pro.ORMSupportClasses.PerformWorkEventArgs2 e)
        {
            // indicate whether or not the entity is valid (corresponding to entity validation)
            bool entityToUpdateIsValid = true;

            // Get the entityToDelete from UOW
            // If found, get the entity to be deleted from the UnitOfWork object.
            ProductEntity entityToDelete = null;
            List<UnitOfWorkElement2> deleteItems = e.Uow.GetEntityElementsToDelete();
            if (deleteItems.Count > 0)
            {
                entityToDelete = (ProductEntity)deleteItems[0].Entity;
            }

            // Get the entityToUpdate from UOW
            ProductEntity entityToUpdate = null;
            // If found, get the entity to be updated from the UnitOfWork object.
            List<UnitOfWorkElement2> updateItems = e.Uow.GetEntityElementsToUpdate();
            if (updateItems.Count > 0)
            {
                entityToUpdate = (ProductEntity)updateItems[0].Entity;
            }

            // Commit the LLBLGenProDataSource UnitOfWork.
            DataAccessAdapter adapter = new DataAccessAdapter();
            try
            {
                // commit the work
                e.Uow.Commit(adapter, true);

                // everything OK lets hide the error controls
                HideEntityErrorControls();
            }
            catch (ORMEntityValidationException ex)
            {
                // oops, something is invalid, lets show the info to the user
                ShowEntityErrors(ex.Message);
                entityToUpdateIsValid = false;
            }

            // After save/update acknowledges
            // Show a message to acknowledge a Delete.
            if (entityToDelete != null && entityToUpdateIsValid)
            {
                // check if the entity was deleted, by checking the entity.Fields.State field.
                if (entityToDelete.Fields.State == EntityState.Deleted)
                {
                    Message.Text = "The record was successfully deleted.";
                }
                else
                {
                    Message.Text = "Product with ID = " + entityToDelete.ProductId + " could not be deleted.";
                }
            }

            // Show a message to acknowledge an update.
            if (entityToUpdate != null && entityToUpdateIsValid)
            {
                Message.Text = "Product with ID = " + entityToUpdate.ProductId + " was successfully updated.";
            }
        }

        /// <summary>
        /// Handles the EntityUpdating event of the ProductsDS control.
        /// Used to trap the entity fields errors at the current ProductEntity
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SD.LLBLGen.Pro.ORMSupportClasses.CancelableDataSourceActionEventArgs"/> instance containing the event data.</param>
        protected void ProductsDS_EntityUpdating(object sender, CancelableDataSourceActionEventArgs e)
        {
            // the entity involved
            ProductEntity entityToEvaluate = (ProductEntity)e.InvolvedEntity;

            // Retrieve the fields errors from the entity. This will return a semicolon-separated list containing the info.
            string errors = entityToEvaluate.GetEntityFieldsErrors();

            // there are errors, so cancel the update so the user can fix them.
            if (errors != string.Empty)
            {
                e.Cancel = true;
                ShowEntityErrors(errors);
            }
            else
            {
                HideEntityErrorControls();
            }
        }

        /// <summary>
        /// Handles the RowUpdated event of the ProductsGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewUpdatedEventArgs"/> instance containing the event data.</param>
        protected void ProductsGridView_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            // there's errors, so force the gridView to stay in editMode.
            if (blProductEntityErrors.Visible)
            {
                e.KeepInEditMode = true;
                Message.Visible = false;
            }
        }

        /// <summary>
        /// Handles the RowCancelingEdit event of the ProductsGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewCancelEditEventArgs"/> instance containing the event data.</param>
        protected void ProductsGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            HideEntityErrorControls();
        }

		/// <summary>
        /// Shows the entity errors to the user.
        /// </summary>
        /// <param name="exceptionMessage">The exception message that contains the errors list.</param>
        protected void ShowEntityErrors(string exceptionMessage)
        {
            /// Get the error information via the exception message.
            /// In this case the in-side-entity validator routines return the errors in a string separated by a semicolon (;)
            /// You also could get the info via System.ComponentModel.IDataErrorInfo interface

            // using a BulletedList to list the validation errors presented.
            blProductEntityErrors.Items.Clear();
            string[] errors = exceptionMessage.Split(new char[] { ';' });
            foreach (string error in errors)
            {
                if (error.Trim() != string.Empty)
                {
                    blProductEntityErrors.Items.Add(error);
                }
            }

            // show the errors list to the user
            blProductEntityErrors.Visible = true;            
        }

        /// <summary>
        /// Hides the entity errors controls to the user.
        /// </summary>
        protected void HideEntityErrorControls()
        {
            // this property (blProductEntityErrors.Visible) will be used like a flag to determine whether there are errors.
            blProductEntityErrors.Visible = false;
        }
    }
}
