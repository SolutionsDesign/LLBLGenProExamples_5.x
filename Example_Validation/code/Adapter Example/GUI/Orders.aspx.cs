///////////////////////////////////////////////////////////////
// LLBLGen Pro  Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 5.x
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
using SD.LLBLGen.Pro.Examples;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.EntityClasses;
using SD.LLBLGen.Pro.Examples.HelperClasses;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.DatabaseSpecific;

namespace AdapterWebApp
{

    /// <summary>
    /// This page demonstrates how to work with validaton and LLBLGen Pro v2.5, this page works with OrderEntity instances.
    /// - This page uses a FormView as CRUD control.
    /// - Entity-side (field and entity) validation is implemented by OrderValidator class (look into Validators project). The validator
    ///   is injected via Dependency Injection (DI). For more information see the web.config file and the LLBLGen Pro's Manual.
    /// - GUI-side-fields validation is implemented by System.Web.UI.IValidator objects.
    /// - GUI-side-entity validation is implemented by showing to the user (in a BulltedList) the errors returned from validator.
    /// 
    /// </summary>
    public partial class Orders : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // In order to display the newly inserted item.
                // Display the items sorted by the PK (Identity) in descending order.
                // And Go to the first page of the Form View, when an Item is inserted.(OrdersDS_EntityInserted)
                OrdersDS.SorterToUse = new SortExpression(OrderFields.OrderId | SortOperator.Descending);

                // Also sort the Shippers and Employees lists which will be shown when editing or inserting an order.
                ShippersDS.SorterToUse = new SortExpression(ShipperFields.CompanyName | SortOperator.Ascending);
                EmployeesDS.SorterToUse = new SortExpression(EmployeeFields.LastName | SortOperator.Ascending);

                // To display the Customer, Employee & Shipper names in the ItemTemplate.
                // We use a PrefetchPath to prefetch related entities to bind to their corresponding name fields
                OrdersDS.PrefetchPathToUse = new PrefetchPath2((int)EntityType.OrderEntity);
                OrdersDS.PrefetchPathToUse.Add(OrderEntity.PrefetchPathCustomer);
                OrdersDS.PrefetchPathToUse.Add(OrderEntity.PrefetchPathEmployee);
                OrdersDS.PrefetchPathToUse.Add(OrderEntity.PrefetchPathShipper);

