namespace PleasePleasePlease
{
    partial class UC_Booking2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Booking2));
            panel9 = new Panel();
            panel11 = new Panel();
            panelFilters = new Panel();
            comboBoxFilterRoomNo = new ComboBox();
            dataGridView1 = new DataGridView();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnRoomNo = new DataGridViewTextBoxColumn();
            ColumnCheckInDate = new DataGridViewTextBoxColumn();
            ColumnCheckInTime = new DataGridViewTextBoxColumn();
            ColumnCheckOutDate = new DataGridViewTextBoxColumn();
            ColumnCheckOutTime = new DataGridViewTextBoxColumn();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            label7 = new Label();
            panelAddaGuest = new Panel();
            labelAddBook = new Label();
            panel10 = new Panel();
            label6 = new Label();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(panelAddaGuest);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1230, 999);
            panel9.TabIndex = 21;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(76, 149, 108);
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Controls.Add(panelFilters);
            panel11.Controls.Add(dataGridView1);
            panel11.Controls.Add(panelSearch);
            panel11.Location = new Point(62, 164);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1110, 791);
            panel11.TabIndex = 19;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomNo);
            panelFilters.Location = new Point(144, 136);
            panelFilters.Margin = new Padding(3, 4, 3, 4);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(848, 67);
            panelFilters.TabIndex = 18;
            // 
            // comboBoxFilterRoomNo
            // 
            comboBoxFilterRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomNo.FormattingEnabled = true;
            comboBoxFilterRoomNo.Location = new Point(15, 13);
            comboBoxFilterRoomNo.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterRoomNo.Name = "comboBoxFilterRoomNo";
            comboBoxFilterRoomNo.Size = new Size(127, 32);
            comboBoxFilterRoomNo.TabIndex = 9;
            comboBoxFilterRoomNo.Text = "[template]";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnRoomNo, ColumnCheckInDate, ColumnCheckInTime, ColumnCheckOutDate, ColumnCheckOutTime });
            dataGridView1.Location = new Point(81, 233);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(942, 347);
            dataGridView1.TabIndex = 17;
            // 
            // ColumnGuestID
            // 
            ColumnGuestID.HeaderText = "Guest ID";
            ColumnGuestID.MinimumWidth = 6;
            ColumnGuestID.Name = "ColumnGuestID";
            ColumnGuestID.ReadOnly = true;
            ColumnGuestID.Resizable = DataGridViewTriState.True;
            ColumnGuestID.Width = 130;
            // 
            // ColumnRoomNo
            // 
            ColumnRoomNo.HeaderText = "Room No.";
            ColumnRoomNo.MinimumWidth = 6;
            ColumnRoomNo.Name = "ColumnRoomNo";
            ColumnRoomNo.ReadOnly = true;
            ColumnRoomNo.Resizable = DataGridViewTriState.True;
            ColumnRoomNo.Width = 130;
            // 
            // ColumnCheckInDate
            // 
            ColumnCheckInDate.HeaderText = "Check-In Date";
            ColumnCheckInDate.MinimumWidth = 6;
            ColumnCheckInDate.Name = "ColumnCheckInDate";
            ColumnCheckInDate.ReadOnly = true;
            ColumnCheckInDate.Width = 130;
            // 
            // ColumnCheckInTime
            // 
            ColumnCheckInTime.HeaderText = "Check-In Time";
            ColumnCheckInTime.MinimumWidth = 6;
            ColumnCheckInTime.Name = "ColumnCheckInTime";
            ColumnCheckInTime.ReadOnly = true;
            ColumnCheckInTime.Width = 130;
            // 
            // ColumnCheckOutDate
            // 
            ColumnCheckOutDate.HeaderText = "Check-Out Date";
            ColumnCheckOutDate.MinimumWidth = 6;
            ColumnCheckOutDate.Name = "ColumnCheckOutDate";
            ColumnCheckOutDate.Width = 130;
            // 
            // ColumnCheckOutTime
            // 
            ColumnCheckOutTime.HeaderText = "Check-Out Time";
            ColumnCheckOutTime.MinimumWidth = 6;
            ColumnCheckOutTime.Name = "ColumnCheckOutTime";
            ColumnCheckOutTime.Resizable = DataGridViewTriState.True;
            ColumnCheckOutTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnCheckOutTime.Width = 130;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(201, 53);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(713, 71);
            panelSearch.TabIndex = 16;
            // 
            // buttonMore
            // 
            buttonMore.BackgroundImage = (Image)resources.GetObject("buttonMore.BackgroundImage");
            buttonMore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMore.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMore.Location = new Point(650, 16);
            buttonMore.Margin = new Padding(3, 4, 3, 4);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(32, 36);
            buttonMore.TabIndex = 4;
            buttonMore.UseVisualStyleBackColor = true;
            // 
            // buttonSearchIcon
            // 
            buttonSearchIcon.BackgroundImage = (Image)resources.GetObject("buttonSearchIcon.BackgroundImage");
            buttonSearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchIcon.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchIcon.Location = new Point(611, 16);
            buttonSearchIcon.Margin = new Padding(3, 4, 3, 4);
            buttonSearchIcon.Name = "buttonSearchIcon";
            buttonSearchIcon.Size = new Size(32, 36);
            buttonSearchIcon.TabIndex = 3;
            buttonSearchIcon.UseVisualStyleBackColor = true;
            // 
            // textBoxAddressSearch
            // 
            textBoxAddressSearch.Enabled = false;
            textBoxAddressSearch.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressSearch.ForeColor = SystemColors.WindowFrame;
            textBoxAddressSearch.Location = new Point(1, 16);
            textBoxAddressSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(580, 31);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(59, 44);
            label7.Name = "label7";
            label7.Size = new Size(440, 53);
            label7.TabIndex = 20;
            label7.Text = "Booking Management";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.MediumSeaGreen;
            panelAddaGuest.Controls.Add(labelAddBook);
            panelAddaGuest.Location = new Point(62, 123);
            panelAddaGuest.Margin = new Padding(3, 4, 3, 4);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(175, 43);
            panelAddaGuest.TabIndex = 21;
            // 
            // labelAddBook
            // 
            labelAddBook.AutoSize = true;
            labelAddBook.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddBook.Location = new Point(10, 7);
            labelAddBook.Name = "labelAddBook";
            labelAddBook.Size = new Size(163, 29);
            labelAddBook.TabIndex = 8;
            labelAddBook.Text = "Add a Booking";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(76, 149, 108);
            panel10.Controls.Add(label6);
            panel10.Location = new Point(246, 123);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(194, 43);
            panel10.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 7);
            label6.Name = "label6";
            label6.Size = new Size(177, 29);
            label6.TabIndex = 9;
            label6.Text = "List of Bookings";
            // 
            // UC_Booking2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Booking2";
            Size = new Size(1230, 999);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Panel panel11;
        private Panel panelFilters;
        private ComboBox comboBoxFilterRoomNo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnGuestID;
        private DataGridViewTextBoxColumn ColumnRoomNo;
        private DataGridViewTextBoxColumn ColumnCheckInDate;
        private DataGridViewTextBoxColumn ColumnCheckInTime;
        private DataGridViewTextBoxColumn ColumnCheckOutDate;
        private DataGridViewTextBoxColumn ColumnCheckOutTime;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private Label label7;
        private Panel panelAddaGuest;
        private Label labelAddBook;
        private Panel panel10;
        private Label label6;
    }
}
