namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    partial class Orders
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
            this.components = new System.ComponentModel.Container();
            this._ordersGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._customersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._customersCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCollection();
            this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._employeesBinder = new System.Windows.Forms.BindingSource(this.components);
            this._employeesCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._shippersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._shippersCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._ordersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._ordersCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tcCustomers = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabAuditInfo = new System.Windows.Forms.TabPage();
            this.btnAuditInfoRefesh = new System.Windows.Forms.Button();
            this._auditInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.actionDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affectedEntityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditActionTypeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._auditActionTypeBinder = new System.Windows.Forms.BindingSource(this.components);
            this._auditActionTypeCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditActionTypeCollection();
            this.actionDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._orderAuditInfoBinder = new System.Windows.Forms.BindingSource(this.components);
            this._orderAuditInfoCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._ordersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._customersBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._employeesBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._shippersBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ordersBinder)).BeginInit();
            this.tcCustomers.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabAuditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._auditInfoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._auditActionTypeBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderAuditInfoBinder)).BeginInit();
            this.SuspendLayout();
            // 
            // _ordersGridView
            // 
            this._ordersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._ordersGridView.AutoGenerateColumns = false;
            this._ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipPostalCodeDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn});
            this._ordersGridView.DataSource = this._ordersBinder;
            this._ordersGridView.Location = new System.Drawing.Point(13, 16);
            this._ordersGridView.MultiSelect = false;
            this._ordersGridView.Name = "_ordersGridView";
            this._ordersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ordersGridView.Size = new System.Drawing.Size(784, 267);
            this._ordersGridView.TabIndex = 0;
            this._ordersGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._ordersGridView_UserDeletingRow);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.DataSource = this._customersBinder;
            this.customerIdDataGridViewTextBoxColumn.DisplayMember = "CompanyName";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.customerIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.customerIdDataGridViewTextBoxColumn.ValueMember = "CustomerId";
            // 
            // _customersBinder
            // 
            this._customersBinder.DataSource = this._customersCollection;
            // 
            // _customersCollection
            // 
            this._customersCollection.ActiveContext = null;
            this._customersCollection.AllowEdit = true;
            this._customersCollection.AllowNew = true;
            this._customersCollection.AllowRemove = true;
            this._customersCollection.Capacity = 0;
            this._customersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._customersCollection.DoNotPerformAddIfPresent = false;
            this._customersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CustomerEntityFactory();
            this._customersCollection.IsReadOnly = false;
            this._customersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._customersCollection.RemovedEntitiesTracker = null;
            this._customersCollection.SortClauses = null;
            this._customersCollection.SuppressClearInGetMulti = false;
            this._customersCollection.Transaction = null;
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.DataSource = this._employeesBinder;
            this.employeeIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            this.employeeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.employeeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.employeeIdDataGridViewTextBoxColumn.ValueMember = "EmployeeId";
            // 
            // _employeesBinder
            // 
            this._employeesBinder.DataSource = this._employeesCollection;
            // 
            // _employeesCollection
            // 
            this._employeesCollection.ActiveContext = null;
            this._employeesCollection.AllowEdit = true;
            this._employeesCollection.AllowNew = true;
            this._employeesCollection.AllowRemove = true;
            this._employeesCollection.Capacity = 0;
            this._employeesCollection.ConcurrencyPredicateFactoryToUse = null;
            this._employeesCollection.DoNotPerformAddIfPresent = false;
            this._employeesCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.EmployeeEntityFactory();
            this._employeesCollection.IsReadOnly = false;
            this._employeesCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._employeesCollection.RemovedEntitiesTracker = null;
            this._employeesCollection.SortClauses = null;
            this._employeesCollection.SuppressClearInGetMulti = false;
            this._employeesCollection.Transaction = null;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            // 
            // shippedDateDataGridViewTextBoxColumn
            // 
            this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
            // 
            // shipViaDataGridViewTextBoxColumn
            // 
            this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.DataSource = this._shippersBinder;
            this.shipViaDataGridViewTextBoxColumn.DisplayMember = "CompanyName";
            this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
            this.shipViaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shipViaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.shipViaDataGridViewTextBoxColumn.ValueMember = "ShipperId";
            // 
            // _shippersBinder
            // 
            this._shippersBinder.DataSource = this._shippersCollection;
            // 
            // _shippersCollection
            // 
            this._shippersCollection.ActiveContext = null;
            this._shippersCollection.AllowEdit = true;
            this._shippersCollection.AllowNew = true;
            this._shippersCollection.AllowRemove = true;
            this._shippersCollection.Capacity = 0;
            this._shippersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._shippersCollection.DoNotPerformAddIfPresent = false;
            this._shippersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.ShipperEntityFactory();
            this._shippersCollection.IsReadOnly = false;
            this._shippersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._shippersCollection.RemovedEntitiesTracker = null;
            this._shippersCollection.SortClauses = null;
            this._shippersCollection.SuppressClearInGetMulti = false;
            this._shippersCollection.Transaction = null;
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            // 
            // shipNameDataGridViewTextBoxColumn
            // 
            this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
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
            // shipRegionDataGridViewTextBoxColumn
            // 
            this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
            // 
            // shipPostalCodeDataGridViewTextBoxColumn
            // 
            this.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode";
            this.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode";
            this.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn";
            // 
            // shipCountryDataGridViewTextBoxColumn
            // 
            this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
            // 
            // _ordersBinder
            // 
            this._ordersBinder.DataSource = this._ordersCollection;
            // 
            // _ordersCollection
            // 
            this._ordersCollection.ActiveContext = null;
            this._ordersCollection.AllowEdit = true;
            this._ordersCollection.AllowNew = true;
            this._ordersCollection.AllowRemove = true;
            this._ordersCollection.Capacity = 0;
            this._ordersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._ordersCollection.DoNotPerformAddIfPresent = false;
            this._ordersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.OrderEntityFactory();
            this._ordersCollection.IsReadOnly = false;
            this._ordersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._ordersCollection.RemovedEntitiesTracker = null;
            this._ordersCollection.SortClauses = null;
            this._ordersCollection.SuppressClearInGetMulti = false;
            this._ordersCollection.Transaction = null;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(694, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(585, 304);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Orders";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(729, 504);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(103, 32);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(790, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DatabaseSpecificAuditor class is injected into OrderEntity instances. Every chang" +
                "e you make is journaled into the OrderAuditInfo table when you click \'Save Chang" +
                "es\'.";
            // 
            // tcCustomers
            // 
            this.tcCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcCustomers.Controls.Add(this.tabCustomers);
            this.tcCustomers.Controls.Add(this.tabAuditInfo);
            this.tcCustomers.Location = new System.Drawing.Point(12, 101);
            this.tcCustomers.Name = "tcCustomers";
            this.tcCustomers.SelectedIndex = 0;
            this.tcCustomers.Size = new System.Drawing.Size(824, 383);
            this.tcCustomers.TabIndex = 6;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this._ordersGridView);
            this.tabCustomers.Controls.Add(this.btnLoad);
            this.tabCustomers.Controls.Add(this.btnSave);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(816, 357);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Show Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabAuditInfo
            // 
            this.tabAuditInfo.Controls.Add(this.btnAuditInfoRefesh);
            this.tabAuditInfo.Controls.Add(this._auditInfoDataGrid);
            this.tabAuditInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAuditInfo.Name = "tabAuditInfo";
            this.tabAuditInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuditInfo.Size = new System.Drawing.Size(816, 357);
            this.tabAuditInfo.TabIndex = 1;
            this.tabAuditInfo.Text = "Show AuditInfo";
            this.tabAuditInfo.UseVisualStyleBackColor = true;
            // 
            // btnAuditInfoRefesh
            // 
            this.btnAuditInfoRefesh.Location = new System.Drawing.Point(697, 319);
            this.btnAuditInfoRefesh.Name = "btnAuditInfoRefesh";
            this.btnAuditInfoRefesh.Size = new System.Drawing.Size(103, 32);
            this.btnAuditInfoRefesh.TabIndex = 4;
            this.btnAuditInfoRefesh.Text = "Refresh";
            this.btnAuditInfoRefesh.UseVisualStyleBackColor = true;
            this.btnAuditInfoRefesh.Click += new System.EventHandler(this.btnAuditInfoRefesh_Click);
            // 
            // _auditInfoDataGrid
            // 
            this._auditInfoDataGrid.AllowUserToAddRows = false;
            this._auditInfoDataGrid.AllowUserToDeleteRows = false;
            this._auditInfoDataGrid.AutoGenerateColumns = false;
            this._auditInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._auditInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actionDateTimeDataGridViewTextBoxColumn,
            this.affectedEntityNameDataGridViewTextBoxColumn,
            this.AuditActionTypeId,
            this.actionDataDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.orderIdDataGridViewTextBoxColumn1});
            this._auditInfoDataGrid.DataSource = this._orderAuditInfoBinder;
            this._auditInfoDataGrid.Location = new System.Drawing.Point(23, 19);
            this._auditInfoDataGrid.Name = "_auditInfoDataGrid";
            this._auditInfoDataGrid.ReadOnly = true;
            this._auditInfoDataGrid.Size = new System.Drawing.Size(777, 281);
            this._auditInfoDataGrid.TabIndex = 0;
            // 
            // actionDateTimeDataGridViewTextBoxColumn
            // 
            this.actionDateTimeDataGridViewTextBoxColumn.DataPropertyName = "ActionDateTime";
            this.actionDateTimeDataGridViewTextBoxColumn.HeaderText = "ActionDateTime";
            this.actionDateTimeDataGridViewTextBoxColumn.Name = "actionDateTimeDataGridViewTextBoxColumn";
            this.actionDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDateTimeDataGridViewTextBoxColumn.Width = 120;
            // 
            // affectedEntityNameDataGridViewTextBoxColumn
            // 
            this.affectedEntityNameDataGridViewTextBoxColumn.DataPropertyName = "AffectedEntityName";
            this.affectedEntityNameDataGridViewTextBoxColumn.HeaderText = "AffectedEntityName";
            this.affectedEntityNameDataGridViewTextBoxColumn.Name = "affectedEntityNameDataGridViewTextBoxColumn";
            this.affectedEntityNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.affectedEntityNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // AuditActionTypeId
            // 
            this.AuditActionTypeId.DataPropertyName = "AuditActionTypeId";
            this.AuditActionTypeId.DataSource = this._auditActionTypeBinder;
            this.AuditActionTypeId.DisplayMember = "Name";
            this.AuditActionTypeId.HeaderText = "AuditActionType";
            this.AuditActionTypeId.Name = "AuditActionTypeId";
            this.AuditActionTypeId.ReadOnly = true;
            this.AuditActionTypeId.ValueMember = "AuditActionTypeId";
            this.AuditActionTypeId.Width = 120;
            // 
            // _auditActionTypeBinder
            // 
            this._auditActionTypeBinder.DataSource = this._auditActionTypeCollection;
            // 
            // _auditActionTypeCollection
            // 
            this._auditActionTypeCollection.ActiveContext = null;
            this._auditActionTypeCollection.AllowEdit = true;
            this._auditActionTypeCollection.AllowNew = true;
            this._auditActionTypeCollection.AllowRemove = true;
            this._auditActionTypeCollection.Capacity = 0;
            this._auditActionTypeCollection.ConcurrencyPredicateFactoryToUse = null;
            this._auditActionTypeCollection.DoNotPerformAddIfPresent = false;
            this._auditActionTypeCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.AuditActionTypeEntityFactory();
            this._auditActionTypeCollection.IsReadOnly = false;
            this._auditActionTypeCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._auditActionTypeCollection.RemovedEntitiesTracker = null;
            this._auditActionTypeCollection.SortClauses = null;
            this._auditActionTypeCollection.SuppressClearInGetMulti = false;
            this._auditActionTypeCollection.Transaction = null;
            // 
            // actionDataDataGridViewTextBoxColumn
            // 
            this.actionDataDataGridViewTextBoxColumn.DataPropertyName = "ActionData";
            this.actionDataDataGridViewTextBoxColumn.HeaderText = "ActionData";
            this.actionDataDataGridViewTextBoxColumn.Name = "actionDataDataGridViewTextBoxColumn";
            this.actionDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.actionDataDataGridViewTextBoxColumn.Width = 500;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderIdDataGridViewTextBoxColumn1
            // 
            this.orderIdDataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn1.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn1.Name = "orderIdDataGridViewTextBoxColumn1";
            this.orderIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.orderIdDataGridViewTextBoxColumn1.Width = 50;
            // 
            // _orderAuditInfoBinder
            // 
            this._orderAuditInfoBinder.DataSource = this._orderAuditInfoCollection;
            // 
            // _orderAuditInfoCollection
            // 
            this._orderAuditInfoCollection.ActiveContext = null;
            this._orderAuditInfoCollection.AllowEdit = true;
            this._orderAuditInfoCollection.AllowNew = true;
            this._orderAuditInfoCollection.AllowRemove = true;
            this._orderAuditInfoCollection.Capacity = 0;
            this._orderAuditInfoCollection.ConcurrencyPredicateFactoryToUse = null;
            this._orderAuditInfoCollection.DoNotPerformAddIfPresent = false;
            this._orderAuditInfoCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.OrderAuditInfoEntityFactory();
            this._orderAuditInfoCollection.IsReadOnly = false;
            this._orderAuditInfoCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._orderAuditInfoCollection.RemovedEntitiesTracker = null;
            this._orderAuditInfoCollection.SortClauses = null;
            this._orderAuditInfoCollection.SuppressClearInGetMulti = false;
            this._orderAuditInfoCollection.Transaction = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "This deep level auditor allows you to record more specific audit information, as " +
                "it refers to order entities.";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tcCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.MaximizeBox = false;
            this.Name = "Orders";
            this.Text = "LLBLGenPro Auditing Example - Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ordersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._customersBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._employeesBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._shippersBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ordersBinder)).EndInit();
            this.tcCustomers.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabAuditInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._auditInfoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._auditActionTypeBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._orderAuditInfoBinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource _ordersBinder;
        private System.Windows.Forms.DataGridView _ordersGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tcCustomers;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabAuditInfo;
        private System.Windows.Forms.BindingSource _customersBinder;
        private System.Windows.Forms.BindingSource _employeesBinder;
        private System.Windows.Forms.Button btnAuditInfoRefesh;
        private System.Windows.Forms.DataGridView _auditInfoDataGrid;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderCollection _ordersCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCollection _customersCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.EmployeeCollection _employeesCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ShipperCollection _shippersCollection;
        private System.Windows.Forms.BindingSource _shippersBinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn employeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn shipViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource _orderAuditInfoBinder;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.OrderAuditInfoCollection _orderAuditInfoCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditActionTypeCollection _auditActionTypeCollection;
        private System.Windows.Forms.BindingSource _auditActionTypeBinder;
        private System.Windows.Forms.DataGridViewComboBoxColumn auditActionTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affectedEntityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AuditActionTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
    }
}