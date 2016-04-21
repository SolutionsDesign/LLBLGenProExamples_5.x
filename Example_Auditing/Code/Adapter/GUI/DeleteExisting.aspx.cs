using System;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.Examples.Auditing;

/// <summary>
/// Page which allows the user to delete one existing entity instance.
/// </summary>
public partial class DeleteExisting : System.Web.UI.Page
{
	#region Class Member Declarations
	private EntityType _selectedEntityType;
	private bool _entityTypeDefined = false;
	private IEditControl _editor;
	private ISearchControl _searcher;
	#endregion

	protected void Page_Load(object sender, EventArgs e)
	{
		int entityTypeValue = 0;
		Int32.TryParse(Request.QueryString["EntityType"], out entityTypeValue);
		if(Enum.IsDefined(typeof(EntityType), entityTypeValue))
		{
			_selectedEntityType = (EntityType)entityTypeValue;
			_entityTypeDefined = true;
		}

		if(_entityTypeDefined)
		{
			// load edit control for given entity.
			Control controlToAdd = Page.LoadControl("~/Controls/Edit" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + ".ascx");
			_editor = controlToAdd as IEditControl;
			if(_editor != null)
			{
				_editor.EditMode = FormViewMode.ReadOnly;
				_editor.DeleteMode = true;
				phEditControls.Controls.Add(controlToAdd);
			}
			phEditArea.Visible = false;
			
			// load search control 
			controlToAdd = Page.LoadControl("~/Controls/Search" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + ".ascx");
			_searcher = controlToAdd as ISearchControl;
			if(_searcher != null)
			{
				if(Request.QueryString.Count == 1)
				{
					// just entitytype specified.
					_searcher.AllowSingleEntitySearches = true;
					_searcher.AllowMultiEntitySearches = false;
					_searcher.SearchClicked += new EventHandler(searcher_SearchClicked);
					phSearchControls.Controls.Add(controlToAdd);
					phSearchArea.Visible = true;
				}
				else
				{
					// get the filter based on the query string's PK fields. Use the search control for this, as it contains the logic for this.
					if(_editor != null)
					{
						_editor.FilterToUse = _searcher.CreateFilter(Request.QueryString);
						phSearchArea.Visible = false;
						phEditArea.Visible = true;
					}
				}
			}
		}

		if(!Page.IsPostBack)
		{
			if(_entityTypeDefined)
			{
				this.Title += _selectedEntityType.ToString() + " instance";
				lblEntityName.Text = GeneralUtils.EntityTypeToEntityName(_selectedEntityType);
			}

            // check for user info
            if (SessionHelper.GetUserID() == string.Empty)
            {
                Response.Redirect("Login.aspx");
            }

		}
	}

	/// <summary>
	/// Handles the SearchClicked event of the searcher control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	private void searcher_SearchClicked(object sender, EventArgs e)
	{
		if((_searcher != null) && (_editor!=null))
		{
			_editor.FilterToUse = _searcher.Filter;
			phSearchArea.Visible = false;
			phEditArea.Visible = true;
		}
	}
}
