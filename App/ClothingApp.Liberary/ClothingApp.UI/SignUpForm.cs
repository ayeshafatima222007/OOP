using ClothingApp.Library.BL;
using ClothingApp.Library.DL;
using ClothingApp.Library.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingApp.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
             
        }



        private void SignUpForm_Load(object sender, EventArgs e)     //form name
        {
            // Move your initialization logic here!
            txtAddress.Enabled = false;
            txtAddress.BackColor = Color.LightGray;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)      //header panel
        {

        }

        private void label1_Click(object sender, EventArgs e)    //header shop name
        {

        }
 

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUserValid_Click(object sender, EventArgs e)
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

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRole.SelectedItem.ToString() == "Buyer")
            {
                txtAddress.Enabled = true;          // enable address for Buyer
                txtAddress.BackColor = Color.White;
            }
            else
            {
                txtAddress.Enabled = false;         // disable for Seller and Admin
                txtAddress.Clear();                 // clear any typed text
                txtAddress.BackColor = Color.LightGray;
            }
        }


        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btn_SignUp_Click(object sender, EventArgs e)
        {


            lblErorSignUp.Text = "";  // clear previous error

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (cmbRole.SelectedItem == null) { lblErorSignUp.Text = "Please select a role."; return; }
            string role = cmbRole.SelectedItem.ToString();

            if (!Validation.IsValidUsername(username)) 
            {
                lblErorSignUp.Text = "Invalid username.";
                return;
            }
            if (!Validation.IsValidPassword(password)) 
            {
                lblErorSignUp.Text = "Invalid password."; 
                return;
            }

            if (!Validation.IsValidPhone(phone)) 
            {
                lblErorSignUp.Text = "Invalid phone number.";
                return; 
            }
            if (role == "Buyer" && !Validation.IsValidAddress(address))
            {
                lblErorSignUp.Text = "Address must be at least 5 characters.";
                return;
            }

            UserBL user = null;
            if (role == "Buyer") user = new BuyerBL(username, password, phone, address);
            else if (role == "Seller") user = new SellerBL(username, password, phone);
            else if (role == "Admin") user = new AdminBL(username, password, phone);

            UserDL userDL = new UserDL();
            bool success = userDL.SignUp(user);

            if (success)
            {
                MessageBox.Show("Account created successfully! Please sign in.");
                LandingPage landing = new LandingPage();
                landing.Show();
                this.Close();
            }
            else
            {
                lblErorSignUp.Text = "Sign up failed. Username may already exist.";  //label instead of MessageBox
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

            LandingPage landing = new LandingPage();
            landing.Show();
            this.Close();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb != null)
            {
                txtPassword.PasswordChar = cb.Checked ? '\0' : '*';
            }
        }

        private void lblErorSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
