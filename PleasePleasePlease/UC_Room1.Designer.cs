namespace PleasePleasePlease
{
    partial class UC_Room1 : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Room1));
            panel9 = new Panel();
            panelListofRoom = new Panel();
            panelFilters = new Panel();
            comboBoxFilterRoomType = new ComboBox();
            comboBoxFilterRoomStatus = new ComboBox();
            dataGridViewRoom = new DataGridView();
            ColumnRoomNo = new DataGridViewTextBoxColumn();
            ColumnRoomType = new DataGridViewComboBoxColumn();
            ColumnFloorNo = new DataGridViewTextBoxColumn();
            ColumnMaxCap = new DataGridViewTextBoxColumn();
            ColumnRoomRate = new DataGridViewTextBoxColumn();
            ColumnRoomStatus = new DataGridViewComboBoxColumn();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            textBoxMaxCapacity = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            textBoxFloorNo = new TextBox();
            label3 = new Label();
            panel8 = new Panel();
            textBoxRoomRate = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            comboBoxRoomStatus = new ComboBox();
            label5 = new Label();
            buttonAddRoom = new Button();
            panel2 = new Panel();
            comboBoxRoomType = new ComboBox();
            label1 = new Label();
            panel11 = new Panel();
            textBoxRoomNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panelAddaGuest = new Panel();
            labelAddRoom = new Label();
            panel10 = new Panel();
            labelListofRoom = new Label();
            panel9.SuspendLayout();
            panelListofRoom.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).BeginInit();
            panelSearch.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.AutoSize = true;
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.Controls.Add(panelListofRoom);
            panel9.Controls.Add(panel4);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(panelAddaGuest);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(1230, 999);
            panel9.TabIndex = 23;
            // 
            // panelListofRoom
            // 
            panelListofRoom.BackColor = Color.FromArgb(76, 149, 108);
            panelListofRoom.BackgroundImageLayout = ImageLayout.Zoom;
            panelListofRoom.Controls.Add(panelFilters);
            panelListofRoom.Controls.Add(dataGridViewRoom);
            panelListofRoom.Controls.Add(panelSearch);
            panelListofRoom.Location = new Point(59, 164);
            panelListofRoom.Margin = new Padding(3, 4, 3, 4);
            panelListofRoom.Name = "panelListofRoom";
            panelListofRoom.Size = new Size(1085, 747);
            panelListofRoom.TabIndex = 22;
            panelListofRoom.Visible = false;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomType);
            panelFilters.Controls.Add(comboBoxFilterRoomStatus);
            panelFilters.Location = new Point(127, 104);
            panelFilters.Margin = new Padding(3, 4, 3, 4);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(848, 67);
            panelFilters.TabIndex = 12;
            panelFilters.Visible = false;
            // 
            // comboBoxFilterRoomType
            // 
            comboBoxFilterRoomType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomType.FormattingEnabled = true;
            comboBoxFilterRoomType.Location = new Point(10, 13);
            comboBoxFilterRoomType.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterRoomType.Name = "comboBoxFilterRoomType";
            comboBoxFilterRoomType.Size = new Size(141, 32);
            comboBoxFilterRoomType.TabIndex = 7;
            comboBoxFilterRoomType.Text = " Room Type";
            // 
            // comboBoxFilterRoomStatus
            // 
            comboBoxFilterRoomStatus.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomStatus.FormattingEnabled = true;
            comboBoxFilterRoomStatus.Location = new Point(161, 13);
            comboBoxFilterRoomStatus.Margin = new Padding(6, 7, 6, 7);
            comboBoxFilterRoomStatus.Name = "comboBoxFilterRoomStatus";
            comboBoxFilterRoomStatus.Size = new Size(138, 32);
            comboBoxFilterRoomStatus.TabIndex = 6;
            comboBoxFilterRoomStatus.Text = " Room Status";
            // 
            // dataGridViewRoom
            // 
            dataGridViewRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoom.Columns.AddRange(new DataGridViewColumn[] { ColumnRoomNo, ColumnRoomType, ColumnFloorNo, ColumnMaxCap, ColumnRoomRate, ColumnRoomStatus });
            dataGridViewRoom.Location = new Point(79, 179);
            dataGridViewRoom.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRoom.Name = "dataGridViewRoom";
            dataGridViewRoom.RowHeadersWidth = 51;
            dataGridViewRoom.Size = new Size(941, 347);
            dataGridViewRoom.TabIndex = 5;
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
            // ColumnRoomType
            // 
            ColumnRoomType.HeaderText = "Room Type";
            ColumnRoomType.MinimumWidth = 6;
            ColumnRoomType.Name = "ColumnRoomType";
            ColumnRoomType.ReadOnly = true;
            ColumnRoomType.Resizable = DataGridViewTriState.True;
            ColumnRoomType.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnRoomType.Width = 130;
            // 
            // ColumnFloorNo
            // 
            ColumnFloorNo.HeaderText = "Floor No.";
            ColumnFloorNo.MinimumWidth = 6;
            ColumnFloorNo.Name = "ColumnFloorNo";
            ColumnFloorNo.ReadOnly = true;
            ColumnFloorNo.Width = 130;
            // 
            // ColumnMaxCap
            // 
            ColumnMaxCap.HeaderText = "Max. Capacity";
            ColumnMaxCap.MinimumWidth = 6;
            ColumnMaxCap.Name = "ColumnMaxCap";
            ColumnMaxCap.ReadOnly = true;
            ColumnMaxCap.Width = 130;
            // 
            // ColumnRoomRate
            // 
            ColumnRoomRate.HeaderText = "Room Rate";
            ColumnRoomRate.MinimumWidth = 6;
            ColumnRoomRate.Name = "ColumnRoomRate";
            ColumnRoomRate.Width = 130;
            // 
            // ColumnRoomStatus
            // 
            ColumnRoomStatus.HeaderText = "Room Status";
            ColumnRoomStatus.MinimumWidth = 6;
            ColumnRoomStatus.Name = "ColumnRoomStatus";
            ColumnRoomStatus.Resizable = DataGridViewTriState.True;
            ColumnRoomStatus.Width = 130;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(218, 25);
            panelSearch.Margin = new Padding(3, 4, 3, 4);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(713, 71);
            panelSearch.TabIndex = 4;
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
            buttonMore.Click += buttonMore_Click;
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
            textBoxAddressSearch.Location = new Point(10, 16);
            textBoxAddressSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(580, 31);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(buttonAddRoom);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel11);
            panel4.Location = new Point(61, 164);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(1083, 747);
            panel4.TabIndex = 23;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxMaxCapacity);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(669, 383);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(258, 89);
            panel6.TabIndex = 4;
            // 
            // textBoxMaxCapacity
            // 
            textBoxMaxCapacity.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMaxCapacity.Location = new Point(10, 45);
            textBoxMaxCapacity.Margin = new Padding(3, 4, 3, 4);
            textBoxMaxCapacity.Name = "textBoxMaxCapacity";
            textBoxMaxCapacity.Size = new Size(227, 31);
            textBoxMaxCapacity.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 8);
            label2.Name = "label2";
            label2.Size = new Size(159, 29);
            label2.TabIndex = 0;
            label2.Text = "Max. Capacity";
            // 
            // panel7
            // 
            panel7.Controls.Add(textBoxFloorNo);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(669, 257);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(258, 89);
            panel7.TabIndex = 4;
            // 
            // textBoxFloorNo
            // 
            textBoxFloorNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFloorNo.Location = new Point(10, 45);
            textBoxFloorNo.Margin = new Padding(3, 4, 3, 4);
            textBoxFloorNo.Name = "textBoxFloorNo";
            textBoxFloorNo.Size = new Size(227, 31);
            textBoxFloorNo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 8);
            label3.Name = "label3";
            label3.Size = new Size(105, 29);
            label3.TabIndex = 0;
            label3.Text = "Floor No.";
            // 
            // panel8
            // 
            panel8.Controls.Add(textBoxRoomRate);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(149, 515);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(258, 89);
            panel8.TabIndex = 3;
            // 
            // textBoxRoomRate
            // 
            textBoxRoomRate.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRoomRate.Location = new Point(10, 45);
            textBoxRoomRate.Margin = new Padding(3, 4, 3, 4);
            textBoxRoomRate.Name = "textBoxRoomRate";
            textBoxRoomRate.Size = new Size(227, 31);
            textBoxRoomRate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 8);
            label4.Name = "label4";
            label4.Size = new Size(127, 29);
            label4.TabIndex = 0;
            label4.Text = "Room Rate";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBoxRoomStatus);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(149, 383);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 89);
            panel1.TabIndex = 7;
            // 
            // comboBoxRoomStatus
            // 
            comboBoxRoomStatus.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomStatus.FormattingEnabled = true;
            comboBoxRoomStatus.Location = new Point(10, 48);
            comboBoxRoomStatus.Margin = new Padding(3, 4, 3, 4);
            comboBoxRoomStatus.Name = "comboBoxRoomStatus";
            comboBoxRoomStatus.Size = new Size(227, 32);
            comboBoxRoomStatus.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 8);
            label5.Name = "label5";
            label5.Size = new Size(146, 29);
            label5.TabIndex = 0;
            label5.Text = "Room Status";
            // 
            // buttonAddRoom
            // 
            buttonAddRoom.BackColor = Color.FromArgb(45, 106, 79);
            buttonAddRoom.FlatStyle = FlatStyle.System;
            buttonAddRoom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddRoom.Location = new Point(879, 649);
            buttonAddRoom.Margin = new Padding(3, 4, 3, 4);
            buttonAddRoom.Name = "buttonAddRoom";
            buttonAddRoom.Size = new Size(153, 55);
            buttonAddRoom.TabIndex = 2;
            buttonAddRoom.Text = "Add Room";
            buttonAddRoom.UseVisualStyleBackColor = false;
            buttonAddRoom.Click += buttonAddRoom_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBoxRoomType);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(149, 257);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(282, 89);
            panel2.TabIndex = 5;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(10, 48);
            comboBoxRoomType.Margin = new Padding(3, 4, 3, 4);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(227, 32);
            comboBoxRoomType.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(129, 29);
            label1.TabIndex = 0;
            label1.Text = "Room Type";
            // 
            // panel11
            // 
            panel11.Controls.Add(textBoxRoomNo);
            panel11.Controls.Add(label8);
            panel11.Location = new Point(149, 131);
            panel11.Margin = new Padding(3, 4, 3, 4);
            panel11.Name = "panel11";
            panel11.Size = new Size(258, 89);
            panel11.TabIndex = 2;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(59, 44);
            label7.Name = "label7";
            label7.Size = new Size(395, 53);
            label7.TabIndex = 20;
            label7.Text = "Room Management";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelAddaGuest.Controls.Add(labelAddRoom);
            panelAddaGuest.Location = new Point(62, 123);
            panelAddaGuest.Margin = new Padding(3, 4, 3, 4);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(175, 43);
            panelAddaGuest.TabIndex = 21;
            // 
            // labelAddRoom
            // 
            labelAddRoom.AutoSize = true;
            labelAddRoom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddRoom.Location = new Point(22, 7);
            labelAddRoom.Name = "labelAddRoom";
            labelAddRoom.Size = new Size(139, 29);
            labelAddRoom.TabIndex = 8;
            labelAddRoom.Text = "Add a Room";
            labelAddRoom.Click += labelAddRoom_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.MediumSeaGreen;
            panel10.Controls.Add(labelListofRoom);
            panel10.Location = new Point(232, 123);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Size = new Size(194, 43);
            panel10.TabIndex = 22;
            // 
            // labelListofRoom
            // 
            labelListofRoom.AutoSize = true;
            labelListofRoom.BackColor = Color.Transparent;
            labelListofRoom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListofRoom.Location = new Point(23, 7);
            labelListofRoom.Name = "labelListofRoom";
            labelListofRoom.Size = new Size(153, 29);
            labelListofRoom.TabIndex = 9;
            labelListofRoom.Text = "List of Rooms";
            labelListofRoom.Click += labelListofRoom_Click;
            // 
            // UC_Room1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Room1";
            Size = new Size(1230, 999);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panelListofRoom.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoom).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel9;
        private Panel panel4;
        private Panel panel6;
        private TextBox textBoxMaxCapacity;
        private Label label2;
        private Panel panel7;
        private TextBox textBoxFloorNo;
        private Label label3;
        private Panel panel8;
        private TextBox textBoxRoomRate;
        private Label label4;
        private Panel panel1;
        private ComboBox comboBoxRoomStatus;
        private Label label5;
        private Button buttonAddRoom;
        private Panel panel2;
        private ComboBox comboBoxRoomType;
        private Label label1;
        private Panel panel11;
        private TextBox textBoxRoomNo;
        private Label label8;
        private Label label7;
        private Panel panelAddaGuest;
        private Label labelAddRoom;
        private Panel panel10;
        private Label labelListofRoom;
        private Panel panelListofRoom;
        private Panel panelFilters;
        private ComboBox comboBoxFilterRoomType;
        private ComboBox comboBoxFilterRoomStatus;
        private DataGridView dataGridViewRoom;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private DataGridViewTextBoxColumn ColumnRoomNo;
        private DataGridViewComboBoxColumn ColumnRoomType;
        private DataGridViewTextBoxColumn ColumnFloorNo;
        private DataGridViewTextBoxColumn ColumnMaxCap;
        private DataGridViewTextBoxColumn ColumnRoomRate;
        private DataGridViewComboBoxColumn ColumnRoomStatus;
    }
}
