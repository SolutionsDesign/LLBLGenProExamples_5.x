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
public partial class _Login : System.Web.UI.Page 
{
	/// <summary>
	/// Handles the Load event of the Page control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // retrieve user info
        UserEntity user = new UserEntity(txtUserName.Text);
        using (DataAccessAdapter adapter = new DataAccessAdapter())
        {
            adapter.FetchEntity(user);
        }

        // user exist
        if (!user.IsNew)
        {
            // check for valid password
            if (user.Password == txtPassword.Text)
            {
                SessionHelper.AddUserObject(user);
                Response.Redirect("Default.aspx");
            }

            // wrong password!
            else
            {
                this.lblLoginValidate.Visible = true;
            }
        }

        // user doesn't exist!
        else
        {
            lblLoginValidate.Visible = true;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
