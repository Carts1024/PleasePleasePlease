namespace Mirai_Paradise_Hotel
{
    partial class Booking_Update
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel4 = new Panel();
            label7 = new Label();
            GradButtonUpdateBook = new Guna.UI2.WinForms.Guna2GradientButton();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel11 = new Panel();
            this.RoomNbr_ud = new Guna.UI2.WinForms.Guna2TextBox();
            label8 = new Label();
            checkOutDate_ud = new DateTimePicker();
            checkOutTime_ud = new DateTimePicker();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(GradButtonUpdateBook);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel11);
            panel4.Location = new Point(-9, -26);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1083, 747);
            panel4.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 39);
            label7.Name = "label7";
            label7.Size = new Size(329, 53);
            label7.TabIndex = 29;
            label7.Text = "Update Booking";
            // 
            // GradButtonUpdateBook
            // 
            GradButtonUpdateBook.Animated = true;
            GradButtonUpdateBook.AutoRoundedCorners = true;
            GradButtonUpdateBook.BackColor = Color.Transparent;
            GradButtonUpdateBook.BorderRadius = 39;
            GradButtonUpdateBook.CustomizableEdges = customizableEdges5;
            GradButtonUpdateBook.DisabledState.BorderColor = Color.DarkGray;
            GradButtonUpdateBook.DisabledState.CustomBorderColor = Color.DarkGray;
            GradButtonUpdateBook.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GradButtonUpdateBook.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            GradButtonUpdateBook.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GradButtonUpdateBook.FillColor = Color.FromArgb(32, 191, 85);
            GradButtonUpdateBook.FillColor2 = Color.SteelBlue;
            GradButtonUpdateBook.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradButtonUpdateBook.ForeColor = Color.White;
            GradButtonUpdateBook.Location = new Point(790, 596);
            GradButtonUpdateBook.Margin = new Padding(3, 4, 3, 4);
            GradButtonUpdateBook.Name = "GradButtonUpdateBook";
            GradButtonUpdateBook.ShadowDecoration.CustomizableEdges = customizableEdges6;
            GradButtonUpdateBook.Size = new Size(230, 81);
            GradButtonUpdateBook.TabIndex = 28;
            GradButtonUpdateBook.Text = "Update Booking";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkOutTime_ud);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(149, 491);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 103);
            panel1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 8);
            label5.Name = "label5";
            label5.Size = new Size(180, 29);
            label5.TabIndex = 0;
            label5.Text = "Check Out Time";
            // 
            // panel2
            // 
            panel2.Controls.Add(checkOutDate_ud);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(149, 370);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 100);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(179, 29);
            label1.TabIndex = 0;
            label1.Text = "Check Out Date";
            // 
            // panel11
            // 
            panel11.Controls.Add(this.RoomNbr_ud);
            panel11.Controls.Add(label8);
            panel11.Location = new Point(149, 258);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(282, 95);
            panel11.TabIndex = 2;
            // 
            // RoomNbr_ud
            // 
            this.RoomNbr_ud.AutoRoundedCorners = true;
            this.RoomNbr_ud.BorderRadius = 21;
            this.RoomNbr_ud.CustomizableEdges = customizableEdges7;
            this.RoomNbr_ud.DefaultText = "";
            this.RoomNbr_ud.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            this.RoomNbr_ud.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            this.RoomNbr_ud.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            this.RoomNbr_ud.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            this.RoomNbr_ud.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            this.RoomNbr_ud.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.RoomNbr_ud.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            this.RoomNbr_ud.Location = new Point(10, 40);
            this.RoomNbr_ud.Margin = new Padding(5);
            this.RoomNbr_ud.Name = "RoomNbr_ud";
            this.RoomNbr_ud.PasswordChar = '\0';
            this.RoomNbr_ud.PlaceholderText = "";
            this.RoomNbr_ud.SelectedText = "";
            this.RoomNbr_ud.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.RoomNbr_ud.Size = new Size(233, 44);
            this.RoomNbr_ud.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 8);
            label8.Name = "label8";
            label8.Size = new Size(114, 29);
            label8.TabIndex = 0;
            label8.Text = "Room No.";
            // 
            // checkOutDate_ud
            // 
            checkOutDate_ud.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutDate_ud.Location = new Point(10, 53);
            checkOutDate_ud.Margin = new Padding(3, 4, 3, 4);
            checkOutDate_ud.Name = "checkOutDate_ud";
            checkOutDate_ud.Size = new Size(228, 31);
            checkOutDate_ud.TabIndex = 8;
            checkOutDate_ud.Value = new DateTime(2024, 6, 28, 17, 5, 54, 0);
            // 
            // checkOutTime_ud
            // 
            checkOutTime_ud.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOutTime_ud.Format = DateTimePickerFormat.Time;
            checkOutTime_ud.Location = new Point(10, 57);
            checkOutTime_ud.Margin = new Padding(3, 4, 3, 4);
            checkOutTime_ud.Name = "checkOutTime_ud";
            checkOutTime_ud.Size = new Size(228, 31);
            checkOutTime_ud.TabIndex = 9;
            checkOutTime_ud.Value = new DateTime(2024, 6, 28, 17, 5, 54, 0);
            // 
            // Booking_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 695);
            Controls.Add(panel4);
            Name = "Booking_Update";
            Text = "Booking_Update";
            Load += Booking_Update_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Label label7;
        private Panel panel12;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRoomBedType;
        private Label label10;
        private Guna.UI2.WinForms.Guna2GradientButton GradButtonUpdateBook;
        private Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMaxCapacity;
        private Label label2;
        private Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox textBoxFloorNo;
        private Label label3;
        private Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox textBoxRoomRate;
        private Label label4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxRoomStatus;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private Panel panel11;
        private Guna.UI2.WinForms.Guna2TextBox textBoxRoomNo;
        private Label label8;
        private DateTimePicker checkOutDate_ud;
        private DateTimePicker checkOutTime_ud;
    }
}