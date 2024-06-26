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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            ButtonGenerateInvo = new Guna.UI2.WinForms.Guna2GradientButton();
            buttonGenerateInvoice = new Button();
            labelGuestInvoice = new Label();
            panelAddaGuest = new Panel();
            labelTableGuestInvoice = new Label();
            panelBaseTable = new Panel();
            panelFilters = new Panel();
            comboBoxFilterPaymentStatus = new ComboBox();
            panelSearch = new Panel();
            buttonSaveEditBillings = new Button();
            buttonEditBillings = new Button();
            buttonExitEditBillings = new Button();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            dataGridViewInvoice = new DataGridView();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnBookingID = new DataGridViewTextBoxColumn();
            ColumnInvoiceNumber = new DataGridViewTextBoxColumn();
            ColumnDateIssued = new DataGridViewTextBoxColumn();
            ColumnDueDate = new DataGridViewTextBoxColumn();
            ColumnPaymentStatus = new DataGridViewComboBoxColumn();
            userBindingSource1 = new BindingSource(components);
            userBindingSource = new BindingSource(components);
            panel3.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            panelBaseTable.SuspendLayout();
            panelFilters.SuspendLayout();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(ButtonGenerateInvo);
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
            // ButtonGenerateInvo
            // 
            ButtonGenerateInvo.Animated = true;
            ButtonGenerateInvo.AutoRoundedCorners = true;
            ButtonGenerateInvo.BackColor = Color.Transparent;
            ButtonGenerateInvo.BorderRadius = 29;
            ButtonGenerateInvo.CustomizableEdges = customizableEdges1;
            ButtonGenerateInvo.DisabledState.BorderColor = Color.DarkGray;
            ButtonGenerateInvo.DisabledState.CustomBorderColor = Color.DarkGray;
            ButtonGenerateInvo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ButtonGenerateInvo.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            ButtonGenerateInvo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ButtonGenerateInvo.FillColor = Color.FromArgb(32, 191, 85);
            ButtonGenerateInvo.FillColor2 = Color.SteelBlue;
            ButtonGenerateInvo.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonGenerateInvo.ForeColor = Color.White;
            ButtonGenerateInvo.Location = new Point(766, 26);
            ButtonGenerateInvo.Name = "ButtonGenerateInvo";
            ButtonGenerateInvo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ButtonGenerateInvo.Size = new Size(201, 61);
            ButtonGenerateInvo.TabIndex = 27;
            ButtonGenerateInvo.Text = "Generate Invoice";
            ButtonGenerateInvo.Click += ButtonGenerateInvo_Click;
            // 
            // buttonGenerateInvoice
            // 
            buttonGenerateInvoice.BackColor = Color.FromArgb(27, 67, 50);
            buttonGenerateInvoice.Enabled = false;
            buttonGenerateInvoice.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonGenerateInvoice.FlatStyle = FlatStyle.Flat;
            buttonGenerateInvoice.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGenerateInvoice.ForeColor = Color.White;
            buttonGenerateInvoice.Location = new Point(870, 38);
            buttonGenerateInvoice.Name = "buttonGenerateInvoice";
            buttonGenerateInvoice.Size = new Size(97, 49);
            buttonGenerateInvoice.TabIndex = 18;
            buttonGenerateInvoice.Text = "Generate Invoice";
            buttonGenerateInvoice.UseVisualStyleBackColor = false;
            buttonGenerateInvoice.Click += buttonGenerateInvoice_Click;
            // 
            // labelGuestInvoice
            // 
            labelGuestInvoice.AutoSize = true;
            labelGuestInvoice.BackColor = Color.Transparent;
            labelGuestInvoice.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGuestInvoice.Location = new Point(51, 15);
            labelGuestInvoice.Name = "labelGuestInvoice";
            labelGuestInvoice.Size = new Size(231, 42);
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
            labelTableGuestInvoice.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTableGuestInvoice.Location = new Point(12, 5);
            labelTableGuestInvoice.Name = "labelTableGuestInvoice";
            labelTableGuestInvoice.Size = new Size(130, 23);
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
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterPaymentStatus);
            panelFilters.Location = new Point(191, 78);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(701, 50);
            panelFilters.TabIndex = 20;
            panelFilters.Visible = false;
            // 
            // comboBoxFilterPaymentStatus
            // 
            comboBoxFilterPaymentStatus.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterPaymentStatus.FormattingEnabled = true;
            comboBoxFilterPaymentStatus.Location = new Point(13, 10);
            comboBoxFilterPaymentStatus.Name = "comboBoxFilterPaymentStatus";
            comboBoxFilterPaymentStatus.Size = new Size(157, 28);
            comboBoxFilterPaymentStatus.TabIndex = 9;
            comboBoxFilterPaymentStatus.Text = "Payment Status";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonSaveEditBillings);
            panelSearch.Controls.Add(buttonEditBillings);
            panelSearch.Controls.Add(buttonExitEditBillings);
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(191, 19);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(701, 53);
            panelSearch.TabIndex = 19;
            // 
            // buttonSaveEditBillings
            // 
            buttonSaveEditBillings.BackgroundImage = (Image)resources.GetObject("buttonSaveEditBillings.BackgroundImage");
            buttonSaveEditBillings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveEditBillings.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSaveEditBillings.Location = new Point(673, 12);
            buttonSaveEditBillings.Name = "buttonSaveEditBillings";
            buttonSaveEditBillings.Size = new Size(28, 27);
            buttonSaveEditBillings.TabIndex = 14;
            buttonSaveEditBillings.UseVisualStyleBackColor = true;
            buttonSaveEditBillings.Visible = false;
            buttonSaveEditBillings.Click += buttonSaveEditBillings_Click;
            // 
            // buttonEditBillings
            // 
            buttonEditBillings.BackgroundImage = (Image)resources.GetObject("buttonEditBillings.BackgroundImage");
            buttonEditBillings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditBillings.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditBillings.Location = new Point(673, 12);
            buttonEditBillings.Name = "buttonEditBillings";
            buttonEditBillings.Size = new Size(28, 27);
            buttonEditBillings.TabIndex = 13;
            buttonEditBillings.UseVisualStyleBackColor = true;
            buttonEditBillings.Click += buttonEditBillings_Click;
            // 
            // buttonExitEditBillings
            // 
            buttonExitEditBillings.BackgroundImage = (Image)resources.GetObject("buttonExitEditBillings.BackgroundImage");
            buttonExitEditBillings.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExitEditBillings.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExitEditBillings.Location = new Point(639, 12);
            buttonExitEditBillings.Name = "buttonExitEditBillings";
            buttonExitEditBillings.Size = new Size(28, 27);
            buttonExitEditBillings.TabIndex = 11;
            buttonExitEditBillings.UseVisualStyleBackColor = true;
            buttonExitEditBillings.Visible = false;
            buttonExitEditBillings.Click += buttonExitEditBookings_Click;
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
            textBoxAddressSearch.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressSearch.ForeColor = SystemColors.WindowFrame;
            textBoxAddressSearch.Location = new Point(1, 12);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.PlaceholderText = "Search";
            textBoxAddressSearch.Size = new Size(508, 27);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.WordWrap = false;
            // 
            // dataGridViewInvoice
            // 
            dataGridViewInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvoice.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnBookingID, ColumnInvoiceNumber, ColumnDateIssued, ColumnDueDate, ColumnPaymentStatus });
            dataGridViewInvoice.Location = new Point(69, 134);
            dataGridViewInvoice.Name = "dataGridViewInvoice";
            dataGridViewInvoice.RowHeadersWidth = 51;
            dataGridViewInvoice.Size = new Size(823, 415);
            dataGridViewInvoice.TabIndex = 18;
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
            // ColumnBookingID
            // 
            ColumnBookingID.HeaderText = "Booking ID";
            ColumnBookingID.MinimumWidth = 6;
            ColumnBookingID.Name = "ColumnBookingID";
            ColumnBookingID.ReadOnly = true;
            ColumnBookingID.Width = 130;
            // 
            // ColumnInvoiceNumber
            // 
            ColumnInvoiceNumber.HeaderText = "Invoice Number";
            ColumnInvoiceNumber.MinimumWidth = 6;
            ColumnInvoiceNumber.Name = "ColumnInvoiceNumber";
            ColumnInvoiceNumber.ReadOnly = true;
            ColumnInvoiceNumber.Width = 130;
            // 
            // ColumnDateIssued
            // 
            ColumnDateIssued.HeaderText = "Date Issued";
            ColumnDateIssued.MinimumWidth = 6;
            ColumnDateIssued.Name = "ColumnDateIssued";
            ColumnDateIssued.ReadOnly = true;
            ColumnDateIssued.Resizable = DataGridViewTriState.True;
            ColumnDateIssued.Width = 130;
            // 
            // ColumnDueDate
            // 
            ColumnDueDate.HeaderText = "Due Date";
            ColumnDueDate.MinimumWidth = 6;
            ColumnDueDate.Name = "ColumnDueDate";
            ColumnDueDate.ReadOnly = true;
            ColumnDueDate.Resizable = DataGridViewTriState.True;
            ColumnDueDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnDueDate.Width = 130;
            // 
            // ColumnPaymentStatus
            // 
            ColumnPaymentStatus.HeaderText = "Payment Status";
            ColumnPaymentStatus.MinimumWidth = 6;
            ColumnPaymentStatus.Name = "ColumnPaymentStatus";
            ColumnPaymentStatus.ReadOnly = true;
            ColumnPaymentStatus.Resizable = DataGridViewTriState.True;
            ColumnPaymentStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnPaymentStatus.Width = 120;
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Mirai_Paradise_Hotel.User);
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
            panelFilters.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
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
        private BindingSource userBindingSource;
        private BindingSource userBindingSource1;
        private Button buttonExitEditBillings;
        private Button buttonEditBillings;
        private Button buttonSaveEditBillings;
        private DataGridViewTextBoxColumn ColumnGuestID;
        private DataGridViewTextBoxColumn ColumnBookingID;
        private DataGridViewTextBoxColumn ColumnInvoiceNumber;
        private DataGridViewTextBoxColumn ColumnDateIssued;
        private DataGridViewTextBoxColumn ColumnDueDate;
        private DataGridViewComboBoxColumn ColumnPaymentStatus;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonGenerateInvo;
    }
}
