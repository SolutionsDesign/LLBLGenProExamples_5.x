namespace SD.LLBLGenPro.Examples.GUI
{
    partial class ProductForm
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
            this._productsCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.ProductCollection();
            this._productsBinder = new System.Windows.Forms.BindingSource(this.components);
            this._productsGrid = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._suppliersCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.SupplierCollection();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._categoriesCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.CategoryCollection();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._productsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxHeader = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._productsBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._productsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._productsErrorProvider)).BeginInit();
            this.gbxHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this._productsCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.ProductEntityFactory();
            this._productsCollection.IsReadOnly = false;
            this._productsCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._productsCollection.RemovedEntitiesTracker = null;
            this._productsCollection.SortClauses = null;
            this._productsCollection.SuppressClearInGetMulti = false;
            this._productsCollection.Transaction = null;
            // 
            // _productsBinder
            // 
            this._productsBinder.DataSource = this._productsCollection;
            // 
            // _productsGrid
            // 
            this._productsGrid.AutoGenerateColumns = false;
            this._productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this._productsGrid.DataSource = this._productsBinder;
            this._productsGrid.Location = new System.Drawing.Point(21, 89);
            this._productsGrid.MultiSelect = false;
            this._productsGrid.Name = "_productsGrid";
            this._productsGrid.Size = new System.Drawing.Size(884, 326);
            this._productsGrid.TabIndex = 0;
            this._productsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this._productsGrid_UserDeletingRow);
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
            this.supplierIdDataGridViewTextBoxColumn.DataSource = this._suppliersCollection;
            this.supplierIdDataGridViewTextBoxColumn.DisplayMember = "CompanyName";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierIdDataGridViewTextBoxColumn.ValueMember = "SupplierId";
            // 
            // _suppliersCollection
            // 
            this._suppliersCollection.ActiveContext = null;
            this._suppliersCollection.AllowEdit = true;
            this._suppliersCollection.AllowNew = true;
            this._suppliersCollection.AllowRemove = true;
            this._suppliersCollection.Capacity = 4;
            this._suppliersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._suppliersCollection.DoNotPerformAddIfPresent = false;
            this._suppliersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.SupplierEntityFactory();
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
            this.categoryIdDataGridViewTextBoxColumn.DataSource = this._categoriesCollection;
            this.categoryIdDataGridViewTextBoxColumn.DisplayMember = "CategoryName";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIdDataGridViewTextBoxColumn.ValueMember = "CategoryId";
            // 
            // _categoriesCollection
            // 
            this._categoriesCollection.ActiveContext = null;
            this._categoriesCollection.AllowEdit = true;
            this._categoriesCollection.AllowNew = true;
            this._categoriesCollection.AllowRemove = true;
            this._categoriesCollection.Capacity = 4;
            this._categoriesCollection.ConcurrencyPredicateFactoryToUse = null;
            this._categoriesCollection.DoNotPerformAddIfPresent = false;
            this._categoriesCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.CategoryEntityFactory();
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
            // _productsErrorProvider
            // 
            this._productsErrorProvider.ContainerControl = this;
            this._productsErrorProvider.DataSource = this._productsBinder;
            // 
            // gbxHeader
            // 
            this.gbxHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxHeader.Controls.Add(this.label1);
            this.gbxHeader.Location = new System.Drawing.Point(-9, -8);
            this.gbxHeader.Name = "gbxHeader";
            this.gbxHeader.Size = new System.Drawing.Size(955, 71);
            this.gbxHeader.TabIndex = 32;
            this.gbxHeader.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Products";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(771, 432);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(132, 35);
            this.btnSaveAll.TabIndex = 33;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 35);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(630, 432);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(132, 35);
            this.btnCancelAll.TabIndex = 35;
            this.btnCancelAll.Text = "Cancel All";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 485);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 116);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(621, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "User can\'t update an existing discontinued product. First (s)he must save the pro" +
                "duct as Active and then modifications are allowed.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "UnitsInStock >= 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "UnitPrice >=0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Things validated";
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 617);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.gbxHeader);
            this.Controls.Add(this._productsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation Example - Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this._productsBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._productsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._productsErrorProvider)).EndInit();
            this.gbxHeader.ResumeLayout(false);
            this.gbxHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SD.LLBLGen.Pro.Examples.CollectionClasses.ProductCollection _productsCollection;
        private System.Windows.Forms.BindingSource _productsBinder;
        private System.Windows.Forms.DataGridView _productsGrid;
        private System.Windows.Forms.ErrorProvider _productsErrorProvider;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.SupplierCollection _suppliersCollection;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.CategoryCollection _categoriesCollection;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.GroupBox gbxHeader;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}