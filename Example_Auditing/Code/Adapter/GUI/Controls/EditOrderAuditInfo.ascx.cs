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
/// Control class to edit a 'OrderAuditInfo' entity instance
/// </summary>
public partial class Controls_EditOrderAuditInfo : System.Web.UI.UserControl, IEditControl
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
		frmEditOrderAuditInfo.DefaultMode = _editMode;

        if (!IsPostBack)
        {
            // add prefetchpath, so related entity fields could be populated
            IPrefetchPath2 path = new PrefetchPath2((int)EntityType.AuditInfoEntity);
            path.Add(AuditInfoEntity.PrefetchPathAuditActionType);

            _OrderAuditInfoDS.PrefetchPathToUse = path;
        }
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
	/// Handles the ItemCommand event of the frmEditOrderAuditInfo control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.FormViewCommandEventArgs"/> instance containing the event data.</param>
	protected void frmEditOrderAuditInfo_ItemCommand(object sender, FormViewCommandEventArgs e)
	{
		if(!Page.IsValid)
		{
			return;
		}
		
		switch(e.CommandName)
		{
			case "InsertAndNew":
				frmEditOrderAuditInfo.InsertItem(true);
				break;
			case "InsertAndHome":
				frmEditOrderAuditInfo.InsertItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "UpdateAndHome":
				frmEditOrderAuditInfo.UpdateItem(true);
				Response.Redirect("~/default.aspx");
				break;
			case "InsertAndView":
				frmEditOrderAuditInfo.InsertItem(true);
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.OrderAuditInfoEntity + _pkValuesAfterInsert);
				break;
			case "EditExisting":
				frmEditOrderAuditInfo.ChangeMode(FormViewMode.Edit);
				break;
			case "DeleteExisting":
				frmEditOrderAuditInfo.DeleteItem();
				Response.Redirect("~/default.aspx");
				break;
		}
	}

	
	/// <summary>
	/// Handles the ItemCreated event of the frmEditOrderAuditInfo control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void frmEditOrderAuditInfo_ItemCreated(object sender, EventArgs e)
	{
		switch(frmEditOrderAuditInfo.CurrentMode)
		{
			case FormViewMode.Insert:
				// set filters for fk fields, if applicable. 
				if(Request.QueryString["20FkField"]=="OrderId")
				{
					TextBox control = (TextBox)frmEditOrderAuditInfo.FindControl("tbxOrderId");
					if(control!=null)
					{
						control.Text = Request.QueryString["OrderId"];
						control.ReadOnly = true;
					}
				}
				break;
			case FormViewMode.ReadOnly:
				Button btnDelete = (Button)frmEditOrderAuditInfo.FindControl("btnDelete");
				Button btnEdit = (Button)frmEditOrderAuditInfo.FindControl("btnEdit");
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
	/// Eventhandler for the PerformWork event on the _OrderAuditInfoDS datasourcecontrol
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _OrderAuditInfoDS_PerformSelect(object sender, PerformSelectEventArgs2 e)
	{
		using(DataAccessAdapter adapter = new DataAccessAdapter())
		{
			adapter.FetchEntityCollection(e.ContainedCollection, e.Filter, e.MaxNumberOfItemsToReturn, e.Sorter, e.PrefetchPath, e.PageNumber, e.PageSize);
		}
	}

	
	/// <summary>
	/// Eventhandler for the PerformWork event on the _OrderAuditInfoDS datasourcecontrol
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	protected void _OrderAuditInfoDS_PerformWork(object sender, PerformWorkEventArgs2 e)
	{
		// as we're using a formview, there's just 1 entity in the UoW.
		OrderAuditInfoEntity entityToProcess = null;
		List<UnitOfWorkElement2> elementsToInsert = e.Uow.GetEntityElementsToInsert();
		if(elementsToInsert.Count > 0)
		{
			// it's an insert operation. grab the entity so we can determine the PK later on. 
			entityToProcess = (OrderAuditInfoEntity)elementsToInsert[0].Entity;
		}
		using(DataAccessAdapter adapter = new DataAccessAdapter())
		{
			e.Uow.Commit(adapter, true);
		}
		if(entityToProcess != null)
		{
			// store the PK values so a redirect can use these. 
			_pkValuesAfterInsert = "&AuditInfoId=" + entityToProcess.AuditInfoId;

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
				_OrderAuditInfoDS.FilterToUse = new RelationPredicateBucket(value);
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
