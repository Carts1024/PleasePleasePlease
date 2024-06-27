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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            label7 = new Label();
            panelAddaGuest = new Panel();
            labelAddBook = new Label();
            panel10 = new Panel();
            label6 = new Label();
            TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
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
            panel9.Name = "panel9";
            panel9.Size = new Size(1076, 749);
            panel9.TabIndex = 21;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(76, 149, 108);
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Controls.Add(panelFilters);
            panel11.Controls.Add(dataGridView1);
            panel11.Controls.Add(panelSearch);
            panel11.Location = new Point(54, 123);
            panel11.Name = "panel11";
            panel11.Size = new Size(971, 593);
            panel11.TabIndex = 19;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomNo);
            panelFilters.Location = new Point(126, 102);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 18;
            // 
            // comboBoxFilterRoomNo
            // 
            comboBoxFilterRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomNo.FormattingEnabled = true;
            comboBoxFilterRoomNo.Location = new Point(13, 10);
            comboBoxFilterRoomNo.Name = "comboBoxFilterRoomNo";
            comboBoxFilterRoomNo.Size = new Size(112, 27);
            comboBoxFilterRoomNo.TabIndex = 9;
            comboBoxFilterRoomNo.Text = "[template]";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnRoomNo, ColumnCheckInDate, ColumnCheckInTime, ColumnCheckOutDate, ColumnCheckOutTime });
            dataGridView1.Location = new Point(71, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(824, 260);
            dataGridView1.TabIndex = 17;
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
            panelSearch.Controls.Add(TextBoxSearch);
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Location = new Point(176, 40);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 16;
            // 
            // buttonMore
            // 
            buttonMore.BackgroundImage = (Image)resources.GetObject("buttonMore.BackgroundImage");
            buttonMore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMore.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMore.Location = new Point(569, 12);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(28, 27);
            buttonMore.TabIndex = 4;
            buttonMore.UseVisualStyleBackColor = true;
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
            panelAddaGuest.BackColor = Color.MediumSeaGreen;
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
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(76, 149, 108);
            panel10.Controls.Add(label6);
            panel10.Location = new Point(215, 92);
            panel10.Name = "panel10";
            panel10.Size = new Size(170, 32);
            panel10.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 5);
            label6.Name = "label6";
            label6.Size = new Size(149, 23);
            label6.TabIndex = 9;
            label6.Text = "List of Bookings";
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Animated = true;
            TextBoxSearch.AutoRoundedCorners = true;
            TextBoxSearch.BorderRadius = 12;
            TextBoxSearch.CustomizableEdges = customizableEdges1;
            TextBoxSearch.DefaultText = "Search";
            TextBoxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            TextBoxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            TextBoxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            TextBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            TextBoxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxSearch.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBoxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            TextBoxSearch.Location = new Point(1, 12);
            TextBoxSearch.Margin = new Padding(4);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.PasswordChar = '\0';
            TextBoxSearch.PlaceholderText = "";
            TextBoxSearch.SelectedText = "";
            TextBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TextBoxSearch.Size = new Size(508, 27);
            TextBoxSearch.TabIndex = 22;
            // 
            // UC_Booking2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Name = "UC_Booking2";
            Size = new Size(1076, 749);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
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
        private Label label7;
        private Panel panelAddaGuest;
        private Label labelAddBook;
        private Panel panel10;
        private Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
    }
}
