namespace SD.LLBLGenPro.Examples.GUI
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
			this.btnCustomers = new System.Windows.Forms.Button();
			this.btnProducts = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.gbxHeader = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.hlForums = new System.Windows.Forms.LinkLabel();
			this.gbxHeader.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCustomers
			// 
			this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCustomers.Location = new System.Drawing.Point(15, 91);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(105, 57);
			this.btnCustomers.TabIndex = 0;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseVisualStyleBackColor = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnProducts
			// 
			this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnProducts.Location = new System.Drawing.Point(186, 91);
			this.btnProducts.Name = "btnProducts";
			this.btnProducts.Size = new System.Drawing.Size(105, 57);
			this.btnProducts.TabIndex = 1;
			this.btnProducts.Text = "Products";
			this.btnProducts.UseVisualStyleBackColor = true;
			this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(489, 439);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(95, 29);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnOrders
			// 
			this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOrders.Location = new System.Drawing.Point(357, 91);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new System.Drawing.Size(105, 57);
			this.btnOrders.TabIndex = 3;
			this.btnOrders.Text = "Orders";
			this.btnOrders.UseVisualStyleBackColor = true;
			this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
			// 
			// gbxHeader
			// 
			this.gbxHeader.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gbxHeader.Controls.Add(this.label1);
			this.gbxHeader.Location = new System.Drawing.Point(-11, -11);
			this.gbxHeader.Name = "gbxHeader";
			this.gbxHeader.Size = new System.Drawing.Size(866, 71);
			this.gbxHeader.TabIndex = 32;
			this.gbxHeader.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(508, 31);
			this.label1.TabIndex = 27;
			this.label1.Text = "LLBLGenPro v4 - Validation Examples";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "Customer example";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 13);
			this.label3.TabIndex = 34;
			this.label3.Text = "- Using CustomerValidator class";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(44, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(345, 13);
			this.label8.TabIndex = 39;
			this.label8.Text = "- Validator initialized via OnInitialized() method override (see partial class)";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(44, 72);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(239, 13);
			this.label9.TabIndex = 40;
			this.label9.Text = "- Entity field validation using Regular Expressions.";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(44, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(187, 13);
			this.label10.TabIndex = 41;
			this.label10.Text = "- Direct GUI-Entity validation behavior.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(187, 13);
			this.label4.TabIndex = 46;
			this.label4.Text = "- Direct GUI-Entity validation behavior.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(44, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(239, 13);
			this.label5.TabIndex = 45;
			this.label5.Text = "- Entity field validation using Regular Expressions.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(44, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(345, 13);
			this.label7.TabIndex = 43;
			this.label7.Text = "- Implementing validation INSIDE  ProductEntity class (see partial class).";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(17, 121);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(107, 13);
			this.label11.TabIndex = 42;
			this.label11.Text = "Products example";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(44, 271);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(187, 13);
			this.label12.TabIndex = 51;
			this.label12.Text = "- Direct GUI-Entity validation behavior.";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(44, 255);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(239, 13);
			this.label13.TabIndex = 50;
			this.label13.Text = "- Entity field validation using Regular Expressions.";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(44, 239);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(361, 13);
			this.label14.TabIndex = 49;
			this.label14.Text = "- Validator initialized via Dependency Injection mechanism (see app.config).";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(44, 223);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(383, 13);
			this.label15.TabIndex = 48;
			this.label15.Text = "- Using OrderValidator class (see SD.LLBLGen.Pro.Examples.Validators project).";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(17, 204);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(94, 13);
			this.label16.TabIndex = 47;
			this.label16.Text = "Orders example";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(15, 168);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 306);
			this.groupBox1.TabIndex = 52;
			this.groupBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(12, 496);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(572, 32);
			this.label6.TabIndex = 53;
			this.label6.Text = "The examples should only be used for demo purposes. The code of this example shou" +
    "ld not be used directly in production without further testing.\r\n";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label17
			// 
			this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label17.Location = new System.Drawing.Point(12, 534);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(572, 16);
			this.label17.TabIndex = 54;
			this.label17.Text = "To obtain more information and/or help, please read LLBLGen Pro documentation and" +
    " visit at";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hlForums
			// 
			this.hlForums.AutoSize = true;
			this.hlForums.Location = new System.Drawing.Point(214, 553);
			this.hlForums.Name = "hlForums";
			this.hlForums.Size = new System.Drawing.Size(165, 13);
			this.hlForums.TabIndex = 55;
			this.hlForums.TabStop = true;
			this.hlForums.Text = "http://www.llblgen.com/tinyforum";
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 575);
			this.Controls.Add(this.hlForums);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxHeader);
			this.Controls.Add(this.btnOrders);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnProducts);
			this.Controls.Add(this.btnCustomers);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Menu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LLBLGenPro - Validation Examples";
			this.gbxHeader.ResumeLayout(false);
			this.gbxHeader.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.GroupBox gbxHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.LinkLabel hlForums;
    }
}