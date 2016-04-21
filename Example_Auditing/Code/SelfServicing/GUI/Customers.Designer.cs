namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    partial class Customers
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
            this._customersGridView = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._customersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._customersCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCollection();
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
            this.auditActionTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._auditActinTypeBinder = new System.Windows.Forms.BindingSource(this.components);
            this._auditActionTypeCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditActionTypeCollection();
            this.actionDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._auditInfoBinder = new System.Windows.Forms.BindingSource(this.components);
            this._auditInfoCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection();
            ((System.ComponentModel.ISupportInitialize)(this._customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._customersBinder)).BeginInit();
            this.tcCustomers.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tabAuditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._auditInfoDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._auditActinTypeBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._auditInfoBinder)).BeginInit();
            this.SuspendLayout();
            // 
            // _customersGridView
            // 
            this._customersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._customersGridView.AutoGenerateColumns = false;
            this._customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._customersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactTitleDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn});
            this._customersGridView.DataSource = this._customersBinder;
            this._customersGridView.Location = new System.Drawing.Point(13, 16);
            this._customersGridView.MultiSelect = false;
            this._customersGridView.Name = "_customersGridView";
            this._customersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._customersGridView.Size = new System.Drawing.Size(718, 280);
            this._customersGridView.TabIndex = 0;
            this._customersGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._customersGridView_UserDeletingRow);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            // 
            // contactTitleDataGridViewTextBoxColumn
            // 
            this.contactTitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.HeaderText = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.Name = "contactTitleDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(628, 311);
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
            this.btnLoad.Location = new System.Drawing.Point(519, 311);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Customers";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Location = new System.Drawing.Point(663, 487);
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
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(744, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DatabaseAuditor class is injected into CustomerEntity instances. Every change you" +
                " make is journaled into the AuditInfo table when you click \'Save Changes\'.";
            // 
            // tcCustomers
            // 
            this.tcCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcCustomers.Controls.Add(this.tabCustomers);
            this.tcCustomers.Controls.Add(this.tabAuditInfo);
            this.tcCustomers.Location = new System.Drawing.Point(12, 81);
            this.tcCustomers.Name = "tcCustomers";
            this.tcCustomers.SelectedIndex = 0;
            this.tcCustomers.Size = new System.Drawing.Size(758, 390);
            this.tcCustomers.TabIndex = 6;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this._customersGridView);
            this.tabCustomers.Controls.Add(this.btnLoad);
            this.tabCustomers.Controls.Add(this.btnSave);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(750, 364);
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
            this.tabAuditInfo.Size = new System.Drawing.Size(750, 364);
            this.tabAuditInfo.TabIndex = 1;
            this.tabAuditInfo.Text = "Show AuditInfo";
            this.tabAuditInfo.UseVisualStyleBackColor = true;
            // 
            // btnAuditInfoRefesh
            // 
            this.btnAuditInfoRefesh.Location = new System.Drawing.Point(630, 326);
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
            this.auditActionTypeIdDataGridViewTextBoxColumn,
            this.actionDataDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this._auditInfoDataGrid.DataSource = this._auditInfoBinder;
            this._auditInfoDataGrid.Location = new System.Drawing.Point(23, 19);
            this._auditInfoDataGrid.Name = "_auditInfoDataGrid";
            this._auditInfoDataGrid.ReadOnly = true;
            this._auditInfoDataGrid.Size = new System.Drawing.Size(710, 289);
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
            // auditActionTypeIdDataGridViewTextBoxColumn
            // 
            this.auditActionTypeIdDataGridViewTextBoxColumn.DataPropertyName = "AuditActionTypeId";
            this.auditActionTypeIdDataGridViewTextBoxColumn.DataSource = this._auditActinTypeBinder;
            this.auditActionTypeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.auditActionTypeIdDataGridViewTextBoxColumn.HeaderText = "AuditActionType";
            this.auditActionTypeIdDataGridViewTextBoxColumn.Name = "auditActionTypeIdDataGridViewTextBoxColumn";
            this.auditActionTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.auditActionTypeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.auditActionTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.auditActionTypeIdDataGridViewTextBoxColumn.ValueMember = "AuditActionTypeId";
            this.auditActionTypeIdDataGridViewTextBoxColumn.Width = 120;
            // 
            // _auditActinTypeBinder
            // 
            this._auditActinTypeBinder.DataSource = this._auditActionTypeCollection;
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
            this.actionDataDataGridViewTextBoxColumn.Width = 550;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 50;
            // 
            // _auditInfoBinder
            // 
            this._auditInfoBinder.DataSource = this._auditInfoCollection;
            // 
            // _auditInfoCollection
            // 
            this._auditInfoCollection.ActiveContext = null;
            this._auditInfoCollection.AllowEdit = true;
            this._auditInfoCollection.AllowNew = true;
            this._auditInfoCollection.AllowRemove = true;
            this._auditInfoCollection.Capacity = 0;
            this._auditInfoCollection.ConcurrencyPredicateFactoryToUse = null;
            this._auditInfoCollection.DoNotPerformAddIfPresent = false;
            this._auditInfoCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.AuditInfoEntityFactory();
            this._auditInfoCollection.IsReadOnly = false;
            this._auditInfoCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._auditInfoCollection.RemovedEntitiesTracker = null;
            this._auditInfoCollection.SortClauses = null;
            this._auditInfoCollection.SuppressClearInGetMulti = false;
            this._auditInfoCollection.Transaction = null;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 531);
            this.Controls.Add(this.tcCustomers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.MaximizeBox = false;
            this.Name = "Customers";
            this.Text = "LLBLGenPro Auditing Example - Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this._customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._customersBinder)).EndInit();
            this.tcCustomers.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tabAuditInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._auditInfoDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._auditActinTypeBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._auditInfoBinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource _customersBinder;
        private System.Windows.Forms.DataGridView _customersGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CustomerCollection _customersCollection;
        private System.Windows.Forms.TabControl tcCustomers;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabAuditInfo;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditInfoCollection _auditInfoCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditActionTypeCollection _auditActionTypeCollection;
        private System.Windows.Forms.BindingSource _auditInfoBinder;
        private System.Windows.Forms.BindingSource _auditActinTypeBinder;
        private System.Windows.Forms.Button btnAuditInfoRefesh;
        private System.Windows.Forms.DataGridView _auditInfoDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affectedEntityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn auditActionTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    }
}