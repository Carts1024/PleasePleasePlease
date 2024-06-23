namespace Mirai_Paradise_Hotel
{
    partial class CreateAccount
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
            panel1 = new Panel();
            buttonBack = new Button();
            panel2 = new Panel();
            comboBoxAccountType = new ComboBox();
            labelErrorAccountExist = new Label();
            labelErrorPassword = new Label();
            labelErrorUsername = new Label();
            textBoxConfirmPassword = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnCreateAccount = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 106, 79);
            panel1.Controls.Add(buttonBack);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 644);
            panel1.TabIndex = 0;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(158, 93);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(86, 31);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBoxAccountType);
            panel2.Controls.Add(labelErrorAccountExist);
            panel2.Controls.Add(labelErrorPassword);
            panel2.Controls.Add(labelErrorUsername);
            panel2.Controls.Add(textBoxConfirmPassword);
            panel2.Controls.Add(textBoxPassword);
            panel2.Controls.Add(textBoxUsername);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnCreateAccount);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(158, 132);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(655, 396);
            panel2.TabIndex = 0;
            // 
            // comboBoxAccountType
            // 
            comboBoxAccountType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAccountType.FormattingEnabled = true;
            comboBoxAccountType.Location = new Point(62, 215);
            comboBoxAccountType.Margin = new Padding(3, 4, 3, 4);
            comboBoxAccountType.Name = "comboBoxAccountType";
            comboBoxAccountType.Size = new Size(218, 32);
            comboBoxAccountType.TabIndex = 23;
            // 
            // labelErrorAccountExist
            // 
            labelErrorAccountExist.AutoSize = true;
            labelErrorAccountExist.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorAccountExist.ForeColor = Color.Red;
            labelErrorAccountExist.Location = new Point(196, 275);
            labelErrorAccountExist.Name = "labelErrorAccountExist";
            labelErrorAccountExist.Size = new Size(261, 20);
            labelErrorAccountExist.TabIndex = 22;
            labelErrorAccountExist.Text = "Account already exist in the system.";
            labelErrorAccountExist.Visible = false;
            // 
            // labelErrorPassword
            // 
            labelErrorPassword.AutoSize = true;
            labelErrorPassword.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorPassword.ForeColor = Color.Red;
            labelErrorPassword.Location = new Point(213, 275);
            labelErrorPassword.Name = "labelErrorPassword";
            labelErrorPassword.Size = new Size(224, 20);
            labelErrorPassword.TabIndex = 21;
            labelErrorPassword.Text = "Please confirm your password.";
            labelErrorPassword.Visible = false;
            // 
            // labelErrorUsername
            // 
            labelErrorUsername.AutoSize = true;
            labelErrorUsername.Font = new Font("SF Pro Display", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelErrorUsername.ForeColor = Color.Red;
            labelErrorUsername.Location = new Point(234, 275);
            labelErrorUsername.Name = "labelErrorUsername";
            labelErrorUsername.Size = new Size(179, 20);
            labelErrorUsername.TabIndex = 20;
            labelErrorUsername.Text = "Username not available.";
            labelErrorUsername.Visible = false;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(375, 215);
            textBoxConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(218, 31);
            textBoxConfirmPassword.TabIndex = 19;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(375, 116);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(218, 31);
            textBoxPassword.TabIndex = 18;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(62, 116);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(218, 31);
            textBoxUsername.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SF Pro Display", 10F);
            label6.Location = new Point(58, 188);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 14;
            label6.Text = "Account Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 10F);
            label5.Location = new Point(375, 188);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 13;
            label5.Text = "Confirm Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 10F);
            label4.Location = new Point(375, 90);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 12;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 10F);
            label3.Location = new Point(58, 90);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 11;
            label3.Text = "Username:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(45, 106, 79);
            btnCreateAccount.Font = new Font("SF Pro Display", 11F);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(249, 309);
            btnCreateAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(145, 53);
            btnCreateAccount.TabIndex = 10;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 106, 79);
            label1.Location = new Point(183, 13);
            label1.Name = "label1";
            label1.Size = new Size(313, 44);
            label1.TabIndex = 0;
            label1.Text = "Create an Account";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 644);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mirai Paradise Hotel";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnCreateAccount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox textBoxConfirmPassword;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelErrorUsername;
        private Label labelErrorAccountExist;
        private Label labelErrorPassword;
        private ComboBox comboBoxAccountType;
        private Button buttonBack;
    }
}