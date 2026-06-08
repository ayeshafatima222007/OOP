using ClothingApp.Library.BL;
using ClothingApp.Library.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingApp.UI
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            lblError.Text = "";  

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            //  inline empty check like the image
            if (username == "" || password == "")
            {
                lblError.Text = "Please enter username and password.";
                return;
            }

            UserDL userDL = new UserDL();
            UserBL user = userDL.SignIn(username, password);

            if (user == null)
            {
                lblError.Text = "Invalid username or password.";   
                return;
            }

            MessageBox.Show("Welcome, " + user.getUsername() + "!");

            string role = user.getRole();

            if (role == "Buyer")
            {

                BuyerBL buyer = new BuyerBL(user.getUsername(), user.getPassword(), user.getPhoneNumber(), "");
                BuyerForm buyerForm = new BuyerForm(buyer);
                buyerForm.Show();
                this.Hide();
            }
            else if (role == "Seller")
            {
                SellerBL seller = new SellerBL(user.getUsername(), user.getPassword(), user.getPhoneNumber());
                SellerForm sellerForm = new SellerForm(seller);
                sellerForm.Show();
                this.Hide();
            }
            else if (role == "Admin")
            {

                AdminBL admin = new AdminBL(user.getUsername(), user.getPassword(), user.getPhoneNumber());
                Admin_Form adminForm = new Admin_Form(admin);
                adminForm.Show();
                this.Hide();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            LandingPage landing = new LandingPage();
            landing.Show();
            this.Close();
        }

        private void panel_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblValidationSignIn_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}
