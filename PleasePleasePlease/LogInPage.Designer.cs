﻿namespace Mirai_Paradise_Hotel
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panelBase = new Panel();
            HotelLogo = new Panel();
            panel1 = new Panel();
            linkLabelCreateAccount = new LinkLabel();
            lblErrorCredentials = new Label();
            btnLogin = new Button();
            lblForgotPass = new LinkLabel();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new MaskedTextBox();
            txtUsername = new TextBox();
            lblAccLogin = new Label();
            panelBase.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(45, 106, 79);
            panelBase.Controls.Add(HotelLogo);
            panelBase.Dock = DockStyle.Left;
            panelBase.Location = new Point(0, 0);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(453, 466);
            panelBase.TabIndex = 0;
            // 
            // HotelLogo
            // 
            HotelLogo.BackgroundImage = (Image)resources.GetObject("HotelLogo.BackgroundImage");
            HotelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            HotelLogo.Location = new Point(3, 40);
            HotelLogo.Name = "HotelLogo";
            HotelLogo.Size = new Size(447, 387);
            HotelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 106, 79);
            panel1.Controls.Add(linkLabelCreateAccount);
            panel1.Controls.Add(lblErrorCredentials);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblForgotPass);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblAccLogin);
            panel1.Location = new Point(507, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 276);
            panel1.TabIndex = 1;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.LinkColor = Color.MediumSeaGreen;
            linkLabelCreateAccount.Location = new Point(177, 240);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(89, 15);
            linkLabelCreateAccount.TabIndex = 10;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Create Account";
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // lblErrorCredentials
            // 
            lblErrorCredentials.AutoSize = true;
            lblErrorCredentials.Font = new Font("Microsoft Sans Serif", 10F);
            lblErrorCredentials.ForeColor = Color.Red;
            lblErrorCredentials.Location = new Point(71, 180);
            lblErrorCredentials.Name = "lblErrorCredentials";
            lblErrorCredentials.Size = new Size(317, 17);
            lblErrorCredentials.TabIndex = 9;
            lblErrorCredentials.Text = "You have entered invalid username or password.";
            lblErrorCredentials.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(45, 106, 79);
            btnLogin.Font = new Font("Microsoft Sans Serif", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(174, 204);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(93, 33);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.LinkColor = Color.MediumSeaGreen;
            lblForgotPass.Location = new Point(283, 155);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(95, 15);
            lblForgotPass.TabIndex = 7;
            lblForgotPass.TabStop = true;
            lblForgotPass.Text = "Forgot Password";
            lblForgotPass.LinkClicked += lblForgotPass_LinkClicked;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 14F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(44, 129);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(96, 24);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 14F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(43, 84);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 24);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(154, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(154, 84);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblAccLogin
            // 
            lblAccLogin.AutoSize = true;
            lblAccLogin.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblAccLogin.ForeColor = Color.White;
            lblAccLogin.Location = new Point(125, 9);
            lblAccLogin.Name = "lblAccLogin";
            lblAccLogin.Size = new Size(221, 36);
            lblAccLogin.TabIndex = 0;
            lblAccLogin.Text = "Account Login";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 466);
            Controls.Add(panel1);
            Controls.Add(panelBase);
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mirai Paradise Hotel";
            panelBase.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBase;
        private Panel HotelLogo;
        private Panel panel1;
        private Label lblPassword;
        private Label lblUsername;
        private MaskedTextBox txtPassword;
        private TextBox txtUsername;
        private Label lblAccLogin;
        private Button btnLogin;
        private LinkLabel lblForgotPass;
        private Label lblErrorCredentials;
        private LinkLabel linkLabelCreateAccount;
    }
}