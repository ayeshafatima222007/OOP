namespace ClothingApp.UI
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.paneltop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblValidationSignUp = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblErorSignUp = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.paneltop.SuspendLayout();
            this.panel_sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_top.Controls.Add(this.paneltop);
            this.panel_top.Controls.Add(this.panel_header);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(778, 100);
            this.panel_top.TabIndex = 1;
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.RosyBrown;
            this.paneltop.Controls.Add(this.lblHeader);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(778, 100);
            this.paneltop.TabIndex = 1;
            this.paneltop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.RosyBrown;
            this.lblHeader.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Firebrick;
            this.lblHeader.Location = new System.Drawing.Point(305, 32);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(106, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Sign Up";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_header
            // 
            this.panel_header.AutoSize = true;
            this.panel_header.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_header.Font = new System.Drawing.Font("Bernard MT Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_header.ForeColor = System.Drawing.Color.Firebrick;
            this.panel_header.Location = new System.Drawing.Point(305, 32);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(166, 38);
            this.panel_header.TabIndex = 0;
            this.panel_header.Text = "ABAYA SHOP";
            this.panel_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(255, 135);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 28);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(390, 128);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(327, 35);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(255, 183);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(113, 32);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(390, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(327, 35);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(255, 264);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(113, 32);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(390, 261);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(327, 35);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(255, 316);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(113, 32);
            this.lblRole.TabIndex = 8;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRole.Click += new System.EventHandler(this.lblRole_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Seller",
            "Buyer"});
            this.cmbRole.Location = new System.Drawing.Point(390, 316);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(327, 28);
            this.cmbRole.TabIndex = 9;
            this.cmbRole.Text = "Admin/Seller/Buyer";
            this.cmbRole.SelectedIndexChanged += new System.EventHandler(this.cmbRole_SelectedIndexChanged);
            // 
            // lblValidationSignUp
            // 
            this.lblValidationSignUp.BackColor = System.Drawing.SystemColors.Info;
            this.lblValidationSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidationSignUp.Location = new System.Drawing.Point(12, 33);
            this.lblValidationSignUp.Name = "lblValidationSignUp";
            this.lblValidationSignUp.Size = new System.Drawing.Size(189, 350);
            this.lblValidationSignUp.TabIndex = 11;
            this.lblValidationSignUp.Text = resources.GetString("lblValidationSignUp.Text");
            this.lblValidationSignUp.Click += new System.EventHandler(this.lblUserValid_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(255, 367);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(113, 32);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(390, 364);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(327, 35);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.SystemColors.Info;
            this.btn_SignUp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.Location = new System.Drawing.Point(371, 447);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(100, 50);
            this.btn_SignUp.TabIndex = 13;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_sidebar.BackgroundImage")));
            this.panel_sidebar.Controls.Add(this.lblValidationSignUp);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 100);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(212, 444);
            this.panel_sidebar.TabIndex = 15;
            this.panel_sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_sidebar_Paint);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Back.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(546, 447);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(100, 50);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.RosyBrown;
            this.chkShowPassword.Location = new System.Drawing.Point(390, 219);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(148, 24);
            this.chkShowPassword.TabIndex = 23;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // lblErorSignUp
            // 
            this.lblErorSignUp.AutoSize = true;
            this.lblErorSignUp.BackColor = System.Drawing.Color.Transparent;
            this.lblErorSignUp.ForeColor = System.Drawing.Color.Red;
            this.lblErorSignUp.Location = new System.Drawing.Point(312, 419);
            this.lblErorSignUp.Name = "lblErorSignUp";
            this.lblErorSignUp.Size = new System.Drawing.Size(13, 20);
            this.lblErorSignUp.TabIndex = 24;
            this.lblErorSignUp.Text = " ";
            this.lblErorSignUp.Click += new System.EventHandler(this.lblErorSignUp_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.lblErorSignUp);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panel_sidebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label panel_header;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblValidationSignUp;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblErorSignUp;
    }
}