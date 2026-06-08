namespace ClothingApp.UI
{
    partial class BuyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerForm));
            this.pnlHeaderPanel = new System.Windows.Forms.Panel();
            this.lblBuyerHeader = new System.Windows.Forms.Label();
            this.tabBuyer = new System.Windows.Forms.TabControl();
            this.TabBrowseProduct = new System.Windows.Forms.TabPage();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.pnlBrowseSidebar = new System.Windows.Forms.Panel();
            this.btnRefreshBrowse = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtBrowseSearch = new System.Windows.Forms.TextBox();
            this.lblBrowseSearch = new System.Windows.Forms.Label();
            this.dgvBrowse = new System.Windows.Forms.DataGridView();
            this.tabCart = new System.Windows.Forms.TabPage();
            this.btnApplyCodeGo = new System.Windows.Forms.Button();
            this.lblDiscountCode = new System.Windows.Forms.Label();
            this.txtDiscountCode = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlCartSidebar = new System.Windows.Forms.Panel();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.txtSearchOrder = new System.Windows.Forms.TextBox();
            this.lblSearchOrder = new System.Windows.Forms.Label();
            this.pnlOredersSIdebar = new System.Windows.Forms.Panel();
            this.btnRefreshOrders = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.tabCheckOut = new System.Windows.Forms.TabPage();
            this.btnConfirmCheckout = new System.Windows.Forms.Button();
            this.lblDeliveryCost = new System.Windows.Forms.Label();
            this.txtDeliveryCost = new System.Windows.Forms.TextBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblDeliveryMethod = new System.Windows.Forms.Label();
            this.cmbDeliveryMethod = new System.Windows.Forms.ComboBox();
            this.lblDeliveryId = new System.Windows.Forms.Label();
            this.txtDeliveryId = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentId = new System.Windows.Forms.Label();
            this.txtPaymentId = new System.Windows.Forms.TextBox();
            this.txtCheckoutTotal = new System.Windows.Forms.TextBox();
            this.lblCheckoutTotal = new System.Windows.Forms.Label();
            this.txtCurrentOrderId = new System.Windows.Forms.TextBox();
            this.lblCurrentOrderId = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.btnBuyerExitYes = new System.Windows.Forms.Button();
            this.btnBuyerExitNo = new System.Windows.Forms.Button();
            this.pnlHeaderPanel.SuspendLayout();
            this.tabBuyer.SuspendLayout();
            this.TabBrowseProduct.SuspendLayout();
            this.pnlBrowseSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).BeginInit();
            this.tabCart.SuspendLayout();
            this.pnlCartSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.tabOrders.SuspendLayout();
            this.pnlOredersSIdebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.tabCheckOut.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeaderPanel
            // 
            this.pnlHeaderPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.pnlHeaderPanel.Controls.Add(this.lblBuyerHeader);
            this.pnlHeaderPanel.Location = new System.Drawing.Point(-1, -1);
            this.pnlHeaderPanel.Name = "pnlHeaderPanel";
            this.pnlHeaderPanel.Size = new System.Drawing.Size(1028, 113);
            this.pnlHeaderPanel.TabIndex = 0;
            this.pnlHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeaderPanel_Paint);
            // 
            // lblBuyerHeader
            // 
            this.lblBuyerHeader.AutoSize = true;
            this.lblBuyerHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyerHeader.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyerHeader.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBuyerHeader.Location = new System.Drawing.Point(433, 40);
            this.lblBuyerHeader.Name = "lblBuyerHeader";
            this.lblBuyerHeader.Size = new System.Drawing.Size(141, 38);
            this.lblBuyerHeader.TabIndex = 0;
            this.lblBuyerHeader.Text = "Hey Buyer";
            this.lblBuyerHeader.Click += new System.EventHandler(this.lblBuyerHeader_Click);
            // 
            // tabBuyer
            // 
            this.tabBuyer.Controls.Add(this.TabBrowseProduct);
            this.tabBuyer.Controls.Add(this.tabCart);
            this.tabBuyer.Controls.Add(this.tabOrders);
            this.tabBuyer.Controls.Add(this.tabCheckOut);
            this.tabBuyer.Controls.Add(this.tabProfile);
            this.tabBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBuyer.Location = new System.Drawing.Point(-1, 118);
            this.tabBuyer.Name = "tabBuyer";
            this.tabBuyer.SelectedIndex = 0;
            this.tabBuyer.Size = new System.Drawing.Size(1028, 576);
            this.tabBuyer.TabIndex = 1;
            this.tabBuyer.Tag = " ";
            // 
            // TabBrowseProduct
            // 
            this.TabBrowseProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabBrowseProduct.BackgroundImage")));
            this.TabBrowseProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabBrowseProduct.Controls.Add(this.btnAddToCart);
            this.TabBrowseProduct.Controls.Add(this.pnlBrowseSidebar);
            this.TabBrowseProduct.Controls.Add(this.txtBrowseSearch);
            this.TabBrowseProduct.Controls.Add(this.lblBrowseSearch);
            this.TabBrowseProduct.Controls.Add(this.dgvBrowse);
            this.TabBrowseProduct.Location = new System.Drawing.Point(4, 31);
            this.TabBrowseProduct.Name = "TabBrowseProduct";
            this.TabBrowseProduct.Padding = new System.Windows.Forms.Padding(3);
            this.TabBrowseProduct.Size = new System.Drawing.Size(1020, 541);
            this.TabBrowseProduct.TabIndex = 0;
            this.TabBrowseProduct.Text = "Browse Product";
            this.TabBrowseProduct.UseVisualStyleBackColor = true;
            this.TabBrowseProduct.Click += new System.EventHandler(this.TabBrowseProduct_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.SystemColors.Info;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(436, 432);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(298, 59);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // pnlBrowseSidebar
            // 
            this.pnlBrowseSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBrowseSidebar.BackgroundImage")));
            this.pnlBrowseSidebar.Controls.Add(this.btnRefreshBrowse);
            this.pnlBrowseSidebar.Controls.Add(this.btnSearchProduct);
            this.pnlBrowseSidebar.Location = new System.Drawing.Point(10, 321);
            this.pnlBrowseSidebar.Name = "pnlBrowseSidebar";
            this.pnlBrowseSidebar.Size = new System.Drawing.Size(225, 212);
            this.pnlBrowseSidebar.TabIndex = 3;
            this.pnlBrowseSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBrowseSidebar_Paint);
            // 
            // btnRefreshBrowse
            // 
            this.btnRefreshBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshBrowse.BackgroundImage")));
            this.btnRefreshBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBrowse.Location = new System.Drawing.Point(3, 49);
            this.btnRefreshBrowse.Name = "btnRefreshBrowse";
            this.btnRefreshBrowse.Size = new System.Drawing.Size(219, 40);
            this.btnRefreshBrowse.TabIndex = 1;
            this.btnRefreshBrowse.Text = "Refresh Browse";
            this.btnRefreshBrowse.UseVisualStyleBackColor = true;
            this.btnRefreshBrowse.Click += new System.EventHandler(this.btnRefreshBrowse_Click);
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.BackgroundImage")));
            this.btnSearchProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.Location = new System.Drawing.Point(3, 3);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(219, 40);
            this.btnSearchProduct.TabIndex = 0;
            this.btnSearchProduct.Text = "Search Product";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtBrowseSearch
            // 
            this.txtBrowseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrowseSearch.Location = new System.Drawing.Point(534, 373);
            this.txtBrowseSearch.Name = "txtBrowseSearch";
            this.txtBrowseSearch.Size = new System.Drawing.Size(257, 30);
            this.txtBrowseSearch.TabIndex = 2;
            this.txtBrowseSearch.TextChanged += new System.EventHandler(this.txtBrowseSearch_TextChanged);
            // 
            // lblBrowseSearch
            // 
            this.lblBrowseSearch.AutoSize = true;
            this.lblBrowseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowseSearch.Location = new System.Drawing.Point(383, 378);
            this.lblBrowseSearch.Name = "lblBrowseSearch";
            this.lblBrowseSearch.Size = new System.Drawing.Size(145, 25);
            this.lblBrowseSearch.TabIndex = 1;
            this.lblBrowseSearch.Text = "Browse Search";
            this.lblBrowseSearch.Click += new System.EventHandler(this.lblBrowseSearch_Click);
            // 
            // dgvBrowse
            // 
            this.dgvBrowse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrowse.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrowse.Location = new System.Drawing.Point(7, 4);
            this.dgvBrowse.Name = "dgvBrowse";
            this.dgvBrowse.RowHeadersWidth = 62;
            this.dgvBrowse.RowTemplate.Height = 28;
            this.dgvBrowse.Size = new System.Drawing.Size(1006, 311);
            this.dgvBrowse.TabIndex = 0;
            this.dgvBrowse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBrowse_CellContentClick);
            // 
            // tabCart
            // 
            this.tabCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCart.BackgroundImage")));
            this.tabCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCart.Controls.Add(this.btnApplyCodeGo);
            this.tabCart.Controls.Add(this.lblDiscountCode);
            this.tabCart.Controls.Add(this.txtDiscountCode);
            this.tabCart.Controls.Add(this.btnPlaceOrder);
            this.tabCart.Controls.Add(this.txtTotalAmount);
            this.tabCart.Controls.Add(this.txtTotal);
            this.tabCart.Controls.Add(this.lblTotalAmount);
            this.tabCart.Controls.Add(this.lblTotal);
            this.tabCart.Controls.Add(this.pnlCartSidebar);
            this.tabCart.Controls.Add(this.dgvCart);
            this.tabCart.Location = new System.Drawing.Point(4, 31);
            this.tabCart.Name = "tabCart";
            this.tabCart.Padding = new System.Windows.Forms.Padding(3);
            this.tabCart.Size = new System.Drawing.Size(1020, 541);
            this.tabCart.TabIndex = 1;
            this.tabCart.Text = "Cart";
            this.tabCart.UseVisualStyleBackColor = true;
            // 
            // btnApplyCodeGo
            // 
            this.btnApplyCodeGo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnApplyCodeGo.Location = new System.Drawing.Point(792, 360);
            this.btnApplyCodeGo.Name = "btnApplyCodeGo";
            this.btnApplyCodeGo.Size = new System.Drawing.Size(81, 41);
            this.btnApplyCodeGo.TabIndex = 9;
            this.btnApplyCodeGo.Text = "Go";
            this.btnApplyCodeGo.UseVisualStyleBackColor = false;
            this.btnApplyCodeGo.Click += new System.EventHandler(this.btnApplyCodeGo_Click);
            // 
            // lblDiscountCode
            // 
            this.lblDiscountCode.AutoSize = true;
            this.lblDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountCode.Location = new System.Drawing.Point(325, 369);
            this.lblDiscountCode.Name = "lblDiscountCode";
            this.lblDiscountCode.Size = new System.Drawing.Size(192, 25);
            this.lblDiscountCode.TabIndex = 8;
            this.lblDiscountCode.Text = "Enter Discount Code";
            this.lblDiscountCode.Click += new System.EventHandler(this.lblDiscountCode_Click);
            // 
            // txtDiscountCode
            // 
            this.txtDiscountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountCode.Location = new System.Drawing.Point(541, 364);
            this.txtDiscountCode.Name = "txtDiscountCode";
            this.txtDiscountCode.Size = new System.Drawing.Size(225, 30);
            this.txtDiscountCode.TabIndex = 7;
            this.txtDiscountCode.TextChanged += new System.EventHandler(this.txtDiscountCode_TextChanged);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.Info;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(477, 454);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(254, 54);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "PlaceOrder";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(541, 413);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(225, 30);
            this.txtTotalAmount.TabIndex = 5;
            this.txtTotalAmount.TextChanged += new System.EventHandler(this.txtTotalAmount_TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(541, 312);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(225, 30);
            this.txtTotal.TabIndex = 4;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(388, 413);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(129, 25);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(431, 317);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // pnlCartSidebar
            // 
            this.pnlCartSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCartSidebar.BackgroundImage")));
            this.pnlCartSidebar.Controls.Add(this.btnClearCart);
            this.pnlCartSidebar.Controls.Add(this.btnRemoveFromCart);
            this.pnlCartSidebar.Location = new System.Drawing.Point(3, 284);
            this.pnlCartSidebar.Name = "pnlCartSidebar";
            this.pnlCartSidebar.Size = new System.Drawing.Size(226, 251);
            this.pnlCartSidebar.TabIndex = 1;
            this.pnlCartSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCartSidebar_Paint);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearCart.BackgroundImage")));
            this.btnClearCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.Location = new System.Drawing.Point(4, 49);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(219, 40);
            this.btnClearCart.TabIndex = 3;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCart.BackgroundImage")));
            this.btnRemoveFromCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCart.Location = new System.Drawing.Point(3, 3);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(219, 40);
            this.btnRemoveFromCart.TabIndex = 2;
            this.btnRemoveFromCart.Text = "Remove From Cart";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(3, 3);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 62;
            this.dgvCart.RowTemplate.Height = 28;
            this.dgvCart.Size = new System.Drawing.Size(1014, 279);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellContentClick);
            // 
            // tabOrders
            // 
            this.tabOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabOrders.BackgroundImage")));
            this.tabOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabOrders.Controls.Add(this.btnSearchOrder);
            this.tabOrders.Controls.Add(this.txtSearchOrder);
            this.tabOrders.Controls.Add(this.lblSearchOrder);
            this.tabOrders.Controls.Add(this.pnlOredersSIdebar);
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 31);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(1020, 541);
            this.tabOrders.TabIndex = 2;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            this.tabOrders.Click += new System.EventHandler(this.tabOrders_Click);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchOrder.Location = new System.Drawing.Point(452, 452);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(308, 46);
            this.btnSearchOrder.TabIndex = 4;
            this.btnSearchOrder.Text = "Search Order";
            this.btnSearchOrder.UseVisualStyleBackColor = false;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchOrder.Location = new System.Drawing.Point(551, 399);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.Size = new System.Drawing.Size(232, 30);
            this.txtSearchOrder.TabIndex = 3;
            this.txtSearchOrder.TextChanged += new System.EventHandler(this.txtSearchOrder_TextChanged);
            // 
            // lblSearchOrder
            // 
            this.lblSearchOrder.AutoSize = true;
            this.lblSearchOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchOrder.Location = new System.Drawing.Point(381, 399);
            this.lblSearchOrder.Name = "lblSearchOrder";
            this.lblSearchOrder.Size = new System.Drawing.Size(130, 25);
            this.lblSearchOrder.TabIndex = 2;
            this.lblSearchOrder.Text = "Search Order";
            this.lblSearchOrder.Click += new System.EventHandler(this.lblSearchOrder_Click);
            // 
            // pnlOredersSIdebar
            // 
            this.pnlOredersSIdebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOredersSIdebar.BackgroundImage")));
            this.pnlOredersSIdebar.Controls.Add(this.btnRefreshOrders);
            this.pnlOredersSIdebar.Location = new System.Drawing.Point(4, 351);
            this.pnlOredersSIdebar.Name = "pnlOredersSIdebar";
            this.pnlOredersSIdebar.Size = new System.Drawing.Size(226, 187);
            this.pnlOredersSIdebar.TabIndex = 1;
            this.pnlOredersSIdebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOredersSIdebar_Paint);
            // 
            // btnRefreshOrders
            // 
            this.btnRefreshOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshOrders.BackgroundImage")));
            this.btnRefreshOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshOrders.Location = new System.Drawing.Point(4, 3);
            this.btnRefreshOrders.Name = "btnRefreshOrders";
            this.btnRefreshOrders.Size = new System.Drawing.Size(219, 40);
            this.btnRefreshOrders.TabIndex = 0;
            this.btnRefreshOrders.Text = "Refresh Orders";
            this.btnRefreshOrders.UseVisualStyleBackColor = true;
            this.btnRefreshOrders.Click += new System.EventHandler(this.btnRefreshOrders_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(3, 3);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 28;
            this.dgvOrders.Size = new System.Drawing.Size(1010, 342);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // tabCheckOut
            // 
            this.tabCheckOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCheckOut.BackgroundImage")));
            this.tabCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCheckOut.Controls.Add(this.btnConfirmCheckout);
            this.tabCheckOut.Controls.Add(this.lblDeliveryCost);
            this.tabCheckOut.Controls.Add(this.txtDeliveryCost);
            this.tabCheckOut.Controls.Add(this.txtDeliveryAddress);
            this.tabCheckOut.Controls.Add(this.lblDeliveryAddress);
            this.tabCheckOut.Controls.Add(this.lblDeliveryMethod);
            this.tabCheckOut.Controls.Add(this.cmbDeliveryMethod);
            this.tabCheckOut.Controls.Add(this.lblDeliveryId);
            this.tabCheckOut.Controls.Add(this.txtDeliveryId);
            this.tabCheckOut.Controls.Add(this.lblPaymentMethod);
            this.tabCheckOut.Controls.Add(this.cmbPaymentMethod);
            this.tabCheckOut.Controls.Add(this.lblPaymentId);
            this.tabCheckOut.Controls.Add(this.txtPaymentId);
            this.tabCheckOut.Controls.Add(this.txtCheckoutTotal);
            this.tabCheckOut.Controls.Add(this.lblCheckoutTotal);
            this.tabCheckOut.Controls.Add(this.txtCurrentOrderId);
            this.tabCheckOut.Controls.Add(this.lblCurrentOrderId);
            this.tabCheckOut.Location = new System.Drawing.Point(4, 31);
            this.tabCheckOut.Name = "tabCheckOut";
            this.tabCheckOut.Size = new System.Drawing.Size(1020, 541);
            this.tabCheckOut.TabIndex = 3;
            this.tabCheckOut.Text = "Check Out";
            this.tabCheckOut.UseVisualStyleBackColor = true;
            this.tabCheckOut.Click += new System.EventHandler(this.tabCheckOut_Click);
            // 
            // btnConfirmCheckout
            // 
            this.btnConfirmCheckout.BackColor = System.Drawing.SystemColors.Info;
            this.btnConfirmCheckout.Location = new System.Drawing.Point(364, 424);
            this.btnConfirmCheckout.Name = "btnConfirmCheckout";
            this.btnConfirmCheckout.Size = new System.Drawing.Size(346, 56);
            this.btnConfirmCheckout.TabIndex = 16;
            this.btnConfirmCheckout.Text = "Confirm Checkout";
            this.btnConfirmCheckout.UseVisualStyleBackColor = false;
            this.btnConfirmCheckout.Click += new System.EventHandler(this.btnConfirmCheckout_Click);
            // 
            // lblDeliveryCost
            // 
            this.lblDeliveryCost.AutoSize = true;
            this.lblDeliveryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryCost.Location = new System.Drawing.Point(49, 324);
            this.lblDeliveryCost.Name = "lblDeliveryCost";
            this.lblDeliveryCost.Size = new System.Drawing.Size(128, 25);
            this.lblDeliveryCost.TabIndex = 15;
            this.lblDeliveryCost.Text = "Delivery Cost";
            this.lblDeliveryCost.Click += new System.EventHandler(this.lblDeliveryCost_Click);
            // 
            // txtDeliveryCost
            // 
            this.txtDeliveryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryCost.Location = new System.Drawing.Point(196, 319);
            this.txtDeliveryCost.Name = "txtDeliveryCost";
            this.txtDeliveryCost.Size = new System.Drawing.Size(244, 30);
            this.txtDeliveryCost.TabIndex = 14;
            this.txtDeliveryCost.TextChanged += new System.EventHandler(this.txtDeliveryCost_TextChanged);
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(186, 245);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(817, 30);
            this.txtDeliveryAddress.TabIndex = 13;
            this.txtDeliveryAddress.TextChanged += new System.EventHandler(this.txtDeliveryAddress_TextChanged);
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.Location = new System.Drawing.Point(20, 248);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(160, 25);
            this.lblDeliveryAddress.TabIndex = 12;
            this.lblDeliveryAddress.Text = "Delivery Address";
            this.lblDeliveryAddress.Click += new System.EventHandler(this.lblDeliveryAddress_Click);
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.AutoSize = true;
            this.lblDeliveryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryMethod.Location = new System.Drawing.Point(557, 173);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.lblDeliveryMethod.Size = new System.Drawing.Size(153, 25);
            this.lblDeliveryMethod.TabIndex = 11;
            this.lblDeliveryMethod.Text = "Delivery Method";
            this.lblDeliveryMethod.Click += new System.EventHandler(this.lblDeliveryMethod_Click);
            // 
            // cmbDeliveryMethod
            // 
            this.cmbDeliveryMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeliveryMethod.FormattingEnabled = true;
            this.cmbDeliveryMethod.Items.AddRange(new object[] {
            "Pickup",
            "HomeDelivery"});
            this.cmbDeliveryMethod.Location = new System.Drawing.Point(725, 168);
            this.cmbDeliveryMethod.Name = "cmbDeliveryMethod";
            this.cmbDeliveryMethod.Size = new System.Drawing.Size(244, 33);
            this.cmbDeliveryMethod.TabIndex = 10;
            this.cmbDeliveryMethod.SelectedIndexChanged += new System.EventHandler(this.cmbDeliveryMethod_SelectedIndexChanged);
            // 
            // lblDeliveryId
            // 
            this.lblDeliveryId.AutoSize = true;
            this.lblDeliveryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryId.Location = new System.Drawing.Point(56, 166);
            this.lblDeliveryId.Name = "lblDeliveryId";
            this.lblDeliveryId.Size = new System.Drawing.Size(106, 25);
            this.lblDeliveryId.TabIndex = 9;
            this.lblDeliveryId.Text = "Delivery ID";
            this.lblDeliveryId.Click += new System.EventHandler(this.lblDeliveryId_Click);
            // 
            // txtDeliveryId
            // 
            this.txtDeliveryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryId.Location = new System.Drawing.Point(196, 166);
            this.txtDeliveryId.Name = "txtDeliveryId";
            this.txtDeliveryId.Size = new System.Drawing.Size(244, 30);
            this.txtDeliveryId.TabIndex = 8;
            this.txtDeliveryId.TextChanged += new System.EventHandler(this.txtDeliveryId_TextChanged);
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(557, 101);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(160, 25);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Payment Method";
            this.lblPaymentMethod.Click += new System.EventHandler(this.lblPaymentMethod_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Online"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(725, 96);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(244, 33);
            this.cmbPaymentMethod.TabIndex = 6;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // lblPaymentId
            // 
            this.lblPaymentId.AutoSize = true;
            this.lblPaymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentId.Location = new System.Drawing.Point(49, 101);
            this.lblPaymentId.Name = "lblPaymentId";
            this.lblPaymentId.Size = new System.Drawing.Size(113, 25);
            this.lblPaymentId.TabIndex = 5;
            this.lblPaymentId.Text = "Payment ID";
            this.lblPaymentId.Click += new System.EventHandler(this.lblPaymentId_Click);
            // 
            // txtPaymentId
            // 
            this.txtPaymentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentId.Location = new System.Drawing.Point(196, 96);
            this.txtPaymentId.Name = "txtPaymentId";
            this.txtPaymentId.Size = new System.Drawing.Size(244, 30);
            this.txtPaymentId.TabIndex = 4;
            this.txtPaymentId.TextChanged += new System.EventHandler(this.txtPaymentId_TextChanged);
            // 
            // txtCheckoutTotal
            // 
            this.txtCheckoutTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckoutTotal.Location = new System.Drawing.Point(725, 37);
            this.txtCheckoutTotal.Name = "txtCheckoutTotal";
            this.txtCheckoutTotal.Size = new System.Drawing.Size(244, 30);
            this.txtCheckoutTotal.TabIndex = 3;
            this.txtCheckoutTotal.TextChanged += new System.EventHandler(this.txtCheckoutTotal_TextChanged);
            // 
            // lblCheckoutTotal
            // 
            this.lblCheckoutTotal.AutoSize = true;
            this.lblCheckoutTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckoutTotal.Location = new System.Drawing.Point(557, 42);
            this.lblCheckoutTotal.Name = "lblCheckoutTotal";
            this.lblCheckoutTotal.Size = new System.Drawing.Size(145, 25);
            this.lblCheckoutTotal.TabIndex = 2;
            this.lblCheckoutTotal.Text = "Checkout Total";
            this.lblCheckoutTotal.Click += new System.EventHandler(this.lblCheckoutTotal_Click);
            // 
            // txtCurrentOrderId
            // 
            this.txtCurrentOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentOrderId.Location = new System.Drawing.Point(196, 37);
            this.txtCurrentOrderId.Name = "txtCurrentOrderId";
            this.txtCurrentOrderId.Size = new System.Drawing.Size(244, 30);
            this.txtCurrentOrderId.TabIndex = 1;
            this.txtCurrentOrderId.TextChanged += new System.EventHandler(this.txtCurrentOrderId_TextChanged);
            // 
            // lblCurrentOrderId
            // 
            this.lblCurrentOrderId.AutoSize = true;
            this.lblCurrentOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentOrderId.Location = new System.Drawing.Point(34, 42);
            this.lblCurrentOrderId.Name = "lblCurrentOrderId";
            this.lblCurrentOrderId.Size = new System.Drawing.Size(156, 25);
            this.lblCurrentOrderId.TabIndex = 0;
            this.lblCurrentOrderId.Text = "Current Order ID";
            this.lblCurrentOrderId.Click += new System.EventHandler(this.lblCurrentOrderId_Click);
            // 
            // tabProfile
            // 
            this.tabProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabProfile.BackgroundImage")));
            this.tabProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabProfile.Controls.Add(this.btnBuyerExitNo);
            this.tabProfile.Controls.Add(this.btnBuyerExitYes);
            this.tabProfile.Controls.Add(this.lblExit);
            this.tabProfile.Controls.Add(this.btnUpdateProfile);
            this.tabProfile.Controls.Add(this.txtAddress);
            this.tabProfile.Controls.Add(this.lblAddress);
            this.tabProfile.Controls.Add(this.txtConfirmPassword);
            this.tabProfile.Controls.Add(this.lblConfirmPassword);
            this.tabProfile.Controls.Add(this.txtNewPassword);
            this.tabProfile.Controls.Add(this.lblNewPassword);
            this.tabProfile.Controls.Add(this.txtPhoneNumber);
            this.tabProfile.Controls.Add(this.lblPhoneNumber);
            this.tabProfile.Controls.Add(this.txtUsername);
            this.tabProfile.Controls.Add(this.lblUsername);
            this.tabProfile.Location = new System.Drawing.Point(4, 31);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Size = new System.Drawing.Size(1020, 541);
            this.tabProfile.TabIndex = 4;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            this.tabProfile.Click += new System.EventHandler(this.tabProfile_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.Location = new System.Drawing.Point(347, 315);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(336, 69);
            this.btnUpdateProfile.TabIndex = 10;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(130, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(883, 30);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(24, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 25);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(740, 108);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(221, 30);
            this.txtConfirmPassword.TabIndex = 7;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(547, 111);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(171, 25);
            this.lblConfirmPassword.TabIndex = 6;
            this.lblConfirmPassword.Text = "Confirm Password";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.Location = new System.Drawing.Point(201, 108);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(221, 30);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(54, 108);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(142, 25);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New Password";
            this.lblNewPassword.Click += new System.EventHandler(this.lblNewPassword_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(740, 44);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(221, 30);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(575, 49);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(143, 25);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(201, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 30);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(73, 44);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(257, 436);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(213, 29);
            this.lblExit.TabIndex = 11;
            this.lblExit.Text = "Do you want to exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // btnBuyerExitYes
            // 
            this.btnBuyerExitYes.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBuyerExitYes.Location = new System.Drawing.Point(495, 434);
            this.btnBuyerExitYes.Name = "btnBuyerExitYes";
            this.btnBuyerExitYes.Size = new System.Drawing.Size(101, 42);
            this.btnBuyerExitYes.TabIndex = 12;
            this.btnBuyerExitYes.Text = "Yes";
            this.btnBuyerExitYes.UseVisualStyleBackColor = false;
            this.btnBuyerExitYes.Click += new System.EventHandler(this.btnBuyerExitYes_Click);
            // 
            // btnBuyerExitNo
            // 
            this.btnBuyerExitNo.BackColor = System.Drawing.Color.Red;
            this.btnBuyerExitNo.Location = new System.Drawing.Point(617, 436);
            this.btnBuyerExitNo.Name = "btnBuyerExitNo";
            this.btnBuyerExitNo.Size = new System.Drawing.Size(101, 42);
            this.btnBuyerExitNo.TabIndex = 13;
            this.btnBuyerExitNo.Text = "No";
            this.btnBuyerExitNo.UseVisualStyleBackColor = false;
            this.btnBuyerExitNo.Click += new System.EventHandler(this.btnBuyerExitNo_Click);
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 694);
            this.Controls.Add(this.tabBuyer);
            this.Controls.Add(this.pnlHeaderPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 750);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.Load += new System.EventHandler(this.BuyerForm_Load);
            this.pnlHeaderPanel.ResumeLayout(false);
            this.pnlHeaderPanel.PerformLayout();
            this.tabBuyer.ResumeLayout(false);
            this.TabBrowseProduct.ResumeLayout(false);
            this.TabBrowseProduct.PerformLayout();
            this.pnlBrowseSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowse)).EndInit();
            this.tabCart.ResumeLayout(false);
            this.tabCart.PerformLayout();
            this.pnlCartSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.tabOrders.ResumeLayout(false);
            this.tabOrders.PerformLayout();
            this.pnlOredersSIdebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.tabCheckOut.ResumeLayout(false);
            this.tabCheckOut.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.tabProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderPanel;
        private System.Windows.Forms.Label lblBuyerHeader;
        private System.Windows.Forms.TabControl tabBuyer;
        private System.Windows.Forms.TabPage TabBrowseProduct;
        private System.Windows.Forms.TabPage tabCart;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabCheckOut;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.DataGridView dgvBrowse;
        private System.Windows.Forms.Panel pnlBrowseSidebar;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtBrowseSearch;
        private System.Windows.Forms.Label lblBrowseSearch;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRefreshBrowse;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlCartSidebar;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlOredersSIdebar;
        private System.Windows.Forms.Button btnRefreshOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.TextBox txtSearchOrder;
        private System.Windows.Forms.Label lblSearchOrder;
        private System.Windows.Forms.Label lblCurrentOrderId;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentId;
        private System.Windows.Forms.TextBox txtPaymentId;
        private System.Windows.Forms.TextBox txtCheckoutTotal;
        private System.Windows.Forms.Label lblCheckoutTotal;
        private System.Windows.Forms.TextBox txtCurrentOrderId;
        private System.Windows.Forms.ComboBox cmbDeliveryMethod;
        private System.Windows.Forms.Label lblDeliveryId;
        private System.Windows.Forms.TextBox txtDeliveryId;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Button btnConfirmCheckout;
        private System.Windows.Forms.Label lblDeliveryCost;
        private System.Windows.Forms.TextBox txtDeliveryCost;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryMethod;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnApplyCodeGo;
        private System.Windows.Forms.Label lblDiscountCode;
        private System.Windows.Forms.TextBox txtDiscountCode;
        private System.Windows.Forms.Button btnBuyerExitNo;
        private System.Windows.Forms.Button btnBuyerExitYes;
        private System.Windows.Forms.Label lblExit;
    }
}