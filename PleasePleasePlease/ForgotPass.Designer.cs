namespace Mirai_Paradise_Hotel
{
    partial class ForgotPass
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            buttonBack = new Button();
            panel1 = new Panel();
            conPass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            newPass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            lblErrorResetPass = new Label();
            btnResetPass = new Button();
            lblConfirmPass = new Label();
            lblNewPass = new Label();
            lblResetPass = new Label();
            username_txt = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 106, 79);
            panel2.Controls.Add(buttonBack);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 489);
            panel2.TabIndex = 1;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(86, 48);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(86, 31);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(username_txt);
            panel1.Controls.Add(conPass_txt);
            panel1.Controls.Add(newPass_txt);
            panel1.Controls.Add(lblErrorResetPass);
            panel1.Controls.Add(btnResetPass);
            panel1.Controls.Add(lblConfirmPass);
            panel1.Controls.Add(lblNewPass);
            panel1.Controls.Add(lblResetPass);
            panel1.Location = new Point(86, 87);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 389);
            panel1.TabIndex = 1;
            // 
            // conPass_txt
            // 
            conPass_txt.AutoRoundedCorners = true;
            conPass_txt.BorderRadius = 14;
            conPass_txt.CustomizableEdges = customizableEdges3;
            conPass_txt.DefaultText = "";
            conPass_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            conPass_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            conPass_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            conPass_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            conPass_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            conPass_txt.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conPass_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            conPass_txt.Location = new Point(186, 211);
            conPass_txt.Margin = new Padding(5);
            conPass_txt.Name = "conPass_txt";
            conPass_txt.PasswordChar = '\0';
            conPass_txt.PlaceholderText = "";
            conPass_txt.SelectedText = "";
            conPass_txt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            conPass_txt.Size = new Size(235, 31);
            conPass_txt.TabIndex = 37;
            // 
            // newPass_txt
            // 
            newPass_txt.AutoRoundedCorners = true;
            newPass_txt.BorderRadius = 14;
            newPass_txt.CustomizableEdges = customizableEdges5;
            newPass_txt.DefaultText = "";
            newPass_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            newPass_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            newPass_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            newPass_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            newPass_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            newPass_txt.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPass_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            newPass_txt.Location = new Point(186, 158);
            newPass_txt.Margin = new Padding(5);
            newPass_txt.Name = "newPass_txt";
            newPass_txt.PasswordChar = '\0';
            newPass_txt.PlaceholderText = "";
            newPass_txt.SelectedText = "";
            newPass_txt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            newPass_txt.Size = new Size(235, 31);
            newPass_txt.TabIndex = 36;
            // 
            // lblErrorResetPass
            // 
            lblErrorResetPass.AutoSize = true;
            lblErrorResetPass.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorResetPass.ForeColor = Color.Red;
            lblErrorResetPass.Location = new Point(130, 276);
            lblErrorResetPass.Name = "lblErrorResetPass";
            lblErrorResetPass.Size = new Size(213, 18);
            lblErrorResetPass.TabIndex = 10;
            lblErrorResetPass.Text = "Please confirm your password.";
            lblErrorResetPass.Visible = false;
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = Color.FromArgb(45, 106, 79);
            btnResetPass.Font = new Font("Microsoft Sans Serif", 11F);
            btnResetPass.ForeColor = Color.White;
            btnResetPass.Location = new Point(168, 307);
            btnResetPass.Margin = new Padding(3, 4, 3, 4);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(106, 44);
            btnResetPass.TabIndex = 9;
            btnResetPass.Text = "Confirm";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += btnLogin_Click;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Microsoft Sans Serif", 10F);
            lblConfirmPass.Location = new Point(31, 211);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(152, 20);
            lblConfirmPass.TabIndex = 2;
            lblConfirmPass.Text = "Confirm Password:";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Microsoft Sans Serif", 10F);
            lblNewPass.ForeColor = Color.Black;
            lblNewPass.Location = new Point(31, 158);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(126, 20);
            lblNewPass.TabIndex = 1;
            lblNewPass.Text = "New Password:";
            // 
            // lblResetPass
            // 
            lblResetPass.AutoSize = true;
            lblResetPass.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblResetPass.ForeColor = Color.FromArgb(45, 106, 79);
            lblResetPass.Location = new Point(90, 12);
            lblResetPass.Name = "lblResetPass";
            lblResetPass.Size = new Size(305, 42);
            lblResetPass.TabIndex = 0;
            lblResetPass.Text = "Reset Password";
            // 
            // username_txt
            // 
            username_txt.AutoRoundedCorners = true;
            username_txt.BorderRadius = 14;
            username_txt.CustomizableEdges = customizableEdges1;
            username_txt.DefaultText = "";
            username_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            username_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            username_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            username_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            username_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txt.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            username_txt.Location = new Point(186, 103);
            username_txt.Margin = new Padding(5);
            username_txt.Name = "username_txt";
            username_txt.PasswordChar = '\0';
            username_txt.PlaceholderText = "";
            username_txt.SelectedText = "";
            username_txt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            username_txt.Size = new Size(235, 31);
            username_txt.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(31, 103);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 39;
            label1.Text = "Username:";
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 489);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForgotPass";
            Text = "Forgot Password";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btnResetPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private Label lblResetPass;
        private Label lblErrorResetPass;
        private Button buttonBack;
        private Guna.UI2.WinForms.Guna2TextBox conPass_txt;
        private Guna.UI2.WinForms.Guna2TextBox newPass_txt;
        private Guna.UI2.WinForms.Guna2TextBox username_txt;
        private Label label1;
    }
}