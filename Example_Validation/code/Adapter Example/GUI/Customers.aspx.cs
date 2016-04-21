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
    /// This page demonstrates how to work with validaton and LLBLGen Pro v2.5, this page works with CustomerEntity instances.
    /// - This page uses a GridView as CRUD control.
    /// - Entity-side (field and entity) validation is implemented by CustomerValidator class. For more information
    ///   see the comments in that class.
    /// - GUI-side-fields validation is implemented by System.Web.UI.IValidator objects.
    /// - GUI-side-entity validation is implemented by showing to the user (in a BulltedList) the errors returned from validator.
    /// 
    /// </summary>
    public partial class Customers : System.Web.UI.Page
    {
        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IPrefetchPath2 path = new PrefetchPath2((int)EntityType.CustomerEntity);
                path.Add(CustomerEntity.PrefetchPathOrders);

                CustomersDS.PrefetchPathToUse = path;                
            }

        }

        /// <summary>
        /// Customerses the D s_ perform select.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected void CustomersDS_PerformSelect(object sender, PerformSelectEventArgs2 e)
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.PrefetchPath, e.PageNumber, e.PageSize);
            }
        }

        /// <summary>
        /// Customerses the D s_ perform work.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected void CustomersDS_PerformWork(object sender, PerformWorkEventArgs2 e)
        {
            try
            {
                // perform the commit
                using (DataAccessAdapter adapter = new DataAccessAdapter())
                {
                    e.Uow.Commit(adapter, true);
                }

                // everything OK, so hide the errors.
                HideEntityErrorControls();
            }

            // some validation rules have been broken!
            catch (ORMEntityValidationException ex)
            {
                // oops, there are errors somewhere, lets show them to the user.
                // this message come from the CustomerValidator class and come formatted so we can split it.
                ShowEntityErrors(ex.Message);
            }

            /// -- catch other exceptions --
            /// ...
        }

        /// <summary>
        /// Performs the GetDbCount call for the CustomersDS datasource.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        protected void CustomersDS_PerformGetDbCount(object sender, PerformGetDbCountEventArgs2 e)
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                e.DbCount = (int)adapter.GetScalar(CustomerFields.CustomerId, AggregateFunction.Count);
            }
        }

        /// <summary>
        /// Handles the Entity Deleted Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CustomersDS_EntityDeleted(object sender, SD.LLBLGen.Pro.ORMSupportClasses.DataSourceActionEventArgs e)
        {
            CustomerEntity customer = ((CustomerEntity)e.InvolvedEntity);
            
            // check if the entity was deleted, by checking the entity.Fields.State field.
            if(customer.Fields.State == EntityState.Deleted)
            {
                Message.Text = "The record was successfully deleted";            
            }
            else
            {
                Message.Text = "Customer with ID = " + customer.CustomerId + " could not be deleted";                        
            }
        }

        /// <summary>
        /// Handles the Entity Updated Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CustomersDS_EntityUpdated(object sender, SD.LLBLGen.Pro.ORMSupportClasses.DataSourceActionEventArgs e)
        {
            CustomerEntity customer = ((CustomerEntity)e.InvolvedEntity);
            Message.Text = "Customer with ID = " + customer.CustomerId + " was successfully updated";
        }
        

        /// <summary>
        /// Handles the RowUpdating event of the CustomersGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewUpdateEventArgs"/> instance containing the event data.</param>
        protected void CustomersGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // there are errors, so lets force the GridView to cancel the update operation so the user can fix the errors.
            if (blCustomerEntityErrors.Visible)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Handles the Order-Details GridView RowCommand event.
        /// Used to handle a couple of custom command to isert a new Order-Detail
        /// either from the footer or from the Empty template.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void CustomersGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // AddFromFooter command is issued by an Add button in the GridView's Footer.
            // To enable inserting from a GridView.
            if (e.CommandName == "AddFromFooter" && Page.IsValid)
            {
                // create the new customer
                CustomerEntity newCustomer = new CustomerEntity();
                newCustomer.CustomerId = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertCustomerId")).Text;
                newCustomer.CompanyName = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertCompanyName")).Text;
                newCustomer.ContactName = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertContactName")).Text;
                newCustomer.ContactTitle = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertContactTitle")).Text;
                newCustomer.PostalCode = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertPostalCode")).Text;
                newCustomer.City = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertCity")).Text;
                newCustomer.Country = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertCountry")).Text;
                newCustomer.Phone = ((TextBox)CustomersGridView.FooterRow.FindControl("InsertPhone")).Text;

                // saving the entity
                using (DataAccessAdapter adapter = new DataAccessAdapter())
                {
                    try
                    {
                        adapter.SaveEntity(newCustomer);

                        // everything OK, so lets hide the errors controls
                        HideEntityErrorControls();
                    }
                    catch (ORMEntityValidationException ex)
                    {
                        // oops, there are errors somewhere, lets show them to the user.
                        // this message come from the CustomerValidator class and come formatted so we can split it.
                        ShowEntityErrors(ex.Message);
                    }
                }

                // refresh the grid
                CustomersGridView.DataBind();
            }
        }

        /// <summary>
        /// Shows the entity errors to the user.
        /// We use a BulletedList to list the errors.
        /// </summary>
        /// <param name="exceptionMessage">The exception message that contains the errors list.</param>
        protected void ShowEntityErrors(string exceptionMessage)
        {
            /// Get the error information via the exception message.
            /// In this case the CustomerValidator class return the errors attached to the exception message string 
            /// separated by a semicolon (;)

            // using a BulletedList to list the validation errors presented.
            blCustomerEntityErrors.Items.Clear();
            string[] errors = exceptionMessage.Split(new char[] { ';' });
            foreach (string error in errors)
            {
                if (error.Trim() != string.Empty)
                {
                    blCustomerEntityErrors.Items.Add(error);
                }
            }

            // show the errors list to the user
            blCustomerEntityErrors.Visible = true;
        }

        /// <summary>
        /// Hides the entity errors controls to the user.
        /// </summary>
        protected void HideEntityErrorControls()
        {
            // this property (blCustomerEntityErrors.Visible) will be used like a flag to determine
            // if there's errors at the entity evaluated.
            blCustomerEntityErrors.Visible = false;
        }
    }
}
