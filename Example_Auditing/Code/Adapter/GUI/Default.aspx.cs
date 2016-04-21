using System;

using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DatabaseSpecific;

/// <summary>
/// The default start page of the application.
/// </summary>
public partial class _Default : System.Web.UI.Page 
{
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
		if(!Page.IsPostBack)
		{
			// add all entity types to the combo box.
			int[] values = (int[])Enum.GetValues(typeof(EntityType));
			for(int i = 0; i < values.Length; i++)
			{
				// add the item, but strip off the 'Entity' suffix
				cbxEntity.Items.Add(new ListItem(GeneralUtils.EntityTypeToEntityName((EntityType)i), i.ToString()));
			}

            // check for user info
            if (SessionHelper.GetUserID() == string.Empty)
            {
                Response.Redirect("Login.aspx");
            }

            #region get autiding simple text filename to use

            // look for SimpleTextAuditorTxtFileName setting at .config file
            string _outputAuditFileName = string.Empty;
            AppSettingsReader appConfiguration = new AppSettingsReader();
            try
            {
                _outputAuditFileName = (string)appConfiguration.GetValue("SimpleTextAuditorTxtFileName", typeof(string));
            }

            // SimpleTextAuditorTxtFileName not found! use default filename
            catch (InvalidOperationException)
            {
                _outputAuditFileName = "c:\\noraudit.txt";
            }

            this.lblAuditTextFileName.Text = _outputAuditFileName;

            #endregion
        }
    }


	/// <summary>
	/// Handles the Click event of the btnAdd control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnAdd_Click(object sender, EventArgs e)
	{
		Response.Redirect("AddNew.aspx?EntityType=" + cbxEntity.SelectedValue);
	}


	/// <summary>
	/// Handles the Click event of the btnEdit control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnEdit_Click(object sender, EventArgs e)
	{
		Response.Redirect("EditExisting.aspx?EntityType=" + cbxEntity.SelectedValue);
	}


	/// <summary>
	/// Handles the Click event of the btnDelete control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnDelete_Click(object sender, EventArgs e)
	{
		Response.Redirect("DeleteExisting.aspx?EntityType=" + cbxEntity.SelectedValue);
	}


	/// <summary>
	/// Handles the Click event of the btnListSubSet control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnListSubSet_Click(object sender, EventArgs e)
	{
		Response.Redirect("ListSubSet.aspx?EntityType=" + cbxEntity.SelectedValue);
	}


	/// <summary>
	/// Handles the Click event of the btnListAll control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnListAll_Click(object sender, EventArgs e)
	{
		Response.Redirect("ListAll.aspx?EntityType=" + cbxEntity.SelectedValue);
	}

    protected void btnListAllProducts_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListAll.aspx?EntityType=11");
    }

    protected void btnListAllCustomers_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListAll.aspx?EntityType=3");
    }

    protected void btnListAllOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("ListAll.aspx?EntityType=8");
    }
}
