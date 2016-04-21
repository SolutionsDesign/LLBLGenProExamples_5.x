namespace SD.LLBLGenPro.Examples.GUI
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this._ordersBinder = new System.Windows.Forms.BindingSource(this.components);
            this._ordersCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.OrderCollection();
            this.cbxCustomer = new System.Windows.Forms.ComboBox();
            this._customersCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this._employeesCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.EmployeeCollection();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.txtShipRegion = new System.Windows.Forms.TextBox();
            this.txtShipPostalCode = new System.Windows.Forms.TextBox();
            this.txtShipCountry = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.lblShippedDate = new System.Windows.Forms.Label();
            this.cbxShipper = new System.Windows.Forms.ComboBox();
            this._shippersCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.ShipperCollection();
            this.lblShipper = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblShipName = new System.Windows.Forms.Label();
            this.lblShipAddress = new System.Windows.Forms.Label();
            this.lblShipCity = new System.Windows.Forms.Label();
            this.lblShipRegion = new System.Windows.Forms.Label();
            this.lblShipPostalCode = new System.Windows.Forms.Label();
            this.lblShipCountry = new System.Windows.Forms.Label();
            this._ordersBinderNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this._orderDetailsGrid = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._productsCollection = new SD.LLBLGen.Pro.Examples.CollectionClasses.ProductCollection();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxOrder = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._ordersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxHeader = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._ordersBinder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ordersBinderNav)).BeginInit();
            this._ordersBinderNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDetailsGrid)).BeginInit();
            this.gbxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ordersErrorProvider)).BeginInit();
            this.gbxHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOrderId
            // 
            this.txtOrderId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "OrderId", true));
            this.txtOrderId.Location = new System.Drawing.Point(104, 24);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(121, 20);
            this.txtOrderId.TabIndex = 0;
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
            this._ordersCollection.Capacity = 4;
            this._ordersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._ordersCollection.DoNotPerformAddIfPresent = false;
            this._ordersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.OrderEntityFactory();
            this._ordersCollection.IsReadOnly = false;
            this._ordersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._ordersCollection.RemovedEntitiesTracker = null;
            this._ordersCollection.SortClauses = null;
            this._ordersCollection.SuppressClearInGetMulti = false;
            this._ordersCollection.Transaction = null;
            // 
            // cbxCustomer
            // 
            this.cbxCustomer.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._ordersBinder, "CustomerId", true));
            this.cbxCustomer.DataSource = this._customersCollection;
            this.cbxCustomer.DisplayMember = "CompanyName";
            this.cbxCustomer.FormattingEnabled = true;
            this.cbxCustomer.Location = new System.Drawing.Point(104, 51);
            this.cbxCustomer.Name = "cbxCustomer";
            this.cbxCustomer.Size = new System.Drawing.Size(219, 21);
            this.cbxCustomer.TabIndex = 1;
            this.cbxCustomer.ValueMember = "CustomerId";
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
            // cbxEmployee
            // 
            this.cbxEmployee.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._ordersBinder, "EmployeeId", true));
            this.cbxEmployee.DataSource = this._employeesCollection;
            this.cbxEmployee.DisplayMember = "FullName";
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(104, 79);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(219, 21);
            this.cbxEmployee.TabIndex = 2;
            this.cbxEmployee.ValueMember = "EmployeeId";
            // 
            // _employeesCollection
            // 
            this._employeesCollection.ActiveContext = null;
            this._employeesCollection.AllowEdit = true;
            this._employeesCollection.AllowNew = true;
            this._employeesCollection.AllowRemove = true;
            this._employeesCollection.Capacity = 4;
            this._employeesCollection.ConcurrencyPredicateFactoryToUse = null;
            this._employeesCollection.DoNotPerformAddIfPresent = false;
            this._employeesCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.EmployeeEntityFactory();
            this._employeesCollection.IsReadOnly = false;
            this._employeesCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._employeesCollection.RemovedEntitiesTracker = null;
            this._employeesCollection.SortClauses = null;
            this._employeesCollection.SuppressClearInGetMulti = false;
            this._employeesCollection.Transaction = null;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "OrderDate", true));
            this.txtOrderDate.Location = new System.Drawing.Point(104, 107);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(100, 20);
            this.txtOrderDate.TabIndex = 3;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "RequiredDate", true));
            this.txtRequiredDate.Location = new System.Drawing.Point(104, 134);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(100, 20);
            this.txtRequiredDate.TabIndex = 4;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShippedDate", true));
            this.txtShippedDate.Location = new System.Drawing.Point(104, 161);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(100, 20);
            this.txtShippedDate.TabIndex = 5;
            // 
            // txtFreight
            // 
            this.txtFreight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "Freight", true));
            this.txtFreight.Location = new System.Drawing.Point(446, 25);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(100, 20);
            this.txtFreight.TabIndex = 7;
            // 
            // txtShipName
            // 
            this.txtShipName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShipName", true));
            this.txtShipName.Location = new System.Drawing.Point(446, 52);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(274, 20);
            this.txtShipName.TabIndex = 8;
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShipAddress", true));
            this.txtShipAddress.Location = new System.Drawing.Point(446, 79);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(274, 20);
            this.txtShipAddress.TabIndex = 9;
            // 
            // txtShipCity
            // 
            this.txtShipCity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShipCity", true));
            this.txtShipCity.Location = new System.Drawing.Point(446, 106);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(139, 20);
            this.txtShipCity.TabIndex = 10;
            // 
            // txtShipRegion
            // 
            this.txtShipRegion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShipRegion", true));
            this.txtShipRegion.Location = new System.Drawing.Point(446, 133);
            this.txtShipRegion.Name = "txtShipRegion";
            this.txtShipRegion.Size = new System.Drawing.Size(139, 20);
            this.txtShipRegion.TabIndex = 11;
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShipPostalCode", true));
            this.txtShipPostalCode.Location = new System.Drawing.Point(446, 160);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(86, 20);
            this.txtShipPostalCode.TabIndex = 12;
            // 
            // txtShipCountry
            // 
            this.txtShipCountry.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._ordersBinder, "ShipCountry", true));
            this.txtShipCountry.Location = new System.Drawing.Point(446, 187);
            this.txtShipCountry.Name = "txtShipCountry";
            this.txtShipCountry.Size = new System.Drawing.Size(139, 20);
            this.txtShipCountry.TabIndex = 13;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(52, 28);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(45, 13);
            this.lblOrderId.TabIndex = 14;
            this.lblOrderId.Text = "OrderId:";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(43, 56);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 13);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.Text = "Customer:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(41, 84);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(56, 13);
            this.lblEmployee.TabIndex = 16;
            this.lblEmployee.Text = "Employee:";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(35, 112);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(62, 13);
            this.lblOrderDate.TabIndex = 17;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(18, 140);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(79, 13);
            this.lblRequiredDate.TabIndex = 18;
            this.lblRequiredDate.Text = "Required Date:";
            // 
            // lblShippedDate
            // 
            this.lblShippedDate.AutoSize = true;
            this.lblShippedDate.Location = new System.Drawing.Point(22, 168);
            this.lblShippedDate.Name = "lblShippedDate";
            this.lblShippedDate.Size = new System.Drawing.Size(75, 13);
            this.lblShippedDate.TabIndex = 19;
            this.lblShippedDate.Text = "Shipped Date:";
            // 
            // cbxShipper
            // 
            this.cbxShipper.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this._ordersBinder, "ShipVia", true));
            this.cbxShipper.DataSource = this._shippersCollection;
            this.cbxShipper.DisplayMember = "CompanyName";
            this.cbxShipper.FormattingEnabled = true;
            this.cbxShipper.Location = new System.Drawing.Point(104, 188);
            this.cbxShipper.Name = "cbxShipper";
            this.cbxShipper.Size = new System.Drawing.Size(219, 21);
            this.cbxShipper.TabIndex = 20;
            this.cbxShipper.ValueMember = "ShipperId";
            // 
            // _shippersCollection
            // 
            this._shippersCollection.ActiveContext = null;
            this._shippersCollection.AllowEdit = true;
            this._shippersCollection.AllowNew = true;
            this._shippersCollection.AllowRemove = true;
            this._shippersCollection.Capacity = 4;
            this._shippersCollection.ConcurrencyPredicateFactoryToUse = null;
            this._shippersCollection.DoNotPerformAddIfPresent = false;
            this._shippersCollection.EntityFactoryToUse = new SD.LLBLGen.Pro.Examples.FactoryClasses.ShipperEntityFactory();
            this._shippersCollection.IsReadOnly = false;
            this._shippersCollection.MaxNumberOfItemsToReturn = ((long)(0));
            this._shippersCollection.RemovedEntitiesTracker = null;
            this._shippersCollection.SortClauses = null;
            this._shippersCollection.SuppressClearInGetMulti = false;
            this._shippersCollection.Transaction = null;
            // 
            // lblShipper
            // 
            this.lblShipper.AutoSize = true;
            this.lblShipper.Location = new System.Drawing.Point(51, 196);
            this.lblShipper.Name = "lblShipper";
            this.lblShipper.Size = new System.Drawing.Size(46, 13);
            this.lblShipper.TabIndex = 21;
            this.lblShipper.Text = "Shipper:";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(398, 29);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(42, 13);
            this.lblFreight.TabIndex = 22;
            this.lblFreight.Text = "Freight:";
            // 
            // lblShipName
            // 
            this.lblShipName.AutoSize = true;
            this.lblShipName.Location = new System.Drawing.Point(378, 56);
            this.lblShipName.Name = "lblShipName";
            this.lblShipName.Size = new System.Drawing.Size(62, 13);
            this.lblShipName.TabIndex = 23;
            this.lblShipName.Text = "Ship Name:";
            // 
            // lblShipAddress
            // 
            this.lblShipAddress.AutoSize = true;
            this.lblShipAddress.Location = new System.Drawing.Point(368, 83);
            this.lblShipAddress.Name = "lblShipAddress";
            this.lblShipAddress.Size = new System.Drawing.Size(72, 13);
            this.lblShipAddress.TabIndex = 24;
            this.lblShipAddress.Text = "Ship Address:";
            // 
            // lblShipCity
            // 
            this.lblShipCity.AutoSize = true;
            this.lblShipCity.Location = new System.Drawing.Point(389, 110);
            this.lblShipCity.Name = "lblShipCity";
            this.lblShipCity.Size = new System.Drawing.Size(51, 13);
            this.lblShipCity.TabIndex = 25;
            this.lblShipCity.Text = "Ship City:";
            // 
            // lblShipRegion
            // 
            this.lblShipRegion.AutoSize = true;
            this.lblShipRegion.Location = new System.Drawing.Point(372, 137);
            this.lblShipRegion.Name = "lblShipRegion";
            this.lblShipRegion.Size = new System.Drawing.Size(68, 13);
            this.lblShipRegion.TabIndex = 26;
            this.lblShipRegion.Text = "Ship Region:";
            // 
            // lblShipPostalCode
            // 
            this.lblShipPostalCode.AutoSize = true;
            this.lblShipPostalCode.Location = new System.Drawing.Point(349, 164);
            this.lblShipPostalCode.Name = "lblShipPostalCode";
            this.lblShipPostalCode.Size = new System.Drawing.Size(91, 13);
            this.lblShipPostalCode.TabIndex = 27;
            this.lblShipPostalCode.Text = "Ship Postal Code:";
            // 
            // lblShipCountry
            // 
            this.lblShipCountry.AutoSize = true;
            this.lblShipCountry.Location = new System.Drawing.Point(370, 191);
            this.lblShipCountry.Name = "lblShipCountry";
            this.lblShipCountry.Size = new System.Drawing.Size(70, 13);
            this.lblShipCountry.TabIndex = 28;
            this.lblShipCountry.Text = "Ship Country:";
            // 
            // _ordersBinderNav
            // 
            this._ordersBinderNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this._ordersBinderNav.BindingSource = this._ordersBinder;
            this._ordersBinderNav.CountItem = this.bindingNavigatorCountItem;
            this._ordersBinderNav.DeleteItem = null;
            this._ordersBinderNav.Dock = System.Windows.Forms.DockStyle.None;
            this._ordersBinderNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.tsbEdit,
            this.bindingNavigatorAddNewItem});
            this._ordersBinderNav.Location = new System.Drawing.Point(27, 68);
            this._ordersBinderNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._ordersBinderNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._ordersBinderNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._ordersBinderNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._ordersBinderNav.Name = "_ordersBinderNav";
            this._ordersBinderNav.PositionItem = this.bindingNavigatorPositionItem;
            this._ordersBinderNav.Size = new System.Drawing.Size(262, 25);
            this._ordersBinderNav.TabIndex = 29;
            this._ordersBinderNav.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this._ordersBinderNav_ItemClicked);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbEdit
            // 
            this.tsbEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(29, 22);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // _orderDetailsGrid
            // 
            this._orderDetailsGrid.AutoGenerateColumns = false;
            this._orderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._orderDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.ProductId,
            this.UnitPrice,
            this.Quantity,
            this.Discount});
            this._orderDetailsGrid.DataMember = "OrderDetails";
            this._orderDetailsGrid.DataSource = this._ordersBinder;
            this._orderDetailsGrid.Location = new System.Drawing.Point(25, 245);
            this._orderDetailsGrid.Name = "_orderDetailsGrid";
            this._orderDetailsGrid.Size = new System.Drawing.Size(695, 114);
            this._orderDetailsGrid.TabIndex = 30;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.DataSource = this._productsCollection;
            this.ProductId.DisplayMember = "ProductName";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ProductId.ValueMember = "ProductId";
            // 
            // _productsCollection
            // 
            this._productsCollection.ActiveContext = null;
            this._productsCollection.AllowEdit = true;
            this._productsCollection.AllowNew = true;
            this._productsCollection.AllowRemove = true;
            this._productsCollection.Capacity = 4;
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
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            // 
            // gbxOrder
            // 
            this.gbxOrder.Controls.Add(this.btnCancel);
            this.gbxOrder.Controls.Add(this.btnSave);
            this.gbxOrder.Controls.Add(this.label1);
            this.gbxOrder.Controls.Add(this._orderDetailsGrid);
            this.gbxOrder.Controls.Add(this.lblShipCountry);
            this.gbxOrder.Controls.Add(this.lblShipPostalCode);
            this.gbxOrder.Controls.Add(this.lblShipRegion);
            this.gbxOrder.Controls.Add(this.lblShipCity);
            this.gbxOrder.Controls.Add(this.lblShipAddress);
            this.gbxOrder.Controls.Add(this.lblShipName);
            this.gbxOrder.Controls.Add(this.lblFreight);
            this.gbxOrder.Controls.Add(this.lblShipper);
            this.gbxOrder.Controls.Add(this.cbxShipper);
            this.gbxOrder.Controls.Add(this.lblShippedDate);
            this.gbxOrder.Controls.Add(this.lblRequiredDate);
            this.gbxOrder.Controls.Add(this.lblOrderDate);
            this.gbxOrder.Controls.Add(this.lblEmployee);
            this.gbxOrder.Controls.Add(this.lblCustomer);
            this.gbxOrder.Controls.Add(this.lblOrderId);
            this.gbxOrder.Controls.Add(this.txtShipCountry);
            this.gbxOrder.Controls.Add(this.txtShipPostalCode);
            this.gbxOrder.Controls.Add(this.txtShipRegion);
            this.gbxOrder.Controls.Add(this.txtShipCity);
            this.gbxOrder.Controls.Add(this.txtShipAddress);
            this.gbxOrder.Controls.Add(this.txtShipName);
            this.gbxOrder.Controls.Add(this.txtFreight);
            this.gbxOrder.Controls.Add(this.txtShippedDate);
            this.gbxOrder.Controls.Add(this.txtRequiredDate);
            this.gbxOrder.Controls.Add(this.txtOrderDate);
            this.gbxOrder.Controls.Add(this.cbxEmployee);
            this.gbxOrder.Controls.Add(this.cbxCustomer);
            this.gbxOrder.Controls.Add(this.txtOrderId);
            this.gbxOrder.Enabled = false;
            this.gbxOrder.Location = new System.Drawing.Point(27, 90);
            this.gbxOrder.Name = "gbxOrder";
            this.gbxOrder.Size = new System.Drawing.Size(767, 419);
            this.gbxOrder.TabIndex = 33;
            this.gbxOrder.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(675, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(591, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Order Items";
            // 
            // _ordersErrorProvider
            // 
            this._ordersErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this._ordersErrorProvider.ContainerControl = this;
            this._ordersErrorProvider.DataSource = this._ordersBinder;
            // 
            // gbxHeader
            // 
            this.gbxHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxHeader.Controls.Add(this.label2);
            this.gbxHeader.Location = new System.Drawing.Point(-12, -12);
            this.gbxHeader.Name = "gbxHeader";
            this.gbxHeader.Size = new System.Drawing.Size(866, 71);
            this.gbxHeader.TabIndex = 34;
            this.gbxHeader.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Orders";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(27, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 141);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "- ShippedDate  >= OrderDate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "- RequiredDate >= OrderDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "- Freight >= 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "- OrderDate > (Today - 1 month). You can\'t add orders which are too old.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "OrderValidator checks the following\r\n";
            // 
            // frmOrders
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 668);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxHeader);
            this.Controls.Add(this.gbxOrder);
            this.Controls.Add(this._ordersBinderNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation Example - Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ordersBinder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ordersBinderNav)).EndInit();
            this._ordersBinderNav.ResumeLayout(false);
            this._ordersBinderNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._orderDetailsGrid)).EndInit();
            this.gbxOrder.ResumeLayout(false);
            this.gbxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ordersErrorProvider)).EndInit();
            this.gbxHeader.ResumeLayout(false);
            this.gbxHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.ComboBox cbxCustomer;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.TextBox txtShipRegion;
        private System.Windows.Forms.TextBox txtShipPostalCode;
        private System.Windows.Forms.TextBox txtShipCountry;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.Label lblShippedDate;
        private System.Windows.Forms.ComboBox cbxShipper;
        private System.Windows.Forms.Label lblShipper;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblShipName;
        private System.Windows.Forms.Label lblShipAddress;
        private System.Windows.Forms.Label lblShipCity;
        private System.Windows.Forms.Label lblShipRegion;
        private System.Windows.Forms.Label lblShipPostalCode;
        private System.Windows.Forms.Label lblShipCountry;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.OrderCollection _ordersCollection;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.EmployeeCollection _employeesCollection;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.CustomerCollection _customersCollection;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.ShipperCollection _shippersCollection;
        private System.Windows.Forms.BindingSource _ordersBinder;
        private System.Windows.Forms.BindingNavigator _ordersBinderNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView _orderDetailsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductId;
        private SD.LLBLGen.Pro.Examples.CollectionClasses.ProductCollection _productsCollection;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.GroupBox gbxOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider _ordersErrorProvider;
        private System.Windows.Forms.GroupBox gbxHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}