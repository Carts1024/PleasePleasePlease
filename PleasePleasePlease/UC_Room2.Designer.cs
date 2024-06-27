namespace PleasePleasePlease
{
    partial class UC_Room2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Room2));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelBaseRooms1 = new Panel();
            earpanelAddRoom = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            panelFilters = new Panel();
            comboBoxFilterRoomRate = new ComboBox();
            comboBoxFilterFloorNo = new ComboBox();
            comboBoxFilterRoomNo = new ComboBox();
            comboBoxFilterMaxCap = new ComboBox();
            comboBoxFilterRoomType = new ComboBox();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            ColumnRoomNo = new DataGridViewTextBoxColumn();
            ColumnRoomType = new DataGridViewComboBoxColumn();
            ColumnFloorNo = new DataGridViewTextBoxColumn();
            ColumnMaxCap = new DataGridViewTextBoxColumn();
            ColumnRoomRate = new DataGridViewTextBoxColumn();
            ColumnRoomStatus = new DataGridViewComboBoxColumn();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            labelRM = new Label();
            TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panelBaseRooms1.SuspendLayout();
            earpanelAddRoom.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panelBaseRooms1
            // 
            panelBaseRooms1.BackgroundImage = (Image)resources.GetObject("panelBaseRooms1.BackgroundImage");
            panelBaseRooms1.Controls.Add(earpanelAddRoom);
            panelBaseRooms1.Controls.Add(panel4);
            panelBaseRooms1.Controls.Add(panel7);
            panelBaseRooms1.Controls.Add(labelRM);
            panelBaseRooms1.Dock = DockStyle.Fill;
            panelBaseRooms1.Location = new Point(0, 0);
            panelBaseRooms1.Name = "panelBaseRooms1";
            panelBaseRooms1.Size = new Size(1076, 749);
            panelBaseRooms1.TabIndex = 20;
            panelBaseRooms1.Visible = false;
            // 
            // earpanelAddRoom
            // 
            earpanelAddRoom.BackColor = Color.MediumSeaGreen;
            earpanelAddRoom.Controls.Add(label4);
            earpanelAddRoom.Location = new Point(59, 130);
            earpanelAddRoom.Name = "earpanelAddRoom";
            earpanelAddRoom.Size = new Size(153, 32);
            earpanelAddRoom.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 5);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 12;
            label4.Text = "Add a Room";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(218, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 32);
            panel4.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 5);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 11;
            label2.Text = "List of Rooms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 5);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 10;
            label3.Text = "Add a Room";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(76, 149, 108);
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Controls.Add(panelFilters);
            panel7.Controls.Add(dataGridView1);
            panel7.Controls.Add(panelSearch);
            panel7.Location = new Point(59, 161);
            panel7.Name = "panel7";
            panel7.Size = new Size(956, 551);
            panel7.TabIndex = 21;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomRate);
            panelFilters.Controls.Add(comboBoxFilterFloorNo);
            panelFilters.Controls.Add(comboBoxFilterRoomNo);
            panelFilters.Controls.Add(comboBoxFilterMaxCap);
            panelFilters.Controls.Add(comboBoxFilterRoomType);
            panelFilters.Controls.Add(comboBox2);
            panelFilters.Location = new Point(99, 89);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 12;
            // 
            // comboBoxFilterRoomRate
            // 
            comboBoxFilterRoomRate.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomRate.FormattingEnabled = true;
            comboBoxFilterRoomRate.Location = new Point(508, 10);
            comboBoxFilterRoomRate.Name = "comboBoxFilterRoomRate";
            comboBoxFilterRoomRate.Size = new Size(101, 27);
            comboBoxFilterRoomRate.TabIndex = 11;
            comboBoxFilterRoomRate.Text = " Room Rate";
            // 
            // comboBoxFilterFloorNo
            // 
            comboBoxFilterFloorNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterFloorNo.FormattingEnabled = true;
            comboBoxFilterFloorNo.Location = new Point(267, 10);
            comboBoxFilterFloorNo.Name = "comboBoxFilterFloorNo";
            comboBoxFilterFloorNo.Size = new Size(101, 27);
            comboBoxFilterFloorNo.TabIndex = 10;
            comboBoxFilterFloorNo.Text = " Floor No.";
            // 
            // comboBoxFilterRoomNo
            // 
            comboBoxFilterRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomNo.FormattingEnabled = true;
            comboBoxFilterRoomNo.Location = new Point(13, 10);
            comboBoxFilterRoomNo.Name = "comboBoxFilterRoomNo";
            comboBoxFilterRoomNo.Size = new Size(112, 27);
            comboBoxFilterRoomNo.TabIndex = 9;
            comboBoxFilterRoomNo.Text = " Room No.";
            // 
            // comboBoxFilterMaxCap
            // 
            comboBoxFilterMaxCap.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterMaxCap.FormattingEnabled = true;
            comboBoxFilterMaxCap.Location = new Point(376, 10);
            comboBoxFilterMaxCap.Name = "comboBoxFilterMaxCap";
            comboBoxFilterMaxCap.Size = new Size(128, 27);
            comboBoxFilterMaxCap.TabIndex = 8;
            comboBoxFilterMaxCap.Text = " Max. Capacity";
            // 
            // comboBoxFilterRoomType
            // 
            comboBoxFilterRoomType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomType.FormattingEnabled = true;
            comboBoxFilterRoomType.Location = new Point(133, 10);
            comboBoxFilterRoomType.Name = "comboBoxFilterRoomType";
            comboBoxFilterRoomType.Size = new Size(124, 27);
            comboBoxFilterRoomType.TabIndex = 7;
            comboBoxFilterRoomType.Text = " Room Type";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(615, 10);
            comboBox2.Margin = new Padding(5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 27);
            comboBox2.TabIndex = 6;
            comboBox2.Text = " Room Status";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnRoomNo, ColumnRoomType, ColumnFloorNo, ColumnMaxCap, ColumnRoomRate, ColumnRoomStatus });
            dataGridView1.Location = new Point(88, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(763, 260);
            dataGridView1.TabIndex = 5;
            // 
            // ColumnRoomNo
            // 
            ColumnRoomNo.HeaderText = "Room No.";
            ColumnRoomNo.Name = "ColumnRoomNo";
            ColumnRoomNo.ReadOnly = true;
            ColumnRoomNo.Resizable = DataGridViewTriState.True;
            ColumnRoomNo.Width = 120;
            // 
            // ColumnRoomType
            // 
            ColumnRoomType.HeaderText = "Room Type";
            ColumnRoomType.Name = "ColumnRoomType";
            ColumnRoomType.ReadOnly = true;
            ColumnRoomType.Resizable = DataGridViewTriState.True;
            ColumnRoomType.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnRoomType.Width = 120;
            // 
            // ColumnFloorNo
            // 
            ColumnFloorNo.HeaderText = "Floor No.";
            ColumnFloorNo.Name = "ColumnFloorNo";
            ColumnFloorNo.ReadOnly = true;
            ColumnFloorNo.Width = 120;
            // 
            // ColumnMaxCap
            // 
            ColumnMaxCap.HeaderText = "Max. Capacity";
            ColumnMaxCap.Name = "ColumnMaxCap";
            ColumnMaxCap.ReadOnly = true;
            ColumnMaxCap.Width = 120;
            // 
            // ColumnRoomRate
            // 
            ColumnRoomRate.HeaderText = "Room Rate";
            ColumnRoomRate.Name = "ColumnRoomRate";
            ColumnRoomRate.Width = 120;
            // 
            // ColumnRoomStatus
            // 
            ColumnRoomStatus.HeaderText = "Room Status";
            ColumnRoomStatus.Name = "ColumnRoomStatus";
            ColumnRoomStatus.Resizable = DataGridViewTriState.True;
            ColumnRoomStatus.Width = 120;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(TextBoxSearch);
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Location = new Point(145, 27);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 4;
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
            // labelRM
            // 
            labelRM.AutoSize = true;
            labelRM.BackColor = Color.Transparent;
            labelRM.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRM.Location = new Point(63, 49);
            labelRM.Name = "labelRM";
            labelRM.Size = new Size(326, 42);
            labelRM.TabIndex = 11;
            labelRM.Text = "Room Management";
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
            TextBoxSearch.TabIndex = 23;
            // 
            // UC_Room2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBaseRooms1);
            Name = "UC_Room2";
            Size = new Size(1076, 749);
            panelBaseRooms1.ResumeLayout(false);
            panelBaseRooms1.PerformLayout();
            earpanelAddRoom.ResumeLayout(false);
            earpanelAddRoom.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBaseRooms1;
        private Panel earpanelAddRoom;
        private Label label4;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Panel panel7;
        private Panel panelFilters;
        private ComboBox comboBoxFilterRoomRate;
        private ComboBox comboBoxFilterFloorNo;
        private ComboBox comboBoxFilterRoomNo;
        private ComboBox comboBoxFilterMaxCap;
        private ComboBox comboBoxFilterRoomType;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnRoomNo;
        private DataGridViewComboBoxColumn ColumnRoomType;
        private DataGridViewTextBoxColumn ColumnFloorNo;
        private DataGridViewTextBoxColumn ColumnMaxCap;
        private DataGridViewTextBoxColumn ColumnRoomRate;
        private DataGridViewComboBoxColumn ColumnRoomStatus;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private Label labelRM;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxSearch;
    }
}
