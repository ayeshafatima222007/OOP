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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)     //bg form
        {

        }

        private void label1_Click(object sender, EventArgs e)     //header shop name
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)   //top panel
        {

        }

        private void pnlLandingsidebar_Paint(object sender, PaintEventArgs e)       //left panel
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)     //signup button
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)  //signin button
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)   //Exit Button
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void lb_welcome_Click(object sender, EventArgs e)    //welcome label
        {

        }
 
    }
}
