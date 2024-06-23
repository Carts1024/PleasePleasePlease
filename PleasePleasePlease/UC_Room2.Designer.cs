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
            textBoxAddressSearch = new TextBox();
            labelRM = new Label();
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
            panelBaseRooms1.AutoSize = true;
            panelBaseRooms1.BackgroundImage = (Image)resources.GetObject("panelBaseRooms1.BackgroundImage");
            panelBaseRooms1.Controls.Add(earpanelAddRoom);
            panelBaseRooms1.Controls.Add(panel4);
            panelBaseRooms1.Controls.Add(panel7);
            panelBaseRooms1.Controls.Add(labelRM);
            panelBaseRooms1.Dock = DockStyle.Fill;
            panelBaseRooms1.Location = new Point(0, 0);
            panelBaseRooms1.Margin = new Padding(3, 4, 3, 4);
            panelBaseRooms1.Name = "panelBaseRooms1";
            panelBaseRooms1.Size = new Size(1230, 999);
            panelBaseRooms1.TabIndex = 20;
            panelBaseRooms1.Visible = false;
            // 
            // earpanelAddRoom
            // 
            earpanelAddRoom.BackColor = Color.MediumSeaGreen;
            earpanelAddRoom.Controls.Add(label4);
            earpanelAddRoom.Location = new Point(67, 173);
            earpanelAddRoom.Margin = new Padding(3, 4, 3, 4);
            earpanelAddRoom.Name = "earpanelAddRoom";
            earpanelAddRoom.Size = new Size(175, 43);
            earpanelAddRoom.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 7);
            label4.Name = "label4";
            label4.Size = new Size(139, 29);
            label4.TabIndex = 12;
            label4.Text = "Add a Room";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(249, 173);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(175, 43);
            panel4.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 7);
            label2.Name = "label2";
            label2.Size = new Size(153, 29);
            label2.TabIndex = 11;
            label2.Text = "List of Rooms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 7);
            label3.Name = "label3";
            label3.Size = new Size(139, 29);
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
            panel7.Location = new Point(67, 215);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(1093, 735);
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
            panelFilters.Location = new Point(113, 119);
            panelFilters.Margin = new Padding(3, 4, 3, 4);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(848, 67);
            panelFilters.TabIndex = 12;
            // 
            // comboBoxFilterRoomRate
            // 
            comboBoxFilterRoomRate.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomRate.FormattingEnabled = true;
            comboBoxFilterRoomRate.Location = new Point(581, 13);
            comboBoxFilterRoomRate.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterRoomRate.Name = "comboBoxFilterRoomRate";
            comboBoxFilterRoomRate.Size = new Size(115, 32);
            comboBoxFilterRoomRate.TabIndex = 11;
            comboBoxFilterRoomRate.Text = " Room Rate";
            // 
            // comboBoxFilterFloorNo
            // 
            comboBoxFilterFloorNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterFloorNo.FormattingEnabled = true;
            comboBoxFilterFloorNo.Location = new Point(305, 13);
            comboBoxFilterFloorNo.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterFloorNo.Name = "comboBoxFilterFloorNo";
            comboBoxFilterFloorNo.Size = new Size(115, 32);
            comboBoxFilterFloorNo.TabIndex = 10;
            comboBoxFilterFloorNo.Text = " Floor No.";
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
            comboBoxFilterRoomNo.Text = " Room No.";
            // 
            // comboBoxFilterMaxCap
            // 
            comboBoxFilterMaxCap.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterMaxCap.FormattingEnabled = true;
            comboBoxFilterMaxCap.Location = new Point(430, 13);
            comboBoxFilterMaxCap.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterMaxCap.Name = "comboBoxFilterMaxCap";
            comboBoxFilterMaxCap.Size = new Size(146, 32);
            comboBoxFilterMaxCap.TabIndex = 8;
            comboBoxFilterMaxCap.Text = " Max. Capacity";
            // 
            // comboBoxFilterRoomType
            // 
            comboBoxFilterRoomType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomType.FormattingEnabled = true;
            comboBoxFilterRoomType.Location = new Point(152, 13);
            comboBoxFilterRoomType.Margin = new Padding(3, 4, 3, 4);
            comboBoxFilterRoomType.Name = "comboBoxFilterRoomType";
            comboBoxFilterRoomType.Size = new Size(141, 32);
            comboBoxFilterRoomType.TabIndex = 7;
            comboBoxFilterRoomType.Text = " Room Type";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(703, 13);
            comboBox2.Margin = new Padding(6, 7, 6, 7);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(138, 32);
            comboBox2.TabIndex = 6;
            comboBox2.Text = " Room Status";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnRoomNo, ColumnRoomType, ColumnFloorNo, ColumnMaxCap, ColumnRoomRate, ColumnRoomStatus });
            dataGridView1.Location = new Point(101, 220);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 347);
            dataGridView1.TabIndex = 5;
            // 
            // ColumnRoomNo
            // 
            ColumnRoomNo.HeaderText = "Room No.";
            ColumnRoomNo.MinimumWidth = 6;
            ColumnRoomNo.Name = "ColumnRoomNo";
            ColumnRoomNo.ReadOnly = true;
            ColumnRoomNo.Resizable = DataGridViewTriState.True;
            ColumnRoomNo.Width = 120;
            // 
            // ColumnRoomType
            // 
            ColumnRoomType.HeaderText = "Room Type";
            ColumnRoomType.MinimumWidth = 6;
            ColumnRoomType.Name = "ColumnRoomType";
            ColumnRoomType.ReadOnly = true;
            ColumnRoomType.Resizable = DataGridViewTriState.True;
            ColumnRoomType.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnRoomType.Width = 120;
            // 
            // ColumnFloorNo
            // 
            ColumnFloorNo.HeaderText = "Floor No.";
            ColumnFloorNo.MinimumWidth = 6;
            ColumnFloorNo.Name = "ColumnFloorNo";
            ColumnFloorNo.ReadOnly = true;
            ColumnFloorNo.Width = 120;
            // 
            // ColumnMaxCap
            // 
            ColumnMaxCap.HeaderText = "Max. Capacity";
            ColumnMaxCap.MinimumWidth = 6;
            ColumnMaxCap.Name = "ColumnMaxCap";
            ColumnMaxCap.ReadOnly = true;
            ColumnMaxCap.Width = 120;
            // 
            // ColumnRoomRate
            // 
            ColumnRoomRate.HeaderText = "Room Rate";
            ColumnRoomRate.MinimumWidth = 6;
            ColumnRoomRate.Name = "ColumnRoomRate";
            ColumnRoomRate.Width = 120;
            // 
            // ColumnRoomStatus
            // 
            ColumnRoomStatus.HeaderText = "Room Status";
            ColumnRoomStatus.MinimumWidth = 6;
            ColumnRoomStatus.Name = "ColumnRoomStatus";
            ColumnRoomStatus.Resizable = DataGridViewTriState.True;
            ColumnRoomStatus.Width = 120;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(166, 36);
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
            textBoxAddressSearch.Location = new Point(10, 16);
            textBoxAddressSearch.Margin = new Padding(3, 4, 3, 4);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(580, 31);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // labelRM
            // 
            labelRM.AutoSize = true;
            labelRM.BackColor = Color.Transparent;
            labelRM.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRM.Location = new Point(72, 65);
            labelRM.Name = "labelRM";
            labelRM.Size = new Size(395, 53);
            labelRM.TabIndex = 11;
            labelRM.Text = "Room Management";
            // 
            // UC_Room2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelBaseRooms1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Room2";
            Size = new Size(1230, 999);
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
            panelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBoxAddressSearch;
        private Label labelRM;
    }
}
