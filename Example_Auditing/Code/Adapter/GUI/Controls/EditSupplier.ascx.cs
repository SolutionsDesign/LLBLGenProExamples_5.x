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
/// Control class to edit a 'Supplier' entity instance
/// </summary>
public partial class Controls_EditSupplier : System.Web.UI.UserControl, IEditControl
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
		frmEditSupplier.DefaultMode = _editMode;
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
	/// Handles the ItemCommand event of the frmEditSupplier control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.FormViewCommandEventArgs"/> instance containing the event data.</param>
	protected void frmEditSupplier_ItemCommand(object sender, FormViewCommandEventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		
		switch(e.CommandName)
		{
			case "InsertAndNew":
				frmEditSupplier.InsertItem(true);
				break;
			case "InsertAndHome":
				frmEditSupplier.InsertItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "UpdateAndHome":
				frmEditSupplier.UpdateItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "InsertAndView":
				frmEditSupplier.InsertItem(true);
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.SupplierEntity + _pkValuesAfterInsert);
				break;
			case "EditExisting":
				frmEditSupplier.ChangeMode(FormViewMode.Edit);
				break;
			case "DeleteExisting":
				frmEditSupplier.DeleteItem();
				Response.Redirect("~/default.aspx");
				break;
		}
	}

	
	/// <summary>
	/// Handles the ItemCreated event of the frmEditSupplier control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void frmEditSupplier_ItemCreated(object sender, EventArgs e)
	{
		switch(frmEditSupplier.CurrentMode)
		{
			case FormViewMode.Insert:
				// set filters for fk fields, if applicable. 
				break;
			case FormViewMode.ReadOnly:
				Button btnDelete = (Button)frmEditSupplier.FindControl("btnDelete");
				Button btnEdit = (Button)frmEditSupplier.FindControl("btnEdit");
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
	/// Eventhandler for the PerformWork event on the _SupplierDS datasourcecontrol
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _SupplierDS_PerformSelect(object sender, PerformSelectEventArgs2 e)
	{
		using(DataAccessAdapter adapter = new DataAccessAdapter())
		{
			adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.PrefetchPath, e.PageNumber, e.PageSize);
		}
	}

	
	/// <summary>
	/// Eventhandler for the PerformWork event on the _SupplierDS datasourcecontrol
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _SupplierDS_PerformWork(object sender, PerformWorkEventArgs2 e)
	{
		// as we're using a formview, there's just 1 entity in the UoW.
		SupplierEntity entityToProcess = null;
		List<UnitOfWorkElement2> elementsToInsert = e.Uow.GetEntityElementsToInsert();
		if(elementsToInsert.Count > 0)
		{
			// it's an insert operation. grab the entity so we can determine the PK later on. 
			entityToProcess = (SupplierEntity)elementsToInsert[0].Entity;
		}
		using(DataAccessAdapter adapter = new DataAccessAdapter())
		{
			e.Uow.Commit(adapter, true);
		}
		if(entityToProcess != null)
		{
			// store the PK values so a redirect can use these. 
			_pkValuesAfterInsert = "&SupplierId=" + entityToProcess.SupplierId;

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
				_SupplierDS.FilterToUse = new RelationPredicateBucket(value);
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
