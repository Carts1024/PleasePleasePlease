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
            buttonImportBooking = new Button();
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
            panel9.Controls.Add(buttonImportBooking);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(panelAddaGuest);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1230, 999);
            panel9.TabIndex = 22;
            // 
            // buttonImportBooking
            // 
            buttonImportBooking.BackColor = Color.FromArgb(27, 67, 50);
            buttonImportBooking.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonImportBooking.FlatStyle = FlatStyle.Flat;
            buttonImportBooking.Font = new Font("SF Pro Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImportBooking.ForeColor = Color.White;
            buttonImportBooking.Location = new Point(942, 80);
            buttonImportBooking.Margin = new Padding(3, 4, 3, 4);
            buttonImportBooking.Name = "buttonImportBooking";
            buttonImportBooking.Size = new Size(230, 65);
            buttonImportBooking.TabIndex = 23;
            buttonImportBooking.Text = "Import Records";
            buttonImportBooking.UseVisualStyleBackColor = false;
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
            panel11.Location = new Point(62, 164);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1110, 791);
            panel11.TabIndex = 19;
            // 
            // panelListofBooking
            // 
            panelListofBooking.BackColor = Color.FromArgb(76, 149, 108);
            panelListofBooking.BackgroundImageLayout = ImageLayout.Zoom;
            panelListofBooking.Controls.Add(dataGridViewBooking);
            panelListofBooking.Controls.Add(panelSearch);
            panelListofBooking.Location = new Point(0, 0);
            panelListofBooking.Margin = new Padding(3, 4, 3, 4);
            panelListofBooking.Name = "panelListofBooking";
            panelListofBooking.Size = new Size(1110, 791);
            panelListofBooking.TabIndex = 20;
            panelListofBooking.Visible = false;
            // 
            // dataGridViewBooking
            // 
            dataGridViewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooking.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnRoomNo, ColumnCheckInDate, ColumnCheckInTime, ColumnCheckOutDate, ColumnCheckOutTime });
            dataGridViewBooking.Location = new Point(79, 179);
            dataGridViewBooking.Margin = new Padding(3, 4, 3, 4);
            dataGridViewBooking.Name = "dataGridViewBooking";
            dataGridViewBooking.RowHeadersWidth = 51;
            dataGridViewBooking.Size = new Size(941, 347);
            dataGridViewBooking.TabIndex = 17;
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
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(218, 25);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(713, 71);
            panelSearch.TabIndex = 16;
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
            buttonSearchIcon.Click += buttonSearchIcon_Click;
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
            // buttonAddBooking
            // 
            buttonAddBooking.BackColor = Color.FromArgb(27, 67, 50);
            buttonAddBooking.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonAddBooking.FlatStyle = FlatStyle.Flat;
            buttonAddBooking.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddBooking.ForeColor = Color.White;
            buttonAddBooking.Location = new Point(854, 672);
            buttonAddBooking.Margin = new Padding(3, 4, 3, 4);
            buttonAddBooking.Name = "buttonAddBooking";
            buttonAddBooking.Size = new Size(213, 65);
            buttonAddBooking.TabIndex = 10;
            buttonAddBooking.Text = "Add Booking";
            buttonAddBooking.UseVisualStyleBackColor = false;
            buttonAddBooking.Click += buttonAddBooking_Click;
            // 
            // panelCheckOutTime
            // 
            panelCheckOutTime.Controls.Add(textBoxCheckOutTime);
            panelCheckOutTime.Controls.Add(labelCheckOutTime);
            panelCheckOutTime.Location = new Point(673, 449);
            panelCheckOutTime.Margin = new Padding(3, 4, 3, 4);
            panelCheckOutTime.Name = "panelCheckOutTime";
            panelCheckOutTime.Size = new Size(258, 89);
            panelCheckOutTime.TabIndex = 7;
            // 
            // textBoxCheckOutTime
            // 
            textBoxCheckOutTime.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCheckOutTime.Location = new Point(10, 45);
            textBoxCheckOutTime.Margin = new Padding(3, 4, 3, 4);
            textBoxCheckOutTime.Name = "textBoxCheckOutTime";
            textBoxCheckOutTime.Size = new Size(227, 31);
            textBoxCheckOutTime.TabIndex = 1;
            // 
            // labelCheckOutTime
            // 
            labelCheckOutTime.AutoSize = true;
            labelCheckOutTime.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCheckOutTime.Location = new Point(10, 8);
            labelCheckOutTime.Name = "labelCheckOutTime";
            labelCheckOutTime.Size = new Size(185, 29);
            labelCheckOutTime.TabIndex = 0;
            labelCheckOutTime.Text = "Check-Out Time";
            // 
            // panelCheckInTime
            // 
            panelCheckInTime.Controls.Add(textBoxCheckInTime);
            panelCheckInTime.Controls.Add(label4);
            panelCheckInTime.Location = new Point(673, 319);
            panelCheckInTime.Margin = new Padding(3, 4, 3, 4);
            panelCheckInTime.Name = "panelCheckInTime";
            panelCheckInTime.Size = new Size(258, 89);
            panelCheckInTime.TabIndex = 7;
            // 
            // textBoxCheckInTime
            // 
            textBoxCheckInTime.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCheckInTime.Location = new Point(10, 45);
            textBoxCheckInTime.Margin = new Padding(3, 4, 3, 4);
            textBoxCheckInTime.Name = "textBoxCheckInTime";
            textBoxCheckInTime.Size = new Size(227, 31);
            textBoxCheckInTime.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 8);
            label4.Name = "label4";
            label4.Size = new Size(165, 29);
            label4.TabIndex = 0;
            label4.Text = "Check-In Time";
            // 
            // panelRoomNo
            // 
            panelRoomNo.Controls.Add(textBoxRoomNo);
            panelRoomNo.Controls.Add(labelRoomNo);
            panelRoomNo.Location = new Point(673, 187);
            panelRoomNo.Margin = new Padding(3, 4, 3, 4);
            panelRoomNo.Name = "panelRoomNo";
            panelRoomNo.Size = new Size(258, 89);
            panelRoomNo.TabIndex = 7;
            // 
            // textBoxRoomNo
            // 
            textBoxRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRoomNo.Location = new Point(10, 45);
            textBoxRoomNo.Margin = new Padding(3, 4, 3, 4);
            textBoxRoomNo.Name = "textBoxRoomNo";
            textBoxRoomNo.Size = new Size(227, 31);
            textBoxRoomNo.TabIndex = 1;
            // 
            // labelRoomNo
            // 
            labelRoomNo.AutoSize = true;
            labelRoomNo.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomNo.Location = new Point(10, 8);
            labelRoomNo.Name = "labelRoomNo";
            labelRoomNo.Size = new Size(114, 29);
            labelRoomNo.TabIndex = 0;
            labelRoomNo.Text = "Room No.";
            // 
            // panelCheckOutDate
            // 
            panelCheckOutDate.Controls.Add(dateTimePickerCheckout);
            panelCheckOutDate.Controls.Add(labelCheckOutDate);
            panelCheckOutDate.Location = new Point(274, 449);
            panelCheckOutDate.Margin = new Padding(3, 4, 3, 4);
            panelCheckOutDate.Name = "panelCheckOutDate";
            panelCheckOutDate.Size = new Size(258, 89);
            panelCheckOutDate.TabIndex = 8;
            // 
            // dateTimePickerCheckout
            // 
            dateTimePickerCheckout.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerCheckout.Location = new Point(10, 45);
            dateTimePickerCheckout.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerCheckout.Name = "dateTimePickerCheckout";
            dateTimePickerCheckout.Size = new Size(228, 31);
            dateTimePickerCheckout.TabIndex = 8;
            // 
            // labelCheckOutDate
            // 
            labelCheckOutDate.AutoSize = true;
            labelCheckOutDate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCheckOutDate.Location = new Point(10, 8);
            labelCheckOutDate.Name = "labelCheckOutDate";
            labelCheckOutDate.Size = new Size(184, 29);
            labelCheckOutDate.TabIndex = 0;
            labelCheckOutDate.Text = "Check-Out Date";
            // 
            // panelCheckInDate
            // 
            panelCheckInDate.Controls.Add(dateTimePickerCheckIn);
            panelCheckInDate.Controls.Add(labelCheckInDate);
            panelCheckInDate.Location = new Point(274, 319);
            panelCheckInDate.Margin = new Padding(3, 4, 3, 4);
            panelCheckInDate.Name = "panelCheckInDate";
            panelCheckInDate.Size = new Size(258, 89);
            panelCheckInDate.TabIndex = 7;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerCheckIn.Location = new Point(10, 45);
            dateTimePickerCheckIn.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(228, 31);
            dateTimePickerCheckIn.TabIndex = 7;
            // 
            // labelCheckInDate
            // 
            labelCheckInDate.AutoSize = true;
            labelCheckInDate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCheckInDate.Location = new Point(10, 8);
            labelCheckInDate.Name = "labelCheckInDate";
            labelCheckInDate.Size = new Size(164, 29);
            labelCheckInDate.TabIndex = 0;
            labelCheckInDate.Text = "Check-In Date";
            // 
            // panelGuestID
            // 
            panelGuestID.Controls.Add(textBoxGuestID);
            panelGuestID.Controls.Add(labelGuestID);
            panelGuestID.Location = new Point(274, 187);
            panelGuestID.Margin = new Padding(3, 4, 3, 4);
            panelGuestID.Name = "panelGuestID";
            panelGuestID.Size = new Size(258, 89);
            panelGuestID.TabIndex = 6;
            // 
            // textBoxGuestID
            // 
            textBoxGuestID.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGuestID.Location = new Point(10, 45);
            textBoxGuestID.Margin = new Padding(3, 4, 3, 4);
            textBoxGuestID.Name = "textBoxGuestID";
            textBoxGuestID.Size = new Size(227, 31);
            textBoxGuestID.TabIndex = 1;
            // 
            // labelGuestID
            // 
            labelGuestID.AutoSize = true;
            labelGuestID.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGuestID.Location = new Point(10, 8);
            labelGuestID.Name = "labelGuestID";
            labelGuestID.Size = new Size(103, 29);
            labelGuestID.TabIndex = 0;
            labelGuestID.Text = "Guest ID";
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
            panelAddaGuest.BackColor = Color.FromArgb(76, 149, 108);
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
            labelAddBook.Click += labelAddBook_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.MediumSeaGreen;
            panel10.Controls.Add(labelListofBooking);
            panel10.Location = new Point(234, 123);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(194, 43);
            panel10.TabIndex = 22;
            // 
            // labelListofBooking
            // 
            labelListofBooking.AutoSize = true;
            labelListofBooking.BackColor = Color.Transparent;
            labelListofBooking.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListofBooking.Location = new Point(13, 7);
            labelListofBooking.Name = "labelListofBooking";
            labelListofBooking.Size = new Size(177, 29);
            labelListofBooking.TabIndex = 9;
            labelListofBooking.Text = "List of Bookings";
            labelListofBooking.Click += labelListofBooking_Click;
            // 
            // UC_Booking1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Booking1";
            Size = new Size(1230, 999);
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
        private Button buttonImportBooking;
    }
}
