using ClothingApp.Library.BL;
using ClothingApp.Library.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingApp.UI
{
    public partial class SellerForm : Form
    {

        private SellerBL loggedInSeller;
        private UserDL userDL = new UserDL();


        public SellerForm(SellerBL seller)
        {

            InitializeComponent();
            loggedInSeller = seller;
            txtUsername.ReadOnly = true;
            LoadProducts();
            LoadOrders();
            LoadDiscounts();
            LoadProfile();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }


        //-----------------------------Product Panel---------------------------------
        private void tabProduct_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = row.Cells["Name"].Value?.ToString();
                txtColor.Text = row.Cells["Color"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtQty.Text = row.Cells["Quantity"].Value?.ToString();
                cmbCategory.Text = row.Cells["Category"].Value?.ToString();
                cmbSize.Text = row.Cells["Size"].Value?.ToString();
            }
        }

        private void pnlProductSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblProductId_Click(object sender, EventArgs e)
        {

        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblColor_Click(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString();
            string name = txtProductName.Text.Trim();
            string color = txtColor.Text.Trim();
            string size = cmbSize.SelectedItem?.ToString();
            string priceText = txtPrice.Text.Trim();
            string qtyText = txtQty.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(color) ||
                string.IsNullOrWhiteSpace(size) || string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(qtyText))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!double.TryParse(priceText, out double price) || price <= 0)
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty <= 0)
            {
                MessageBox.Show("Invalid quantity.");
                return;
            }

            ProductBL prod = new ProductBL(id, category, name, color, size, price, qty);
            bool result = ProductDL.AddProduct(prod);

            if (result)
            {
                MessageBox.Show("Product added successfully.");
                ClearProductFields();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to add product. ID may already exist or invalid input.");
            }
        }



        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

            string id = txtProductId.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString();
            string name = txtProductName.Text.Trim();
            string color = txtColor.Text.Trim();
            string size = cmbSize.SelectedItem?.ToString();
            string priceText = txtPrice.Text.Trim();
            string qtyText = txtQty.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Enter Product ID to update.");
                return;
            }

            if (!double.TryParse(priceText, out double price) || price <= 0)
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            if (!int.TryParse(qtyText, out int qty) || qty <= 0)
            {
                MessageBox.Show("Invalid quantity.");
                return;
            }

            ProductBL updated = new ProductBL(id, category, name, color, size, price, qty);
            bool result = ProductDL.UpdateProduct(id, updated);

            if (result)
            {
                MessageBox.Show("Product updated.");
                ClearProductFields();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Update failed. Product not found or invalid input.");
            }
        }


        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Enter Product ID to remove.");
                return;
            }

            bool result = ProductDL.RemoveProduct(id);

            if (result)
            {
                MessageBox.Show("Product removed.");
                ClearProductFields();
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            ClearProductFields();
        }



        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string search = txtSearchProduct.Text.Trim();

            if (string.IsNullOrWhiteSpace(search))
            {
                LoadProducts();
                return;
            }

            // try find by ID first
            ProductBL prod = ProductDL.FindProduct(search);
            dgvProduct.Rows.Clear();

            if (prod != null)
            {
                dgvProduct.Rows.Add(
                    prod.getProductId(),
                    prod.getCategory(),
                    prod.getName(),
                    prod.getColor(),
                    prod.getSize(),
                    prod.getPrice(),
                    prod.getQuantity()
                );
            }
            else
            {
                // try find by category
                List<ProductBL> byCategory = ProductDL.FindByCategory(search);
                foreach (ProductBL p in byCategory)
                {
                    dgvProduct.Rows.Add(
                        p.getProductId(),
                        p.getCategory(),
                        p.getName(),
                        p.getColor(),
                        p.getSize(),
                        p.getPrice(),
                        p.getQuantity()
                    );
                }

                if (byCategory.Count == 0)
                {
                    MessageBox.Show("No product found.");
                }
            }
        }



        private void LoadProducts()               //helper function
        {
            List<ProductBL> products = ProductDL.GetAllProducts();
            dgvProduct.Rows.Clear();
            dgvProduct.Columns.Clear();

            dgvProduct.Columns.Add("ProductId", "Product ID");
            dgvProduct.Columns.Add("Category", "Category");
            dgvProduct.Columns.Add("Name", "Name");
            dgvProduct.Columns.Add("Color", "Color");
            dgvProduct.Columns.Add("Size", "Size");
            dgvProduct.Columns.Add("Price", "Price");
            dgvProduct.Columns.Add("Quantity", "Quantity");

            foreach (ProductBL p in products)
            {
                dgvProduct.Rows.Add(
                    p.getProductId(),
                    p.getCategory(),
                    p.getName(),
                    p.getColor(),
                    p.getSize(),
                    p.getPrice(),
                    p.getQuantity()
                );
            }
        }


        private void ClearProductFields()        //helper function
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            txtColor.Text = "";
            txtPrice.Text = "";
            txtQty.Text = "";
            cmbCategory.SelectedIndex = -1;
            cmbSize.SelectedIndex = -1;
        }




        //--------------------------Order Panel-----------------------------------


        private void tabOrder_Click(object sender, EventArgs e)
        {

        }

        private void pnlOrderSidebar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblOrderId_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {

            string id = txtOrderId.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Enter Order ID.");
                return;
            }

            OrderBL ord = OrderDL.FindOrder(id);
            dgvOrder.Rows.Clear();

            if (ord != null)
            {
                dgvOrder.Rows.Add(
                    ord.getOrderId(),
                    ord.getBuyer().getUsername(),
                    ord.getStatus(),
                    ord.getOrderDate().ToString("yyyy-MM-dd")
                );
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }


        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {

            txtOrderId.Text = "";
            LoadOrders();
        }


        private void LoadOrders()        //helper function
        {
            List<OrderBL> orders = OrderDL.GetAllOrders();
            dgvOrder.Rows.Clear();
            dgvOrder.Columns.Clear();

            dgvOrder.Columns.Add("OrderId", "Order ID");
            dgvOrder.Columns.Add("Buyer", "Buyer");
            dgvOrder.Columns.Add("Status", "Status");
            dgvOrder.Columns.Add("OrderDate", "Order Date");

            foreach (OrderBL o in orders)
            {
                dgvOrder.Rows.Add(
                    o.getOrderId(),
                    o.getBuyer().getUsername(),
                    o.getStatus(),
                    o.getOrderDate().ToString("yyyy-MM-dd")
                );
            }
        }



        //-----------------------------Discount Panel----------------------
        private void tabDiscount_Click(object sender, EventArgs e)
        {

        }

        private void dgvDiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiscount.Rows[e.RowIndex];
                txtDiscountId.Text = row.Cells["DiscountCode"].Value?.ToString();
                txtDiscountPercent.Text = row.Cells["DiscountPercent"].Value?.ToString();
            }

        }

        private void pnlDiscountSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            string code = txtDiscountId.Text.Trim();
            string percentText = txtDiscountPercent.Text.Trim();

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(percentText))
            {
                MessageBox.Show("Fill all discount fields.");
                return;
            }

            if (!double.TryParse(percentText, out double percent))
            {
                MessageBox.Show("Invalid percent value.");
                return;
            }

             
            DiscountBL existing = DiscountDL.FindDiscount(code);
            bool result;

            if (existing != null)
            {
                DiscountBL updated = new DiscountBL(code, percent, true);
                result = DiscountDL.UpdateDiscount(code, updated);
            }
            else
            {
                DiscountBL newDiscount = new DiscountBL(code, percent, true);
                result = DiscountDL.AddDiscount(newDiscount);
            }

            if (result)
            {
                MessageBox.Show("Discount applied.");
                ClearDiscountFields();
                LoadDiscounts();
            }
            else
            {
                MessageBox.Show("Failed. Check discount percent (5-50).");
            }
        }



        private void btnRemoveDiscount_Click(object sender, EventArgs e)
        {

            string code = txtDiscountId.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Enter Discount Code.");
                return;
            }

            bool result = DiscountDL.RemoveDiscount(code);

            if (result)
            {
                MessageBox.Show("Discount removed.");
                ClearDiscountFields();
                LoadDiscounts();
            }
            else
            {
                MessageBox.Show("Discount not found.");
            }
        }

        private void lblDiscountId_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountId_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void lblDiscountPercent_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountPercent_TextChanged(object sender, EventArgs e)
        {

        }



        private void LoadDiscounts()      //Helper functions
        {
            List<DiscountBL> discounts = DiscountDL.GetAllDiscounts();
            dgvDiscount.Rows.Clear();
            dgvDiscount.Columns.Clear();

            dgvDiscount.Columns.Add("DiscountCode", "Discount Code");
            dgvDiscount.Columns.Add("DiscountPercent", "Percent (%)");
            dgvDiscount.Columns.Add("IsActive", "Active");

            foreach (DiscountBL d in discounts)
            {
                dgvDiscount.Rows.Add(
                    d.getDiscountCode(),
                    d.getDiscountPercent(),
                    d.getIsActive()
                );
            }
        }


        private void ClearDiscountFields()        //helper function
        {
            txtDiscountId.Text = "";
            txtDiscountPercent.Text = "";
        }


        //-----------------Profile Panel----------------
        private void tabProfile_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

            string phone = txtPhone.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Enter new password.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            bool result = userDL.UpdateUser(loggedInSeller.getUsername(), phone, newPass);

            if (result)
            {
                loggedInSeller.setPhoneNumber(phone);
                loggedInSeller.setPassword(newPass);
                MessageBox.Show("Profile updated.");
                LoadProfile();
            }
            else
            {
                MessageBox.Show("Update failed. Check phone (11 digits) and password format (5-8 chars, upper, lower, number, special char).");
            }

        }

        private void lblSellerLogout_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoutYes_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignInForm login = new SignInForm();
            login.Show();
        }

        private void btnLogoutNo_Click(object sender, EventArgs e)
        {

        }


        private void LoadProfile()      //helper function
        {
            txtUsername.Text = loggedInSeller.getUsername();
            txtPhone.Text = loggedInSeller.getPhoneNumber();
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }


    }
}
