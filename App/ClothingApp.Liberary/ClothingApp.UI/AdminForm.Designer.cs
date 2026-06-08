namespace ClothingApp.UI
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.paneltop = new System.Windows.Forms.Panel();
            this.lblAdminHead = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.btnDelUserGo = new System.Windows.Forms.Button();
            this.btnFindUsernameGo = new System.Windows.Forms.Button();
            this.btnFindRoleGo = new System.Windows.Forms.Button();
            this.btnLoadAllUsers = new System.Windows.Forms.Button();
            this.txtDel_User = new System.Windows.Forms.TextBox();
            this.lblDel_User = new System.Windows.Forms.Label();
            this.txtFind_Uname = new System.Windows.Forms.TextBox();
            this.lblFind_Uname = new System.Windows.Forms.Label();
            this.txtFind_Role = new System.Windows.Forms.TextBox();
            this.lblFind_Role = new System.Windows.Forms.Label();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.ProductAdminSidePanel = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.btnFindProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.pnlAdminOrderLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFindOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrderStatus = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.cmbOrderStatus = new System.Windows.Forms.ComboBox();
            this.txtSearchOrderId = new System.Windows.Forms.TextBox();
            this.lblSearchOrderId = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.txtBuyerOrder = new System.Windows.Forms.TextBox();
            this.lblBuyerOrder = new System.Windows.Forms.Label();
            this.btnLoadOrders = new System.Windows.Forms.Button();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabPayments = new System.Windows.Forms.TabPage();
            this.txtSearchPaidOrderId = new System.Windows.Forms.TextBox();
            this.lblSearchPaidOrderId = new System.Windows.Forms.Label();
            this.pnlAdminPaymentLeft = new System.Windows.Forms.Panel();
            this.btnSearchByOrderId = new System.Windows.Forms.Button();
            this.btnFindPayment = new System.Windows.Forms.Button();
            this.btnMarkPaid = new System.Windows.Forms.Button();
            this.txtPayProdId = new System.Windows.Forms.TextBox();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.btnLoadPayment = new System.Windows.Forms.Button();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.tabDiscount = new System.Windows.Forms.TabPage();
            this.lblSearchDiscountCode = new System.Windows.Forms.Label();
            this.txtSearchDiscountCode = new System.Windows.Forms.TextBox();
            this.pnlAdminDiscountLeft = new System.Windows.Forms.Panel();
            this.btnFindDiscount = new System.Windows.Forms.Button();
            this.btnUpdateDiscount = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnLoadDiscount = new System.Windows.Forms.Button();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.dgvDiscount = new System.Windows.Forms.DataGridView();
            this.tabDelivery = new System.Windows.Forms.TabPage();
            this.txtDevlSearchOrderId = new System.Windows.Forms.TextBox();
            this.lblDevlSearchOrderId = new System.Windows.Forms.Label();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.txtDeliveryCost = new System.Windows.Forms.TextBox();
            this.lblDeliveryStatus = new System.Windows.Forms.Label();
            this.cmbDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.txtDevlOrderId = new System.Windows.Forms.TextBox();
            this.lblDevlOrderId = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.lblDeliveryId = new System.Windows.Forms.Label();
            this.btnLoadDeliveries = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnDevlFindByOrder = new System.Windows.Forms.Button();
            this.btnFindDelivery = new System.Windows.Forms.Button();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.tabExitAdmin = new System.Windows.Forms.TabPage();
            this.btnAdminNo = new System.Windows.Forms.Button();
            this.btnAdminYes = new System.Windows.Forms.Button();
            this.lblAdminLogOut = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabProducts.SuspendLayout();
            this.ProductAdminSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.tabOrder.SuspendLayout();
            this.pnlAdminOrderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabPayments.SuspendLayout();
            this.pnlAdminPaymentLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.tabDiscount.SuspendLayout();
            this.pnlAdminDiscountLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).BeginInit();
            this.tabDelivery.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.tabExitAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.RosyBrown;
            this.paneltop.Controls.Add(this.lblAdminHead);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(978, 100);
            this.paneltop.TabIndex = 2;
            // 
            // lblAdminHead
            // 
            this.lblAdminHead.AutoSize = true;
            this.lblAdminHead.BackColor = System.Drawing.Color.RosyBrown;
            this.lblAdminHead.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminHead.ForeColor = System.Drawing.Color.Firebrick;
            this.lblAdminHead.Location = new System.Drawing.Point(430, 33);
            this.lblAdminHead.Name = "lblAdminHead";
            this.lblAdminHead.Size = new System.Drawing.Size(148, 38);
            this.lblAdminHead.TabIndex = 0;
            this.lblAdminHead.Text = "Hey Admin";
            this.lblAdminHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdminHead.Click += new System.EventHandler(this.lblAdminHead_Click);
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabUsers);
            this.tabAdmin.Controls.Add(this.tabProducts);
            this.tabAdmin.Controls.Add(this.tabOrder);
            this.tabAdmin.Controls.Add(this.tabPayments);
            this.tabAdmin.Controls.Add(this.tabDiscount);
            this.tabAdmin.Controls.Add(this.tabDelivery);
            this.tabAdmin.Controls.Add(this.tabExitAdmin);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdmin.Location = new System.Drawing.Point(0, 100);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(978, 544);
            this.tabAdmin.TabIndex = 3;
            // 
            // tabUsers
            // 
            this.tabUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabUsers.BackgroundImage")));
            this.tabUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabUsers.Controls.Add(this.btnDelUserGo);
            this.tabUsers.Controls.Add(this.btnFindUsernameGo);
            this.tabUsers.Controls.Add(this.btnFindRoleGo);
            this.tabUsers.Controls.Add(this.btnLoadAllUsers);
            this.tabUsers.Controls.Add(this.txtDel_User);
            this.tabUsers.Controls.Add(this.lblDel_User);
            this.tabUsers.Controls.Add(this.txtFind_Uname);
            this.tabUsers.Controls.Add(this.lblFind_Uname);
            this.tabUsers.Controls.Add(this.txtFind_Role);
            this.tabUsers.Controls.Add(this.lblFind_Role);
            this.tabUsers.Controls.Add(this.dgvUser);
            this.tabUsers.Location = new System.Drawing.Point(4, 34);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(970, 506);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            this.tabUsers.Click += new System.EventHandler(this.tabUsers_Click);
            // 
            // btnDelUserGo
            // 
            this.btnDelUserGo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDelUserGo.Location = new System.Drawing.Point(668, 454);
            this.btnDelUserGo.Name = "btnDelUserGo";
            this.btnDelUserGo.Size = new System.Drawing.Size(75, 35);
            this.btnDelUserGo.TabIndex = 10;
            this.btnDelUserGo.Text = "Go";
            this.btnDelUserGo.UseVisualStyleBackColor = false;
            this.btnDelUserGo.Click += new System.EventHandler(this.btnDelUserGo_Click);
            // 
            // btnFindUsernameGo
            // 
            this.btnFindUsernameGo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFindUsernameGo.Location = new System.Drawing.Point(668, 404);
            this.btnFindUsernameGo.Name = "btnFindUsernameGo";
            this.btnFindUsernameGo.Size = new System.Drawing.Size(75, 35);
            this.btnFindUsernameGo.TabIndex = 9;
            this.btnFindUsernameGo.Text = "Go";
            this.btnFindUsernameGo.UseVisualStyleBackColor = false;
            this.btnFindUsernameGo.Click += new System.EventHandler(this.btnFindUsernameGo_Click);
            // 
            // btnFindRoleGo
            // 
            this.btnFindRoleGo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnFindRoleGo.Location = new System.Drawing.Point(668, 356);
            this.btnFindRoleGo.Name = "btnFindRoleGo";
            this.btnFindRoleGo.Size = new System.Drawing.Size(75, 35);
            this.btnFindRoleGo.TabIndex = 8;
            this.btnFindRoleGo.Text = "Go";
            this.btnFindRoleGo.UseVisualStyleBackColor = false;
            this.btnFindRoleGo.Click += new System.EventHandler(this.btnFindRoleGo_Click);
            // 
            // btnLoadAllUsers
            // 
            this.btnLoadAllUsers.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadAllUsers.Location = new System.Drawing.Point(310, 296);
            this.btnLoadAllUsers.Name = "btnLoadAllUsers";
            this.btnLoadAllUsers.Size = new System.Drawing.Size(345, 49);
            this.btnLoadAllUsers.TabIndex = 7;
            this.btnLoadAllUsers.Text = "Load All Users";
            this.btnLoadAllUsers.UseVisualStyleBackColor = false;
            this.btnLoadAllUsers.Click += new System.EventHandler(this.btnLoadAllUsers_Click);
            // 
            // txtDel_User
            // 
            this.txtDel_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDel_User.Location = new System.Drawing.Point(326, 456);
            this.txtDel_User.Name = "txtDel_User";
            this.txtDel_User.Size = new System.Drawing.Size(313, 30);
            this.txtDel_User.TabIndex = 6;
            this.txtDel_User.TextChanged += new System.EventHandler(this.txtDel_User_TextChanged);
            // 
            // lblDel_User
            // 
            this.lblDel_User.AutoSize = true;
            this.lblDel_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDel_User.Location = new System.Drawing.Point(175, 459);
            this.lblDel_User.Name = "lblDel_User";
            this.lblDel_User.Size = new System.Drawing.Size(114, 25);
            this.lblDel_User.TabIndex = 5;
            this.lblDel_User.Text = "Delete User";
            this.lblDel_User.Click += new System.EventHandler(this.lblDel_User_Click);
            // 
            // txtFind_Uname
            // 
            this.txtFind_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind_Uname.Location = new System.Drawing.Point(326, 409);
            this.txtFind_Uname.Name = "txtFind_Uname";
            this.txtFind_Uname.Size = new System.Drawing.Size(313, 30);
            this.txtFind_Uname.TabIndex = 4;
            this.txtFind_Uname.TextChanged += new System.EventHandler(this.txtFind_Uname_TextChanged);
            // 
            // lblFind_Uname
            // 
            this.lblFind_Uname.AutoSize = true;
            this.lblFind_Uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind_Uname.Location = new System.Drawing.Point(124, 409);
            this.lblFind_Uname.Name = "lblFind_Uname";
            this.lblFind_Uname.Size = new System.Drawing.Size(173, 25);
            this.lblFind_Uname.TabIndex = 3;
            this.lblFind_Uname.Text = "Find By Username";
            this.lblFind_Uname.Click += new System.EventHandler(this.lblFind_Uname_Click);
            // 
            // txtFind_Role
            // 
            this.txtFind_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind_Role.Location = new System.Drawing.Point(326, 358);
            this.txtFind_Role.Name = "txtFind_Role";
            this.txtFind_Role.Size = new System.Drawing.Size(313, 30);
            this.txtFind_Role.TabIndex = 2;
            this.txtFind_Role.TextChanged += new System.EventHandler(this.txtFind_Role_TextChanged);
            // 
            // lblFind_Role
            // 
            this.lblFind_Role.AutoSize = true;
            this.lblFind_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind_Role.Location = new System.Drawing.Point(175, 358);
            this.lblFind_Role.Name = "lblFind_Role";
            this.lblFind_Role.Size = new System.Drawing.Size(122, 25);
            this.lblFind_Role.TabIndex = 1;
            this.lblFind_Role.Text = "Find By Role";
            this.lblFind_Role.Click += new System.EventHandler(this.lblFind_Role_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(8, 6);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 25;
            this.dgvUser.Size = new System.Drawing.Size(954, 284);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // tabProducts
            // 
            this.tabProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProducts.BackgroundImage")));
            this.tabProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabProducts.Controls.Add(this.ProductAdminSidePanel);
            this.tabProducts.Controls.Add(this.txtProductId);
            this.tabProducts.Controls.Add(this.lblProductId);
            this.tabProducts.Controls.Add(this.txtQty);
            this.tabProducts.Controls.Add(this.lblQty);
            this.tabProducts.Controls.Add(this.txtPrice);
            this.tabProducts.Controls.Add(this.lblPrice);
            this.tabProducts.Controls.Add(this.txtSize);
            this.tabProducts.Controls.Add(this.lblSize);
            this.tabProducts.Controls.Add(this.btnLoadProducts);
            this.tabProducts.Controls.Add(this.txtColor);
            this.tabProducts.Controls.Add(this.lblColor);
            this.tabProducts.Controls.Add(this.txtName);
            this.tabProducts.Controls.Add(this.txtCategory);
            this.tabProducts.Controls.Add(this.lblName);
            this.tabProducts.Controls.Add(this.lblCategory);
            this.tabProducts.Controls.Add(this.dgvProduct);
            this.tabProducts.Location = new System.Drawing.Point(4, 34);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(970, 506);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            this.tabProducts.Click += new System.EventHandler(this.tabProducts_Click);
            // 
            // ProductAdminSidePanel
            // 
            this.ProductAdminSidePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProductAdminSidePanel.BackgroundImage")));
            this.ProductAdminSidePanel.Controls.Add(this.btnAddProduct);
            this.ProductAdminSidePanel.Controls.Add(this.btnDelProduct);
            this.ProductAdminSidePanel.Controls.Add(this.btnFindProduct);
            this.ProductAdminSidePanel.Controls.Add(this.btnUpdateProduct);
            this.ProductAdminSidePanel.Location = new System.Drawing.Point(9, 260);
            this.ProductAdminSidePanel.Name = "ProductAdminSidePanel";
            this.ProductAdminSidePanel.Size = new System.Drawing.Size(225, 229);
            this.ProductAdminSidePanel.TabIndex = 21;
            this.ProductAdminSidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProductAdminSidePanel_Paint);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(3, 7);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(219, 40);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = " Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelProduct.BackgroundImage")));
            this.btnDelProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProduct.Location = new System.Drawing.Point(3, 139);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(219, 45);
            this.btnDelProduct.TabIndex = 19;
            this.btnDelProduct.Text = "Delete Product";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            this.btnDelProduct.Click += new System.EventHandler(this.btnDelProduct_Click);
            // 
            // btnFindProduct
            // 
            this.btnFindProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindProduct.BackgroundImage")));
            this.btnFindProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindProduct.Location = new System.Drawing.Point(3, 51);
            this.btnFindProduct.Name = "btnFindProduct";
            this.btnFindProduct.Size = new System.Drawing.Size(219, 40);
            this.btnFindProduct.TabIndex = 20;
            this.btnFindProduct.Text = "Find Product";
            this.btnFindProduct.UseVisualStyleBackColor = true;
            this.btnFindProduct.Click += new System.EventHandler(this.btnFindProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.BackgroundImage")));
            this.btnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(3, 93);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(219, 40);
            this.btnUpdateProduct.TabIndex = 18;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(500, 459);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(274, 30);
            this.txtProductId.TabIndex = 16;
            this.txtProductId.TextChanged += new System.EventHandler(this.txtProductId_TextChanged);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(337, 459);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(103, 25);
            this.lblProductId.TabIndex = 15;
            this.lblProductId.Text = "Product ID";
            this.lblProductId.Click += new System.EventHandler(this.lblProductId_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(717, 405);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(197, 30);
            this.txtQty.TabIndex = 14;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(626, 410);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(85, 25);
            this.lblQty.TabIndex = 13;
            this.lblQty.Text = "Quantity";
            this.lblQty.Click += new System.EventHandler(this.lblQty_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(342, 414);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(197, 30);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(258, 410);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 25);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(717, 308);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(197, 30);
            this.txtSize.TabIndex = 10;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(660, 311);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(51, 25);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size";
            this.lblSize.Click += new System.EventHandler(this.lblSize_Click);
            // 
            // btnLoadProducts
            // 
            this.btnLoadProducts.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadProducts.Location = new System.Drawing.Point(376, 255);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(505, 47);
            this.btnLoadProducts.TabIndex = 8;
            this.btnLoadProducts.Text = "Load All Products";
            this.btnLoadProducts.UseVisualStyleBackColor = false;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(717, 358);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(197, 30);
            this.txtColor.TabIndex = 7;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(652, 363);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(59, 25);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            this.lblColor.Click += new System.EventHandler(this.lblColor_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(342, 363);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 30);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(342, 313);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(185, 30);
            this.txtCategory.TabIndex = 4;
            this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(250, 366);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(240, 311);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(8, 6);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.Size = new System.Drawing.Size(956, 248);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // tabOrder
            // 
            this.tabOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabOrder.BackgroundImage")));
            this.tabOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabOrder.Controls.Add(this.pnlAdminOrderLeft);
            this.tabOrder.Controls.Add(this.cmbOrderStatus);
            this.tabOrder.Controls.Add(this.txtSearchOrderId);
            this.tabOrder.Controls.Add(this.lblSearchOrderId);
            this.tabOrder.Controls.Add(this.txtOrderDate);
            this.tabOrder.Controls.Add(this.lblOrderDate);
            this.tabOrder.Controls.Add(this.txtBuyerOrder);
            this.tabOrder.Controls.Add(this.lblBuyerOrder);
            this.tabOrder.Controls.Add(this.btnLoadOrders);
            this.tabOrder.Controls.Add(this.lblOrderStatus);
            this.tabOrder.Controls.Add(this.lblOrderId);
            this.tabOrder.Controls.Add(this.txtOrderId);
            this.tabOrder.Controls.Add(this.dgvOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 34);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(970, 506);
            this.tabOrder.TabIndex = 2;
            this.tabOrder.Text = "Order";
            this.tabOrder.UseVisualStyleBackColor = true;
            this.tabOrder.Click += new System.EventHandler(this.tabOrder_Click);
            // 
            // pnlAdminOrderLeft
            // 
            this.pnlAdminOrderLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAdminOrderLeft.BackgroundImage")));
            this.pnlAdminOrderLeft.Controls.Add(this.btnFindOrder);
            this.pnlAdminOrderLeft.Controls.Add(this.btnUpdateOrderStatus);
            this.pnlAdminOrderLeft.Controls.Add(this.btnDelOrder);
            this.pnlAdminOrderLeft.Location = new System.Drawing.Point(8, 259);
            this.pnlAdminOrderLeft.Name = "pnlAdminOrderLeft";
            this.pnlAdminOrderLeft.Size = new System.Drawing.Size(225, 239);
            this.pnlAdminOrderLeft.TabIndex = 17;
            this.pnlAdminOrderLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminOrderLeft_Paint);
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindOrder.BackgroundImage")));
            this.btnFindOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindOrder.Location = new System.Drawing.Point(3, 3);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(219, 40);
            this.btnFindOrder.TabIndex = 6;
            this.btnFindOrder.Text = "Find Order";
            this.btnFindOrder.UseVisualStyleBackColor = true;
            this.btnFindOrder.Click += new System.EventHandler(this.btnFindOrder_Click);
            // 
            // btnUpdateOrderStatus
            // 
            this.btnUpdateOrderStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateOrderStatus.BackgroundImage")));
            this.btnUpdateOrderStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateOrderStatus.Location = new System.Drawing.Point(3, 49);
            this.btnUpdateOrderStatus.Name = "btnUpdateOrderStatus";
            this.btnUpdateOrderStatus.Size = new System.Drawing.Size(219, 40);
            this.btnUpdateOrderStatus.TabIndex = 7;
            this.btnUpdateOrderStatus.Text = "Update Order Status";
            this.btnUpdateOrderStatus.UseVisualStyleBackColor = true;
            this.btnUpdateOrderStatus.Click += new System.EventHandler(this.btnUpdateOrderStatus_Click);
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelOrder.BackgroundImage")));
            this.btnDelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelOrder.Location = new System.Drawing.Point(3, 95);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(219, 40);
            this.btnDelOrder.TabIndex = 16;
            this.btnDelOrder.Text = "Delete Order";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            this.btnDelOrder.Click += new System.EventHandler(this.btnDelOrder_Click);
            // 
            // cmbOrderStatus
            // 
            this.cmbOrderStatus.FormattingEnabled = true;
            this.cmbOrderStatus.Items.AddRange(new object[] {
            "Pending",
            "Processing",
            "Shipped",
            "Delivered",
            "Cancelled"});
            this.cmbOrderStatus.Location = new System.Drawing.Point(746, 317);
            this.cmbOrderStatus.Name = "cmbOrderStatus";
            this.cmbOrderStatus.Size = new System.Drawing.Size(193, 33);
            this.cmbOrderStatus.TabIndex = 15;
            this.cmbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cmbOrderStatus_SelectedIndexChanged);
            // 
            // txtSearchOrderId
            // 
            this.txtSearchOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrderId.Location = new System.Drawing.Point(512, 436);
            this.txtSearchOrderId.Name = "txtSearchOrderId";
            this.txtSearchOrderId.Size = new System.Drawing.Size(269, 30);
            this.txtSearchOrderId.TabIndex = 14;
            this.txtSearchOrderId.TextChanged += new System.EventHandler(this.txtSearchOrderId_TextChanged);
            // 
            // lblSearchOrderId
            // 
            this.lblSearchOrderId.AutoSize = true;
            this.lblSearchOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOrderId.Location = new System.Drawing.Point(352, 439);
            this.lblSearchOrderId.Name = "lblSearchOrderId";
            this.lblSearchOrderId.Size = new System.Drawing.Size(154, 25);
            this.lblSearchOrderId.TabIndex = 13;
            this.lblSearchOrderId.Text = "Search Order ID";
            this.lblSearchOrderId.Click += new System.EventHandler(this.lblSearchOrderId_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(746, 376);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(193, 30);
            this.txtOrderDate.TabIndex = 12;
            this.txtOrderDate.TextChanged += new System.EventHandler(this.txtOrderDate_TextChanged);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(632, 383);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(108, 25);
            this.lblOrderDate.TabIndex = 11;
            this.lblOrderDate.Text = "Order Date";
            this.lblOrderDate.Click += new System.EventHandler(this.lblOrderDate_Click);
            // 
            // txtBuyerOrder
            // 
            this.txtBuyerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuyerOrder.Location = new System.Drawing.Point(393, 378);
            this.txtBuyerOrder.Name = "txtBuyerOrder";
            this.txtBuyerOrder.Size = new System.Drawing.Size(203, 30);
            this.txtBuyerOrder.TabIndex = 10;
            this.txtBuyerOrder.TextChanged += new System.EventHandler(this.txtBuyerOrder_TextChanged);
            // 
            // lblBuyerOrder
            // 
            this.lblBuyerOrder.AutoSize = true;
            this.lblBuyerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerOrder.Location = new System.Drawing.Point(236, 381);
            this.lblBuyerOrder.Name = "lblBuyerOrder";
            this.lblBuyerOrder.Size = new System.Drawing.Size(158, 25);
            this.lblBuyerOrder.TabIndex = 9;
            this.lblBuyerOrder.Text = "Buyer Username";
            this.lblBuyerOrder.Click += new System.EventHandler(this.lblBuyerOrder_Click);
            // 
            // btnLoadOrders
            // 
            this.btnLoadOrders.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadOrders.Location = new System.Drawing.Point(433, 255);
            this.btnLoadOrders.Name = "btnLoadOrders";
            this.btnLoadOrders.Size = new System.Drawing.Size(407, 47);
            this.btnLoadOrders.TabIndex = 5;
            this.btnLoadOrders.Text = "Load All Order";
            this.btnLoadOrders.UseVisualStyleBackColor = false;
            this.btnLoadOrders.Click += new System.EventHandler(this.btnLoadOrders_Click);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(617, 320);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(123, 25);
            this.lblOrderStatus.TabIndex = 3;
            this.lblOrderStatus.Text = "Order Status";
            this.lblOrderStatus.Click += new System.EventHandler(this.lblOrderStatus_Click);
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(291, 316);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(86, 25);
            this.lblOrderId.TabIndex = 2;
            this.lblOrderId.Text = "Order ID";
            this.lblOrderId.Click += new System.EventHandler(this.lblOrderId_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Location = new System.Drawing.Point(393, 320);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(203, 30);
            this.txtOrderId.TabIndex = 1;
            this.txtOrderId.TextChanged += new System.EventHandler(this.txtOrderId_TextChanged);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(6, 6);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 62;
            this.dgvOrder.RowTemplate.Height = 28;
            this.dgvOrder.Size = new System.Drawing.Size(958, 246);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentClick);
            // 
            // tabPayments
            // 
            this.tabPayments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPayments.BackgroundImage")));
            this.tabPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPayments.Controls.Add(this.txtSearchPaidOrderId);
            this.tabPayments.Controls.Add(this.lblSearchPaidOrderId);
            this.tabPayments.Controls.Add(this.pnlAdminPaymentLeft);
            this.tabPayments.Controls.Add(this.btnMarkPaid);
            this.tabPayments.Controls.Add(this.txtPayProdId);
            this.tabPayments.Controls.Add(this.lblPaymentId);
            this.tabPayments.Controls.Add(this.btnLoadPayment);
            this.tabPayments.Controls.Add(this.dgvPayment);
            this.tabPayments.Location = new System.Drawing.Point(4, 34);
            this.tabPayments.Name = "tabPayments";
            this.tabPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayments.Size = new System.Drawing.Size(970, 506);
            this.tabPayments.TabIndex = 3;
            this.tabPayments.Text = "Payments";
            this.tabPayments.UseVisualStyleBackColor = true;
            this.tabPayments.Click += new System.EventHandler(this.tabPayments_Click);
            // 
            // txtSearchPaidOrderId
            // 
            this.txtSearchPaidOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPaidOrderId.Location = new System.Drawing.Point(417, 451);
            this.txtSearchPaidOrderId.Name = "txtSearchPaidOrderId";
            this.txtSearchPaidOrderId.Size = new System.Drawing.Size(278, 30);
            this.txtSearchPaidOrderId.TabIndex = 7;
            this.txtSearchPaidOrderId.TextChanged += new System.EventHandler(this.txtSearchPaidOrderId_TextChanged);
            // 
            // lblSearchPaidOrderId
            // 
            this.lblSearchPaidOrderId.AutoSize = true;
            this.lblSearchPaidOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPaidOrderId.Location = new System.Drawing.Point(251, 451);
            this.lblSearchPaidOrderId.Name = "lblSearchPaidOrderId";
            this.lblSearchPaidOrderId.Size = new System.Drawing.Size(154, 25);
            this.lblSearchPaidOrderId.TabIndex = 6;
            this.lblSearchPaidOrderId.Text = "Search Order ID";
            this.lblSearchPaidOrderId.Click += new System.EventHandler(this.lblSearchPaidOrderId_Click);
            // 
            // pnlAdminPaymentLeft
            // 
            this.pnlAdminPaymentLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAdminPaymentLeft.BackgroundImage")));
            this.pnlAdminPaymentLeft.Controls.Add(this.btnSearchByOrderId);
            this.pnlAdminPaymentLeft.Controls.Add(this.btnFindPayment);
            this.pnlAdminPaymentLeft.Location = new System.Drawing.Point(9, 323);
            this.pnlAdminPaymentLeft.Name = "pnlAdminPaymentLeft";
            this.pnlAdminPaymentLeft.Size = new System.Drawing.Size(225, 175);
            this.pnlAdminPaymentLeft.TabIndex = 5;
            this.pnlAdminPaymentLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminPaymentLeft_Paint);
            // 
            // btnSearchByOrderId
            // 
            this.btnSearchByOrderId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchByOrderId.BackgroundImage")));
            this.btnSearchByOrderId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchByOrderId.Location = new System.Drawing.Point(6, 49);
            this.btnSearchByOrderId.Name = "btnSearchByOrderId";
            this.btnSearchByOrderId.Size = new System.Drawing.Size(219, 40);
            this.btnSearchByOrderId.TabIndex = 7;
            this.btnSearchByOrderId.Text = "Find By Order";
            this.btnSearchByOrderId.UseVisualStyleBackColor = true;
            this.btnSearchByOrderId.Click += new System.EventHandler(this.btnSearchByOrderId_Click);
            // 
            // btnFindPayment
            // 
            this.btnFindPayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindPayment.BackgroundImage")));
            this.btnFindPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindPayment.Location = new System.Drawing.Point(3, 3);
            this.btnFindPayment.Name = "btnFindPayment";
            this.btnFindPayment.Size = new System.Drawing.Size(219, 40);
            this.btnFindPayment.TabIndex = 6;
            this.btnFindPayment.Text = "Find Payment";
            this.btnFindPayment.UseVisualStyleBackColor = true;
            this.btnFindPayment.Click += new System.EventHandler(this.btnFindPayment_Click);
            // 
            // btnMarkPaid
            // 
            this.btnMarkPaid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarkPaid.BackgroundImage")));
            this.btnMarkPaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarkPaid.Location = new System.Drawing.Point(718, 399);
            this.btnMarkPaid.Name = "btnMarkPaid";
            this.btnMarkPaid.Size = new System.Drawing.Size(228, 38);
            this.btnMarkPaid.TabIndex = 4;
            this.btnMarkPaid.Text = "Mark Paid";
            this.btnMarkPaid.UseVisualStyleBackColor = true;
            this.btnMarkPaid.Click += new System.EventHandler(this.btnMarkPaid_Click);
            // 
            // txtPayProdId
            // 
            this.txtPayProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayProdId.Location = new System.Drawing.Point(417, 403);
            this.txtPayProdId.Name = "txtPayProdId";
            this.txtPayProdId.Size = new System.Drawing.Size(278, 30);
            this.txtPayProdId.TabIndex = 3;
            this.txtPayProdId.TextChanged += new System.EventHandler(this.txtPayProdId_TextChanged);
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentId.Location = new System.Drawing.Point(267, 408);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(113, 25);
            this.lblPaymentId.TabIndex = 2;
            this.lblPaymentId.Text = "Payment ID";
            this.lblPaymentId.Click += new System.EventHandler(this.lblPaymentId_Click);
            // 
            // btnLoadPayment
            // 
            this.btnLoadPayment.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPayment.Location = new System.Drawing.Point(272, 334);
            this.btnLoadPayment.Name = "btnLoadPayment";
            this.btnLoadPayment.Size = new System.Drawing.Size(448, 54);
            this.btnLoadPayment.TabIndex = 1;
            this.btnLoadPayment.Text = "Load All Payments";
            this.btnLoadPayment.UseVisualStyleBackColor = false;
            this.btnLoadPayment.Click += new System.EventHandler(this.btnLoadPayment_Click);
            // 
            // dgvPayment
            // 
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayment.Location = new System.Drawing.Point(8, 6);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersWidth = 62;
            this.dgvPayment.RowTemplate.Height = 28;
            this.dgvPayment.Size = new System.Drawing.Size(956, 310);
            this.dgvPayment.TabIndex = 0;
            this.dgvPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellContentClick);
            // 
            // tabDiscount
            // 
            this.tabDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDiscount.BackgroundImage")));
            this.tabDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDiscount.Controls.Add(this.lblSearchDiscountCode);
            this.tabDiscount.Controls.Add(this.txtSearchDiscountCode);
            this.tabDiscount.Controls.Add(this.pnlAdminDiscountLeft);
            this.tabDiscount.Controls.Add(this.btnLoadDiscount);
            this.tabDiscount.Controls.Add(this.chkIsActive);
            this.tabDiscount.Controls.Add(this.txtDiscountPercent);
            this.tabDiscount.Controls.Add(this.lblDiscountPercent);
            this.tabDiscount.Controls.Add(this.txtDiscountCode);
            this.tabDiscount.Controls.Add(this.lblDiscountCode);
            this.tabDiscount.Controls.Add(this.dgvDiscount);
            this.tabDiscount.Location = new System.Drawing.Point(4, 34);
            this.tabDiscount.Name = "tabDiscount";
            this.tabDiscount.Size = new System.Drawing.Size(970, 506);
            this.tabDiscount.TabIndex = 4;
            this.tabDiscount.Text = "Discounts";
            this.tabDiscount.UseVisualStyleBackColor = true;
            this.tabDiscount.Click += new System.EventHandler(this.tabDiscount_Click);
            // 
            // lblSearchDiscountCode
            // 
            this.lblSearchDiscountCode.AutoSize = true;
            this.lblSearchDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchDiscountCode.Location = new System.Drawing.Point(315, 399);
            this.lblSearchDiscountCode.Name = "lblSearchDiscountCode";
            this.lblSearchDiscountCode.Size = new System.Drawing.Size(209, 25);
            this.lblSearchDiscountCode.TabIndex = 12;
            this.lblSearchDiscountCode.Text = "Search Discount Code";
            // 
            // txtSearchDiscountCode
            // 
            this.txtSearchDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDiscountCode.Location = new System.Drawing.Point(530, 396);
            this.txtSearchDiscountCode.Name = "txtSearchDiscountCode";
            this.txtSearchDiscountCode.Size = new System.Drawing.Size(236, 30);
            this.txtSearchDiscountCode.TabIndex = 11;
            // 
            // pnlAdminDiscountLeft
            // 
            this.pnlAdminDiscountLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlAdminDiscountLeft.BackgroundImage")));
            this.pnlAdminDiscountLeft.Controls.Add(this.btnFindDiscount);
            this.pnlAdminDiscountLeft.Controls.Add(this.btnUpdateDiscount);
            this.pnlAdminDiscountLeft.Controls.Add(this.btnAddDiscount);
            this.pnlAdminDiscountLeft.Controls.Add(this.btnDeleteDiscount);
            this.pnlAdminDiscountLeft.Location = new System.Drawing.Point(4, 294);
            this.pnlAdminDiscountLeft.Name = "pnlAdminDiscountLeft";
            this.pnlAdminDiscountLeft.Size = new System.Drawing.Size(225, 209);
            this.pnlAdminDiscountLeft.TabIndex = 10;
            this.pnlAdminDiscountLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdminDiscountLeft_Paint);
            // 
            // btnFindDiscount
            // 
            this.btnFindDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindDiscount.BackgroundImage")));
            this.btnFindDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindDiscount.Location = new System.Drawing.Point(0, 50);
            this.btnFindDiscount.Name = "btnFindDiscount";
            this.btnFindDiscount.Size = new System.Drawing.Size(222, 40);
            this.btnFindDiscount.TabIndex = 10;
            this.btnFindDiscount.Text = "Find Discount";
            this.btnFindDiscount.UseVisualStyleBackColor = true;
            this.btnFindDiscount.Click += new System.EventHandler(this.btnFindDiscount_Click);
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateDiscount.BackgroundImage")));
            this.btnUpdateDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateDiscount.Location = new System.Drawing.Point(4, 92);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(219, 40);
            this.btnUpdateDiscount.TabIndex = 8;
            this.btnUpdateDiscount.Text = "Update Discount";
            this.btnUpdateDiscount.UseVisualStyleBackColor = true;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDiscount.BackgroundImage")));
            this.btnAddDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDiscount.Location = new System.Drawing.Point(3, 5);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(219, 40);
            this.btnAddDiscount.TabIndex = 7;
            this.btnAddDiscount.Text = "Add Discount";
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteDiscount.BackgroundImage")));
            this.btnDeleteDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteDiscount.Location = new System.Drawing.Point(4, 138);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(219, 40);
            this.btnDeleteDiscount.TabIndex = 9;
            this.btnDeleteDiscount.Text = "Delete Discount";
            this.btnDeleteDiscount.UseVisualStyleBackColor = true;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnLoadDiscount
            // 
            this.btnLoadDiscount.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadDiscount.Location = new System.Drawing.Point(356, 293);
            this.btnLoadDiscount.Name = "btnLoadDiscount";
            this.btnLoadDiscount.Size = new System.Drawing.Size(372, 46);
            this.btnLoadDiscount.TabIndex = 6;
            this.btnLoadDiscount.Text = "Load Discount";
            this.btnLoadDiscount.UseVisualStyleBackColor = false;
            this.btnLoadDiscount.Click += new System.EventHandler(this.btnLoadDiscount_Click);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.BackColor = System.Drawing.Color.RosyBrown;
            this.chkIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkIsActive.Location = new System.Drawing.Point(433, 443);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(235, 29);
            this.chkIsActive.TabIndex = 5;
            this.chkIsActive.Text = "Is discount code active";
            this.chkIsActive.UseVisualStyleBackColor = false;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercent.Location = new System.Drawing.Point(791, 349);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(159, 30);
            this.txtDiscountPercent.TabIndex = 4;
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.txtDiscountPercent_TextChanged);
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountPercent.Location = new System.Drawing.Point(628, 352);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(160, 25);
            this.lblDiscountPercent.TabIndex = 3;
            this.lblDiscountPercent.Text = "Discount Percent";
            this.lblDiscountPercent.Click += new System.EventHandler(this.lblDiscountPercent_Click);
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountCode.Location = new System.Drawing.Point(392, 351);
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.Size = new System.Drawing.Size(196, 30);
            this.txtDiscountCode.TabIndex = 2;
            this.txtDiscountCode.TextChanged += new System.EventHandler(this.txtDiscountCode_TextChanged);
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountCode.Location = new System.Drawing.Point(245, 356);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(141, 25);
            this.lblDiscountCode.TabIndex = 1;
            this.lblDiscountCode.Text = "Discount Code";
            this.lblDiscountCode.Click += new System.EventHandler(this.lblDiscountCode_Click);
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiscount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscount.Location = new System.Drawing.Point(3, 3);
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.RowHeadersWidth = 62;
            this.dgvDiscount.RowTemplate.Height = 28;
            this.dgvDiscount.Size = new System.Drawing.Size(964, 284);
            this.dgvDiscount.TabIndex = 0;
            this.dgvDiscount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscount_CellContentClick);
            // 
            // tabDelivery
            // 
            this.tabDelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabDelivery.BackgroundImage")));
            this.tabDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDelivery.Controls.Add(this.txtDevlSearchOrderId);
            this.tabDelivery.Controls.Add(this.lblDevlSearchOrderId);
            this.tabDelivery.Controls.Add(this.lblDeliveryCost);
            this.tabDelivery.Controls.Add(this.txtDeliveryCost);
            this.tabDelivery.Controls.Add(this.lblDeliveryStatus);
            this.tabDelivery.Controls.Add(this.cmbDeliveryStatus);
            this.tabDelivery.Controls.Add(this.txtDeliveryAddress);
            this.tabDelivery.Controls.Add(this.lblDeliveryAddress);
            this.tabDelivery.Controls.Add(this.txtDevlOrderId);
            this.tabDelivery.Controls.Add(this.lblDevlOrderId);
            this.tabDelivery.Controls.Add(this.txtDeliveryId);
            this.tabDelivery.Controls.Add(this.lblDeliveryId);
            this.tabDelivery.Controls.Add(this.btnLoadDeliveries);
            this.tabDelivery.Controls.Add(this.panel1);
            this.tabDelivery.Controls.Add(this.dgvDelivery);
            this.tabDelivery.Location = new System.Drawing.Point(4, 34);
            this.tabDelivery.Name = "tabDelivery";
            this.tabDelivery.Size = new System.Drawing.Size(970, 506);
            this.tabDelivery.TabIndex = 6;
            this.tabDelivery.Text = "Deliveries";
            this.tabDelivery.UseVisualStyleBackColor = true;
            this.tabDelivery.Click += new System.EventHandler(this.tabDelivery_Click);
            // 
            // txtDevlSearchOrderId
            // 
            this.txtDevlSearchOrderId.Location = new System.Drawing.Point(485, 429);
            this.txtDevlSearchOrderId.Name = "txtDevlSearchOrderId";
            this.txtDevlSearchOrderId.Size = new System.Drawing.Size(306, 30);
            this.txtDevlSearchOrderId.TabIndex = 14;
            this.txtDevlSearchOrderId.TextChanged += new System.EventHandler(this.txtDevlSearchOrderId_TextChanged);
            // 
            // lblDevlSearchOrderId
            // 
            this.lblDevlSearchOrderId.AutoSize = true;
            this.lblDevlSearchOrderId.Location = new System.Drawing.Point(276, 434);
            this.lblDevlSearchOrderId.Name = "lblDevlSearchOrderId";
            this.lblDevlSearchOrderId.Size = new System.Drawing.Size(182, 25);
            this.lblDevlSearchOrderId.TabIndex = 13;
            this.lblDevlSearchOrderId.Text = "Search By Order ID";
            this.lblDevlSearchOrderId.Click += new System.EventHandler(this.lblDevlSearchOrderId_Click);
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Location = new System.Drawing.Point(663, 363);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(128, 25);
            this.lblDeliveryCost.TabIndex = 12;
            this.lblDeliveryCost.Text = "Delivery Cost";
            this.lblDeliveryCost.Click += new System.EventHandler(this.lblDeliveryCost_Click);
            // 
            // txtDeliveryCost
            // 
            this.txtDeliveryCost.Location = new System.Drawing.Point(785, 358);
            this.txtDeliveryCost.Name = "txtDeliveryCost";
            this.txtDeliveryCost.Size = new System.Drawing.Size(177, 30);
            this.txtDeliveryCost.TabIndex = 11;
            this.txtDeliveryCost.TextChanged += new System.EventHandler(this.txtDeliveryCost_TextChanged);
            // 
            // lblDeliveryStatus
            // 
            this.lblDeliveryStatus.AutoSize = true;
            this.lblDeliveryStatus.Location = new System.Drawing.Point(259, 361);
            this.lblDeliveryStatus.Name = "lblDeliveryStatus";
            this.lblDeliveryStatus.Size = new System.Drawing.Size(143, 25);
            this.lblDeliveryStatus.TabIndex = 10;
            this.lblDeliveryStatus.Text = "Delivery Status";
            this.lblDeliveryStatus.Click += new System.EventHandler(this.lblDeliveryStatus_Click);
            // 
            // cmbDeliveryStatus
            // 
            this.cmbDeliveryStatus.FormattingEnabled = true;
            this.cmbDeliveryStatus.Items.AddRange(new object[] {
            "Pending",
            "Shipping",
            "Delivered"});
            this.cmbDeliveryStatus.Location = new System.Drawing.Point(414, 353);
            this.cmbDeliveryStatus.Name = "cmbDeliveryStatus";
            this.cmbDeliveryStatus.Size = new System.Drawing.Size(200, 33);
            this.cmbDeliveryStatus.TabIndex = 9;
            this.cmbDeliveryStatus.SelectedIndexChanged += new System.EventHandler(this.cmbDeliveryStatus_SelectedIndexChanged);
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(414, 312);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(548, 30);
            this.txtDeliveryAddress.TabIndex = 8;
            this.txtDeliveryAddress.TextChanged += new System.EventHandler(this.txtDeliveryAddress_TextChanged);
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(259, 312);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(160, 25);
            this.lblDeliveryAddress.TabIndex = 7;
            this.lblDeliveryAddress.Text = "Delivery Address";
            this.lblDeliveryAddress.Click += new System.EventHandler(this.lblDeliveryAddress_Click);
            // 
            // txtDevlOrderId
            // 
            this.txtDevlOrderId.Location = new System.Drawing.Point(785, 270);
            this.txtDevlOrderId.Name = "txtDevlOrderId";
            this.txtDevlOrderId.Size = new System.Drawing.Size(177, 30);
            this.txtDevlOrderId.TabIndex = 6;
            this.txtDevlOrderId.TextChanged += new System.EventHandler(this.txtDevlOrderId_TextChanged);
            // 
            // lblDevlOrderId
            // 
            this.lblDevlOrderId.AutoSize = true;
            this.lblDevlOrderId.Location = new System.Drawing.Point(693, 270);
            this.lblDevlOrderId.Name = "lblDevlOrderId";
            this.lblDevlOrderId.Size = new System.Drawing.Size(86, 25);
            this.lblDevlOrderId.TabIndex = 5;
            this.lblDevlOrderId.Text = "Order ID";
            this.lblDevlOrderId.Click += new System.EventHandler(this.lblDevlOrderId_Click);
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Location = new System.Drawing.Point(414, 270);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(200, 30);
            this.txtDeliveryId.TabIndex = 4;
            this.txtDeliveryId.TextChanged += new System.EventHandler(this.txtDeliveryId_TextChanged);
            // 
            // lblDeliveryId
            // 
            this.lblDeliveryId.AutoSize = true;
            this.lblDeliveryId.Location = new System.Drawing.Point(281, 270);
            this.lblDeliveryId.Name = "lblDeliveryId";
            this.lblDeliveryId.Size = new System.Drawing.Size(106, 25);
            this.lblDeliveryId.TabIndex = 3;
            this.lblDeliveryId.Text = "Delivery ID";
            this.lblDeliveryId.Click += new System.EventHandler(this.lblDeliveryId_Click);
            // 
            // btnLoadDeliveries
            // 
            this.btnLoadDeliveries.BackColor = System.Drawing.SystemColors.Info;
            this.btnLoadDeliveries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadDeliveries.Location = new System.Drawing.Point(466, 200);
            this.btnLoadDeliveries.Name = "btnLoadDeliveries";
            this.btnLoadDeliveries.Size = new System.Drawing.Size(313, 51);
            this.btnLoadDeliveries.TabIndex = 1;
            this.btnLoadDeliveries.Text = "Load Deliveries";
            this.btnLoadDeliveries.UseVisualStyleBackColor = false;
            this.btnLoadDeliveries.Click += new System.EventHandler(this.btnLoadDeliveries_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnUpdateStatus);
            this.panel1.Controls.Add(this.btnDevlFindByOrder);
            this.panel1.Controls.Add(this.btnFindDelivery);
            this.panel1.Location = new System.Drawing.Point(9, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 296);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateStatus.BackgroundImage")));
            this.btnUpdateStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateStatus.Location = new System.Drawing.Point(0, 95);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(219, 40);
            this.btnUpdateStatus.TabIndex = 5;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnDevlFindByOrder
            // 
            this.btnDevlFindByOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDevlFindByOrder.BackgroundImage")));
            this.btnDevlFindByOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevlFindByOrder.Location = new System.Drawing.Point(3, 49);
            this.btnDevlFindByOrder.Name = "btnDevlFindByOrder";
            this.btnDevlFindByOrder.Size = new System.Drawing.Size(219, 40);
            this.btnDevlFindByOrder.TabIndex = 4;
            this.btnDevlFindByOrder.Text = "Find By Order";
            this.btnDevlFindByOrder.UseVisualStyleBackColor = true;
            this.btnDevlFindByOrder.Click += new System.EventHandler(this.btnDevlFindByOrder_Click);
            // 
            // btnFindDelivery
            // 
            this.btnFindDelivery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindDelivery.BackgroundImage")));
            this.btnFindDelivery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindDelivery.Location = new System.Drawing.Point(3, 3);
            this.btnFindDelivery.Name = "btnFindDelivery";
            this.btnFindDelivery.Size = new System.Drawing.Size(219, 40);
            this.btnFindDelivery.TabIndex = 3;
            this.btnFindDelivery.Text = "Find Delivery";
            this.btnFindDelivery.UseVisualStyleBackColor = true;
            this.btnFindDelivery.Click += new System.EventHandler(this.btnFindDelivery_Click);
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelivery.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.Location = new System.Drawing.Point(8, 3);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.RowHeadersWidth = 62;
            this.dgvDelivery.RowTemplate.Height = 28;
            this.dgvDelivery.Size = new System.Drawing.Size(959, 193);
            this.dgvDelivery.TabIndex = 0;
            this.dgvDelivery.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDelivery_CellContentClick);
            // 
            // tabExitAdmin
            // 
            this.tabExitAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabExitAdmin.BackgroundImage")));
            this.tabExitAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabExitAdmin.Controls.Add(this.btnAdminNo);
            this.tabExitAdmin.Controls.Add(this.btnAdminYes);
            this.tabExitAdmin.Controls.Add(this.lblAdminLogOut);
            this.tabExitAdmin.Location = new System.Drawing.Point(4, 34);
            this.tabExitAdmin.Name = "tabExitAdmin";
            this.tabExitAdmin.Size = new System.Drawing.Size(970, 506);
            this.tabExitAdmin.TabIndex = 5;
            this.tabExitAdmin.Text = "Exit";
            this.tabExitAdmin.UseVisualStyleBackColor = true;
            this.tabExitAdmin.Click += new System.EventHandler(this.tabExitAdmin_Click);
            // 
            // btnAdminNo
            // 
            this.btnAdminNo.BackColor = System.Drawing.Color.Red;
            this.btnAdminNo.Location = new System.Drawing.Point(695, 151);
            this.btnAdminNo.Name = "btnAdminNo";
            this.btnAdminNo.Size = new System.Drawing.Size(113, 43);
            this.btnAdminNo.TabIndex = 2;
            this.btnAdminNo.Text = "No";
            this.btnAdminNo.UseVisualStyleBackColor = false;
            this.btnAdminNo.Click += new System.EventHandler(this.btnAdminNo_Click);
            // 
            // btnAdminYes
            // 
            this.btnAdminYes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnAdminYes.Location = new System.Drawing.Point(554, 151);
            this.btnAdminYes.Name = "btnAdminYes";
            this.btnAdminYes.Size = new System.Drawing.Size(113, 43);
            this.btnAdminYes.TabIndex = 1;
            this.btnAdminYes.Text = "Yes";
            this.btnAdminYes.UseVisualStyleBackColor = false;
            this.btnAdminYes.Click += new System.EventHandler(this.btnAdminYes_Click);
            // 
            // lblAdminLogOut
            // 
            this.lblAdminLogOut.AutoSize = true;
            this.lblAdminLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminLogOut.Location = new System.Drawing.Point(92, 162);
            this.lblAdminLogOut.Name = "lblAdminLogOut";
            this.lblAdminLogOut.Size = new System.Drawing.Size(416, 32);
            this.lblAdminLogOut.TabIndex = 0;
            this.lblAdminLogOut.Text = "Do you want to log out as admin";
            this.lblAdminLogOut.Click += new System.EventHandler(this.lblAdminLogOut_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.paneltop);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabProducts.ResumeLayout(false);
            this.tabProducts.PerformLayout();
            this.ProductAdminSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            this.pnlAdminOrderLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabPayments.ResumeLayout(false);
            this.tabPayments.PerformLayout();
            this.pnlAdminPaymentLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.tabDiscount.ResumeLayout(false);
            this.tabDiscount.PerformLayout();
            this.pnlAdminDiscountLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscount)).EndInit();
            this.tabDelivery.ResumeLayout(false);
            this.tabDelivery.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.tabExitAdmin.ResumeLayout(false);
            this.tabExitAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lblAdminHead;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.TextBox txtDel_User;
        private System.Windows.Forms.Label lblDel_User;
        private System.Windows.Forms.TextBox txtFind_Uname;
        private System.Windows.Forms.Label lblFind_Uname;
        private System.Windows.Forms.TextBox txtFind_Role;
        private System.Windows.Forms.Label lblFind_Role;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabPayments;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Button btnLoadOrders;
        private System.Windows.Forms.Button btnUpdateOrderStatus;
        private System.Windows.Forms.Button btnFindOrder;
        private System.Windows.Forms.Button btnLoadPayment;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.Button btnMarkPaid;
        private System.Windows.Forms.TextBox txtPayProdId;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TabPage tabDiscount;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.DataGridView dgvDiscount;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnLoadDiscount;
        private System.Windows.Forms.Button btnDeleteDiscount;
        private System.Windows.Forms.Button btnUpdateDiscount;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.TabPage tabExitAdmin;
        private System.Windows.Forms.Label lblAdminLogOut;
        private System.Windows.Forms.Button btnAdminNo;
        private System.Windows.Forms.Button btnAdminYes;
        private System.Windows.Forms.Button btnLoadAllUsers;
        private System.Windows.Forms.Button btnFindRoleGo;
        private System.Windows.Forms.Button btnDelUserGo;
        private System.Windows.Forms.Button btnFindUsernameGo;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.TextBox txtBuyerOrder;
        private System.Windows.Forms.Label lblBuyerOrder;
        private System.Windows.Forms.TextBox txtSearchOrderId;
        private System.Windows.Forms.Label lblSearchOrderId;
        private System.Windows.Forms.ComboBox cmbOrderStatus;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnFindProduct;
        private System.Windows.Forms.Panel ProductAdminSidePanel;
        private System.Windows.Forms.FlowLayoutPanel pnlAdminOrderLeft;
        private System.Windows.Forms.Panel pnlAdminPaymentLeft;
        private System.Windows.Forms.Button btnFindPayment;
        private System.Windows.Forms.Label lblSearchPaidOrderId;
        private System.Windows.Forms.TextBox txtSearchPaidOrderId;
        private System.Windows.Forms.Button btnSearchByOrderId;
        private System.Windows.Forms.Panel pnlAdminDiscountLeft;
        private System.Windows.Forms.Button btnFindDiscount;
        private System.Windows.Forms.TextBox txtSearchDiscountCode;
        private System.Windows.Forms.Label lblSearchDiscountCode;
        private System.Windows.Forms.TabPage tabDelivery;
        private System.Windows.Forms.Button btnLoadDeliveries;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFindDelivery;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.TextBox txtDevlOrderId;
        private System.Windows.Forms.Label lblDevlOrderId;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label lblDeliveryId;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnDevlFindByOrder;
        private System.Windows.Forms.TextBox txtDevlSearchOrderId;
        private System.Windows.Forms.Label lblDevlSearchOrderId;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.TextBox txtDeliveryCost;
        private System.Windows.Forms.Label lblDeliveryStatus;
        private System.Windows.Forms.ComboBox cmbDeliveryStatus;
    }
}