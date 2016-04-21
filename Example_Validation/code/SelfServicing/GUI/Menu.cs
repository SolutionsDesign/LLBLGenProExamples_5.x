///////////////////////////////////////////////////////////////
// LLBLGen Pro v2.6 - Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 2.6
// (c) Solutions Design
//////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SD.LLBLGenPro.Examples.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customers = new CustomerForm();
            customers.ShowDialog(this);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm products = new ProductForm();
            products.ShowDialog(this);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderForm orders = new OrderForm();
            orders.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}