namespace PleasePleasePlease
{
    partial class UC_Billing
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Billing));
            panel3 = new Panel();
            buttonGenerateInvoice = new Button();
            labelGuestInvoice = new Label();
            panelAddaGuest = new Panel();
            labelTableGuestInvoice = new Label();
            panelBaseTable = new Panel();
            userBindingSource1 = new BindingSource(components);
            panelFilters = new Panel();
            comboBoxFilterPaymentStatus = new ComboBox();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            dataGridViewInvoice = new DataGridView();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnBookingID = new DataGridViewTextBoxColumn();
            ColumnInvoiceNumber = new DataGridViewTextBoxColumn();
            ColumnIssueDate = new DataGridViewTextBoxColumn();
            ColumnDueDate = new DataGridViewTextBoxColumn();
            ColumnPaymentStatus = new DataGridViewComboBoxColumn();
            ColumnPaymentMethod = new DataGridViewComboBoxColumn();
            userBindingSource = new BindingSource(components);
            panel3.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            panelBaseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            panelFilters.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(buttonGenerateInvoice);
            panel3.Controls.Add(labelGuestInvoice);
            panel3.Controls.Add(panelAddaGuest);
            panel3.Controls.Add(panelBaseTable);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1076, 749);
            panel3.TabIndex = 20;
            // 
            // buttonGenerateInvoice
            // 
            buttonGenerateInvoice.BackColor = Color.FromArgb(27, 67, 50);
            buttonGenerateInvoice.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonGenerateInvoice.FlatStyle = FlatStyle.Flat;
            buttonGenerateInvoice.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateInvoice.ForeColor = Color.White;
            buttonGenerateInvoice.Location = new Point(794, 18);
            buttonGenerateInvoice.Name = "buttonGenerateInvoice";
            buttonGenerateInvoice.Size = new Size(186, 49);
            buttonGenerateInvoice.TabIndex = 18;
            buttonGenerateInvoice.Text = "Generate Invoice";
            buttonGenerateInvoice.UseVisualStyleBackColor = false;
            buttonGenerateInvoice.Click += buttonGenerateInvoice_Click;
            // 
            // labelGuestInvoice
            // 
            labelGuestInvoice.AutoSize = true;
            labelGuestInvoice.BackColor = Color.Transparent;
            labelGuestInvoice.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGuestInvoice.Location = new Point(51, 15);
            labelGuestInvoice.Name = "labelGuestInvoice";
            labelGuestInvoice.Size = new Size(242, 39);
            labelGuestInvoice.TabIndex = 16;
            labelGuestInvoice.Text = "Guest Invoice";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelAddaGuest.Controls.Add(labelTableGuestInvoice);
            panelAddaGuest.Location = new Point(53, 74);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(153, 32);
            panelAddaGuest.TabIndex = 17;
            // 
            // labelTableGuestInvoice
            // 
            labelTableGuestInvoice.AutoSize = true;
            labelTableGuestInvoice.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTableGuestInvoice.Location = new Point(12, 5);
            labelTableGuestInvoice.Name = "labelTableGuestInvoice";
            labelTableGuestInvoice.Size = new Size(137, 24);
            labelTableGuestInvoice.TabIndex = 9;
            labelTableGuestInvoice.Text = "Guest Invoice";
            // 
            // panelBaseTable
            // 
            panelBaseTable.BackColor = Color.FromArgb(76, 149, 108);
            panelBaseTable.BackgroundImageLayout = ImageLayout.Zoom;
            panelBaseTable.Controls.Add(panelFilters);
            panelBaseTable.Controls.Add(panelSearch);
            panelBaseTable.Controls.Add(dataGridViewInvoice);
            panelBaseTable.Location = new Point(53, 105);
            panelBaseTable.Name = "panelBaseTable";
            panelBaseTable.Size = new Size(927, 577);
            panelBaseTable.TabIndex = 14;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Mirai_Paradise_Hotel.User);
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterPaymentStatus);
            panelFilters.Location = new Point(111, 78);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 20;
            panelFilters.Visible = false;
            // 
            // comboBoxFilterPaymentStatus
            // 
            comboBoxFilterPaymentStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterPaymentStatus.FormattingEnabled = true;
            comboBoxFilterPaymentStatus.Location = new Point(13, 10);
            comboBoxFilterPaymentStatus.Name = "comboBoxFilterPaymentStatus";
            comboBoxFilterPaymentStatus.Size = new Size(132, 28);
            comboBoxFilterPaymentStatus.TabIndex = 9;
            comboBoxFilterPaymentStatus.Text = "Payment Status";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(191, 19);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 19;
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
            // textBoxAddressSearch
            // 
            textBoxAddressSearch.Enabled = false;
            textBoxAddressSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressSearch.ForeColor = SystemColors.WindowFrame;
            textBoxAddressSearch.Location = new Point(1, 12);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(508, 26);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnBookingID, ColumnInvoiceNumber, ColumnIssueDate, ColumnDueDate, ColumnPaymentStatus, ColumnPaymentMethod });
            dataGridViewInvoice.Location = new Point(69, 134);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.Size = new Size(823, 260);
            dataGridViewInvoice.TabIndex = 18;
            // 
            // ColumnGuestID
            // 
            ColumnGuestID.HeaderText = "Guest ID";
            ColumnGuestID.Name = "ColumnGuestID";
            ColumnGuestID.Resizable = DataGridViewTriState.True;
            ColumnGuestID.Width = 120;
            // 
            // ColumnBookingID
            // 
            ColumnBookingID.HeaderText = "Booking ID";
            ColumnBookingID.Name = "ColumnBookingID";
            ColumnBookingID.Width = 120;
            // 
            // ColumnInvoiceNumber
            // 
            ColumnInvoiceNumber.HeaderText = "Invoice Number";
            ColumnInvoiceNumber.Name = "ColumnInvoiceNumber";
            ColumnInvoiceNumber.Width = 120;
            // 
            // ColumnIssueDate
            // 
            ColumnIssueDate.HeaderText = "Issue Date";
            ColumnIssueDate.Name = "ColumnIssueDate";
            ColumnIssueDate.Resizable = DataGridViewTriState.True;
            ColumnIssueDate.Width = 120;
            // 
            // ColumnDueDate
            // 
            ColumnDueDate.HeaderText = "Due Date";
            ColumnDueDate.Name = "ColumnDueDate";
            ColumnDueDate.Resizable = DataGridViewTriState.True;
            ColumnDueDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnDueDate.Width = 120;
            // 
            // ColumnPaymentStatus
            // 
            ColumnPaymentStatus.HeaderText = "Payment Status";
            ColumnPaymentStatus.Name = "ColumnPaymentStatus";
            ColumnPaymentStatus.Resizable = DataGridViewTriState.True;
            ColumnPaymentStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnPaymentStatus.Width = 120;
            // 
            // ColumnPaymentMethod
            // 
            ColumnPaymentMethod.HeaderText = "Payment Method";
            ColumnPaymentMethod.Name = "ColumnPaymentMethod";
            ColumnPaymentMethod.Resizable = DataGridViewTriState.True;
            ColumnPaymentMethod.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnPaymentMethod.Width = 130;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Mirai_Paradise_Hotel.User);
            // 
            // UC_Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Name = "UC_Billing";
            Size = new Size(1076, 749);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            panelBaseTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            panelFilters.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label labelGuestInvoice;
        private Panel panelAddaGuest;
        private Label labelTableGuestInvoice;
        private Panel panelBaseTable;
        private Panel panelFilters;
        private ComboBox comboBoxFilterPaymentStatus;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private Button buttonGenerateInvoice;
        private DataGridView dataGridViewInvoice;
        private DataGridViewTextBoxColumn ColumnGuestID;
        private DataGridViewTextBoxColumn ColumnBookingID;
        private DataGridViewTextBoxColumn ColumnInvoiceNumber;
        private DataGridViewTextBoxColumn ColumnIssueDate;
        private DataGridViewTextBoxColumn ColumnDueDate;
        private DataGridViewComboBoxColumn ColumnPaymentStatus;
        private DataGridViewComboBoxColumn ColumnPaymentMethod;
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
    }
}
