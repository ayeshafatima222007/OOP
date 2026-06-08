namespace ClothingApp.UI
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.panel_top = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Label();
            this.pnlLandingsidebar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            this.pnlLandingsidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.RosyBrown;
            this.panel_top.Controls.Add(this.panel_header);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 100);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel_header.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlLandingsidebar
            // 
            this.pnlLandingsidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLandingsidebar.BackgroundImage")));
            this.pnlLandingsidebar.Controls.Add(this.btnExit);
            this.pnlLandingsidebar.Controls.Add(this.btnSignIn);
            this.pnlLandingsidebar.Controls.Add(this.btnSignUp);
            this.pnlLandingsidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLandingsidebar.Location = new System.Drawing.Point(0, 100);
            this.pnlLandingsidebar.Name = "pnlLandingsidebar";
            this.pnlLandingsidebar.Size = new System.Drawing.Size(188, 500);
            this.pnlLandingsidebar.TabIndex = 1;
            this.pnlLandingsidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLandingsidebar_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Info;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(188, 68);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Info;
            this.btnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignIn.BackgroundImage")));
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(0, 74);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(188, 68);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.Info;
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(0, 0);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(188, 68);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lb_welcome.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_welcome.Location = new System.Drawing.Point(344, 290);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(294, 80);
            this.lb_welcome.TabIndex = 1;
            this.lb_welcome.Text = "Welcome";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_welcome.Click += new System.EventHandler(this.lb_welcome_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.pnlLandingsidebar);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.pnlLandingsidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label panel_header;
        private System.Windows.Forms.Panel pnlLandingsidebar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lb_welcome;
    }
}