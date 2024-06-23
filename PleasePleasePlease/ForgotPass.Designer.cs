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
            panel2 = new Panel();
            buttonBack = new Button();
            panel1 = new Panel();
            lblErrorResetPass = new Label();
            btnResetPass = new Button();
            txtConfirmPass = new TextBox();
            txtNewPass = new TextBox();
            lblConfirmPass = new Label();
            lblNewPass = new Label();
            lblResetPass = new Label();
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
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 313);
            panel2.TabIndex = 1;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(75, 36);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 23);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblErrorResetPass);
            panel1.Controls.Add(btnResetPass);
            panel1.Controls.Add(txtConfirmPass);
            panel1.Controls.Add(txtNewPass);
            panel1.Controls.Add(lblConfirmPass);
            panel1.Controls.Add(lblNewPass);
            panel1.Controls.Add(lblResetPass);
            panel1.Location = new Point(75, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(384, 207);
            panel1.TabIndex = 1;
            // 
            // lblErrorResetPass
            // 
            lblErrorResetPass.AutoSize = true;
            lblErrorResetPass.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorResetPass.ForeColor = Color.Red;
            lblErrorResetPass.Location = new Point(113, 145);
            lblErrorResetPass.Name = "lblErrorResetPass";
            lblErrorResetPass.Size = new Size(174, 15);
            lblErrorResetPass.TabIndex = 10;
            lblErrorResetPass.Text = "Please confirm your password.";
            lblErrorResetPass.Visible = false;
            // 
            // btnResetPass
            // 
            btnResetPass.BackColor = Color.FromArgb(45, 106, 79);
            btnResetPass.Font = new Font("Microsoft Sans Serif", 11F);
            btnResetPass.ForeColor = Color.White;
            btnResetPass.Location = new Point(147, 162);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(93, 33);
            btnResetPass.TabIndex = 9;
            btnResetPass.Text = "Confirm";
            btnResetPass.UseVisualStyleBackColor = false;
            btnResetPass.Click += btnLogin_Click;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(163, 107);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(178, 23);
            txtConfirmPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(163, 66);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(178, 23);
            txtNewPass.TabIndex = 3;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Microsoft Sans Serif", 10F);
            lblConfirmPass.Location = new Point(39, 109);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(125, 17);
            lblConfirmPass.TabIndex = 2;
            lblConfirmPass.Text = "Confirm Password:";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Microsoft Sans Serif", 10F);
            lblNewPass.ForeColor = Color.Black;
            lblNewPass.Location = new Point(58, 68);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(104, 17);
            lblNewPass.TabIndex = 1;
            lblNewPass.Text = "New Password:";
            // 
            // lblResetPass
            // 
            lblResetPass.AutoSize = true;
            lblResetPass.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold);
            lblResetPass.ForeColor = Color.FromArgb(45, 106, 79);
            lblResetPass.Location = new Point(79, 9);
            lblResetPass.Name = "lblResetPass";
            lblResetPass.Size = new Size(246, 36);
            lblResetPass.TabIndex = 0;
            lblResetPass.Text = "Reset Password";
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 313);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "ForgotPass";
            Text = "s";
            WindowState = FormWindowState.Minimized;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button btnResetPass;
        private TextBox txtConfirmPass;
        private TextBox txtNewPass;
        private Label lblConfirmPass;
        private Label lblNewPass;
        private Label lblResetPass;
        private Label lblErrorResetPass;
        private Button buttonBack;
    }
}