///////////////////////////////////////////////////////////////
// LLBLGen Pro  Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 4.x
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
using SD.LLBLGen.Pro.Examples.HelperClasses;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.DatabaseSpecific;

namespace AdapterWebApp
{
    /// <summary>
    /// This page demonstrates how to work with validaton and LLBLGen Pro v2.5, this page works with EmployeeEntity instances.
    /// - This page uses a GridView as seracher and a FormView as CRUD control.
    /// - Entity-side (field and entity) validation is implemented by EmployeeEntity.ValidateEntity() method. For more information
    ///   see the comments in that class.
    /// - No System.Web.UI.IValidator controls are used. When LLBLGenProDataSource2 performs the work, ValidateEntity return errors
    ///   (if exist) and are shown to the user in a BulletedList.
    /// 
    /// </summary>
    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // Select the first Item in the Employees List DataGrid
                // Nothing will happen if the Grid is empty.
                EmployeesGridView.SelectedIndex = 0;

                // Add a prefetchPath to show the employeeSuperior
                IPrefetchPath2 path = new PrefetchPath2((int)EntityType.EmployeeEntity);
                path.Add(EmployeeEntity.PrefetchPathEmployeeSuperior);
                this.EmployeeDetailsDS.PrefetchPathToUse = path;
            }
        }

        /// <summary>
        /// Handles the LLBLGenProDataSource PerformGetDbCount Event which is raised when LivePersistence is set to false and a GetDbCount has to be performed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeesListDS_PerformGetDbCount(object sender, SD.LLBLGen.Pro.ORMSupportClasses.PerformGetDbCountEventArgs2 e)
        {
            // When enabling paging in the datasource, 
            // Don't get the entities count from the already fetched collection.
            // these would be only those belonging to the first page.
            // The following is the wrong code to use:
            // e.DbCount = e.ContainedCollection.Count;

            // Get the count of all entities in the database
            DataAccessAdapter adapter = new DataAccessAdapter();
            e.DbCount = adapter.GetDbCount(e.ContainedCollection, e.Filter);            
        }

        /// <summary>
        /// Handles the PerformSelect Event of the LLBLGenProDataSource, which is raised when LivePersistence is set to false. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeesListDS_PerformSelect(object sender, SD.LLBLGen.Pro.ORMSupportClasses.PerformSelectEventArgs2 e)
        {
            // build a list of fields to be excluded from the fetch.
            ExcludeIncludeFieldsList excludedFields = new ExcludeIncludeFieldsList(true);
            excludedFields.Add(EmployeeFields.BirthDate);
            excludedFields.Add(EmployeeFields.Address);
            excludedFields.Add(EmployeeFields.City);
            excludedFields.Add(EmployeeFields.Country);
            excludedFields.Add(EmployeeFields.Extension);
            excludedFields.Add(EmployeeFields.HireDate);
            excludedFields.Add(EmployeeFields.HomePhone);
            excludedFields.Add(EmployeeFields.Notes);
            excludedFields.Add(EmployeeFields.Photo);
            excludedFields.Add(EmployeeFields.PhotoPath);
            excludedFields.Add(EmployeeFields.PostalCode);
            excludedFields.Add(EmployeeFields.Region);
            excludedFields.Add(EmployeeFields.ReportsTo);
            excludedFields.Add(EmployeeFields.TitleOfCourtesy);

            // use the DataAccessAdapter's FetchEntityCollection to fetch the contained collection
            // pass the filter and sorter passed in the PerformSelectEventArgs2
            // as well as the list of excluded fields and paging parameters
            DataAccessAdapter adapter = new DataAccessAdapter();
            adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.PrefetchPath, excludedFields, e.PageNumber, e.PageSize);
        }

        /// <summary>
        /// Handles the LLBLGenProDataSource PerformWork Event which is raised when LivePersistence is set to false and an insert/update/delete has to be performed.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeesListDS_PerformWork(object sender, SD.LLBLGen.Pro.ORMSupportClasses.PerformWorkEventArgs2 e)
        {
            //nothing is done to be persisted. The GridView is used only for Viewing.
            // INSERT, Update and Delete are done with the FormView.
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the GridView
        /// Use it to change the mode of the Employee Details FormView to the ReadOnly mode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeesGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeFormView.ChangeMode(FormViewMode.ReadOnly);
        }

        /// <summary>
        /// Handles the DataBound event of the GridView
        /// Use it to select the first row in the grid if it was the only row available.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeesGridView_DataBound(object sender, EventArgs e)
        {
            if (EmployeesGridView.Rows.Count == 1)
            {
                EmployeesGridView.SelectedIndex = 0;
            }
        }

        /// <summary>
        ///  Handles the LLBLGenProDataSource PerformGetDbCount Event which is raised when LivePersistence is set to false and a GetDbCount has to be performed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeDetailsDS_PerformGetDbCount(object sender, PerformGetDbCountEventArgs2 e)
        {
            // We don't have paging here.
            // The FormView always fetches one entity at a time, based on the selected entity of the GridView
            e.DbCount = 1;
        }
        
        /// <summary>
        /// Handles the PerformSelect Event of the LLBLGenProDataSource, which is raised when LivePersistence is set to false. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeDetailsDS_PerformSelect(object sender, PerformSelectEventArgs2 e)
        {
            // use the DataAccessAdapter's FetchEntityCollection to fetch the contained collection
            // We don't need to pass anything to fetch method except the filter and the prefetchPath (
            // to access the EmployeeSuperior related entity).
            DataAccessAdapter adapter = new DataAccessAdapter();
            adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.PrefetchPath);
        }

        /// <summary>
        /// Handles the LLBLGenProDataSource PerformWork Event which is raised when LivePersistence is set to false and an insert/update/delete has to be performed.   
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeDetailsDS_PerformWork(object sender, PerformWorkEventArgs2 e)
        {
            // Get the entityToDelete from UOW
            EmployeeEntity entityToDelete = null;
            // If found, get the entity to be deleted from the UnitOfWork object.
            List<UnitOfWorkElement2> deleteItems = e.Uow.GetEntityElementsToDelete();
            if (deleteItems.Count > 0)
            {
                entityToDelete = (EmployeeEntity)deleteItems[0].Entity;
            }

            // Get the entityToUpdate from UOW
            EmployeeEntity entityToUpdate = null;
            // If found, get the entity to be updated from the UnitOfWork object.
            List<UnitOfWorkElement2> updateItems = e.Uow.GetEntityElementsToUpdate();
            if (updateItems.Count > 0)
            {
                entityToUpdate = (EmployeeEntity)updateItems[0].Entity;
                //Set the Photo of the EMployee, if uploaded.
                SetPicture(entityToUpdate);
            }

            // Get the entityToInsert from UOW
            EmployeeEntity entityToInsert = null;
            // If found, get the entity to be inserted from the UnitOfWork object.
            List<UnitOfWorkElement2> inserteItems = e.Uow.GetEntityElementsToInsert();
            if (inserteItems.Count > 0)
            {
                entityToInsert = (EmployeeEntity)inserteItems[0].Entity;
                //Set the Photo of the EMployee, if uploaded.
                SetPicture(entityToInsert);
            }

            // Determining the entity to validate

            // entity to be validated
            EmployeeEntity entityToValidate = null;

            // flag to know whether the entity is valid
            bool entityToValidateIsValid = true;


            if (entityToInsert != null)
            {
                entityToValidate = entityToInsert;
            }

            if (entityToUpdate != null)
            {
                entityToValidate = entityToUpdate;
            }


            // Validating the entity via ValidateEntity() method
            if (entityToValidate != null)
            {

                try
                {
                    // perform the validate process
                    entityToValidate.ValidateEntity();

                    // everything OK, lets hide the error controls
                    HideEntityErrorControls();
                }
                catch (ORMEntityValidationException ex)
                {
                    // oops, there are errors somewhere, lets show to the user                    
                    ShowEntityErrors(ex.Message);
                    entityToValidateIsValid = false;
                }
            }

            // Perform the work
            if (entityToValidateIsValid)
            {           
                try
                {
                    DataAccessAdapter adapter = new DataAccessAdapter();
                    e.Uow.Commit(adapter, true);
                }
                catch (ORMQueryExecutionException ex)
                {
                    /// catch other errors
                    /// ...
                }
            }
        }

        /// <summary>
        /// Handles the ItemDeleted event of the FormView
        /// Use it to refresh the GridView to reflect the deletion of the Employee in hand.
        /// And the deleted Employee was the last one in the grid, 
        /// select the previous employee, after refreshing the grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeFormView_ItemDeleted(object sender, FormViewDeletedEventArgs e)
        {
            EmployeesGridView.DataBind();

            if (EmployeesGridView.SelectedIndex >= EmployeesGridView.Rows.Count)
            {
                EmployeesGridView.SelectedIndex = EmployeesGridView.Rows.Count - 1;
            }
        }

        /// <summary>
        /// Handles the ItemDeleted event of the FormView
        /// Use it to refresh the GridView to reflect the changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeFormView_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
        {
            EmployeesGridView.DataBind();
        }

        /// <summary>
        /// Handles the ItemDeleted event of the FormView
        /// Use it to refresh the GridView to reflect the insertion of the new Employee.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeFormView_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            EmployeesGridView.DataBind();
        }

        /// <summary>
        /// Handles the ModeChanging event of the EmployeeFormView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.FormViewModeEventArgs"/> instance containing the event data.</param>
        protected void EmployeeFormView_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            // if there is errors, cancel the formView mode change, so the user could fixed the values
            if (blEmployeeEntityErrors.Visible && !e.CancelingEdit)
            {
                e.Cancel = true;
            }

            // if the user is canceling, hide the control that show the errors.
            if (e.CancelingEdit)
            {
                HideEntityErrorControls();

            }
        }

        /// <summary>
        /// Gets the bytes uploaded by the FileUpload control and set them to the Photo property of the
        /// passed in Employee entity. 
        /// </summary>
        /// <param name="entity"> entity envolved in the Insert or Update action</param>
        private void SetPicture(IEntityCore entity)
        {
            FileUpload fileUpload = (FileUpload)EmployeeFormView.FindControl("FileUpload1");

            if (fileUpload.PostedFile != null && !string.IsNullOrEmpty(fileUpload.PostedFile.FileName) && fileUpload.PostedFile.InputStream != null)
            {
                ((EmployeeEntity)entity).Photo = fileUpload.FileBytes;
            }
        }
        
        /// <summary>
        /// Shows the entity errors to the user.
        /// </summary>
        /// <param name="exceptionMessage">The exception message that contains the errors list.</param>
        protected void ShowEntityErrors(string exceptionMessage)
        {
            /// Get the error information via the exception message.
            /// In this case the Employee.ValidateEntity method class will return the errors in a string separated by a semicolon (;)
            /// You also could get the info via System.ComponentModel.IDataErrorInfo interface                            

            // using a BulletedList to list the validation errors presented.            
            blEmployeeEntityErrors.Items.Clear();
            string[] errors = exceptionMessage.Split(new char[] { ';' });
            foreach (string error in errors)
            {
                if (error.Trim() != string.Empty)
                {
                    blEmployeeEntityErrors.Items.Add(error);
                }
            }

            // show the errors list to the user
            blEmployeeEntityErrors.Visible = true;
        }

        /// <summary>
        /// Hides the entity errors controls to the user.
        /// </summary>
        protected void HideEntityErrorControls()
        {
            // this property (blEmployeeEntityErrors.Visible) will be used as a flag to check whether there are errors in the entity.
            blEmployeeEntityErrors.Visible = false;
        }
    }
}
