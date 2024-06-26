namespace PleasePleasePlease
{
    partial class UC_Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Accounts));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            GradButtonAddAccount = new Guna.UI2.WinForms.Guna2GradientButton();
            panelFilters = new Panel();
            comboBoxFilterAccountType = new ComboBox();
            panelSearch = new Panel();
            textBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            buttonSaveEditAccounts = new Button();
            buttonExitEditAccounts = new Button();
            buttonEditAccounts = new Button();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ColumnUserID = new DataGridViewTextBoxColumn();
            ColumnUsername = new DataGridViewTextBoxColumn();
            ColumnPassword = new DataGridViewTextBoxColumn();
            ColumnAccountType = new DataGridViewComboBoxColumn();
            buttonAddAcc = new Button();
            label9 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panelFilters.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 749);
            panel1.TabIndex = 25;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(GradButtonAddAccount);
            panel4.Controls.Add(panelFilters);
            panel4.Controls.Add(panelSearch);
            panel4.Controls.Add(guna2DataGridView1);
            panel4.Controls.Add(buttonAddAcc);
            panel4.Location = new Point(59, 96);
            panel4.Name = "panel4";
            panel4.Size = new Size(948, 620);
            panel4.TabIndex = 18;
            // 
            // GradButtonAddAccount
            // 
            GradButtonAddAccount.Animated = true;
            GradButtonAddAccount.AutoRoundedCorners = true;
            GradButtonAddAccount.BackColor = Color.Transparent;
            GradButtonAddAccount.BorderRadius = 29;
            GradButtonAddAccount.CustomizableEdges = customizableEdges1;
            GradButtonAddAccount.DisabledState.BorderColor = Color.DarkGray;
            GradButtonAddAccount.DisabledState.CustomBorderColor = Color.DarkGray;
            GradButtonAddAccount.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GradButtonAddAccount.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            GradButtonAddAccount.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GradButtonAddAccount.FillColor = Color.FromArgb(32, 191, 85);
            GradButtonAddAccount.FillColor2 = Color.SteelBlue;
            GradButtonAddAccount.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradButtonAddAccount.ForeColor = Color.White;
            GradButtonAddAccount.Location = new Point(705, 536);
            GradButtonAddAccount.Name = "GradButtonAddAccount";
            GradButtonAddAccount.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GradButtonAddAccount.Size = new Size(201, 61);
            GradButtonAddAccount.TabIndex = 28;
            GradButtonAddAccount.Text = "Add Account";
            GradButtonAddAccount.Click += GradButtonAddAccount_Click;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterAccountType);
            panelFilters.Location = new Point(191, 78);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(701, 50);
            panelFilters.TabIndex = 21;
            panelFilters.Visible = false;
            // 
            // comboBoxFilterAccountType
            // 
            comboBoxFilterAccountType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterAccountType.FormattingEnabled = true;
            comboBoxFilterAccountType.Location = new Point(13, 10);
            comboBoxFilterAccountType.Name = "comboBoxFilterAccountType";
            comboBoxFilterAccountType.Size = new Size(132, 27);
            comboBoxFilterAccountType.TabIndex = 9;
            comboBoxFilterAccountType.Text = "Account Type";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(buttonSaveEditAccounts);
            panelSearch.Controls.Add(buttonExitEditAccounts);
            panelSearch.Controls.Add(buttonEditAccounts);
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Location = new Point(191, 19);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(704, 53);
            panelSearch.TabIndex = 20;
            // 
            // textBoxSearch
            // 
            textBoxSearch.AutoRoundedCorners = true;
            textBoxSearch.BackColor = Color.Transparent;
            textBoxSearch.BorderRadius = 17;
            textBoxSearch.CustomizableEdges = customizableEdges3;
            textBoxSearch.DefaultText = "";
            textBoxSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textBoxSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textBoxSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textBoxSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textBoxSearch.Location = new Point(4, 9);
            textBoxSearch.Margin = new Padding(4, 4, 4, 4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PasswordChar = '\0';
            textBoxSearch.PlaceholderText = "Search";
            textBoxSearch.SelectedText = "";
            textBoxSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            textBoxSearch.Size = new Size(524, 36);
            textBoxSearch.TabIndex = 19;
            // 
            // buttonSaveEditAccounts
            // 
            buttonSaveEditAccounts.BackgroundImage = (Image)resources.GetObject("buttonSaveEditAccounts.BackgroundImage");
            buttonSaveEditAccounts.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveEditAccounts.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSaveEditAccounts.Location = new Point(673, 12);
            buttonSaveEditAccounts.Name = "buttonSaveEditAccounts";
            buttonSaveEditAccounts.Size = new Size(28, 27);
            buttonSaveEditAccounts.TabIndex = 13;
            buttonSaveEditAccounts.UseVisualStyleBackColor = true;
            buttonSaveEditAccounts.Visible = false;
            buttonSaveEditAccounts.Click += buttonSaveEditAccounts_Click;
            // 
            // buttonExitEditAccounts
            // 
            buttonExitEditAccounts.BackgroundImage = (Image)resources.GetObject("buttonExitEditAccounts.BackgroundImage");
            buttonExitEditAccounts.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExitEditAccounts.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExitEditAccounts.Location = new Point(639, 12);
            buttonExitEditAccounts.Name = "buttonExitEditAccounts";
            buttonExitEditAccounts.Size = new Size(28, 27);
            buttonExitEditAccounts.TabIndex = 12;
            buttonExitEditAccounts.UseVisualStyleBackColor = true;
            buttonExitEditAccounts.Visible = false;
            buttonExitEditAccounts.Click += buttonExitEditAccounts_Click;
            // 
            // buttonEditAccounts
            // 
            buttonEditAccounts.BackgroundImage = (Image)resources.GetObject("buttonEditAccounts.BackgroundImage");
            buttonEditAccounts.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditAccounts.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditAccounts.Location = new Point(673, 12);
            buttonEditAccounts.Name = "buttonEditAccounts";
            buttonEditAccounts.Size = new Size(28, 27);
            buttonEditAccounts.TabIndex = 11;
            buttonEditAccounts.UseVisualStyleBackColor = true;
            buttonEditAccounts.Click += buttonEditAccounts_Click;
            // 
            // buttonMore
            // 
            buttonMore.BackgroundImage = (Image)resources.GetObject("buttonMore.BackgroundImage");
            buttonMore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMore.Location = new Point(569, 12);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(28, 27);
            buttonMore.TabIndex = 4;
            buttonMore.UseVisualStyleBackColor = true;
            buttonMore.Click += buttonMore_Click;
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
            buttonSearchIcon.Click += buttonSearchIcon_Click;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 17;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnUserID, ColumnUsername, ColumnPassword, ColumnAccountType });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(69, 134);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.Size = new Size(823, 386);
            guna2DataGridView1.TabIndex = 3;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ColumnUserID
            // 
            ColumnUserID.HeaderText = "User ID";
            ColumnUserID.Name = "ColumnUserID";
            ColumnUserID.ReadOnly = true;
            // 
            // ColumnUsername
            // 
            ColumnUsername.HeaderText = "Username";
            ColumnUsername.Name = "ColumnUsername";
            ColumnUsername.ReadOnly = true;
            // 
            // ColumnPassword
            // 
            ColumnPassword.HeaderText = "Password";
            ColumnPassword.Name = "ColumnPassword";
            ColumnPassword.ReadOnly = true;
            // 
            // ColumnAccountType
            // 
            ColumnAccountType.HeaderText = "Account Type";
            ColumnAccountType.Name = "ColumnAccountType";
            ColumnAccountType.ReadOnly = true;
            ColumnAccountType.Resizable = DataGridViewTriState.True;
            ColumnAccountType.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // buttonAddAcc
            // 
            buttonAddAcc.BackColor = Color.FromArgb(45, 106, 79);
            buttonAddAcc.Enabled = false;
            buttonAddAcc.FlatStyle = FlatStyle.System;
            buttonAddAcc.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddAcc.Location = new Point(761, 536);
            buttonAddAcc.Name = "buttonAddAcc";
            buttonAddAcc.Size = new Size(134, 41);
            buttonAddAcc.TabIndex = 2;
            buttonAddAcc.Text = "Add Account";
            buttonAddAcc.UseVisualStyleBackColor = false;
            buttonAddAcc.Visible = false;
            buttonAddAcc.Click += buttonAddAcc_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(49, 44);
            label9.Name = "label9";
            label9.Size = new Size(169, 42);
            label9.TabIndex = 11;
            label9.Text = "Accounts";
            // 
            // UC_Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Accounts";
            Size = new Size(1076, 749);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private Panel panel6;
        private TextBox textBox1;
        private Label label2;
        private Panel panel7;
        private TextBox textBox2;
        private Label label3;
        private Panel panel8;
        private TextBox textBox3;
        private Label label4;
        private Panel panel9;
        private ComboBox comboBox1;
        private Label label5;
        private Button buttonAddAcc;
        private Panel panel10;
        private ComboBox comboBox2;
        private Label label6;
        private Panel panel11;
        private TextBox textBox4;
        private Label label7;
        private Panel panel12;
        private Label label8;
        private Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private Panel panelFilters;
        private ComboBox comboBoxFilterAccountType;
        private Button buttonSaveEditAccounts;
        private Button buttonExitEditAccounts;
        private Button buttonEditAccounts;
        private DataGridViewTextBoxColumn ColumnUserID;
        private DataGridViewTextBoxColumn ColumnUsername;
        private DataGridViewTextBoxColumn ColumnPassword;
        private DataGridViewComboBoxColumn ColumnAccountType;
        private Guna.UI2.WinForms.Guna2GradientButton GradButtonAddAccount;
        private Guna.UI2.WinForms.Guna2TextBox textBoxSearch;
    }
}
