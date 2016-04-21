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
/// Page which lists all instances (with paging) of the given entity type
/// </summary>
public partial class ListAll : System.Web.UI.Page
{
	#region Class Member Declarations
	private EntityType _selectedEntityType;
	private bool _entityTypeDefined = false;
	#endregion

	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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
			if(controlToAdd!=null)
			{
				phControls.Controls.Add(controlToAdd);
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
}
