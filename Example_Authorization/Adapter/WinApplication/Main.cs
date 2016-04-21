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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Launch an MDI child form.
        /// </summary>
        /// <param name="childForm">A new instance of the child form</param>
        private void LaunchChildForm(Form childForm)
        {
            // Look for the form in the already opened forms
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == childForm.GetType())
                {
                    // bring it to front, if found.
                    childForm = mdiChild;
                    childForm.BringToFront();
                    return;
                }
            }
            // Show a new form if it was not opened already.
            childForm.MdiParent = this;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        /// <summary>
        /// Exit menu item click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Orders menu item click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChildForm(new Orders());
        }

        /// <summary>
        /// Order Details menu item click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void orderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChildForm(new OrdersDetails());
        }

        /// <summary>
        /// Employees menu item click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChildForm(new Employees());
        }

        /// <summary>
        /// Customers menu item click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchChildForm(new Customers());
        }

        /// <summary>
        /// Log out menu item click event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close all opend forms
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }

            // Log out.
            LoginHelper.Logout();
        }

        /// <summary>
        /// File menu itme dropdown event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            // Enable and disbale the login & logout menu item
            // according to the user logedIn state.
            lOToolStripMenuItem.Enabled = LoginHelper.IsUserLoggedIn;
            loginToolStripMenuItem.Enabled = !LoginHelper.IsUserLoggedIn;            
        }

        /// <summary>
        /// Log in menu item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display the login form.
            Login login = new Login();
            login.Show();
        }
    }
}