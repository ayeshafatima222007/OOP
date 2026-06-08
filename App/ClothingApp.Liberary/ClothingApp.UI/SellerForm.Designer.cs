namespace ClothingApp.UI
{
    partial class SellerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSellerHeader = new System.Windows.Forms.Label();
            this.tabSellerForm = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlProductSidebar = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.pnlOrderSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.pnlDiscountSidebar = new System.Windows.Forms.Panel();
            this.lblDiscountId = new System.Windows.Forms.Label();
            this.txtDiscountId = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.btnRemoveDiscount = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.lblSellerLogout = new System.Windows.Forms.Label();
            this.btnLogoutYes = new System.Windows.Forms.Button();
            this.btnLogoutNo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabSellerForm.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.pnlProductSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabOrder.SuspendLayout();
            this.pnlOrderSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabDiscount.SuspendLayout();
            this.tabProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.pnlDiscountSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.lblSellerHeader);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblSellerHeader
            // 
            this.lblSellerHeader.AutoSize = true;
            this.lblSellerHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSellerHeader.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerHeader.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSellerHeader.Location = new System.Drawing.Point(425, 39);
            this.lblSellerHeader.Name = "lblSellerHeader";
            this.lblSellerHeader.Size = new System.Drawing.Size(137, 38);
            this.lblSellerHeader.TabIndex = 0;
            this.lblSellerHeader.Text = "Hey Seller";
            // 
            // tabSellerForm
            // 
            this.tabSellerForm.Controls.Add(this.tabProduct);
            this.tabSellerForm.Controls.Add(this.tabOrder);
            this.tabSellerForm.Controls.Add(this.tabDiscount);
            this.tabSellerForm.Controls.Add(this.tabProfile);
            this.tabSellerForm.Location = new System.Drawing.Point(3, 109);
            this.tabSellerForm.Name = "tabSellerForm";
            this.tabSellerForm.SelectedIndex = 0;
            this.tabSellerForm.Size = new System.Drawing.Size(1022, 573);
            this.tabSellerForm.TabIndex = 1;
            // 
            // tabProduct
            // 
            this.tabProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProduct.BackgroundImage")));
            this.tabProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabProduct.Controls.Add(this.txtSearchProduct);
            this.tabProduct.Controls.Add(this.lblSearchProduct);
            this.tabProduct.Controls.Add(this.txtQty);
            this.tabProduct.Controls.Add(this.lblQty);
            this.tabProduct.Controls.Add(this.txtPrice);
            this.tabProduct.Controls.Add(this.lblPrice);
            this.tabProduct.Controls.Add(this.cmbSize);
            this.tabProduct.Controls.Add(this.lblSize);
            this.tabProduct.Controls.Add(this.txtColor);
            this.tabProduct.Controls.Add(this.lblColor);
            this.tabProduct.Controls.Add(this.txtProductName);
            this.tabProduct.Controls.Add(this.lblProductName);
            this.tabProduct.Controls.Add(this.pnlProductSidebar);
            this.tabProduct.Controls.Add(this.cmbCategory);
            this.tabProduct.Controls.Add(this.lblCategory);
            this.tabProduct.Controls.Add(this.txtProductId);
            this.tabProduct.Controls.Add(this.lblProductId);
            this.tabProduct.Controls.Add(this.dgvProduct);
            this.tabProduct.Location = new System.Drawing.Point(4, 29);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(1014, 540);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Products";
            this.tabProduct.UseVisualStyleBackColor = true;
            this.tabProduct.Click += new System.EventHandler(this.tabProduct_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(473, 483);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(314, 30);
            this.txtSearchProduct.TabIndex = 17;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchProduct.Location = new System.Drawing.Point(320, 486);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(147, 25);
            this.lblSearchProduct.TabIndex = 16;
            this.lblSearchProduct.Text = "Search Product";
            this.lblSearchProduct.Click += new System.EventHandler(this.lblSearchProduct_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(514, 438);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(210, 30);
            this.txtQty.TabIndex = 15;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(423, 443);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(85, 25);
            this.lblQty.TabIndex = 14;
            this.lblQty.Text = "Quantity";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(745, 378);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 30);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(660, 378);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // cmbSize
            // 
            this.cmbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbSize.Location = new System.Drawing.Point(340, 378);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(210, 33);
            this.cmbSize.TabIndex = 11;
            this.cmbSize.SelectedIndexChanged += new System.EventHandler(this.cmbSize_SelectedIndexChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(246, 383);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 25);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Size";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(745, 322);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(210, 30);
            this.txtColor.TabIndex = 9;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(660, 322);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(59, 25);
            this.lblColor.TabIndex = 8;
            this.lblColor.Text = "Color";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(340, 317);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(210, 30);
            this.txtProductName.TabIndex = 7;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(246, 322);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(64, 25);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Name";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // pnlProductSidebar
            // 
            this.pnlProductSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlProductSidebar.BackgroundImage")));
            this.pnlProductSidebar.Controls.Add(this.btnSearchProduct);
            this.pnlProductSidebar.Controls.Add(this.btnClearProduct);
            this.pnlProductSidebar.Controls.Add(this.btnRemoveProduct);
            this.pnlProductSidebar.Controls.Add(this.btnUpdateProduct);
            this.pnlProductSidebar.Controls.Add(this.btnAddProduct);
            this.pnlProductSidebar.Location = new System.Drawing.Point(7, 238);
            this.pnlProductSidebar.Name = "pnlProductSidebar";
            this.pnlProductSidebar.Size = new System.Drawing.Size(200, 296);
            this.pnlProductSidebar.TabIndex = 5;
            this.pnlProductSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProductSidebar_Paint);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.BackgroundImage")));
            this.btnSearchProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Location = new System.Drawing.Point(3, 200);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(193, 43);
            this.btnSearchProduct.TabIndex = 4;
            this.btnSearchProduct.Text = "Search Product";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearProduct.BackgroundImage")));
            this.btnClearProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProduct.Location = new System.Drawing.Point(4, 151);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(193, 43);
            this.btnClearProduct.TabIndex = 3;
            this.btnClearProduct.Text = "Clear Product";
            this.btnClearProduct.UseVisualStyleBackColor = true;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.BackgroundImage")));
            this.btnRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(3, 102);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(193, 43);
            this.btnRemoveProduct.TabIndex = 2;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.BackgroundImage")));
            this.btnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(4, 53);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(193, 43);
            this.btnUpdateProduct.TabIndex = 1;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(4, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(193, 43);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Casual",
            "Formal",
            "Embroidered",
            "Sports"});
            this.cmbCategory.Location = new System.Drawing.Point(745, 255);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(210, 33);
            this.cmbCategory.TabIndex = 4;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(647, 258);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(340, 255);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(210, 30);
            this.txtProductId.TabIndex = 2;
            this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(231, 258);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(103, 25);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Product ID";
            this.lblProductId.Click += new System.EventHandler(this.lblProductId_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(6, 6);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 25;
            this.dgvProduct.Size = new System.Drawing.Size(1002, 225);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // tabOrder
            // 
            this.tabOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabOrder.BackgroundImage")));
            this.tabOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabOrder.Controls.Add(this.pnlOrderSidebar);
            this.tabOrder.Controls.Add(this.txtOrderId);
            this.tabOrder.Controls.Add(this.lblOrderId);
            this.tabOrder.Controls.Add(this.dgvOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(1014, 540);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Orders";
            this.tabOrder.UseVisualStyleBackColor = true;
            this.tabOrder.Click += new System.EventHandler(this.tabOrder_Click);
            // 
            // pnlOrderSidebar
            // 
            this.pnlOrderSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOrderSidebar.BackgroundImage")));
            this.pnlOrderSidebar.Controls.Add(this.btnSearchOrder);
            this.pnlOrderSidebar.Controls.Add(this.btnRefreshOrders);
            this.pnlOrderSidebar.Location = new System.Drawing.Point(6, 372);
            this.pnlOrderSidebar.Name = "pnlOrderSidebar";
            this.pnlOrderSidebar.Size = new System.Drawing.Size(200, 165);
            this.pnlOrderSidebar.TabIndex = 3;
            this.pnlOrderSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrderSidebar_Paint);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchOrder.BackgroundImage")));
            this.btnSearchOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrder.Location = new System.Drawing.Point(3, 3);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(193, 43);
            this.btnSearchOrder.TabIndex = 0;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshOrders.BackgroundImage")));
            this.btnRefreshOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshOrders.Location = new System.Drawing.Point(3, 52);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(193, 43);
            this.btnRefreshOrders.TabIndex = 1;
            this.btnRefreshOrders.Text = "Refresh Orders";
            this.btnRefreshOrders.UseVisualStyleBackColor = true;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(428, 411);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(322, 30);
            this.txtOrderId.TabIndex = 2;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(317, 416);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(86, 25);
            this.lblOrderId.TabIndex = 1;
            this.lblOrderId.Text = "Order ID";
            this.lblOrderId.Click += new System.EventHandler(this.lblOrderId_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.Size = new System.Drawing.Size(1002, 360);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // tabDiscount
            // 
            this.tabDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDiscount.BackgroundImage")));
            this.tabDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDiscount.Controls.Add(this.txtDiscountPercent);
            this.tabDiscount.Controls.Add(this.lblDiscountPercent);
            this.tabDiscount.Controls.Add(this.txtDiscountId);
            this.tabDiscount.Controls.Add(this.lblDiscountId);
            this.tabDiscount.Controls.Add(this.pnlDiscountSidebar);
            this.tabDiscount.Controls.Add(this.dgvDiscount);
            this.tabDiscount.Location = new System.Drawing.Point(4, 29);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Size = new System.Drawing.Size(1014, 540);
            this.tabDiscount.TabIndex = 2;
            this.tabDiscount.Text = "Discounts";
            this.tabDiscount.UseVisualStyleBackColor = true;
            this.tabDiscount.Click += new System.EventHandler(this.tabDiscount_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProfile.BackgroundImage")));
            this.tabProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabProfile.Controls.Add(this.btnLogoutNo);
            this.tabProfile.Controls.Add(this.btnLogoutYes);
            this.tabProfile.Controls.Add(this.lblSellerLogout);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.txtConfirmPassword);
            this.tabProfile.Controls.Add(this.lblConfirmPassword);
            this.tabProfile.Controls.Add(this.txtNewPassword);
            this.tabProfile.Controls.Add(this.lblNewPassword);
            this.tabProfile.Controls.Add(this.txtPhone);
            this.tabProfile.Controls.Add(this.lblPhone);
            this.tabProfile.Controls.Add(this.txtUsername);
            this.tabProfile.Controls.Add(this.lblUsername);
            this.tabProfile.Location = new System.Drawing.Point(4, 29);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(1014, 540);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            this.tabProfile.Click += new System.EventHandler(this.tabProfile_Click);
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Location = new System.Drawing.Point(5, 3);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.RowHeadersWidth = 62;
            this.dgvDiscount.RowTemplate.Height = 28;
            this.dgvDiscount.Size = new System.Drawing.Size(1004, 276);
            this.dgvDiscount.TabIndex = 0;
            this.dgvDiscount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellContentClick);
            // 
            // pnlDiscountSidebar
            // 
            this.pnlDiscountSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDiscountSidebar.BackgroundImage")));
            this.pnlDiscountSidebar.Controls.Add(this.btnRemoveDiscount);
            this.pnlDiscountSidebar.Controls.Add(this.btnApplyDiscount);
            this.pnlDiscountSidebar.Location = new System.Drawing.Point(6, 286);
            this.pnlDiscountSidebar.Name = "pnlDiscountSidebar";
            this.pnlDiscountSidebar.Size = new System.Drawing.Size(200, 251);
            this.pnlDiscountSidebar.TabIndex = 1;
            this.pnlDiscountSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDiscountSidebar_Paint);
            // 
            // lblDiscountId
            // 
            this.lblDiscountId.AutoSize = true;
            this.lblDiscountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountId.Location = new System.Drawing.Point(384, 357);
            this.lblDiscountId.Name = "lblDiscountId";
            this.lblDiscountId.Size = new System.Drawing.Size(112, 25);
            this.lblDiscountId.TabIndex = 2;
            this.lblDiscountId.Text = "Discount ID";
            this.lblDiscountId.Click += new System.EventHandler(this.lblDiscountId_Click);
            // 
            // txtDiscountId
            // 
            this.txtDiscountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountId.Location = new System.Drawing.Point(536, 351);
            this.txtDiscountId.Name = "txtDiscountId";
            this.txtDiscountId.Size = new System.Drawing.Size(216, 30);
            this.txtDiscountId.TabIndex = 3;
            this.txtDiscountId.TextChanged += new System.EventHandler(this.txtDiscountId_TextChanged);
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.Location = new System.Drawing.Point(355, 429);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(160, 25);
            this.lblDiscountPercent.TabIndex = 6;
            this.lblDiscountPercent.Text = "Discount Percent";
            this.lblDiscountPercent.Click += new System.EventHandler(this.lblDiscountPercent_Click);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercent.Location = new System.Drawing.Point(536, 426);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(216, 30);
            this.txtDiscountPercent.TabIndex = 7;
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.txtDiscountPercent_TextChanged);
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApplyDiscount.BackgroundImage")));
            this.btnApplyDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplyDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyDiscount.Location = new System.Drawing.Point(4, 4);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(193, 43);
            this.btnApplyDiscount.TabIndex = 0;
            this.btnApplyDiscount.Text = "Apply Discount";
            this.btnApplyDiscount.UseVisualStyleBackColor = true;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // btnRemoveDiscount
            // 
            this.btnRemoveDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveDiscount.BackgroundImage")));
            this.btnRemoveDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDiscount.Location = new System.Drawing.Point(3, 53);
            this.btnRemoveDiscount.Name = "btnRemoveDiscount";
            this.btnRemoveDiscount.Size = new System.Drawing.Size(193, 43);
            this.btnRemoveDiscount.TabIndex = 1;
            this.btnRemoveDiscount.Text = "Remove Discount";
            this.btnRemoveDiscount.UseVisualStyleBackColor = true;
            this.btnRemoveDiscount.Click += new System.EventHandler(this.btnRemoveDiscount_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(57, 47);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(165, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(240, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(550, 47);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(143, 25);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(699, 42);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(240, 30);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(17, 124);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(142, 25);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.Click += new System.EventHandler(this.lblNewPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(165, 119);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(240, 30);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(527, 122);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(166, 25);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "ConfirmPassword";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(699, 117);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(240, 30);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateProfile.BackgroundImage")));
            this.btnUpdateProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(339, 235);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(322, 66);
            this.btnUpdateProfile.TabIndex = 8;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // lblSellerLogout
            // 
            this.lblSellerLogout.AutoSize = true;
            this.lblSellerLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellerLogout.Location = new System.Drawing.Point(175, 457);
            this.lblSellerLogout.Name = "lblSellerLogout";
            this.lblSellerLogout.Size = new System.Drawing.Size(213, 29);
            this.lblSellerLogout.TabIndex = 9;
            this.lblSellerLogout.Text = "Do you want to exit";
            this.lblSellerLogout.Click += new System.EventHandler(this.lblSellerLogout_Click);
            // 
            // btnLogoutYes
            // 
            this.btnLogoutYes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnLogoutYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutYes.Location = new System.Drawing.Point(428, 448);
            this.btnLogoutYes.Name = "btnLogoutYes";
            this.btnLogoutYes.Size = new System.Drawing.Size(130, 46);
            this.btnLogoutYes.TabIndex = 10;
            this.btnLogoutYes.Text = "Yes";
            this.btnLogoutYes.UseVisualStyleBackColor = false;
            this.btnLogoutYes.Click += new System.EventHandler(this.btnLogoutYes_Click);
            // 
            // btnLogoutNo
            // 
            this.btnLogoutNo.BackColor = System.Drawing.Color.Red;
            this.btnLogoutNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoutNo.Location = new System.Drawing.Point(605, 448);
            this.btnLogoutNo.Name = "btnLogoutNo";
            this.btnLogoutNo.Size = new System.Drawing.Size(130, 46);
            this.btnLogoutNo.TabIndex = 11;
            this.btnLogoutNo.Text = "No";
            this.btnLogoutNo.UseVisualStyleBackColor = false;
            this.btnLogoutNo.Click += new System.EventHandler(this.btnLogoutNo_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 694);
            this.Controls.Add(this.tabSellerForm);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 750);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSellerForm.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.pnlProductSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.pnlOrderSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabDiscount.ResumeLayout(false);
            this.tabDiscount.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.pnlDiscountSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSellerHeader;
        private System.Windows.Forms.TabControl tabSellerForm;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel pnlProductSidebar;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.FlowLayoutPanel pnlOrderSidebar;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.Label lblDiscountId;
        private System.Windows.Forms.Panel pnlDiscountSidebar;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountId;
        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Button btnRemoveDiscount;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnLogoutNo;
        private System.Windows.Forms.Button btnLogoutYes;
        private System.Windows.Forms.Label lblSellerLogout;
    }
}