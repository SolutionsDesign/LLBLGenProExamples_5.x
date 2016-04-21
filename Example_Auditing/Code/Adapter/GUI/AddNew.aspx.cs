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

/// <summary>Page which adds a new entity instance to the database </summary>
public partial class AddNew : System.Web.UI.Page
{
	#region Class Member Declarations
	private EntityType _selectedEntityType;
	private bool _entityTypeDefined = false;
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
			IEditControl editor = controlToAdd as IEditControl;
			if(editor != null)
			{
				editor.EditMode = FormViewMode.Insert;
				phControls.Controls.Add(controlToAdd);
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
}