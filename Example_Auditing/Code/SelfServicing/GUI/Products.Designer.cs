namespace SD.LLBLGen.Pro.Examples.Auditing.GUI
{
    partial class Products
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
            this._productsGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnDirectUpdate = new System.Windows.Forms.Button();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._suppliersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._suppliersCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._categoriesBinder = new System.Windows.Forms.BindingSource(this.components);
            this._categoriesCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CategoryCollection();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._productsBinder = new System.Windows.Forms.BindingSource(this.components);
            this._productsCollection = new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection();
            ((System.ComponentModel.ISupportInitialize)(this._productsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._suppliersBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._categoriesBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._productsBinder)).BeginInit();
            this.SuspendLayout();
            // 
            // _productsGridView
            // 
            this._productsGridView.AutoGenerateColumns = false;
            this._productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.quantityPerUnitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.unitsOnOrderDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.discontinuedDataGridViewCheckBoxColumn});
            this._productsGridView.DataSource = this._productsBinder;
            this._productsGridView.Location = new System.Drawing.Point(12, 116);
            this._productsGridView.MultiSelect = false;
            this._productsGridView.Name = "_productsGridView";
            this._productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._productsGridView.Size = new System.Drawing.Size(1055, 381);
            this._productsGridView.TabIndex = 0;
            this._productsGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._productsGridView_UserDeletingRow);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(806, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(697, 527);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Products";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(959, 527);
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
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(654, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SimpleTextAuditor is injected to ProducEntity instances. Every change you make is" +
                " journaling in a text file when you click \'Save Changes\'.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Target auditor text file (to change fileName go to app.config):";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFileName.Location = new System.Drawing.Point(325, 74);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(78, 13);
            this.lblFileName.TabIndex = 7;
            this.lblFileName.Text = "c:\\\\noraudit.txt";
            // 
            // btnDirectUpdate
            // 
            this.btnDirectUpdate.Location = new System.Drawing.Point(29, 521);
            this.btnDirectUpdate.Name = "btnDirectUpdate";
            this.btnDirectUpdate.Size = new System.Drawing.Size(145, 38);
            this.btnDirectUpdate.TabIndex = 8;
            this.btnDirectUpdate.Text = "Set Discountinued ALL \'Sea Food\' Products";
            this.btnDirectUpdate.UseVisualStyleBackColor = true;
            this.btnDirectUpdate.Click += new System.EventHandler(this.btnDirectUpdate_Click);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.DataSource = this._suppliersBinder;
            this.supplierIdDataGridViewTextBoxColumn.DisplayMember = "CompanyName";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierIdDataGridViewTextBoxColumn.ValueMember = "SupplierId";
            // 
            // _suppliersBinder
            // 
            this._suppliersBinder.DataSource = this._suppliersCollection;
            // 
            // _suppliersCollection
            // 
            this._suppliersCollection.ActiveContext = null;
            this._suppliersCollection.AllowEdit = true;
            this._suppliersCollection.AllowNew = true;
            this._suppliersCollection.AllowRemove = true;
            this._suppliersCollection.Capacity = 0;
            this._suppliersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._suppliersCollection.DoNotPerformAddIfPresent = false;
            this._suppliersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.SupplierEntityFactory();
            this._suppliersCollection.IsReadOnly = false;
            this._suppliersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._suppliersCollection.RemovedEntitiesTracker = null;
            this._suppliersCollection.SortClauses = null;
            this._suppliersCollection.SuppressClearInGetMulti = false;
            this._suppliersCollection.Transaction = null;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.DataSource = this._categoriesBinder;
            this.categoryIdDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIdDataGridViewTextBoxColumn.ValueMember = "CategoryId";
            // 
            // _categoriesBinder
            // 
            this._categoriesBinder.DataSource = this._categoriesCollection;
            // 
            // _categoriesCollection
            // 
            this._categoriesCollection.ActiveContext = null;
            this._categoriesCollection.AllowEdit = true;
            this._categoriesCollection.AllowNew = true;
            this._categoriesCollection.AllowRemove = true;
            this._categoriesCollection.Capacity = 0;
            this._categoriesCollection.ConcurrencyPredicateFactoryToUse = null;
            this._categoriesCollection.DoNotPerformAddIfPresent = false;
            this._categoriesCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.CategoryEntityFactory();
            this._categoriesCollection.IsReadOnly = false;
            this._categoriesCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._categoriesCollection.RemovedEntitiesTracker = null;
            this._categoriesCollection.SortClauses = null;
            this._categoriesCollection.SuppressClearInGetMulti = false;
            this._categoriesCollection.Transaction = null;
            // 
            // quantityPerUnitDataGridViewTextBoxColumn
            // 
            this.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // unitsOnOrderDataGridViewTextBoxColumn
            // 
            this.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // discontinuedDataGridViewCheckBoxColumn
            // 
            this.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn";
            // 
            // _productsBinder
            // 
            this._productsBinder.DataSource = this._productsCollection;
            // 
            // _productsCollection
            // 
            this._productsCollection.ActiveContext = null;
            this._productsCollection.AllowEdit = true;
            this._productsCollection.AllowNew = true;
            this._productsCollection.AllowRemove = true;
            this._productsCollection.Capacity = 0;
            this._productsCollection.ConcurrencyPredicateFactoryToUse = null;
            this._productsCollection.DoNotPerformAddIfPresent = false;
            this._productsCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses.ProductEntityFactory();
            this._productsCollection.IsReadOnly = false;
            this._productsCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._productsCollection.RemovedEntitiesTracker = null;
            this._productsCollection.SortClauses = null;
            this._productsCollection.SuppressClearInGetMulti = false;
            this._productsCollection.Transaction = null;
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 571);
            this.Controls.Add(this.btnDirectUpdate);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this._productsGridView);
            this.MaximizeBox = false;
            this.Name = "Products";
            this.Text = "LLBLGenPro Auditing Example - Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this._productsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._suppliersBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._categoriesBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._productsBinder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource _productsBinder;
        private System.Windows.Forms.DataGridView _productsGridView;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.ProductCollection _productsCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.CategoryCollection _categoriesCollection;
        private SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.SupplierCollection _suppliersCollection;
        private System.Windows.Forms.BindingSource _categoriesBinder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource _suppliersBinder;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discontinuedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnDirectUpdate;
    }
}