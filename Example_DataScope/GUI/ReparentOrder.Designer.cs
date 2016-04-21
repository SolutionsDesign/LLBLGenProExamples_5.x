namespace Northwind.GUI
{
	partial class ReparentOrder
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
			if(disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			this._employeesFromBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._employeeFromComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this._employeeToComboBox = new System.Windows.Forms.ComboBox();
			this._employeesToBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this._fromOrdersGrid = new System.Windows.Forms.DataGridView();
			this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this._toOrdersGrid = new System.Windows.Forms.DataGridView();
			this.customerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.freightDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.requiredDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipAddressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipCityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipCountryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shippedDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipPostalCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipRegionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipViaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this._moveSelectedButton = new System.Windows.Forms.Button();
			this._saveChangesButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._employeesFromBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._employeesToBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._fromOrdersGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._toOrdersGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// _employeesFromBindingSource
			// 
			this._employeesFromBindingSource.DataSource = typeof(Northwind.DAL.EntityClasses.EmployeeEntity);
			// 
			// _employeeFromComboBox
			// 
			this._employeeFromComboBox.DataSource = this._employeesFromBindingSource;
			this._employeeFromComboBox.DisplayMember = "EmployeeId";
			this._employeeFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._employeeFromComboBox.FormattingEnabled = true;
			this._employeeFromComboBox.Location = new System.Drawing.Point(112, 17);
			this._employeeFromComboBox.Name = "_employeeFromComboBox";
			this._employeeFromComboBox.Size = new System.Drawing.Size(79, 21);
			this._employeeFromComboBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "From EmployeeID";
			// 
			// _employeeToComboBox
			// 
			this._employeeToComboBox.DataSource = this._employeesToBindingSource;
			this._employeeToComboBox.DisplayMember = "EmployeeId";
			this._employeeToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._employeeToComboBox.FormattingEnabled = true;
			this._employeeToComboBox.Location = new System.Drawing.Point(112, 318);
			this._employeeToComboBox.Name = "_employeeToComboBox";
			this._employeeToComboBox.Size = new System.Drawing.Size(79, 21);
			this._employeeToComboBox.TabIndex = 0;
			// 
			// _employeesToBindingSource
			// 
			this._employeesToBindingSource.DataSource = typeof(Northwind.DAL.EntityClasses.EmployeeEntity);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 321);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "To EmployeeID";
			// 
			// _fromOrdersGrid
			// 
			this._fromOrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._fromOrdersGrid.AutoGenerateColumns = false;
			this._fromOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._fromOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.shipPostalCodeDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn});
			this._fromOrdersGrid.DataSource = this.ordersBindingSource;
			this._fromOrdersGrid.Location = new System.Drawing.Point(16, 44);
			this._fromOrdersGrid.MultiSelect = false;
			this._fromOrdersGrid.Name = "_fromOrdersGrid";
			this._fromOrdersGrid.Size = new System.Drawing.Size(742, 229);
			this._fromOrdersGrid.TabIndex = 2;
			this._fromOrdersGrid.SelectionChanged += new System.EventHandler(this._fromOrdersGrid_SelectionChanged);
			// 
			// customerIdDataGridViewTextBoxColumn
			// 
			this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
			// 
			// employeeIdDataGridViewTextBoxColumn
			// 
			this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
			this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
			this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
			// 
			// freightDataGridViewTextBoxColumn
			// 
			this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
			this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
			this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
			// 
			// orderDateDataGridViewTextBoxColumn
			// 
			this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
			// 
			// orderIdDataGridViewTextBoxColumn
			// 
			this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
			// 
			// requiredDateDataGridViewTextBoxColumn
			// 
			this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
			this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
			this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
			// 
			// shipAddressDataGridViewTextBoxColumn
			// 
			this.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
			this.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
			this.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
			// 
			// shipCityDataGridViewTextBoxColumn
			// 
			this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
			this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
			this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
			// 
			// shipCountryDataGridViewTextBoxColumn
			// 
			this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
			this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
			this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
			// 
			// shipNameDataGridViewTextBoxColumn
			// 
			this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
			// 
			// shippedDateDataGridViewTextBoxColumn
			// 
			this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
			this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
			this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
			// 
			// shipPostalCodeDataGridViewTextBoxColumn
			// 
			this.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode";
			this.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode";
			this.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn";
			// 
			// shipRegionDataGridViewTextBoxColumn
			// 
			this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
			this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
			this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
			// 
			// shipViaDataGridViewTextBoxColumn
			// 
			this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
			this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
			this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
			// 
			// ordersBindingSource
			// 
			this.ordersBindingSource.DataMember = "Orders";
			this.ordersBindingSource.DataSource = this._employeesFromBindingSource;
			// 
			// _toOrdersGrid
			// 
			this._toOrdersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._toOrdersGrid.AutoGenerateColumns = false;
			this._toOrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._toOrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn1,
            this.employeeIdDataGridViewTextBoxColumn1,
            this.freightDataGridViewTextBoxColumn1,
            this.orderDateDataGridViewTextBoxColumn1,
            this.orderIdDataGridViewTextBoxColumn1,
            this.requiredDateDataGridViewTextBoxColumn1,
            this.shipAddressDataGridViewTextBoxColumn1,
            this.shipCityDataGridViewTextBoxColumn1,
            this.shipCountryDataGridViewTextBoxColumn1,
            this.shipNameDataGridViewTextBoxColumn1,
            this.shippedDateDataGridViewTextBoxColumn1,
            this.shipPostalCodeDataGridViewTextBoxColumn1,
            this.shipRegionDataGridViewTextBoxColumn1,
            this.shipViaDataGridViewTextBoxColumn1});
			this._toOrdersGrid.DataSource = this.ordersBindingSource1;
			this._toOrdersGrid.Location = new System.Drawing.Point(16, 345);
			this._toOrdersGrid.MultiSelect = false;
			this._toOrdersGrid.Name = "_toOrdersGrid";
			this._toOrdersGrid.Size = new System.Drawing.Size(742, 282);
			this._toOrdersGrid.TabIndex = 2;
			// 
			// customerIdDataGridViewTextBoxColumn1
			// 
			this.customerIdDataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn1.HeaderText = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn1.Name = "customerIdDataGridViewTextBoxColumn1";
			// 
			// employeeIdDataGridViewTextBoxColumn1
			// 
			this.employeeIdDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeId";
			this.employeeIdDataGridViewTextBoxColumn1.HeaderText = "EmployeeId";
			this.employeeIdDataGridViewTextBoxColumn1.Name = "employeeIdDataGridViewTextBoxColumn1";
			// 
			// freightDataGridViewTextBoxColumn1
			// 
			this.freightDataGridViewTextBoxColumn1.DataPropertyName = "Freight";
			this.freightDataGridViewTextBoxColumn1.HeaderText = "Freight";
			this.freightDataGridViewTextBoxColumn1.Name = "freightDataGridViewTextBoxColumn1";
			// 
			// orderDateDataGridViewTextBoxColumn1
			// 
			this.orderDateDataGridViewTextBoxColumn1.DataPropertyName = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn1.HeaderText = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn1.Name = "orderDateDataGridViewTextBoxColumn1";
			// 
			// orderIdDataGridViewTextBoxColumn1
			// 
			this.orderIdDataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
			this.orderIdDataGridViewTextBoxColumn1.HeaderText = "OrderId";
			this.orderIdDataGridViewTextBoxColumn1.Name = "orderIdDataGridViewTextBoxColumn1";
			// 
			// requiredDateDataGridViewTextBoxColumn1
			// 
			this.requiredDateDataGridViewTextBoxColumn1.DataPropertyName = "RequiredDate";
			this.requiredDateDataGridViewTextBoxColumn1.HeaderText = "RequiredDate";
			this.requiredDateDataGridViewTextBoxColumn1.Name = "requiredDateDataGridViewTextBoxColumn1";
			// 
			// shipAddressDataGridViewTextBoxColumn1
			// 
			this.shipAddressDataGridViewTextBoxColumn1.DataPropertyName = "ShipAddress";
			this.shipAddressDataGridViewTextBoxColumn1.HeaderText = "ShipAddress";
			this.shipAddressDataGridViewTextBoxColumn1.Name = "shipAddressDataGridViewTextBoxColumn1";
			// 
			// shipCityDataGridViewTextBoxColumn1
			// 
			this.shipCityDataGridViewTextBoxColumn1.DataPropertyName = "ShipCity";
			this.shipCityDataGridViewTextBoxColumn1.HeaderText = "ShipCity";
			this.shipCityDataGridViewTextBoxColumn1.Name = "shipCityDataGridViewTextBoxColumn1";
			// 
			// shipCountryDataGridViewTextBoxColumn1
			// 
			this.shipCountryDataGridViewTextBoxColumn1.DataPropertyName = "ShipCountry";
			this.shipCountryDataGridViewTextBoxColumn1.HeaderText = "ShipCountry";
			this.shipCountryDataGridViewTextBoxColumn1.Name = "shipCountryDataGridViewTextBoxColumn1";
			// 
			// shipNameDataGridViewTextBoxColumn1
			// 
			this.shipNameDataGridViewTextBoxColumn1.DataPropertyName = "ShipName";
			this.shipNameDataGridViewTextBoxColumn1.HeaderText = "ShipName";
			this.shipNameDataGridViewTextBoxColumn1.Name = "shipNameDataGridViewTextBoxColumn1";
			// 
			// shippedDateDataGridViewTextBoxColumn1
			// 
			this.shippedDateDataGridViewTextBoxColumn1.DataPropertyName = "ShippedDate";
			this.shippedDateDataGridViewTextBoxColumn1.HeaderText = "ShippedDate";
			this.shippedDateDataGridViewTextBoxColumn1.Name = "shippedDateDataGridViewTextBoxColumn1";
			// 
			// shipPostalCodeDataGridViewTextBoxColumn1
			// 
			this.shipPostalCodeDataGridViewTextBoxColumn1.DataPropertyName = "ShipPostalCode";
			this.shipPostalCodeDataGridViewTextBoxColumn1.HeaderText = "ShipPostalCode";
			this.shipPostalCodeDataGridViewTextBoxColumn1.Name = "shipPostalCodeDataGridViewTextBoxColumn1";
			// 
			// shipRegionDataGridViewTextBoxColumn1
			// 
			this.shipRegionDataGridViewTextBoxColumn1.DataPropertyName = "ShipRegion";
			this.shipRegionDataGridViewTextBoxColumn1.HeaderText = "ShipRegion";
			this.shipRegionDataGridViewTextBoxColumn1.Name = "shipRegionDataGridViewTextBoxColumn1";
			// 
			// shipViaDataGridViewTextBoxColumn1
			// 
			this.shipViaDataGridViewTextBoxColumn1.DataPropertyName = "ShipVia";
			this.shipViaDataGridViewTextBoxColumn1.HeaderText = "ShipVia";
			this.shipViaDataGridViewTextBoxColumn1.Name = "shipViaDataGridViewTextBoxColumn1";
			// 
			// ordersBindingSource1
			// 
			this.ordersBindingSource1.DataMember = "Orders";
			this.ordersBindingSource1.DataSource = this._employeesToBindingSource;
			// 
			// _moveSelectedButton
			// 
			this._moveSelectedButton.Location = new System.Drawing.Point(16, 279);
			this._moveSelectedButton.Name = "_moveSelectedButton";
			this._moveSelectedButton.Size = new System.Drawing.Size(125, 23);
			this._moveSelectedButton.TabIndex = 3;
			this._moveSelectedButton.Text = "Move selected";
			this._moveSelectedButton.UseVisualStyleBackColor = true;
			this._moveSelectedButton.Click += new System.EventHandler(this._moveSelectedButton_Click);
			// 
			// _saveChangesButton
			// 
			this._saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._saveChangesButton.Enabled = false;
			this._saveChangesButton.Location = new System.Drawing.Point(633, 279);
			this._saveChangesButton.Name = "_saveChangesButton";
			this._saveChangesButton.Size = new System.Drawing.Size(125, 23);
			this._saveChangesButton.TabIndex = 3;
			this._saveChangesButton.Text = "Save changes";
			this._saveChangesButton.UseVisualStyleBackColor = true;
			this._saveChangesButton.Click += new System.EventHandler(this._saveChangesButton_Click);
			// 
			// ReparentOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 639);
			this.Controls.Add(this._saveChangesButton);
			this.Controls.Add(this._moveSelectedButton);
			this.Controls.Add(this._toOrdersGrid);
			this.Controls.Add(this._fromOrdersGrid);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._employeeToComboBox);
			this.Controls.Add(this._employeeFromComboBox);
			this.Name = "ReparentOrder";
			this.Text = "ReparentOrder";
			((System.ComponentModel.ISupportInitialize)(this._employeesFromBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._employeesToBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._fromOrdersGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._toOrdersGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource _employeesFromBindingSource;
		private System.Windows.Forms.ComboBox _employeeFromComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _employeeToComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView _fromOrdersGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource ordersBindingSource;
		private System.Windows.Forms.DataGridView _toOrdersGrid;
		private System.Windows.Forms.BindingSource _employeesToBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn1;
		private System.Windows.Forms.BindingSource ordersBindingSource1;
		private System.Windows.Forms.Button _moveSelectedButton;
		private System.Windows.Forms.Button _saveChangesButton;
	}
}