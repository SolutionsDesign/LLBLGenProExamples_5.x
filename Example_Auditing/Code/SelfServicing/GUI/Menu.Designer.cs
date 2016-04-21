namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btnShowProducts = new System.Windows.Forms.Button();
			this.btnShowCustomers = new System.Windows.Forms.Button();
			this.btnShowOrders = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShowProducts
			// 
			this.btnShowProducts.Location = new System.Drawing.Point(49, 40);
			this.btnShowProducts.Name = "btnShowProducts";
			this.btnShowProducts.Size = new System.Drawing.Size(116, 23);
			this.btnShowProducts.TabIndex = 0;
			this.btnShowProducts.Text = "Products";
			this.btnShowProducts.UseVisualStyleBackColor = true;
			this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
			// 
			// btnShowCustomers
			// 
			this.btnShowCustomers.Location = new System.Drawing.Point(49, 90);
			this.btnShowCustomers.Name = "btnShowCustomers";
			this.btnShowCustomers.Size = new System.Drawing.Size(116, 23);
			this.btnShowCustomers.TabIndex = 1;
			this.btnShowCustomers.Text = "Customers";
			this.btnShowCustomers.UseVisualStyleBackColor = true;
			this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
			// 
			// btnShowOrders
			// 
			this.btnShowOrders.Location = new System.Drawing.Point(49, 142);
			this.btnShowOrders.Name = "btnShowOrders";
			this.btnShowOrders.Size = new System.Drawing.Size(116, 23);
			this.btnShowOrders.TabIndex = 2;
			this.btnShowOrders.Text = "Orders";
			this.btnShowOrders.UseVisualStyleBackColor = true;
			this.btnShowOrders.Click += new System.EventHandler(this.btnShowOrders_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(467, 418);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(78, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(12, 21);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(475, 31);
			this.lblTitle.TabIndex = 4;
			this.lblTitle.Text = "LLBLGen Pro v5.x Auditing Example";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(433, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "This example shows how to use Auditor classes and Depency Intjection with LLBLGen" +
    "Pro.";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnShowOrders);
			this.groupBox1.Controls.Add(this.btnShowCustomers);
			this.groupBox1.Controls.Add(this.btnShowProducts);
			this.groupBox1.Location = new System.Drawing.Point(155, 114);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(213, 188);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Please select an option";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 350);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(295, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "SimpleTextAuditor class is injected to ProductEntity instances";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 365);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(296, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "DatabaseAuditor class is injected to CustomerEntity instances";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 380);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(316, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "DatabaseSpecificAuditor class is injected to OrderEntity instances";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 412);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(276, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "To change the target entity injected go to Auditor classes";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 427);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(255, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "To enable/disable some auditor, go to app.config file";
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(557, 453);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnExit);
			this.MaximizeBox = false;
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowProducts;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Button btnShowOrders;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}