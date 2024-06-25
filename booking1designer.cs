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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
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
            buttonSaveEditBookings = new Button();
            buttonExitEditBookings = new Button();
            buttonEditBookings = new Button();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel9.Controls.Add(panel1);
            panel9.Controls.Add(panel2);
            panel9.Controls.Add(buttonImportBooking);
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
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 32);
            panel1.TabIndex = 24;
            panel1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 5);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 8;
            label1.Text = "Add a Booking";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(76, 149, 108);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(206, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 32);
            panel2.TabIndex = 25;
            panel2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 5);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 9;
            label2.Text = "List of Bookings";
            // 
            // buttonImportBooking
            // 
            buttonImportBooking.BackColor = Color.FromArgb(27, 67, 50);
            buttonImportBooking.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonImportBooking.FlatStyle = FlatStyle.Flat;
            buttonImportBooking.Font = new Font("SF Pro Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonImportBooking.ForeColor = Color.White;
            buttonImportBooking.Location = new Point(824, 60);
            buttonImportBooking.Name = "buttonImportBooking";
            buttonImportBooking.Size = new Size(201, 49);
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
            dataGridViewBooking.RowHeadersWidth = 51;
            dataGridViewBooking.Size = new Size(823, 260);
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
            panelSearch.Controls.Add(buttonSaveEditBookings);
            panelSearch.Controls.Add(buttonExitEditBookings);
            panelSearch.Controls.Add(buttonEditBookings);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(191, 19);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(701, 53);
            panelSearch.TabIndex = 16;
            // 
            // buttonSaveEditBookings
            // 
            buttonSaveEditBookings.BackgroundImage = (Image)resources.GetObject("buttonSaveEditBookings.BackgroundImage");
            buttonSaveEditBookings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveEditBookings.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSaveEditBookings.Location = new Point(669, 12);
            buttonSaveEditBookings.Name = "buttonSaveEditBookings";
            buttonSaveEditBookings.Size = new Size(28, 27);
            buttonSaveEditBookings.TabIndex = 10;
            buttonSaveEditBookings.UseVisualStyleBackColor = true;
            buttonSaveEditBookings.Visible = false;
            buttonSaveEditBookings.Click += buttonSaveEditBookings_Click;
            // 
            // buttonExitEditBookings
            // 
            buttonExitEditBookings.BackgroundImage = (Image)resources.GetObject("buttonExitEditBookings.BackgroundImage");
            buttonExitEditBookings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExitEditBookings.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExitEditBookings.Location = new Point(635, 12);
            buttonExitEditBookings.Name = "buttonExitEditBookings";
            buttonExitEditBookings.Size = new Size(28, 27);
            buttonExitEditBookings.TabIndex = 9;
            buttonExitEditBookings.UseVisualStyleBackColor = true;
            buttonExitEditBookings.Visible = false;
            buttonExitEditBookings.Click += buttonExitEditGuest_Click;
            // 
            // buttonEditBookings
            // 
            buttonEditBookings.BackgroundImage = (Image)resources.GetObject("buttonEditBookings.BackgroundImage");
            buttonEditBookings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditBookings.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditBookings.Location = new Point(669, 12);
            buttonEditBookings.Name = "buttonEditBookings";
            buttonEditBookings.Size = new Size(28, 27);
            buttonEditBookings.TabIndex = 8;
            buttonEditBookings.UseVisualStyleBackColor = true;
            buttonEditBookings.Click += buttonEditBookings_Click;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button buttonSaveEditBookings;
        private Button buttonExitEditBookings;
        private Button buttonEditBookings;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
    }
}
