namespace Mirai_Paradise_Hotel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelBase = new Panel();
            HotelLogo = new Panel();
            panel1 = new Panel();
            lblErrorCredentials = new Label();
            btnLogin = new Button();
            lblForgotPass = new LinkLabel();
            lblPassword = new Label();
            lblUsername = new Label();
            txtPassword = new MaskedTextBox();
            txtUsername = new TextBox();
            lblAccLogin = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
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
            panelBase.Margin = new Padding(3, 4, 3, 4);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(518, 621);
            panelBase.TabIndex = 0;
            // 
            // HotelLogo
            // 
            HotelLogo.BackgroundImage = (Image)resources.GetObject("HotelLogo.BackgroundImage");
            HotelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            HotelLogo.Location = new Point(3, 53);
            HotelLogo.Margin = new Padding(3, 4, 3, 4);
            HotelLogo.Name = "HotelLogo";
            HotelLogo.Size = new Size(511, 516);
            HotelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 106, 79);
            panel1.Controls.Add(lblErrorCredentials);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblForgotPass);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(lblAccLogin);
            panel1.Location = new Point(579, 133);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 368);
            panel1.TabIndex = 1;
            // 
            // lblErrorCredentials
            // 
            lblErrorCredentials.AutoSize = true;
            lblErrorCredentials.Font = new Font("Microsoft Sans Serif", 10F);
            lblErrorCredentials.ForeColor = Color.Red;
            lblErrorCredentials.Location = new Point(81, 240);
            lblErrorCredentials.Name = "lblErrorCredentials";
            lblErrorCredentials.Size = new Size(370, 20);
            lblErrorCredentials.TabIndex = 9;
            lblErrorCredentials.Text = "You have entered invalid username or password.";
            lblErrorCredentials.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(45, 106, 79);
            btnLogin.Font = new Font("Microsoft Sans Serif", 11F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(199, 272);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 44);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblForgotPass
            // 
            lblForgotPass.AutoSize = true;
            lblForgotPass.LinkColor = Color.MediumSeaGreen;
            lblForgotPass.Location = new Point(323, 207);
            lblForgotPass.Name = "lblForgotPass";
            lblForgotPass.Size = new Size(118, 20);
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
            lblPassword.Location = new Point(50, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(124, 29);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "password:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 14F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(49, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(126, 29);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(176, 172);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(255, 27);
            txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(176, 112);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(255, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblAccLogin
            // 
            lblAccLogin.AutoSize = true;
            lblAccLogin.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblAccLogin.ForeColor = Color.White;
            lblAccLogin.Location = new Point(143, 12);
            lblAccLogin.Name = "lblAccLogin";
            lblAccLogin.Size = new Size(269, 42);
            lblAccLogin.TabIndex = 0;
            lblAccLogin.Text = "Account Login";
            // 
            // guna2Button2
            // 
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Red;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(923, 0);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.PressedColor = Color.IndianRed;
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(61, 41);
            guna2Button2.TabIndex = 2;
            guna2Button2.Text = "X";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.TargetForm = this;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 621);
            Controls.Add(panel1);
            Controls.Add(panelBase);
            FormBorderStyle = FormBorderStyle.None;
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}