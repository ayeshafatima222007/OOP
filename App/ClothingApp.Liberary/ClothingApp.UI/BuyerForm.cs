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
    public partial class BuyerForm : Form
    {
        private BuyerBL loggedInBuyer;
        private UserDL userDL = new UserDL();
        private string currentOrderId = null;
        private double cartTotal = 0;
        private double discountedTotal = 0;

        public BuyerForm(BuyerBL buyer)
        {
            InitializeComponent();
            loggedInBuyer = buyer;
            txtUsername.ReadOnly = true;
            LoadBrowse();
            LoadOrders();
            LoadProfile();
        }


        private void BuyerForm_Load(object sender, EventArgs e)
        {

        }

        //--------------------------Browse Product Panel-------------------------
        private void dgvBrowse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void lblBuyerHeader_Click(object sender, EventArgs e)
        {

        }

        private void TabBrowseProduct_Click(object sender, EventArgs e)
        {

        }

        private void pnlBrowseSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            string search = txtBrowseSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(search))
            {
                LoadBrowse();
                return;
            }

            ProductBL prod = ProductDL.FindProduct(search);
            dgvBrowse.Rows.Clear();

            if (prod != null)
            {
                dgvBrowse.Rows.Add(
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
                List<ProductBL> byCategory = ProductDL.FindByCategory(search);
                foreach (ProductBL p in byCategory)
                {
                    dgvBrowse.Rows.Add(
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
                    MessageBox.Show("No product found.");
            }
        }

        private void btnRefreshBrowse_Click(object sender, EventArgs e)
        {

            txtBrowseSearch.Text = "";
            LoadBrowse();
        }

        private void lblBrowseSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtBrowseSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvBrowse.CurrentRow == null)
            {
                MessageBox.Show("Select a product first.");
                return;
            }

            DataGridViewRow row = dgvBrowse.CurrentRow;
            string id = row.Cells["ProductId"].Value?.ToString();
            string category = row.Cells["Category"].Value?.ToString();
            string name = row.Cells["Name"].Value?.ToString();
            string color = row.Cells["Color"].Value?.ToString();
            string size = row.Cells["Size"].Value?.ToString();
            double price = Convert.ToDouble(row.Cells["Price"].Value);
            int qty = Convert.ToInt32(row.Cells["Quantity"].Value);

            ProductBL product = new ProductBL(id, category, name, color, size, price, qty);
            loggedInBuyer.getCart().AddToCart(product);

            MessageBox.Show(name + " added to cart.");
            RefreshCartView();
        }


        private void LoadBrowse()            //helper function
        {
            List<ProductBL> products = ProductDL.GetAllProducts();
            dgvBrowse.Rows.Clear();
            dgvBrowse.Columns.Clear();

            dgvBrowse.Columns.Add("ProductId", "Product ID");
            dgvBrowse.Columns.Add("Category", "Category");
            dgvBrowse.Columns.Add("Name", "Name");
            dgvBrowse.Columns.Add("Color", "Color");
            dgvBrowse.Columns.Add("Size", "Size");
            dgvBrowse.Columns.Add("Price", "Price");
            dgvBrowse.Columns.Add("Quantity", "Quantity");

            foreach (ProductBL p in products)
            {
                dgvBrowse.Rows.Add(
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


        //---------------------------Cart Panel----------------------------------------
        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlCartSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {

            if (loggedInBuyer.getCart().IsEmpty())
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            ProductBL removed = loggedInBuyer.getCart().RemoveFromCart();
            MessageBox.Show(removed.getName() + " removed from cart.");
            RefreshCartView();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {

            loggedInBuyer.getCart().ClearCart();
            RefreshCartView();
            MessageBox.Show("Cart cleared.");
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {

        }


        private void lblDiscountCode_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyCodeGo_Click(object sender, EventArgs e)
        {

            string code = txtDiscountCode.Text.Trim();

            if (string.IsNullOrWhiteSpace(code))
            {
                MessageBox.Show("Enter a discount code.");
                return;
            }

            if (loggedInBuyer.getCart().IsEmpty())
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            DiscountBL discount = DiscountDL.FindDiscount(code);

            if (discount == null || !discount.getIsActive())
            {
                MessageBox.Show("Invalid or inactive discount code.");
                return;
            }

            discountedTotal = cartTotal - (cartTotal * discount.getDiscountPercent() / 100);
            txtTotalAmount.Text = discountedTotal.ToString("F2");
            MessageBox.Show("Discount applied! " + discount.getDiscountPercent() + "% off.");
        }



        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            if (loggedInBuyer.getCart().IsEmpty())
            {
                MessageBox.Show("Cart is empty. Add products first.");
                return;
            }

            // auto-generate order ID
            currentOrderId = "ORD_" + DateTime.Now.Ticks;

            OrderBL order = new OrderBL(currentOrderId, loggedInBuyer);
            bool result = OrderDL.AddOrder(order);

            if (result)
            {
                MessageBox.Show("Order placed! Order ID: " + currentOrderId);

                // auto-fill checkout tab
                txtCurrentOrderId.Text = currentOrderId;
                txtCheckoutTotal.Text = discountedTotal.ToString("F2");

                // clear cart
                loggedInBuyer.getCart().ClearCart();
                RefreshCartView();
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Failed to place order.");
            }
        }


        private void RefreshCartView()        //helper function
        {
            dgvCart.Rows.Clear();
            dgvCart.Columns.Clear();

            dgvCart.Columns.Add("ProductId", "Product ID");
            dgvCart.Columns.Add("Name", "Name");
            dgvCart.Columns.Add("Category", "Category");
            dgvCart.Columns.Add("Size", "Size");
            dgvCart.Columns.Add("Price", "Price");

            cartTotal = 0;

            // queue to list for display (non-destructive)
            Queue<ProductBL> temp = new Queue<ProductBL>(loggedInBuyer.getCart().GetCartItems());

            foreach (ProductBL p in temp)
            {
                dgvCart.Rows.Add(
                    p.getProductId(),
                    p.getName(),
                    p.getCategory(),
                    p.getSize(),
                    p.getPrice()
                );
                cartTotal += p.getPrice();
            }

            txtTotal.Text = cartTotal.ToString("F2");
            // reset discount when cart changes
            discountedTotal = cartTotal;
            txtTotalAmount.Text = discountedTotal.ToString("F2");
            txtDiscountCode.Text = "";
        }


        //-----------------------------Orders Panel---------------------------
        private void tabOrders_Click(object sender, EventArgs e)
        {

        }
        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlOredersSIdebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefreshOrders_Click(object sender, EventArgs e)
        {

            txtSearchOrder.Text = "";
            LoadOrders();
        }

        private void lblSearchOrder_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {

            string id = txtSearchOrder.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Enter Order ID.");
                return;
            }

            OrderBL ord = OrderDL.FindOrder(id);
            dgvOrders.Rows.Clear();

            if (ord != null && ord.getBuyer().getUsername() == loggedInBuyer.getUsername())
            {
                dgvOrders.Rows.Add(
                    ord.getOrderId(),
                    ord.getStatus(),
                    ord.getOrderDate().ToString("yyyy-MM-dd")
                );
            }
            else
            {
                MessageBox.Show("Order not found.");
            }
        }



        private void LoadOrders()         //helper function
        {
            List<OrderBL> orders = OrderDL.FindOrdersByBuyer(loggedInBuyer.getUsername());
            dgvOrders.Rows.Clear();
            dgvOrders.Columns.Clear();

            dgvOrders.Columns.Add("OrderId", "Order ID");
            dgvOrders.Columns.Add("Status", "Status");
            dgvOrders.Columns.Add("OrderDate", "Order Date");

            foreach (OrderBL o in orders)
            {
                dgvOrders.Rows.Add(
                    o.getOrderId(),
                    o.getStatus(),
                    o.getOrderDate().ToString("yyyy-MM-dd")
                );
            }
        }


        //--------------------------Checkout Panel------------------
        private void tabCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentOrderId_Click(object sender, EventArgs e)
        {

        }

        private void txtCurrentOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCheckoutTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtCheckoutTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentId_Click(object sender, EventArgs e)
        {

        }

        private void txtPaymentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDeliveryId_Click(object sender, EventArgs e)
        {

        }

        private void txtDeliveryId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDeliveryMethod_Click(object sender, EventArgs e)
        {

        }

        private void cmbDeliveryMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDeliveryAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtDeliveryAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDeliveryCost_Click(object sender, EventArgs e)
        {

        }

        private void txtDeliveryCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmCheckout_Click(object sender, EventArgs e)
        {
            string orderId = txtCurrentOrderId.Text.Trim();
            string paymentId = txtPaymentId.Text.Trim();
            string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString();
            string deliveryId = txtDeliveryId.Text.Trim();
            string deliveryMethod = cmbDeliveryMethod.SelectedItem?.ToString();
            string deliveryAddress = txtDeliveryAddress.Text.Trim();
            string deliveryCostText = txtDeliveryCost.Text.Trim();
            string totalText = txtCheckoutTotal.Text.Trim();

            if (string.IsNullOrWhiteSpace(orderId) || string.IsNullOrWhiteSpace(paymentId) ||
                string.IsNullOrWhiteSpace(paymentMethod) || string.IsNullOrWhiteSpace(deliveryId) ||
                string.IsNullOrWhiteSpace(deliveryMethod) || string.IsNullOrWhiteSpace(deliveryAddress) ||
                string.IsNullOrWhiteSpace(deliveryCostText) || string.IsNullOrWhiteSpace(totalText))
            {
                MessageBox.Show("Fill all checkout fields.");
                return;
            }

            if (!double.TryParse(totalText, out double amount) || amount <= 0)
            {
                MessageBox.Show("Invalid checkout total.");
                return;
            }

            if (!double.TryParse(deliveryCostText, out double deliveryCost) || deliveryCost < 0)
            {
                MessageBox.Show("Invalid delivery cost.");
                return;
            }

            // check order exists
            if (OrderDL.FindOrder(orderId) == null)
            {
                MessageBox.Show("Order not found. Place an order first.");
                return;
            }

            // add payment
            PaymentBL payment = new PaymentBL(paymentId, orderId, amount, paymentMethod);
            bool payResult = PaymentDL.AddPayment(payment);

            if (!payResult)
            {
                MessageBox.Show("Payment failed. Payment ID may already exist or invalid method.");
                return;
            }

            // add delivery
            DeliveryBL delivery = new DeliveryBL(deliveryId, orderId, deliveryMethod, deliveryAddress, deliveryCost);
            bool delResult = DeliveryDL.AddDelivery(delivery);

            if (!delResult)
            {
                MessageBox.Show("Delivery failed. Delivery ID may already exist or invalid input.");
                return;
            }

            MessageBox.Show("Checkout complete! Payment and Delivery recorded.");

            // clear checkout fields
            txtCurrentOrderId.Text = "";
            txtCheckoutTotal.Text = "";
            txtPaymentId.Text = "";
            txtDeliveryId.Text = "";
            txtDeliveryAddress.Text = "";
            txtDeliveryCost.Text = "";
            cmbPaymentMethod.SelectedIndex = -1;
            cmbDeliveryMethod.SelectedIndex = -1;
            currentOrderId = null;
            LoadOrders();
        }


        //------------------------------Profile Tab-------------------------


        private void tabProfile_Click(object sender, EventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }


        private void lblNewPassword_Click(object sender, EventArgs e)
        {

        }


        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string phone = txtPhoneNumber.Text.Trim();
            string newPass = txtNewPassword.Text.Trim();
            string confirmPass = txtConfirmPassword.Text.Trim();
            string address = txtAddress.Text.Trim();

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

            bool result = userDL.UpdateUser(loggedInBuyer.getUsername(), phone, newPass, address);

            if (result)
            {
                loggedInBuyer.setPhoneNumber(phone);
                loggedInBuyer.setPassword(newPass);
                loggedInBuyer.setAddress(address);
                MessageBox.Show("Profile updated.");
                LoadProfile();
            }
            else
            {
                MessageBox.Show("Update failed. Check phone (11 digits) and password format.");
            }
        }


        private void LoadProfile()       //helper function
        {

            txtUsername.Text = loggedInBuyer.getUsername();
            txtPhoneNumber.Text = loggedInBuyer.getPhoneNumber();
            txtAddress.Text = loggedInBuyer.getAddress();
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void lblExit_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyerExitYes_Click(object sender, EventArgs e)
        {

            this.Hide();
            SignInForm signIn = new SignInForm();
            signIn.Show();
        }

        private void btnBuyerExitNo_Click(object sender, EventArgs e)
        {

        }
    }
}
