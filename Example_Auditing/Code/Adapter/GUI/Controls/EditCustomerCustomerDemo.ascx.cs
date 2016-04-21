using System;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;

/// <summary>
/// Control class to edit a 'CustomerCustomerDemo' entity instance
/// </summary>
public partial class Controls_EditCustomerCustomerDemo : System.Web.UI.UserControl, IEditControl
{
	#region Class Member Declarations
	private FormViewMode _editMode = FormViewMode.Insert;
	private string _pkValuesAfterInsert = string.Empty;
	private bool _inDeleteMode = false;
	#endregion
	
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void Page_Load(object sender, EventArgs e)
	{
		frmEditCustomerCustomerDemo.DefaultMode = _editMode;
	}
	

	/// <summary>
	/// Handles the Click event of the btnCancel control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnCancel_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}

	
	/// <summary>
	/// Handles the ItemCommand event of the frmEditCustomerCustomerDemo control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.FormViewCommandEventArgs"/> instance containing the event data.</param>
	protected void frmEditCustomerCustomerDemo_ItemCommand(object sender, FormViewCommandEventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		
		switch(e.CommandName)
		{
			case "InsertAndNew":
				frmEditCustomerCustomerDemo.InsertItem(true);
				break;
			case "InsertAndHome":
				frmEditCustomerCustomerDemo.InsertItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "UpdateAndHome":
				frmEditCustomerCustomerDemo.UpdateItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "InsertAndView":
				frmEditCustomerCustomerDemo.InsertItem(true);
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.CustomerCustomerDemoEntity + _pkValuesAfterInsert);
				break;
			case "EditExisting":
				frmEditCustomerCustomerDemo.ChangeMode(FormViewMode.Edit);
				break;
			case "DeleteExisting":
				frmEditCustomerCustomerDemo.DeleteItem();
				Response.Redirect("~/default.aspx");
				break;
		}
	}

	
	/// <summary>
	/// Handles the ItemCreated event of the frmEditCustomerCustomerDemo control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void frmEditCustomerCustomerDemo_ItemCreated(object sender, EventArgs e)
	{
		switch(frmEditCustomerCustomerDemo.CurrentMode)
		{
			case FormViewMode.Insert:
				// set filters for fk fields, if applicable. 
				if(Request.QueryString["20FkField"]=="CustomerId")
				{
					TextBox control = (TextBox)frmEditCustomerCustomerDemo.FindControl("tbxCustomerId");
					if(control!=null)
					{
						control.Text = Request.QueryString["CustomerId"];
						control.ReadOnly = true;
					}
				}
				if(Request.QueryString["20FkField"]=="CustomerTypeId")
				{
					TextBox control = (TextBox)frmEditCustomerCustomerDemo.FindControl("tbxCustomerTypeId");
					if(control!=null)
					{
						control.Text = Request.QueryString["CustomerTypeId"];
						control.ReadOnly = true;
					}
				}
				break;
			case FormViewMode.ReadOnly:
				Button btnDelete = (Button)frmEditCustomerCustomerDemo.FindControl("btnDelete");
				Button btnEdit = (Button)frmEditCustomerCustomerDemo.FindControl("btnEdit");
				if(btnDelete!=null)
				{
					btnDelete.Visible = _inDeleteMode;
				}
				if(btnEdit!=null)
				{
					btnEdit.Visible = !_inDeleteMode;
				}
				break;
		}
	}
	
	
	/// <summary>
	/// Eventhandler for the PerformWork event on the _CustomerCustomerDemoDS datasourcecontrol
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _CustomerCustomerDemoDS_PerformSelect(object sender, PerformSelectEventArgs2 e)
	{
		using(DataAccessAdapter adapter = new DataAccessAdapter())
		{
			adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.PrefetchPath, e.PageNumber, e.PageSize);
		}
	}

	
	/// <summary>
	/// Eventhandler for the PerformWork event on the _CustomerCustomerDemoDS datasourcecontrol
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _CustomerCustomerDemoDS_PerformWork(object sender, PerformWorkEventArgs2 e)
	{
		// as we're using a formview, there's just 1 entity in the UoW.
		CustomerCustomerDemoEntity entityToProcess = null;
		List<UnitOfWorkElement2> elementsToInsert = e.Uow.GetEntityElementsToInsert();
		if(elementsToInsert.Count > 0)
		{
			// it's an insert operation. grab the entity so we can determine the PK later on. 
			entityToProcess = (CustomerCustomerDemoEntity)elementsToInsert[0].Entity;
		}
		using(DataAccessAdapter adapter = new DataAccessAdapter())
		{
			e.Uow.Commit(adapter, true);
		}
		if(entityToProcess != null)
		{
			// store the PK values so a redirect can use these. 
			_pkValuesAfterInsert = "&CustomerId=" + entityToProcess.CustomerId + "&CustomerTypeId=" + entityToProcess.CustomerTypeId;

		}
	}
	
	
	#region Class Property Declarations
	/// <summary>
	/// Gets / sets the edit mode of the control
	/// </summary>	
	public FormViewMode EditMode
	{
		get { return _editMode; }
		set { _editMode = value; }
	}
	
	
	/// <summary>
	/// Sets the filter to use for the editcontrol's datasource control.
	/// </summary>
	public PredicateExpression FilterToUse 
	{
		set
		{
			if(value!=null)
			{
				_CustomerCustomerDemoDS.FilterToUse = new RelationPredicateBucket(value);
			}
		}
	}
	
	/// <summary>
	/// Sets a value indicating whether the delete mode is active. This is effective in FormViewMode.ReadOnly only, and it controls whether the delete button is
	/// active or the edit button. 
	/// </summary>
	public bool DeleteMode 
	{ 
		set
		{
			_inDeleteMode = value;
		}
	}

	#endregion
}
