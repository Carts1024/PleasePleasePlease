namespace Mirai_Paradise_Hotel
{
    partial class Details_Bookings
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2DataGridViewDetailsBookings = new Guna.UI2.WinForms.Guna2DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridViewDetailsBookings).BeginInit();
            SuspendLayout();
            // 
            // guna2DataGridViewDetailsBookings
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridViewDetailsBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridViewDetailsBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridViewDetailsBookings.ColumnHeadersHeight = 17;
            guna2DataGridViewDetailsBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridViewDetailsBookings.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridViewDetailsBookings.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridViewDetailsBookings.Dock = DockStyle.Fill;
            guna2DataGridViewDetailsBookings.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewDetailsBookings.Location = new Point(0, 0);
            guna2DataGridViewDetailsBookings.Name = "guna2DataGridViewDetailsBookings";
            guna2DataGridViewDetailsBookings.RowHeadersVisible = false;
            guna2DataGridViewDetailsBookings.Size = new Size(688, 450);
            guna2DataGridViewDetailsBookings.TabIndex = 0;
            guna2DataGridViewDetailsBookings.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridViewDetailsBookings.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridViewDetailsBookings.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridViewDetailsBookings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridViewDetailsBookings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridViewDetailsBookings.ThemeStyle.BackColor = Color.White;
            guna2DataGridViewDetailsBookings.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewDetailsBookings.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridViewDetailsBookings.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridViewDetailsBookings.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridViewDetailsBookings.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridViewDetailsBookings.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridViewDetailsBookings.ThemeStyle.HeaderStyle.Height = 17;
            guna2DataGridViewDetailsBookings.ThemeStyle.ReadOnly = false;
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridViewDetailsBookings.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // Column1
            // 
            Column1.HeaderText = "Guest Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Room No";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Check In Date";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Check In Time";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Check Out Date";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Check Out Time";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Details_Bookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(688, 450);
            Controls.Add(guna2DataGridViewDetailsBookings);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Details_Bookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)guna2DataGridViewDetailsBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridViewDetailsBookings;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}