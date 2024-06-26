namespace Mirai_Paradise_Hotel
{
    partial class Details_BookingHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Details_BookingHistory));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelBase = new Panel();
            panelSearch = new Panel();
            dateTimePickerBookingHistory = new DateTimePicker();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            dataGridViewBookingHistory = new Guna.UI2.WinForms.Guna2DataGridView();
            ColumnGuestName = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panelBase.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookingHistory).BeginInit();
            SuspendLayout();
            // 
            // panelBase
            // 
            panelBase.AutoScroll = true;
            panelBase.BackColor = Color.FromArgb(45, 106, 79);
            panelBase.BackgroundImageLayout = ImageLayout.Zoom;
            panelBase.Controls.Add(dataGridViewBookingHistory);
            panelBase.Controls.Add(panelSearch);
            panelBase.Dock = DockStyle.Fill;
            panelBase.Location = new Point(0, 0);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(976, 473);
            panelBase.TabIndex = 21;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(dateTimePickerBookingHistory);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(65, 13);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(835, 53);
            panelSearch.TabIndex = 16;
            // 
            // dateTimePickerBookingHistory
            // 
            dateTimePickerBookingHistory.Location = new Point(677, 12);
            dateTimePickerBookingHistory.Name = "dateTimePickerBookingHistory";
            dateTimePickerBookingHistory.Size = new Size(147, 23);
            dateTimePickerBookingHistory.TabIndex = 19;
            // 
            // buttonSearchIcon
            // 
            buttonSearchIcon.BackgroundImage = (Image)resources.GetObject("buttonSearchIcon.BackgroundImage");
            buttonSearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchIcon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchIcon.Location = new Point(535, 12);
            buttonSearchIcon.Name = "buttonSearchIcon";
            buttonSearchIcon.Size = new Size(28, 27);
            buttonSearchIcon.TabIndex = 3;
            buttonSearchIcon.UseVisualStyleBackColor = true;
            // 
            // textBoxAddressSearch
            // 
            textBoxAddressSearch.Enabled = false;
            textBoxAddressSearch.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressSearch.ForeColor = SystemColors.WindowFrame;
            textBoxAddressSearch.Location = new Point(1, 12);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(508, 27);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // dataGridViewBookingHistory
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewBookingHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBookingHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBookingHistory.ColumnHeadersHeight = 17;
            dataGridViewBookingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBookingHistory.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestName, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewBookingHistory.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBookingHistory.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewBookingHistory.Location = new Point(65, 72);
            dataGridViewBookingHistory.Name = "dataGridViewBookingHistory";
            dataGridViewBookingHistory.RowHeadersVisible = false;
            dataGridViewBookingHistory.Size = new Size(835, 366);
            dataGridViewBookingHistory.TabIndex = 19;
            dataGridViewBookingHistory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dataGridViewBookingHistory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dataGridViewBookingHistory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dataGridViewBookingHistory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dataGridViewBookingHistory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dataGridViewBookingHistory.ThemeStyle.BackColor = Color.White;
            dataGridViewBookingHistory.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dataGridViewBookingHistory.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewBookingHistory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewBookingHistory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBookingHistory.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dataGridViewBookingHistory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewBookingHistory.ThemeStyle.HeaderStyle.Height = 17;
            dataGridViewBookingHistory.ThemeStyle.ReadOnly = false;
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.Height = 25;
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewBookingHistory.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ColumnGuestName
            // 
            ColumnGuestName.HeaderText = "Guest Name";
            ColumnGuestName.Name = "ColumnGuestName";
            ColumnGuestName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Room No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Check In Date";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Check In Time";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Check Out Date";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Check Out Time";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Details_BookingHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 473);
            Controls.Add(panelBase);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Details_BookingHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Details_BookingHistory";
            panelBase.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookingHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBase;
        private Panel panelSearch;
        private DateTimePicker dateTimePickerBookingHistory;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewBookingHistory;
        private DataGridViewTextBoxColumn ColumnGuestName;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}