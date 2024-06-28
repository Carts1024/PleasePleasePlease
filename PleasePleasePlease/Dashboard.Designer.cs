namespace Mirai_Paradise_Hotel
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Other fields and controls declared in the form

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panelBase = new Panel();
            panelLogOut = new Panel();
            GradButtonLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
            buttonLogout = new Button();
            panel1 = new Panel();
            buttonAccounts = new Button();
            buttonAnalytics = new Button();
            buttonBilling = new Button();
            buttonBooking = new Button();
            buttonRooms = new Button();
            buttonGuests = new Button();
            buttonDashboard = new Button();
            panelContainer = new Panel();
            panelBase.SuspendLayout();
            panelLogOut.SuspendLayout();
            SuspendLayout();
            // 
            // panelBase
            // 
            panelBase.BackColor = Color.FromArgb(45, 106, 79);
            panelBase.Controls.Add(buttonRooms);
            panelBase.Controls.Add(panelLogOut);
            panelBase.Controls.Add(panel1);
            panelBase.Controls.Add(buttonAccounts);
            panelBase.Controls.Add(buttonAnalytics);
            panelBase.Controls.Add(buttonBilling);
            panelBase.Controls.Add(buttonBooking);
            panelBase.Controls.Add(buttonGuests);
            panelBase.Controls.Add(buttonDashboard);
            panelBase.Dock = DockStyle.Left;
            panelBase.Location = new Point(0, 0);
            panelBase.Margin = new Padding(3, 2, 3, 2);
            panelBase.Name = "panelBase";
            panelBase.Size = new Size(258, 749);
            panelBase.TabIndex = 0;
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(GradButtonLogOut);
            panelLogOut.Controls.Add(buttonLogout);
            panelLogOut.Location = new Point(85, 673);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(177, 54);
            panelLogOut.TabIndex = 9;
            // 
            // GradButtonLogOut
            // 
            GradButtonLogOut.Animated = true;
            GradButtonLogOut.AutoRoundedCorners = true;
            GradButtonLogOut.BackColor = Color.Transparent;
            GradButtonLogOut.BorderRadius = 16;
            GradButtonLogOut.CustomizableEdges = customizableEdges1;
            GradButtonLogOut.DisabledState.BorderColor = Color.DarkGray;
            GradButtonLogOut.DisabledState.CustomBorderColor = Color.DarkGray;
            GradButtonLogOut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            GradButtonLogOut.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            GradButtonLogOut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            GradButtonLogOut.FillColor = Color.FromArgb(32, 191, 85);
            GradButtonLogOut.FillColor2 = Color.SteelBlue;
            GradButtonLogOut.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradButtonLogOut.ForeColor = Color.White;
            GradButtonLogOut.Location = new Point(25, 10);
            GradButtonLogOut.Name = "GradButtonLogOut";
            GradButtonLogOut.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GradButtonLogOut.Size = new Size(137, 35);
            GradButtonLogOut.TabIndex = 28;
            GradButtonLogOut.Text = "Log Out";
            GradButtonLogOut.Click += GradButtonLogOut_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.White;
            buttonLogout.Enabled = false;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.Black;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(25, 28);
            buttonLogout.Margin = new Padding(3, 2, 3, 2);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(13, 0, 0, 0);
            buttonLogout.Size = new Size(132, 17);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "    Log Out";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Visible = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 209);
            panel1.TabIndex = 7;
            // 
            // buttonAccounts
            // 
            buttonAccounts.FlatAppearance.BorderSize = 0;
            buttonAccounts.FlatStyle = FlatStyle.Flat;
            buttonAccounts.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAccounts.ForeColor = Color.Transparent;
            buttonAccounts.Image = (Image)resources.GetObject("buttonAccounts.Image");
            buttonAccounts.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAccounts.Location = new Point(0, 580);
            buttonAccounts.Margin = new Padding(3, 2, 3, 2);
            buttonAccounts.Name = "buttonAccounts";
            buttonAccounts.Padding = new Padding(13, 0, 0, 0);
            buttonAccounts.Size = new Size(257, 56);
            buttonAccounts.TabIndex = 6;
            buttonAccounts.Text = "    Accounts";
            buttonAccounts.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccounts.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAccounts.UseVisualStyleBackColor = true;
            buttonAccounts.Visible = false;
            buttonAccounts.Click += buttonSettings_Click;
            // 
            // buttonAnalytics
            // 
            buttonAnalytics.FlatAppearance.BorderSize = 0;
            buttonAnalytics.FlatStyle = FlatStyle.Flat;
            buttonAnalytics.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAnalytics.ForeColor = Color.Transparent;
            buttonAnalytics.Image = (Image)resources.GetObject("buttonAnalytics.Image");
            buttonAnalytics.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAnalytics.Location = new Point(0, 520);
            buttonAnalytics.Margin = new Padding(3, 2, 3, 2);
            buttonAnalytics.Name = "buttonAnalytics";
            buttonAnalytics.Padding = new Padding(13, 0, 0, 0);
            buttonAnalytics.Size = new Size(257, 56);
            buttonAnalytics.TabIndex = 5;
            buttonAnalytics.Text = "    Analytics";
            buttonAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            buttonAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAnalytics.UseVisualStyleBackColor = true;
            buttonAnalytics.Visible = false;
            buttonAnalytics.Click += buttonAnalytics_Click;
            // 
            // buttonBilling
            // 
            buttonBilling.FlatAppearance.BorderSize = 0;
            buttonBilling.FlatStyle = FlatStyle.Flat;
            buttonBilling.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBilling.ForeColor = Color.Transparent;
            buttonBilling.Image = (Image)resources.GetObject("buttonBilling.Image");
            buttonBilling.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBilling.Location = new Point(3, 402);
            buttonBilling.Margin = new Padding(3, 2, 3, 2);
            buttonBilling.Name = "buttonBilling";
            buttonBilling.Padding = new Padding(13, 0, 0, 0);
            buttonBilling.Size = new Size(257, 56);
            buttonBilling.TabIndex = 4;
            buttonBilling.Text = "    Billing";
            buttonBilling.TextAlign = ContentAlignment.MiddleLeft;
            buttonBilling.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBilling.UseVisualStyleBackColor = true;
            buttonBilling.Click += buttonBilling_Click;
            // 
            // buttonBooking
            // 
            buttonBooking.FlatAppearance.BorderSize = 0;
            buttonBooking.FlatStyle = FlatStyle.Flat;
            buttonBooking.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBooking.ForeColor = Color.Transparent;
            buttonBooking.Image = (Image)resources.GetObject("buttonBooking.Image");
            buttonBooking.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBooking.Location = new Point(3, 342);
            buttonBooking.Margin = new Padding(3, 2, 3, 2);
            buttonBooking.Name = "buttonBooking";
            buttonBooking.Padding = new Padding(13, 0, 0, 0);
            buttonBooking.Size = new Size(257, 56);
            buttonBooking.TabIndex = 3;
            buttonBooking.Text = "    Booking";
            buttonBooking.TextAlign = ContentAlignment.MiddleLeft;
            buttonBooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonBooking.UseVisualStyleBackColor = true;
            buttonBooking.Click += buttonBooking_Click;
            // 
            // buttonRooms
            // 
            buttonRooms.FlatAppearance.BorderSize = 0;
            buttonRooms.FlatStyle = FlatStyle.Flat;
            buttonRooms.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRooms.ForeColor = Color.Transparent;
            buttonRooms.Image = (Image)resources.GetObject("buttonRooms.Image");
            buttonRooms.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRooms.Location = new Point(3, 460);
            buttonRooms.Margin = new Padding(3, 2, 3, 2);
            buttonRooms.Name = "buttonRooms";
            buttonRooms.Padding = new Padding(13, 0, 0, 0);
            buttonRooms.Size = new Size(257, 56);
            buttonRooms.TabIndex = 2;
            buttonRooms.Text = "    Rooms";
            buttonRooms.TextAlign = ContentAlignment.MiddleLeft;
            buttonRooms.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRooms.UseVisualStyleBackColor = true;
            buttonRooms.Visible = false;
            buttonRooms.Click += buttonRooms_Click;
            // 
            // buttonGuests
            // 
            buttonGuests.FlatAppearance.BorderSize = 0;
            buttonGuests.FlatStyle = FlatStyle.Flat;
            buttonGuests.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGuests.ForeColor = Color.Transparent;
            buttonGuests.Image = (Image)resources.GetObject("buttonGuests.Image");
            buttonGuests.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuests.Location = new Point(0, 282);
            buttonGuests.Margin = new Padding(3, 2, 3, 2);
            buttonGuests.Name = "buttonGuests";
            buttonGuests.Padding = new Padding(13, 0, 0, 0);
            buttonGuests.Size = new Size(262, 56);
            buttonGuests.TabIndex = 1;
            buttonGuests.Text = "    Guests";
            buttonGuests.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGuests.UseVisualStyleBackColor = true;
            buttonGuests.Click += buttonGuests_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("SF Pro Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDashboard.ForeColor = Color.Transparent;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 223);
            buttonDashboard.Margin = new Padding(3, 2, 3, 2);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(13, 0, 0, 0);
            buttonDashboard.Size = new Size(257, 56);
            buttonDashboard.TabIndex = 0;
            buttonDashboard.Text = "    Dashboard";
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panelContainer
            // 
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.AutoScroll = true;
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Location = new Point(258, -2);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.MaximumSize = new Size(1920, 1080);
            panelContainer.MinimumSize = new Size(1112, 749);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1920, 1080);
            panelContainer.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelContainer);
            Controls.Add(panelBase);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            panelBase.ResumeLayout(false);
            panelLogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Button buttonAccounts;
        private System.Windows.Forms.Button buttonAnalytics;
        private System.Windows.Forms.Button buttonBilling;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Button buttonGuests;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelContainer;
        private Panel panel1;
        private Button buttonLogout;
        private Panel panelLogOut;
        private Guna.UI2.WinForms.Guna2GradientButton GradButtonLogOut;
    }
}