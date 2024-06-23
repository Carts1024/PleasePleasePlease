namespace PleasePleasePlease
{
    partial class UC_Booking1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Booking1));
            panel9 = new Panel();
            panel11 = new Panel();
            panelListofBooking = new Panel();
            dataGridViewBooking = new DataGridView();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnRoomNo = new DataGridViewTextBoxColumn();
            ColumnCheckInDate = new DataGridViewTextBoxColumn();
            ColumnCheckInTime = new DataGridViewTextBoxColumn();
            ColumnCheckOutDate = new DataGridViewTextBoxColumn();
            ColumnCheckOutTime = new DataGridViewTextBoxColumn();
            panelSearch = new Panel();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            buttonAddBooking = new Button();
            panelCheckOutTime = new Panel();
            textBoxCheckOutTime = new TextBox();
            labelCheckOutTime = new Label();
            panelCheckInTime = new Panel();
            textBoxCheckInTime = new TextBox();
            label4 = new Label();
            panelRoomNo = new Panel();
            textBoxRoomNo = new TextBox();
            labelRoomNo = new Label();
            panelCheckOutDate = new Panel();
            dateTimePickerCheckout = new DateTimePicker();
            labelCheckOutDate = new Label();
            panelCheckInDate = new Panel();
            dateTimePickerCheckIn = new DateTimePicker();
            labelCheckInDate = new Label();
            panelGuestID = new Panel();
            textBoxGuestID = new TextBox();
            labelGuestID = new Label();
            label7 = new Label();
            panelAddaGuest = new Panel();
            labelAddBook = new Label();
            panel10 = new Panel();
            labelListofBooking = new Label();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panelListofBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).BeginInit();
            panelSearch.SuspendLayout();
            panelCheckOutTime.SuspendLayout();
            panelCheckInTime.SuspendLayout();
            panelRoomNo.SuspendLayout();
            panelCheckOutDate.SuspendLayout();
            panelCheckInDate.SuspendLayout();
            panelGuestID.SuspendLayout();
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
            panel9.Name = "panel9";
            panel9.Size = new Size(1076, 749);
            panel9.TabIndex = 22;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(76, 149, 108);
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Controls.Add(panelListofBooking);
            panel11.Controls.Add(buttonAddBooking);
            panel11.Controls.Add(panelCheckOutTime);
            panel11.Controls.Add(panelCheckInTime);
            panel11.Controls.Add(panelRoomNo);
            panel11.Controls.Add(panelCheckOutDate);
            panel11.Controls.Add(panelCheckInDate);
            panel11.Controls.Add(panelGuestID);
            panel11.Location = new Point(54, 123);
            panel11.Name = "panel11";
            panel11.Size = new Size(971, 593);
            panel11.TabIndex = 19;
            // 
            // panelListofBooking
            // 
            panelListofBooking.BackColor = Color.FromArgb(76, 149, 108);
            panelListofBooking.BackgroundImageLayout = ImageLayout.Zoom;
            panelListofBooking.Controls.Add(dataGridViewBooking);
            panelListofBooking.Controls.Add(panelSearch);
            panelListofBooking.Location = new Point(0, 0);
            panelListofBooking.Name = "panelListofBooking";
            panelListofBooking.Size = new Size(971, 593);
            panelListofBooking.TabIndex = 20;
            panelListofBooking.Visible = false;
            // 
            // dataGridViewBooking
            // 
            dataGridViewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooking.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnRoomNo, ColumnCheckInDate, ColumnCheckInTime, ColumnCheckOutDate, ColumnCheckOutTime });
            dataGridViewBooking.Location = new Point(69, 134);
            dataGridViewBooking.Name = "dataGridViewBooking";
            dataGridViewBooking.Size = new Size(823, 260);
            dataGridViewBooking.TabIndex = 17;
            // 
            // ColumnGuestID
            // 
            ColumnGuestID.HeaderText = "Guest ID";
            ColumnGuestID.Name = "ColumnGuestID";
            ColumnGuestID.ReadOnly = true;
            ColumnGuestID.Resizable = DataGridViewTriState.True;
            ColumnGuestID.Width = 130;
            // 
            // ColumnRoomNo
            // 
            ColumnRoomNo.HeaderText = "Room No.";
            ColumnRoomNo.Name = "ColumnRoomNo";
            ColumnRoomNo.ReadOnly = true;
            ColumnRoomNo.Resizable = DataGridViewTriState.True;
            ColumnRoomNo.Width = 130;
            // 
            // ColumnCheckInDate
            // 
            ColumnCheckInDate.HeaderText = "Check-In Date";
            ColumnCheckInDate.Name = "ColumnCheckInDate";
            ColumnCheckInDate.ReadOnly = true;
            ColumnCheckInDate.Width = 130;
            // 
            // ColumnCheckInTime
            // 
            ColumnCheckInTime.HeaderText = "Check-In Time";
            ColumnCheckInTime.Name = "ColumnCheckInTime";
            ColumnCheckInTime.ReadOnly = true;
            ColumnCheckInTime.Width = 130;
            // 
            // ColumnCheckOutDate
            // 
            ColumnCheckOutDate.HeaderText = "Check-Out Date";
            ColumnCheckOutDate.Name = "ColumnCheckOutDate";
            ColumnCheckOutDate.Width = 130;
            // 
            // ColumnCheckOutTime
            // 
            ColumnCheckOutTime.HeaderText = "Check-Out Time";
            ColumnCheckOutTime.Name = "ColumnCheckOutTime";
            ColumnCheckOutTime.Resizable = DataGridViewTriState.True;
            ColumnCheckOutTime.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnCheckOutTime.Width = 130;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(191, 19);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 16;
            // 
            // buttonSearchIcon
            // 
            buttonSearchIcon.BackgroundImage = (Image)resources.GetObject("buttonSearchIcon.BackgroundImage");
            buttonSearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchIcon.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchIcon.Location = new Point(535, 12);
            buttonSearchIcon.Name = "buttonSearchIcon";
            buttonSearchIcon.Size = new Size(28, 27);
            buttonSearchIcon.TabIndex = 3;
            buttonSearchIcon.UseVisualStyleBackColor = true;
            buttonSearchIcon.Click += buttonSearchIcon_Click;
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
            // buttonAddBooking
            // 
            buttonAddBooking.BackColor = Color.FromArgb(27, 67, 50);
            buttonAddBooking.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonAddBooking.FlatStyle = FlatStyle.Flat;
            buttonAddBooking.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddBooking.ForeColor = Color.White;
            buttonAddBooking.Location = new Point(747, 504);
            buttonAddBooking.Name = "buttonAddBooking";
            buttonAddBooking.Size = new Size(186, 49);
            buttonAddBooking.TabIndex = 10;
            buttonAddBooking.Text = "Add Booking";
            buttonAddBooking.UseVisualStyleBackColor = false;
            buttonAddBooking.Click += buttonAddBooking_Click;
            // 
            // panelCheckOutTime
            // 
            panelCheckOutTime.Controls.Add(textBoxCheckOutTime);
            panelCheckOutTime.Controls.Add(labelCheckOutTime);
            panelCheckOutTime.Location = new Point(589, 337);
            panelCheckOutTime.Name = "panelCheckOutTime";
            panelCheckOutTime.Size = new Size(226, 67);
            panelCheckOutTime.TabIndex = 7;
            // 
            // textBoxCheckOutTime
            // 
            textBoxCheckOutTime.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCheckOutTime.Location = new Point(9, 34);
            textBoxCheckOutTime.Name = "textBoxCheckOutTime";
            textBoxCheckOutTime.Size = new Size(199, 27);
            textBoxCheckOutTime.TabIndex = 1;
            // 
            // labelCheckOutTime
            // 
            labelCheckOutTime.AutoSize = true;
            labelCheckOutTime.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCheckOutTime.Location = new Point(9, 6);
            labelCheckOutTime.Name = "labelCheckOutTime";
            labelCheckOutTime.Size = new Size(152, 23);
            labelCheckOutTime.TabIndex = 0;
            labelCheckOutTime.Text = "Check-Out Time";
            // 
            // panelCheckInTime
            // 
            panelCheckInTime.Controls.Add(textBoxCheckInTime);
            panelCheckInTime.Controls.Add(label4);
            panelCheckInTime.Location = new Point(589, 239);
            panelCheckInTime.Name = "panelCheckInTime";
            panelCheckInTime.Size = new Size(226, 67);
            panelCheckInTime.TabIndex = 7;
            // 
            // textBoxCheckInTime
            // 
            textBoxCheckInTime.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCheckInTime.Location = new Point(9, 34);
            textBoxCheckInTime.Name = "textBoxCheckInTime";
            textBoxCheckInTime.Size = new Size(199, 27);
            textBoxCheckInTime.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 6);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 0;
            label4.Text = "Check-In Time";
            // 
            // panelRoomNo
            // 
            panelRoomNo.Controls.Add(textBoxRoomNo);
            panelRoomNo.Controls.Add(labelRoomNo);
            panelRoomNo.Location = new Point(589, 140);
            panelRoomNo.Name = "panelRoomNo";
            panelRoomNo.Size = new Size(226, 67);
            panelRoomNo.TabIndex = 7;
            // 
            // textBoxRoomNo
            // 
            textBoxRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRoomNo.Location = new Point(9, 34);
            textBoxRoomNo.Name = "textBoxRoomNo";
            textBoxRoomNo.Size = new Size(199, 27);
            textBoxRoomNo.TabIndex = 1;
            // 
            // labelRoomNo
            // 
            labelRoomNo.AutoSize = true;
            labelRoomNo.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomNo.Location = new Point(9, 6);
            labelRoomNo.Name = "labelRoomNo";
            labelRoomNo.Size = new Size(94, 23);
            labelRoomNo.TabIndex = 0;
            labelRoomNo.Text = "Room No.";
            // 
            // panelCheckOutDate
            // 
            panelCheckOutDate.Controls.Add(dateTimePickerCheckout);
            panelCheckOutDate.Controls.Add(labelCheckOutDate);
            panelCheckOutDate.Location = new Point(240, 337);
            panelCheckOutDate.Name = "panelCheckOutDate";
            panelCheckOutDate.Size = new Size(226, 67);
            panelCheckOutDate.TabIndex = 8;
            // 
            // dateTimePickerCheckout
            // 
            dateTimePickerCheckout.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerCheckout.Location = new Point(9, 34);
            dateTimePickerCheckout.Name = "dateTimePickerCheckout";
            dateTimePickerCheckout.Size = new Size(200, 27);
            dateTimePickerCheckout.TabIndex = 8;
            // 
            // labelCheckOutDate
            // 
            labelCheckOutDate.AutoSize = true;
            labelCheckOutDate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCheckOutDate.Location = new Point(9, 6);
            labelCheckOutDate.Name = "labelCheckOutDate";
            labelCheckOutDate.Size = new Size(150, 23);
            labelCheckOutDate.TabIndex = 0;
            labelCheckOutDate.Text = "Check-Out Date";
            // 
            // panelCheckInDate
            // 
            panelCheckInDate.Controls.Add(dateTimePickerCheckIn);
            panelCheckInDate.Controls.Add(labelCheckInDate);
            panelCheckInDate.Location = new Point(240, 239);
            panelCheckInDate.Name = "panelCheckInDate";
            panelCheckInDate.Size = new Size(226, 67);
            panelCheckInDate.TabIndex = 7;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerCheckIn.Location = new Point(9, 34);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(200, 27);
            dateTimePickerCheckIn.TabIndex = 7;
            // 
            // labelCheckInDate
            // 
            labelCheckInDate.AutoSize = true;
            labelCheckInDate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCheckInDate.Location = new Point(9, 6);
            labelCheckInDate.Name = "labelCheckInDate";
            labelCheckInDate.Size = new Size(134, 23);
            labelCheckInDate.TabIndex = 0;
            labelCheckInDate.Text = "Check-In Date";
            // 
            // panelGuestID
            // 
            panelGuestID.Controls.Add(textBoxGuestID);
            panelGuestID.Controls.Add(labelGuestID);
            panelGuestID.Location = new Point(240, 140);
            panelGuestID.Name = "panelGuestID";
            panelGuestID.Size = new Size(226, 67);
            panelGuestID.TabIndex = 6;
            // 
            // textBoxGuestID
            // 
            textBoxGuestID.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGuestID.Location = new Point(9, 34);
            textBoxGuestID.Name = "textBoxGuestID";
            textBoxGuestID.Size = new Size(199, 27);
            textBoxGuestID.TabIndex = 1;
            // 
            // labelGuestID
            // 
            labelGuestID.AutoSize = true;
            labelGuestID.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGuestID.Location = new Point(9, 6);
            labelGuestID.Name = "labelGuestID";
            labelGuestID.Size = new Size(85, 23);
            labelGuestID.TabIndex = 0;
            labelGuestID.Text = "Guest ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 33);
            label7.Name = "label7";
            label7.Size = new Size(364, 42);
            label7.TabIndex = 20;
            label7.Text = "Booking Management";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelAddaGuest.Controls.Add(labelAddBook);
            panelAddaGuest.Location = new Point(54, 92);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(153, 32);
            panelAddaGuest.TabIndex = 21;
            // 
            // labelAddBook
            // 
            labelAddBook.AutoSize = true;
            labelAddBook.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddBook.Location = new Point(9, 5);
            labelAddBook.Name = "labelAddBook";
            labelAddBook.Size = new Size(134, 23);
            labelAddBook.TabIndex = 8;
            labelAddBook.Text = "Add a Booking";
            labelAddBook.Click += labelAddBook_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.MediumSeaGreen;
            panel10.Controls.Add(labelListofBooking);
            panel10.Location = new Point(205, 92);
            panel10.Name = "panel10";
            panel10.Size = new Size(170, 32);
            panel10.TabIndex = 22;
            // 
            // labelListofBooking
            // 
            labelListofBooking.AutoSize = true;
            labelListofBooking.BackColor = Color.Transparent;
            labelListofBooking.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListofBooking.Location = new Point(11, 5);
            labelListofBooking.Name = "labelListofBooking";
            labelListofBooking.Size = new Size(149, 23);
            labelListofBooking.TabIndex = 9;
            labelListofBooking.Text = "List of Bookings";
            labelListofBooking.Click += labelListofBooking_Click;
            // 
            // UC_Booking1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Name = "UC_Booking1";
            Size = new Size(1076, 749);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panelListofBooking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooking).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelCheckOutTime.ResumeLayout(false);
            panelCheckOutTime.PerformLayout();
            panelCheckInTime.ResumeLayout(false);
            panelCheckInTime.PerformLayout();
            panelRoomNo.ResumeLayout(false);
            panelRoomNo.PerformLayout();
            panelCheckOutDate.ResumeLayout(false);
            panelCheckOutDate.PerformLayout();
            panelCheckInDate.ResumeLayout(false);
            panelCheckInDate.PerformLayout();
            panelGuestID.ResumeLayout(false);
            panelGuestID.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Panel panel11;
        private Button buttonAddBooking;
        private Panel panelCheckOutTime;
        private TextBox textBoxCheckOutTime;
        private Label labelCheckOutTime;
        private Panel panelCheckInTime;
        private TextBox textBoxCheckInTime;
        private Label label4;
        private Panel panelRoomNo;
        private TextBox textBoxRoomNo;
        private Label labelRoomNo;
        private Panel panelCheckOutDate;
        private Label labelCheckOutDate;
        private Panel panelCheckInDate;
        private Label labelCheckInDate;
        private Panel panelGuestID;
        private TextBox textBoxGuestID;
        private Label labelGuestID;
        private Label label7;
        private Panel panelAddaGuest;
        private Label labelAddBook;
        private Panel panel10;
        private Label labelListofBooking;
        private Panel panelListofBooking;
        private DataGridView dataGridViewBooking;
        private DataGridViewTextBoxColumn ColumnGuestID;
        private DataGridViewTextBoxColumn ColumnRoomNo;
        private DataGridViewTextBoxColumn ColumnCheckInDate;
        private DataGridViewTextBoxColumn ColumnCheckInTime;
        private DataGridViewTextBoxColumn ColumnCheckOutDate;
        private DataGridViewTextBoxColumn ColumnCheckOutTime;
        private Panel panelSearch;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private DateTimePicker dateTimePickerCheckout;
        private DateTimePicker dateTimePickerCheckIn;
    }
}
