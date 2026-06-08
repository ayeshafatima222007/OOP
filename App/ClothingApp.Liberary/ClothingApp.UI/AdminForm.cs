using ClothingApp.Library.BL;
using ClothingApp.Library.DL;
using ClothingApp.Library.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClothingApp.UI
{
    public partial class Admin_Form : Form
    {
        private AdminBL currentAdmin;

        public Admin_Form(AdminBL admin)
        {

            InitializeComponent();
            currentAdmin = admin;
        }
        private void Admin_Form_Load(object sender, EventArgs e)
        {

            try
            {
                LoadAllUsers();
                LoadAllProducts();
                LoadAllOrders();
                LoadAllPayments();
                LoadAllDiscounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Error");
            }
        }

        private void lblAdminHead_Click(object sender, EventArgs e) { }




        //----------------------------User Panel-----------------------------

        private void tabUsers_Click(object sender, EventArgs e) { }
        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                txtFind_Uname.Text = row.Cells["Username"].Value.ToString();
                txtDel_User.Text = row.Cells["Username"].Value.ToString();
                txtFind_Role.Text = row.Cells["Role"].Value.ToString();
            }

        }

        private void btnLoadAllUsers_Click(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void lblFind_Role_Click(object sender, EventArgs e) { }
      
        private void txtFind_Role_TextChanged(object sender, EventArgs e) { }


        private void btnFindRoleGo_Click(object sender, EventArgs e)
        {
            string role = txtFind_Role.Text.Trim();

            if (role != "Buyer" && role != "Seller" && role != "Admin")
            {
                MessageBox.Show("Role must be Buyer, Seller, or Admin.");
                return;
            }

            UserDL userDL = new UserDL();
            List<UserBL> users = userDL.FindByRole(role);
            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Role");

            foreach (UserBL u in users)
                dt.Rows.Add(u.getUsername(), u.getPhoneNumber(), u.getRole());

            dgvUser.DataSource = dt;

            if (users.Count == 0)
                MessageBox.Show("No users found with role: " + role);
        }

        private void lblFind_Uname_Click(object sender, EventArgs e) { }
        private void txtFind_Uname_TextChanged(object sender, EventArgs e) { }

        private void btnFindUsernameGo_Click(object sender, EventArgs e)
        {
            string username = txtFind_Uname.Text.Trim();

            if (!Validation.IsValidUsername(username))
            {
                MessageBox.Show("Invalid username format.");
                return;
            }

            UserDL userDL = new UserDL();
            UserBL user = userDL.FindByUsername(username);
            DataTable dt = new DataTable();
            dt.Columns.Add("Username"); dt.Columns.Add("Phone"); dt.Columns.Add("Role");
            if (user != null)
                dt.Rows.Add(user.getUsername(), user.getPhoneNumber(), user.getRole());
            dgvUser.DataSource = dt;

            if (user == null)
                MessageBox.Show("User not found.", "Info");
        }

        private void lblDel_User_Click(object sender, EventArgs e) { }
        
        private void txtDel_User_TextChanged(object sender, EventArgs e) { }


        private void btnDelUserGo_Click(object sender, EventArgs e)
        {
            string username = txtDel_User.Text.Trim();

            if (!Validation.IsValidUsername(username))
            {
                MessageBox.Show("Invalid username.");
                return;
            }

            // prevent admin from deleting themselves
            if (username == currentAdmin.getUsername())
            {
                MessageBox.Show("You cannot delete your own account.");
                return;
            }

            if (MessageBox.Show("Remove user: " + username + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserDL userDL = new UserDL();
                bool success = userDL.RemoveUser(username);
                MessageBox.Show(success ? "User removed." : "User not found.");
                if (success) { txtDel_User.Clear(); LoadAllUsers(); }
            }
        }

        private void LoadAllUsers()          //Helper Function
        {
            UserDL userDL = new UserDL();
            List<UserBL> users = userDL.FindByRole("Buyer");
            users.AddRange(userDL.FindByRole("Seller"));
            users.AddRange(userDL.FindByRole("Admin"));

            DataTable dt = new DataTable();
            dt.Columns.Add("Username");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Role");

            foreach (UserBL u in users)
                dt.Rows.Add(u.getUsername(), u.getPhoneNumber(), u.getRole());

            dgvUser.DataSource = dt;
        }
 
       
 


        //---------------------------Product Panel-----------------------------
        private void tabProducts_Click(object sender, EventArgs e) { }

        private void ProductAdminSidePanel_Paint(object sender, PaintEventArgs e) { }
     

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["ProductId"].Value.ToString();
                txtCategory.Text = row.Cells["Category"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtColor.Text = row.Cells["Color"].Value.ToString();
                txtSize.Text = row.Cells["Size"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtQty.Text = row.Cells["Quantity"].Value.ToString();

            }
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void lblCategory_Click(object sender, EventArgs e) { }
       
        private void txtCategory_TextChanged(object sender, EventArgs e) { }

        private void lblName_Click(object sender, EventArgs e) { }

        private void txtName_TextChanged(object sender, EventArgs e) { }

        private void lblColor_Click(object sender, EventArgs e) { }

        private void txtColor_TextChanged(object sender, EventArgs e) { }

        private void lblSize_Click(object sender, EventArgs e) { }

        private void txtSize_TextChanged(object sender, EventArgs e) { }

        private void lblPrice_Click(object sender, EventArgs e) { }

        private void txtPrice_TextChanged(object sender, EventArgs e) { }

        private void lblQty_Click(object sender, EventArgs e) { }

        private void txtQty_TextChanged(object sender, EventArgs e) { }

        private void lblProductId_Click(object sender, EventArgs e) { }

        private void txtProductId_TextChanged(object sender, EventArgs e) { }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();
            string category = txtCategory.Text.Trim();
            string name = txtName.Text.Trim();
            string color = txtColor.Text.Trim();
            string size = txtSize.Text.Trim();

            double price;
            int qty;

            if (!Validation.IsValidProductId(id))
            {
                MessageBox.Show("Invalid Product ID.");
                return;
            }

            if (!Validation.IsValidCategory(category))
            {
                MessageBox.Show("Invalid Category.");
                return;
            }

            if (!Validation.IsValidName(name))
            {
                MessageBox.Show("Invalid Name.");
                return;
            }

            if (!Validation.IsValidColor(color))
            {
                MessageBox.Show("Invalid Color.");
                return;
            }

            if (!Validation.IsValidSize(size))
            {
                MessageBox.Show("Invalid Size (S, M, L only).");
                return;
            }

            if (!double.TryParse(txtPrice.Text.Trim(), out price) || !Validation.IsValidPrice(price))
            {
                MessageBox.Show("Invalid Price.");
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out qty) || !Validation.IsValidQuantity(qty))
            {
                MessageBox.Show("Invalid Quantity.");
                return;
            }

            ProductBL p = new ProductBL(txtProductId.Text.Trim(), txtCategory.Text.Trim(),txtName.Text.Trim(), txtColor.Text.Trim(), txtSize.Text.Trim(), price, qty);
            bool success = ProductDL.AddProduct(p);
            MessageBox.Show(success ? "Product added!" : "Failed. Check inputs or ID already exists.");
            if (success) 
            {
                ClearProductFields();
                LoadAllProducts();
            }
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();

            if (!Validation.IsValidProductId(id))
            {
                MessageBox.Show("Enter a valid Product ID.");
                return;
            }

            ProductBL found = ProductDL.FindProduct(id);

            if (found == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            // Populate fields
            txtProductId.Text = found.getProductId();
            txtCategory.Text = found.getCategory();
            txtName.Text = found.getName();
            txtColor.Text = found.getColor();
            txtSize.Text = found.getSize();
            txtPrice.Text = found.getPrice().ToString();
            txtQty.Text = found.getQuantity().ToString();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

            string id = txtProductId.Text.Trim();
            string category = txtCategory.Text.Trim();
            string name = txtName.Text.Trim();
            string color = txtColor.Text.Trim();
            string size = txtSize.Text.Trim();

            double price;
            int qty;

            if (!Validation.IsValidProductId(id))
            {
                MessageBox.Show("Invalid Product ID.");
                return;
            }

            if (!Validation.IsValidCategory(category))
            {
                MessageBox.Show("Invalid Category.");
                return;
            }

            if (!Validation.IsValidName(name))
            {
                MessageBox.Show("Invalid Name.");
                return;
            }

            if (!Validation.IsValidColor(color))
            {
                MessageBox.Show("Invalid Color.");
                return;
            }

            if (!Validation.IsValidSize(size))
            {
                MessageBox.Show("Invalid Size (S, M, L only).");
                return;
            }

            if (!double.TryParse(txtPrice.Text.Trim(), out price) || !Validation.IsValidPrice(price))
            {
                MessageBox.Show("Invalid Price.");
                return;
            }

            if (!int.TryParse(txtQty.Text.Trim(), out qty) || !Validation.IsValidQuantity(qty))
            {
                MessageBox.Show("Invalid Quantity.");
                return;
            }
 
            ProductBL p = new ProductBL(id, txtCategory.Text.Trim(), txtName.Text.Trim(),txtColor.Text.Trim(), txtSize.Text.Trim(), price, qty);
            bool success = ProductDL.UpdateProduct(id, p);
            MessageBox.Show(success ? "Product updated!" : "Update failed.");
            if (success) 
            {
                ClearProductFields(); 
                LoadAllProducts(); 
            }
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {

            string id = txtProductId.Text.Trim();
             
            if (!Validation.IsValidProductId(id))
            {
                MessageBox.Show("Invalid Product ID.");
                return;
            }
            if (MessageBox.Show("Delete product: " + id + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool success = ProductDL.RemoveProduct(id);
                MessageBox.Show(success ? "Product deleted." : "Product not found.");
                if (success) 
                {
                    ClearProductFields(); 
                    LoadAllProducts(); 
                }
            }
        }

        private void LoadAllProducts()           //helper function
        {
            List<ProductBL> products = ProductDL.GetAllProducts();
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId"); dt.Columns.Add("Category"); dt.Columns.Add("Name");
            dt.Columns.Add("Color"); dt.Columns.Add("Size"); dt.Columns.Add("Price"); dt.Columns.Add("Quantity");
            foreach (ProductBL p in products)
                dt.Rows.Add(p.getProductId(), p.getCategory(), p.getName(), p.getColor(), p.getSize(), p.getPrice(), p.getQuantity());
            dgvProduct.DataSource = dt;
        }

        private void ClearProductFields()          //helper function
        {
            txtProductId.Clear(); txtCategory.Clear(); txtName.Clear();
            txtColor.Clear(); txtSize.Clear(); txtPrice.Clear(); txtQty.Clear();
        }

        //-----------------------------Order Panel--------------------------

        private void pnlAdminOrderLeft_Paint(object sender, PaintEventArgs e) { }
        private void tabOrder_Click(object sender, EventArgs e)
        {

            txtOrderId.ReadOnly = true;
            txtOrderDate.ReadOnly = true;
            txtBuyerOrder.ReadOnly = true;
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
                txtOrderId.Text = row.Cells["OrderId"].Value.ToString();
                txtBuyerOrder.Text = row.Cells["BuyerUsername"].Value.ToString();
                cmbOrderStatus.Text = row.Cells["Status"].Value.ToString();
                txtOrderDate.Text = row.Cells["OrderDate"].Value.ToString();
            }
        }

        private void btnLoadOrders_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
        } 

        private void lblOrderId_Click(object sender, EventArgs e) { }
        
        private void txtOrderId_TextChanged(object sender, EventArgs e) { }
      
        private void lblOrderStatus_Click(object sender, EventArgs e) { }

        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = cmbOrderStatus.Text.Trim();
            if (!Validation.IsValidOrderStatus(status))
            {
                MessageBox.Show("Invalid status selected.");
                cmbOrderStatus.SelectedIndex = -1;   // reset it
                return;
            }
        }

        private void lblBuyerOrder_Click(object sender, EventArgs e) { }

        private void txtBuyerOrder_TextChanged(object sender, EventArgs e) { }

        private void lblOrderDate_Click(object sender, EventArgs e) { }


        private void txtOrderDate_TextChanged(object sender, EventArgs e) { }

        private void lblSearchOrderId_Click(object sender, EventArgs e) { }
        private void txtSearchOrderId_TextChanged(object sender, EventArgs e) { }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            string id = txtSearchOrderId.Text.Trim();
            if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("Enter an Order ID to search."); return; }

            OrderBL found = OrderDL.FindOrder(id);
            if (found == null) { MessageBox.Show("Order not found."); return; }

            txtOrderId.Text = found.getOrderId();
            txtBuyerOrder.Text = found.getBuyer().getUsername();
            cmbOrderStatus.Text = found.getStatus();
            txtOrderDate.Text = found.getOrderDate().ToString();
            txtSearchOrderId.Clear();
        }

        private void btnUpdateOrderStatus_Click(object sender, EventArgs e)
        {

            string id = txtOrderId.Text.Trim();
            string newStatus = cmbOrderStatus.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(newStatus))
            {
                MessageBox.Show("Select an order and status first.");
                return;
            }

            bool success = OrderDL.UpdateStatus(id, newStatus);
            MessageBox.Show(success ? "Status updated!" : "Update failed.");
            if (success) 
            {
                ClearOrderFields(); 
                LoadAllOrders();
            }
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            string id = txtOrderId.Text.Trim();
            if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("Select an order."); return; }

            if (MessageBox.Show("Delete order: " + id + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool success = OrderDL.RemoveOrder(id);
                MessageBox.Show(success ? "Order deleted." : "Not found.");
                if (success) 
                {
                    ClearOrderFields(); 
                    LoadAllOrders(); 
                }
            }
        }



        private void LoadAllOrders()        //helper function
        {

            List<OrderBL> orders = OrderDL.GetAllOrders();
            DataTable dt = new DataTable();
            dt.Columns.Add("OrderId");
            dt.Columns.Add("BuyerUsername");
            dt.Columns.Add("Status");
            dt.Columns.Add("OrderDate");

            foreach (OrderBL o in orders)
                dt.Rows.Add(o.getOrderId(), o.getBuyer().getUsername(), o.getStatus(), o.getOrderDate());

            dgvOrder.DataSource = dt;
        }

        private void ClearOrderFields()
        {
            txtOrderId.Clear();
            txtBuyerOrder.Clear();
            cmbOrderStatus.SelectedIndex = -1;
            txtOrderDate.Clear();
        }

        //------------------------Payment Panel--------------------
        private void tabPayments_Click(object sender, EventArgs e) { }

        private void pnlAdminPaymentLeft_Paint(object sender, PaintEventArgs e) { }
       
        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPayment.Rows[e.RowIndex];
                txtPayProdId.Text = row.Cells["PaymentId"].Value.ToString();
            }
        }
        private void btnLoadPayment_Click(object sender, EventArgs e)
        {
            LoadAllPayments();
        }

        private void lblPaymentId_Click(object sender, EventArgs e) { }
        
        private void txtPayProdId_TextChanged(object sender, EventArgs e) { }

        private void txtSearchPaidOrderId_TextChanged(object sender, EventArgs e) { }
       
        private void lblSearchPaidOrderId_Click(object sender, EventArgs e) { }
        
        private void btnMarkPaid_Click(object sender, EventArgs e)
        {
            string paymentId = txtPayProdId.Text.Trim();
 
            if (Validation.IsNullOrEmpty(paymentId))
            {
                MessageBox.Show("Enter Payment ID.");
                return;
            }

            //check if already paid before marking
            PaymentBL existing = PaymentDL.FindPayment(paymentId);
            if (existing == null)
            {
                MessageBox.Show("Payment not found.");
                return;
            }

            if (existing.getIsPaid())
            {
                MessageBox.Show("Already marked as paid.");
                return;
            }

            bool success = PaymentDL.UpdateIsPaid(paymentId, true);
            MessageBox.Show(success ? "Marked as Paid!" : "Failed.");
            if (success)
            {
                txtPayProdId.Clear();
                LoadAllPayments();
            }
        }


        private void btnFindPayment_Click(object sender, EventArgs e)
        {

            string paymentId = txtPayProdId.Text.Trim();

            if (Validation.IsNullOrEmpty(paymentId))
            {
                MessageBox.Show("Enter Payment ID.");
                return;
            }

            PaymentBL found = PaymentDL.FindPayment(paymentId);
            if (found == null) { MessageBox.Show("Payment not found."); return; }

            // show in dgv
            DataTable dt = new DataTable();
            dt.Columns.Add("PaymentId"); dt.Columns.Add("OrderId");
            dt.Columns.Add("Amount"); dt.Columns.Add("Method"); dt.Columns.Add("IsPaid");
            dt.Rows.Add(found.getPaymentId(), found.getOrderId(), found.getAmount(), found.getPaymentMethod(), found.getIsPaid());
            dgvPayment.DataSource = dt;
        }


        private void btnSearchByOrderId_Click(object sender, EventArgs e)
        {
            string orderId = txtSearchPaidOrderId.Text.Trim();

            if (Validation.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Enter Order ID.");
                return;
            }

            PaymentBL found = PaymentDL.FindByOrder(orderId);
            if (found == null) { MessageBox.Show("No payment found for this Order."); return; }

            DataTable dt = new DataTable();
            dt.Columns.Add("PaymentId"); dt.Columns.Add("OrderId");
            dt.Columns.Add("Amount"); dt.Columns.Add("Method"); dt.Columns.Add("IsPaid");
            dt.Rows.Add(found.getPaymentId(), found.getOrderId(), found.getAmount(), found.getPaymentMethod(), found.getIsPaid());
            dgvPayment.DataSource = dt;

            // auto-fill payment id so admin can directly mark paid after finding
            txtPayProdId.Text = found.getPaymentId();
            txtSearchPaidOrderId.Clear();
        }



        private void LoadAllPayments()
        {
            List<PaymentBL> payments = new List<PaymentBL>();
            // Load via all orders
            List<OrderBL> orders = OrderDL.GetAllOrders();
            DataTable dt = new DataTable();
            dt.Columns.Add("PaymentId"); dt.Columns.Add("OrderId"); dt.Columns.Add("Amount");
            dt.Columns.Add("Method"); dt.Columns.Add("IsPaid");

            foreach (OrderBL o in orders)
            {
                PaymentBL p = PaymentDL.FindByOrder(o.getOrderId());
                if (p != null)
                    dt.Rows.Add(p.getPaymentId(), p.getOrderId(), p.getAmount(), p.getPaymentMethod(), p.getIsPaid());
            }
            dgvPayment.DataSource = dt;
        }


        //-----------------------------Discount Panel-----------------------------------

        private void tabDiscount_Click(object sender, EventArgs e) { }

        private void pnlAdminDiscountLeft_Paint(object sender, PaintEventArgs e) { }
     
        private void dgvDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiscount.Rows[e.RowIndex];
                txtDiscountCode.Text = row.Cells["Code"].Value.ToString();
                txtDiscountPercent.Text = row.Cells["Percent"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        private void btnLoadDiscount_Click(object sender, EventArgs e)
        {
            LoadAllDiscounts();
        }

        private void lblDiscountCode_Click(object sender, EventArgs e) { }
      
        private void txtDiscountCode_TextChanged(object sender, EventArgs e) { }
       
        private void lblDiscountPercent_Click(object sender, EventArgs e) { }
        
        private void txtDiscountPercent_TextChanged(object sender, EventArgs e) { }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            string code = txtDiscountCode.Text.Trim();

            // Check Discount Code
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Enter Discount Code.");
                return;
            }

            // Check Percent
            double percent = 0;
            if (!double.TryParse(txtDiscountPercent.Text.Trim(), out percent))
            {
                MessageBox.Show("Invalid percent.");
                return;
            }

            // Validate Percent Range
            if (!Validation.IsValidDiscountPercent(percent))
            {
                MessageBox.Show("Discount percent must be between 5 and 50.");
                return;
            }

            DiscountBL d = new DiscountBL(code, percent, chkIsActive.Checked);

            bool success = DiscountDL.AddDiscount(d);

            MessageBox.Show(success? "Discount added successfully!" : "Failed. Discount code may already exist.");

            if (success)
            {
                ClearDiscountFields();
                LoadAllDiscounts();
            }
        }


        private void btnFindDiscount_Click(object sender, EventArgs e)
        {
            string code = txtSearchDiscountCode.Text.Trim();

            if (!Validation.IsValidDiscountCode(code))
            {
                MessageBox.Show("Enter a Discount Code.");
                return;
            }

            DiscountBL found = DiscountDL.FindDiscount(code);
            if (found == null) { MessageBox.Show("Discount not found."); return; }

            txtDiscountCode.Text = found.getDiscountCode();
            txtDiscountPercent.Text = found.getDiscountPercent().ToString();
            chkIsActive.Checked = found.getIsActive();
            txtSearchDiscountCode.Clear();
        }


        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            string code = txtDiscountCode.Text.Trim();

            // Check Discount Code
            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Enter Discount Code.");
                return;
            }

            // Check Percent
            double percent = 0;
            if (!double.TryParse(txtDiscountPercent.Text.Trim(), out percent))
            {
                MessageBox.Show("Invalid percent.");
                return;
            }

            // Validate Percent Range
            if (!Validation.IsValidDiscountPercent(percent))
            {
                MessageBox.Show("Discount percent must be between 5 and 50.");
                return;
            }

            DiscountBL d = new DiscountBL(code, percent, chkIsActive.Checked);

            bool success = DiscountDL.UpdateDiscount(code, d);

            MessageBox.Show(success ? "Discount updated successfully!" : "Update failed. Discount code not found.");

            if (success)
            {
                ClearDiscountFields();
                LoadAllDiscounts();
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {

            string code = txtDiscountCode.Text.Trim();
            if (string.IsNullOrWhiteSpace(code)) { MessageBox.Show("Enter Discount Code."); return; }

            if (MessageBox.Show("Delete discount: " + code + "?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool success = DiscountDL.RemoveDiscount(code);
                MessageBox.Show(success ? "Discount deleted." : "Not found.");
                if (success) { ClearDiscountFields(); LoadAllDiscounts(); }
            }
        }

        private void LoadAllDiscounts()      //helper function
        {
            List<DiscountBL> discounts = DiscountDL.GetAllDiscounts();
            DataTable dt = new DataTable();
            dt.Columns.Add("Code"); dt.Columns.Add("Percent"); dt.Columns.Add("IsActive");
            foreach (DiscountBL d in discounts)
                dt.Rows.Add(d.getDiscountCode(), d.getDiscountPercent(), d.getIsActive());
            dgvDiscount.DataSource = dt;
        }

        private void ClearDiscountFields()           //helper function
        {
            txtDiscountCode.Clear();
            txtDiscountPercent.Clear();
            chkIsActive.Checked = false;
        }

        //------------------------Delivery Panel------------------------------------
        private void tabDelivery_Click(object sender, EventArgs e)
        {
            txtDevlOrderId.ReadOnly = true;
            txtDeliveryAddress.ReadOnly = true;
            txtDeliveryCost.ReadOnly = true;

            if (cmbDeliveryStatus.Items.Count == 0)
            {
                cmbDeliveryStatus.Items.Add("Pending");
                cmbDeliveryStatus.Items.Add("Shipped");
                cmbDeliveryStatus.Items.Add("Delivered");
            }
        }

        private void dgvDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDelivery.Rows[e.RowIndex];
                txtDeliveryId.Text = row.Cells["DeliveryId"].Value.ToString();
                txtDevlOrderId.Text = row.Cells["OrderId"].Value.ToString();
                txtDeliveryAddress.Text = row.Cells["DeliveryAddress"].Value.ToString();
                cmbDeliveryStatus.Text = row.Cells["DeliveryStatus"].Value.ToString();
                txtDeliveryCost.Text = row.Cells["DeliveryCost"].Value.ToString();
            }
        }

        private void btnLoadDeliveries_Click(object sender, EventArgs e)
        {
            LoadAllDeliveries();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFindDelivery_Click(object sender, EventArgs e)
        {
            string id = txtDeliveryId.Text.Trim();

            if (Validation.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter Delivery ID.");
                return;
            }

            DeliveryBL found = DeliveryDL.FindDelivery(id);
            if (found == null) { MessageBox.Show("Delivery not found."); return; }

            txtDeliveryId.Text = found.getDeliveryId();
            txtDevlOrderId.Text = found.getOrderId();
            txtDeliveryAddress.Text = found.getDeliveryAddress();
            cmbDeliveryStatus.Text = found.getDeliveryStatus();
            txtDeliveryCost.Text = found.getDeliveryCost().ToString();
        }

        private void btnDevlFindByOrder_Click(object sender, EventArgs e)
        {

            string orderId = txtDevlSearchOrderId.Text.Trim();

            if (Validation.IsNullOrEmpty(orderId))
            {
                MessageBox.Show("Enter Order ID.");
                return;
            }

            DeliveryBL found = DeliveryDL.FindByOrder(orderId);
            if (found == null) { MessageBox.Show("No delivery found for this Order."); return; }

            txtDeliveryId.Text = found.getDeliveryId();
            txtDevlOrderId.Text = found.getOrderId();
            txtDeliveryAddress.Text = found.getDeliveryAddress();
            cmbDeliveryStatus.Text = found.getDeliveryStatus();
            txtDeliveryCost.Text = found.getDeliveryCost().ToString();
            txtDevlSearchOrderId.Clear();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {

            string id = txtDeliveryId.Text.Trim();
            string newStatus = cmbDeliveryStatus.Text.Trim();

            if (Validation.IsNullOrEmpty(id))
            {
                MessageBox.Show("Select a delivery first.");
                return;
            }

            if (Validation.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Select a status.");
                return;
            }

            bool success = DeliveryDL.UpdateStatus(id, newStatus);
            MessageBox.Show(success ? "Status updated!" : "Update failed.");
            if (success) { ClearDeliveryFields(); LoadAllDeliveries(); }
        }

        
        private void lblDeliveryId_Click(object sender, EventArgs e) { }
        

        private void txtDeliveryId_TextChanged(object sender, EventArgs e) { }
       
        private void lblDevlOrderId_Click(object sender, EventArgs e) { }
        
        private void txtDevlOrderId_TextChanged(object sender, EventArgs e) { }
        
        private void lblDeliveryAddress_Click(object sender, EventArgs e) { }
       

        private void txtDeliveryAddress_TextChanged(object sender, EventArgs e) { }
       

        private void lblDeliveryStatus_Click(object sender, EventArgs e) { }
       
        private void cmbDeliveryStatus_SelectedIndexChanged(object sender, EventArgs e){ }

        private void lblDeliveryCost_Click(object sender, EventArgs e) { }
        
        private void txtDeliveryCost_TextChanged(object sender, EventArgs e) { }
       
        private void lblDevlSearchOrderId_Click(object sender, EventArgs e) { }
 

        private void txtDevlSearchOrderId_TextChanged(object sender, EventArgs e) { }


        private void LoadAllDeliveries()       // helper
        {
            List<DeliveryBL> deliveries = DeliveryDL.GetAllDeliveries();
            DataTable dt = new DataTable();
            dt.Columns.Add("DeliveryId"); dt.Columns.Add("OrderId");
            dt.Columns.Add("DeliveryAddress"); dt.Columns.Add("DeliveryStatus");
            dt.Columns.Add("DeliveryCost");

            foreach (DeliveryBL d in deliveries)
                dt.Rows.Add(d.getDeliveryId(), d.getOrderId(), d.getDeliveryAddress(), d.getDeliveryStatus(), d.getDeliveryCost());

            dgvDelivery.DataSource = dt;
        }

        private void ClearDeliveryFields()    // helper
        {
            txtDeliveryId.Clear();
            txtDevlOrderId.Clear();
            txtDeliveryAddress.Clear();
            cmbDeliveryStatus.SelectedIndex = -1;
            txtDeliveryCost.Clear();
        }


        //------------------------Log out Panel--------------------------------------
        private void lblAdminLogOut_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminYes_Click(object sender, EventArgs e)
        {
            this.Close();         // close admin form
            SignInForm login = new SignInForm();
            login.Show();
        }

        private void btnAdminNo_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedIndex = 0;   // go back to Users tab
        }

        private void tabExitAdmin_Click(object sender, EventArgs e)
        {

        }

        
    }
}