                // To display the Product Name in the ItemTemplate, we bind to the Product.ProductName
                // which would have been LazyLoaded for each Product -> One database query to get the Product data PER Order-Detail.
                // Instead we use a PrefetchPath to prefetch all the Products related to the fetched Order-Details up front. (One Query).
                OrderDetailsDS.PrefetchPathToUse = new PrefetchPath2((int)EntityType.OrderDetailEntity);
                OrderDetailsDS.PrefetchPathToUse.Add(OrderDetailEntity.PrefetchPathProduct);
            }
        }


        /// <summary>
        /// Handles the Entity PerformWork Event of the LLBLGenProDataSource.
        /// Used to trap the errors if exists when the user saves.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_PerformWork(object sender, PerformWorkEventArgs2 e)
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
                /// Show entity errors to the user. 
                /// In this case this validator the errors list in the exception message.
                ShowEntityErrors(ex.Message);
            }

            /// -- catch other exceptions --
            /// ...
        }

        /// <summary>
        /// Handles the Entity PermormSelect Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_PerformSelect(object sender, PerformSelectEventArgs2 e)
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.PrefetchPath, e.PageNumber, e.PageSize);
            }
        }

        /// <summary>
        /// Handles the Entity PerformGetDbCount Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_PerformGetDbCount(object sender, PerformGetDbCountEventArgs2 e)
        {
            using (DataAccessAdapter adapter = new DataAccessAdapter())
            {
                e.DbCount = (int)adapter.GetScalar(OrderFields.OrderId, AggregateFunction.Count);
            }
        }

        /// <summary>
        /// Handles the Entity Deleted Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_EntityDeleted(object sender, DataSourceActionEventArgs e)
        {
            OrderEntity order = ((OrderEntity)e.InvolvedEntity);

            // check if the entity was deleted, by checking the entity.Fields.State field.
            if (order.Fields.State == EntityState.Deleted)
            {
                OrderMessage.Text = "The record was successfully deleted.";
            }
            else
            {
                OrderMessage.Text = "Order with ID = " + order.OrderId + " could not be deleted.";
            }
        }

        /// <summary>
        /// Handles the Entity Inserted Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_EntityInserted(object sender, DataSourceActionEventArgs e)
        {
            OrderEntity order = ((OrderEntity)e.InvolvedEntity);
            OrderMessage.Text = "A new Order with ID = " + order.OrderId + " was successfully inserted.";

            //Go to the first page of the Form View, to display the newly inserted item.
            OrdersFormView.PageIndex = 0;
        }

        /// <summary>
        /// Handles the Entity Updated Event of the LLBLGenProDataSource
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_EntityUpdated(object sender, DataSourceActionEventArgs e)
        {
            OrderEntity order = ((OrderEntity)e.InvolvedEntity);
            OrderMessage.Text = "Order with ID = " + order.OrderId + " was successfully updated.";
            
            CalculateOrderTotalAmount();
        }

        /// <summary>
        /// Handles the EntityDeleting event of the LLBLGenProDataSource.
        /// Used to delete order details related to the order being deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_EntityDeleting(object sender, CancelableDataSourceActionEventArgs e)
        {
            //Get the Order to be deleted
            OrderEntity orderToDelete = (OrderEntity)e.InvolvedEntity;

            try
            {
                // directly delete all order details with a matching OrderId 
                DataAccessAdapter adapter = new DataAccessAdapter();
                adapter.DeleteEntitiesDirectly("OrderDetailEntity", new RelationPredicateBucket(OrderDetailFields.OrderId == orderToDelete.OrderId));
            }
            // All exceptions are swallowed here, it's outside the scope of this example to handle different exceptions. 
            // If you are going to use this code in production, it's a best practice to add proper exception handling. 
            catch 
            {
                // cancel the Order deletion, if anything wrong happened while deleting its related order-details.
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Handles the ElementsFetched event of the LLBLGenProDataSource
        /// Use it in case of empty data. To change the mode of the FormView to the InsertMode.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersDS_ElementsFetched(object sender, EventArgs e)
        {
            // if there are no orders, go to Insert Mode of the FormView
            // and hide the Order-Details Grid and the total summary.
            if (OrdersDS.EntityCollection.Count <= 0)
            {
                OrdersFormView.ChangeMode(FormViewMode.Insert);
                OrderDetailsGridView.Visible = false;
                TotalAmount.Visible = false;
            }
        }

		/// <summary>
        /// Handles the ModeChanging event of the OrdersFormView control.
        /// Used to manipulate some the way validation error are shown.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Event Arguments form this event <see cref="System.Web.UI.WebControls.FormViewModeEventArgs"/> instance containing the event data.</param>
        protected void OrdersFormView_ModeChanging(object sender, FormViewModeEventArgs e)
        {
            // if there is errors, cancel the formView mode change, so the user could fixed the values
            if (blOrderErrors.Visible && !e.CancelingEdit)
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
        /// Handles the Orders FormView ModeChanged event
        /// Used to hide the Order-Details GridView if we are inserting a new order.
        /// As well as hiding the label showing the total amount of the order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrdersFormView_ModeChanged(object sender, EventArgs e)
        {
            OrderDetailsGridView.Visible = (OrdersFormView.CurrentMode != FormViewMode.Insert);
            TotalAmount.Visible = (OrdersFormView.CurrentMode != FormViewMode.Insert);            
        }

		/// <summary>
        /// Handles the ElementsFetched event of the LLBLGenProDataSource
        /// Which is called when entities are being fetched from the database.
        /// Used to calculate the Total Order Amount.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrderDetailsDS_ElementsFetched(object sender, EventArgs e)
        {
            CalculateOrderTotalAmount();
        }

		/// <summary>
        /// Handles the Order-Details GridView RowCommand event.
        /// Used to handle a couple of custom command to insert a new Order-Detail
        /// either from the footer or from the Empty template.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void OrderDetailsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // AddFromFooter command is issued by an Add button in the GridView's Footer.
            // To enable inserting from a GridView.
            if (e.CommandName == "AddFromFooter" && Page.IsValid)
            {
                OrderDetailEntity orderDetail = new OrderDetailEntity();

                orderDetail.UnitPrice = Convert.ToDecimal(((TextBox)OrderDetailsGridView.FooterRow.FindControl("FooterUnitPrice")).Text);
                orderDetail.Quantity = Convert.ToInt16(((TextBox)OrderDetailsGridView.FooterRow.FindControl("FooterQuantity")).Text);
                orderDetail.Discount = Convert.ToSingle(((TextBox)OrderDetailsGridView.FooterRow.FindControl("FooterDiscount")).Text) / 100;

                orderDetail.ProductId = Convert.ToInt32(((DropDownList)OrderDetailsGridView.FooterRow.FindControl("FooterProducts")).SelectedValue);
                orderDetail.OrderId = Convert.ToInt32(OrdersFormView.SelectedValue.ToString());

                DataAccessAdapter adapter = new DataAccessAdapter();
                adapter.SaveEntity(orderDetail);

                OrderDetailsGridView.DataBind();
            }

            // AddFromEmpty command is issued by an Add button in the GridView's Empty Template.
            // To enable inserting from a GridView.
            // The footer is invisible when there are now rows in the GridView, that's why we use the empty template
            // to insert the first row on the grid.
            else if (e.CommandName == "AddFromEmpty" && Page.IsValid)
            {
                OrderDetailEntity orderDetail = new OrderDetailEntity();

                orderDetail.UnitPrice = Convert.ToDecimal(((TextBox)OrderDetailsGridView.Controls[0].Controls[0].FindControl("EmptyUnitPrice")).Text);
                orderDetail.Quantity = Convert.ToInt16(((TextBox)OrderDetailsGridView.Controls[0].Controls[0].FindControl("EmptyQuantity")).Text);
                orderDetail.Discount = Convert.ToSingle(((TextBox)OrderDetailsGridView.Controls[0].Controls[0].FindControl("EmptyDiscount")).Text) / 100;

                orderDetail.ProductId = Convert.ToInt32(((DropDownList)OrderDetailsGridView.Controls[0].Controls[0].FindControl("EmptyProducts")).SelectedValue);
                orderDetail.OrderId = Convert.ToInt32(OrdersFormView.SelectedValue.ToString());

                DataAccessAdapter adapter = new DataAccessAdapter();
                adapter.SaveEntity(orderDetail);

                OrderDetailsGridView.DataBind();
            }
        }

        /// <summary>
        /// Shows the entity errors to the user.
        /// </summary>
        /// <param name="exceptionMessage">The exception message that contains the errors list.</param>
        protected void ShowEntityErrors(string exceptionMessage)
        {
            /// Get the error information via the exception message.
            /// In this case the OrderValidator class return the errors in a string separated by a semicolon (;)
            /// You also could get the info via System.ComponentModel.IDataErrorInfo interface                            

            // using a BulletedList to enum the validation errors presented.
            blOrderErrors.Items.Clear();
            string[] errors = exceptionMessage.Split(new char[] { ';' });
            foreach (string error in errors)
            {
                if (error.Trim() != string.Empty)
                {
                    blOrderErrors.Items.Add(error);
                }
            }

            // show the errors list to the user
            blOrderErrors.Visible = true;
        }

        /// <summary>
        /// Hides the entity errors controls to the user.
        /// </summary>
        protected void HideEntityErrorControls()
        {
            blOrderErrors.Visible = false;
        }

        /// <summary>
        /// Calculates the Total Order Amount. 
        /// By summing the totals of all order-detail lines in addition to the freight value of the order.
        /// </summary>
        private void CalculateOrderTotalAmount()
        {
            string freightText = string.Empty;

            // Get the Freight amount from the FormView

            // If the GridView is in the ReadOnly mode then the Freight will be written in a label.
            if (OrdersFormView.CurrentMode == FormViewMode.ReadOnly)
            {
                Label control = (Label)OrdersFormView.FindControl("Freight");
                if (control != null)
                {
                    freightText = control.Text;
                }
            }
            // Else the Freight will be written in a TextBox.
            else
            {
                TextBox control = (TextBox)OrdersFormView.FindControl("Freight");
                if (control != null)
                {
                    freightText = control.Text;
                }
            }

            decimal freight = 0;
            decimal totalAmount = 0;

            if (decimal.TryParse(freightText, System.Globalization.NumberStyles.Currency, null, out freight))
            {
                totalAmount += freight;
            }

            // Sum all order-details total values.
            foreach (OrderDetailEntity orderDetail in OrderDetailsDS.EntityCollection)
            {
                totalAmount += orderDetail.Total;
            }

            TotalAmount.Text = "Order total amount including freight = " + totalAmount.ToString("$ #,#0.##");
        }
    }
}
