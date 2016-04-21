using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            // show the Products form
            Products productsForm = new Products();
            productsForm.Show(this);
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            // show the Customers form
            Customers customerForm = new Customers();
            customerForm.Show(this);
        }

        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            // show the Orders form
            Orders orderForm = new Orders();
            orderForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}