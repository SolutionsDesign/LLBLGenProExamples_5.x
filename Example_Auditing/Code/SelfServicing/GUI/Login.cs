using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            lblLoginValidation.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool success = LoginHelper.Login(txtUserID.Text, txtPassword.Text);

            if (success)
            {
                Close();
            }
            else
            {
                lblLoginValidation.Visible = true;
                txtUserID.Clear();
                txtPassword.Clear();
            }
        }
    }
}