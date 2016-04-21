namespace SD.LLBLGen.Pro.Examples.Authorization.GUI
{
    partial class Main
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerRelationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerRelationsToolStripMenuItem,
            this.hRToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.windowsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(727, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.lOToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened);
			// 
			// loginToolStripMenuItem
			// 
			this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
			this.loginToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.loginToolStripMenuItem.Text = "Log&in";
			this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
			// 
			// lOToolStripMenuItem
			// 
			this.lOToolStripMenuItem.Name = "lOToolStripMenuItem";
			this.lOToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.lOToolStripMenuItem.Text = "Log &Out";
			this.lOToolStripMenuItem.Click += new System.EventHandler(this.lOToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// customerRelationsToolStripMenuItem
			// 
			this.customerRelationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem});
			this.customerRelationsToolStripMenuItem.Name = "customerRelationsToolStripMenuItem";
			this.customerRelationsToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
			this.customerRelationsToolStripMenuItem.Text = "Customer &Relations";
			// 
			// customerToolStripMenuItem
			// 
			this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
			this.customerToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.customerToolStripMenuItem.Text = "&Customer";
			this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
			// 
			// hRToolStripMenuItem
			// 
			this.hRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem});
			this.hRToolStripMenuItem.Name = "hRToolStripMenuItem";
			this.hRToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
			this.hRToolStripMenuItem.Text = "&Human Resources";
			// 
			// employeesToolStripMenuItem
			// 
			this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
			this.employeesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.employeesToolStripMenuItem.Text = "&Employees";
			this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.orderDetailsToolStripMenuItem});
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.salesToolStripMenuItem.Text = "&Sales";
			// 
			// ordersToolStripMenuItem
			// 
			this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			this.ordersToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.ordersToolStripMenuItem.Text = "&Orders";
			this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
			// 
			// orderDetailsToolStripMenuItem
			// 
			this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
			this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.orderDetailsToolStripMenuItem.Text = "Order &Details";
			this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
			// 
			// windowsToolStripMenuItem
			// 
			this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
			this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.windowsToolStripMenuItem.Text = "&Windows";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 360);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LLBLGen Pro v4.x Authorization Example";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRelationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}