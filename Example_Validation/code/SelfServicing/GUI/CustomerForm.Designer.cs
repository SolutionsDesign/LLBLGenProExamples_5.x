namespace SD.LLBLGenPro.Examples.GUI
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this._customersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._customersCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this._customersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.lblContactTitle = new System.Windows.Forms.Label();
            this.txtContactTitle = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxFields = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._customersGrid = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxHeader = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._customersBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._customersErrorProvider)).BeginInit();
            this.gbxFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._customersGrid)).BeginInit();
            this.gbxHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "CompanyName", true));
            this.txtCompanyName.Location = new System.Drawing.Point(106, 47);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(246, 20);
            this.txtCompanyName.TabIndex = 1;
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
            this._customersCollection.Capacity = 4;
            this._customersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._customersCollection.DoNotPerformAddIfPresent = false;
            this._customersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.CustomerEntityFactory();
            this._customersCollection.IsReadOnly = false;
            this._customersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._customersCollection.RemovedEntitiesTracker = null;
            this._customersCollection.SortClauses = null;
            this._customersCollection.SuppressClearInGetMulti = false;
            this._customersCollection.Transaction = null;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "CustomerId", true));
            this.txtCustomerId.Location = new System.Drawing.Point(106, 20);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(69, 20);
            this.txtCustomerId.TabIndex = 0;
            // 
            // _customersErrorProvider
            // 
            this._customersErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._customersErrorProvider.ContainerControl = this;
            this._customersErrorProvider.DataSource = this._customersBinder;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(34, 24);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(66, 13);
            this.lblCustomerId.TabIndex = 3;
            this.lblCustomerId.Text = "Customer Id:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(15, 51);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 4;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(22, 78);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(78, 13);
            this.lblContactName.TabIndex = 6;
            this.lblContactName.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            this.txtContactName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "ContactName", true));
            this.txtContactName.Location = new System.Drawing.Point(106, 74);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(246, 20);
            this.txtContactName.TabIndex = 5;
            // 
            // lblContactTitle
            // 
            this.lblContactTitle.AutoSize = true;
            this.lblContactTitle.Location = new System.Drawing.Point(30, 105);
            this.lblContactTitle.Name = "lblContactTitle";
            this.lblContactTitle.Size = new System.Drawing.Size(70, 13);
            this.lblContactTitle.TabIndex = 8;
            this.lblContactTitle.Text = "Contact Title:";
            // 
            // txtContactTitle
            // 
            this.txtContactTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "ContactTitle", true));
            this.txtContactTitle.Location = new System.Drawing.Point(106, 101);
            this.txtContactTitle.Name = "txtContactTitle";
            this.txtContactTitle.Size = new System.Drawing.Size(246, 20);
            this.txtContactTitle.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(52, 132);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(106, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(246, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(431, 24);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // txtCity
            // 
            this.txtCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "City", true));
            this.txtCity.Location = new System.Drawing.Point(464, 20);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 11;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(391, 55);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 14;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "PostalCode", true));
            this.txtPostalCode.Location = new System.Drawing.Point(464, 51);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 13;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(412, 82);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 16;
            this.lblCountry.Text = "Country:";
            // 
            // txtCountry
            // 
            this.txtCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "Country", true));
            this.txtCountry.Location = new System.Drawing.Point(464, 78);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(140, 20);
            this.txtCountry.TabIndex = 15;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(417, 109);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(464, 105);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 17;
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(431, 136);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 13);
            this.lblFax.TabIndex = 20;
            this.lblFax.Text = "Fax:";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._customersBinder, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(464, 132);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 19;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(568, 187);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbxFields
            // 
            this.gbxFields.Controls.Add(this.lblFax);
            this.gbxFields.Controls.Add(this.txtFax);
            this.gbxFields.Controls.Add(this.lblPhone);
            this.gbxFields.Controls.Add(this.txtPhone);
            this.gbxFields.Controls.Add(this.lblCountry);
            this.gbxFields.Controls.Add(this.txtCountry);
            this.gbxFields.Controls.Add(this.lblPostalCode);
            this.gbxFields.Controls.Add(this.txtPostalCode);
            this.gbxFields.Controls.Add(this.lblCity);
            this.gbxFields.Controls.Add(this.txtCity);
            this.gbxFields.Controls.Add(this.lblAddress);
            this.gbxFields.Controls.Add(this.txtAddress);
            this.gbxFields.Controls.Add(this.lblContactTitle);
            this.gbxFields.Controls.Add(this.txtContactTitle);
            this.gbxFields.Controls.Add(this.lblContactName);
            this.gbxFields.Controls.Add(this.txtContactName);
            this.gbxFields.Controls.Add(this.lblCompanyName);
            this.gbxFields.Controls.Add(this.lblCustomerId);
            this.gbxFields.Controls.Add(this.txtCustomerId);
            this.gbxFields.Controls.Add(this.txtCompanyName);
            this.gbxFields.Location = new System.Drawing.Point(12, 285);
            this.gbxFields.Name = "gbxFields";
            this.gbxFields.Size = new System.Drawing.Size(632, 172);
            this.gbxFields.TabIndex = 24;
            this.gbxFields.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(568, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customers";
            // 
            // _customersGrid
            // 
            this._customersGrid.AllowUserToAddRows = false;
            this._customersGrid.AllowUserToOrderColumns = true;
            this._customersGrid.AutoGenerateColumns = false;
            this._customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._customersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.contactTitleDataGridViewTextBoxColumn});
            this._customersGrid.DataSource = this._customersBinder;
            this._customersGrid.Location = new System.Drawing.Point(12, 76);
            this._customersGrid.MultiSelect = false;
            this._customersGrid.Name = "_customersGrid";
            this._customersGrid.ReadOnly = true;
            this._customersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._customersGrid.ShowCellErrors = false;
            this._customersGrid.ShowRowErrors = false;
            this._customersGrid.Size = new System.Drawing.Size(541, 192);
            this._customersGrid.TabIndex = 29;
            this._customersGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._customersGrid_UserDeletingRow);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactTitleDataGridViewTextBoxColumn
            // 
            this.contactTitleDataGridViewTextBoxColumn.DataPropertyName = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.HeaderText = "ContactTitle";
            this.contactTitleDataGridViewTextBoxColumn.Name = "contactTitleDataGridViewTextBoxColumn";
            this.contactTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(568, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxHeader
            // 
            this.gbxHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxHeader.Controls.Add(this.label1);
            this.gbxHeader.Location = new System.Drawing.Point(-10, -10);
            this.gbxHeader.Name = "gbxHeader";
            this.gbxHeader.Size = new System.Drawing.Size(866, 71);
            this.gbxHeader.TabIndex = 31;
            this.gbxHeader.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(568, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 492);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 153);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(591, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone must be in correct format for US-Customers (Country = USA)";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "You can\'t delete a customer which has orders. You will see a elegant message inst" +
                "ead of a ugly exception.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(591, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Rules CustomerValidator is checking\r\n";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 656);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxHeader);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this._customersGrid);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxFields);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation Example  - Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this._customersBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._customersErrorProvider)).EndInit();
            this.gbxFields.ResumeLayout(false);
            this.gbxFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._customersGrid)).EndInit();
            this.gbxHeader.ResumeLayout(false);
            this.gbxHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection _customersCollection;
        private System.Windows.Forms.BindingSource _customersBinder;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.ErrorProvider _customersErrorProvider;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblContactTitle;
        private System.Windows.Forms.TextBox txtContactTitle;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbxFields;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _customersGrid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

