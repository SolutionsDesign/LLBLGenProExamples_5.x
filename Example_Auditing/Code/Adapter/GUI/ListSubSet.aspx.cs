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
using SD.LLBLGen.Pro.ORMSupportClasses;

/// <summary>Page which lists a subset based on a specified filter of a given entity</summary>
public partial class ListSubSet : System.Web.UI.Page
{
	#region Class Member Declarations
	private EntityType _selectedEntityType;
	private bool _entityTypeDefined = false;
	private IListControl _lister;
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
			// load list control for given entity.
			Control controlToAdd = Page.LoadControl("~/Controls/List" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + "Instances.ascx");
			_lister = controlToAdd as IListControl;
			if(_lister != null)
			{
				phListControls.Controls.Add(controlToAdd);
			}
			phListArea.Visible = false;
			
			// load search control 
			controlToAdd = Page.LoadControl("~/Controls/Search" + GeneralUtils.EntityTypeToEntityName(_selectedEntityType) + ".ascx");
			_searcher = controlToAdd as ISearchControl;
			if(_searcher != null)
			{
				_searcher.AllowSingleEntitySearches = false;
				_searcher.AllowMultiEntitySearches = true;
				_searcher.SearchClicked += new EventHandler(searcher_SearchClicked);
				phSearchControls.Controls.Add(controlToAdd);
				phSearchArea.Visible = true;
			}

			bool? showSearchArea = (bool?)ViewState["showSearchArea"];
			if(showSearchArea.HasValue)
			{ 
				// stored in viewstate, show the correct area.
				phSearchArea.Visible = showSearchArea.Value;
				phListArea.Visible = !showSearchArea.Value;
			}
		}

		if(!Page.IsPostBack)
		{
			if(_entityTypeDefined)
			{
				this.Title += _selectedEntityType.ToString() + " instances";
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
		if((_searcher != null) && (_lister!=null))
		{
			_lister.FilterToUse = new RelationPredicateBucket(_searcher.Filter);
			phSearchArea.Visible = false;
			phListArea.Visible = true;
			ViewState["showSearchArea"] = false;
		}
	}
}
