namespace PleasePleasePlease
{
    partial class UC_Accounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Accounts));
            panel1 = new Panel();
            panel4 = new Panel();
            buttonAddAcc = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 999);
            panel1.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(buttonAddAcc);
            panel4.Location = new Point(67, 128);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1083, 826);
            panel4.TabIndex = 18;
            // 
            // buttonAddAcc
            // 
            buttonAddAcc.BackColor = Color.FromArgb(45, 106, 79);
            buttonAddAcc.FlatStyle = FlatStyle.System;
            buttonAddAcc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddAcc.Location = new Point(870, 714);
            buttonAddAcc.Margin = new Padding(3, 4, 3, 4);
            buttonAddAcc.Name = "buttonAddAcc";
            buttonAddAcc.Size = new Size(153, 55);
            buttonAddAcc.TabIndex = 2;
            buttonAddAcc.Text = "Add Account";
            buttonAddAcc.UseVisualStyleBackColor = false;
            buttonAddAcc.Click += buttonAddAcc_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(56, 59);
            label9.Name = "label9";
            label9.Size = new Size(209, 52);
            label9.TabIndex = 11;
            label9.Text = "Accounts";
            // 
            // UC_Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Accounts";
            Size = new Size(1230, 999);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Panel panel6;
        private TextBox textBox1;
        private Label label2;
        private Panel panel7;
        private TextBox textBox2;
        private Label label3;
        private Panel panel8;
        private TextBox textBox3;
        private Label label4;
        private Panel panel9;
        private ComboBox comboBox1;
        private Label label5;
        private Button buttonAddAcc;
        private Panel panel10;
        private ComboBox comboBox2;
        private Label label6;
        private Panel panel11;
        private TextBox textBox4;
        private Label label7;
        private Panel panel12;
        private Label label8;
        private Label label9;
    }
}
