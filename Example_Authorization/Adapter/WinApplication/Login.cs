using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SD.LLBLGen.Pro.Examples.Authorization.Identity;

namespace SD.LLBLGen.Pro.Examples.Authorization.GUI
{
    public partial class Login : Form
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Login()
        {
            InitializeComponent();

            lblLoginValidation.Visible = false;
            lblDescription.Text = "- Please use the Users-Groups Matrix below.\r\n";
            lblDescription.Text += "- Groups are used in Authorization rules.\r\n";
            lblDescription.Text += "- Each form authorization rules are described within each form.\r\n";
            lblDescription.Text += "- Try login with users of different groups to experience different behaviours.\r\n";
        }

        /// <summary>
        /// Login button Click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = LoginHelper.Login(txtUserID.Text, txtPassword.Text);

            if (success)
            {
                // Close the form if login succeeded
                Close();
            }
            else
            {
                // Display an error message if the login failed.
                lblLoginValidation.Visible = true;
                txtPassword.Clear();
            }
        }
    }
}