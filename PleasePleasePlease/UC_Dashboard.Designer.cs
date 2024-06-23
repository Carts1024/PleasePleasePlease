namespace PleasePleasePlease
{
    partial class UC_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Dashboard));
            panel1 = new Panel();
            label30 = new Label();
            label25 = new Label();
            panel18 = new Panel();
            dataGridView1 = new DataGridView();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnRoomNo = new DataGridViewTextBoxColumn();
            ColumnCheckInDate = new DataGridViewTextBoxColumn();
            ColumnCheckInTime = new DataGridViewTextBoxColumn();
            ColumnCheckOutDate = new DataGridViewTextBoxColumn();
            ColumnCheckOutTime = new DataGridViewTextBoxColumn();
            panelSearch = new Panel();
            comboBox1 = new ComboBox();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            panel17 = new Panel();
            label29 = new Label();
            label23 = new Label();
            label24 = new Label();
            button4 = new Button();
            pictureBox4 = new PictureBox();
            panel16 = new Panel();
            label28 = new Label();
            label21 = new Label();
            label22 = new Label();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            panel15 = new Panel();
            label27 = new Label();
            label19 = new Label();
            label20 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel14 = new Panel();
            label26 = new Label();
            label18 = new Label();
            label17 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            panel4 = new Panel();
            panel12 = new Panel();
            label13 = new Label();
            panel13 = new Panel();
            label14 = new Label();
            label15 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            label10 = new Label();
            panel11 = new Panel();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            panel8 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            label6 = new Label();
            panel6 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel12.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label30);
            panel1.Controls.Add(label25);
            panel1.Controls.Add(panel18);
            panel1.Controls.Add(panel17);
            panel1.Controls.Add(panel16);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1920, 1080);
            panel1.MinimumSize = new Size(1076, 749);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 19;
            // 
            // label30
            // 
            label30.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label30.AutoSize = true;
            label30.BackColor = Color.Transparent;
            label30.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(811, 32);
            label30.Name = "label30";
            label30.Size = new Size(257, 33);
            label30.TabIndex = 22;
            label30.Text = "Day, Month, Year";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(27, 522);
            label25.Name = "label25";
            label25.Size = new Size(178, 25);
            label25.TabIndex = 21;
            label25.Text = "Booking History";
            // 
            // panel18
            // 
            panel18.BackColor = Color.FromArgb(45, 106, 79);
            panel18.BackgroundImageLayout = ImageLayout.Zoom;
            panel18.Controls.Add(dataGridView1);
            panel18.Controls.Add(panelSearch);
            panel18.Location = new Point(27, 550);
            panel18.Name = "panel18";
            panel18.Size = new Size(1061, 593);
            panel18.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnRoomNo, ColumnCheckInDate, ColumnCheckInTime, ColumnCheckOutDate, ColumnCheckOutTime });
            dataGridView1.Location = new Point(65, 72);
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
            panelSearch.Controls.Add(comboBox1);
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(29, 13);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(788, 53);
            panelSearch.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(630, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 28);
            comboBox1.TabIndex = 18;
            comboBox1.Text = "   Date";
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
            // panel17
            // 
            panel17.BackColor = Color.FromArgb(64, 145, 108);
            panel17.Controls.Add(label29);
            panel17.Controls.Add(label23);
            panel17.Controls.Add(label24);
            panel17.Controls.Add(button4);
            panel17.Controls.Add(pictureBox4);
            panel17.Location = new Point(848, 295);
            panel17.Name = "panel17";
            panel17.Size = new Size(254, 220);
            panel17.TabIndex = 15;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.FromArgb(255, 255, 128);
            label29.Location = new Point(181, 190);
            label29.Name = "label29";
            label29.Size = new Size(47, 16);
            label29.TabIndex = 15;
            label29.Text = "₱1,479";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label23.Location = new Point(29, 170);
            label23.Name = "label23";
            label23.Size = new Size(71, 16);
            label23.TabIndex = 13;
            label23.Text = "Penthouse";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(29, 157);
            label24.Name = "label24";
            label24.Size = new Size(96, 16);
            label24.TabIndex = 12;
            label24.Text = "Room No: 30";
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(171, 153);
            button4.Name = "button4";
            button4.Size = new Size(69, 33);
            button4.TabIndex = 11;
            button4.Text = "Book";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(30, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(195, 131);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // panel16
            // 
            panel16.BackColor = Color.FromArgb(64, 145, 108);
            panel16.Controls.Add(label28);
            panel16.Controls.Add(label21);
            panel16.Controls.Add(label22);
            panel16.Controls.Add(button3);
            panel16.Controls.Add(pictureBox3);
            panel16.Location = new Point(575, 295);
            panel16.Name = "panel16";
            panel16.Size = new Size(254, 220);
            panel16.TabIndex = 15;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.FromArgb(255, 255, 128);
            label28.Location = new Point(182, 188);
            label28.Name = "label28";
            label28.Size = new Size(47, 16);
            label28.TabIndex = 15;
            label28.Text = "₱1,479";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.Location = new Point(29, 170);
            label21.Name = "label21";
            label21.Size = new Size(49, 16);
            label21.TabIndex = 13;
            label21.Text = "Deluxe";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(29, 157);
            label22.Name = "label22";
            label22.Size = new Size(96, 16);
            label22.TabIndex = 12;
            label22.Text = "Room No: 27";
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(171, 153);
            button3.Name = "button3";
            button3.Size = new Size(69, 33);
            button3.TabIndex = 11;
            button3.Text = "Book";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(30, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(195, 131);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(64, 145, 108);
            panel15.Controls.Add(label27);
            panel15.Controls.Add(label19);
            panel15.Controls.Add(label20);
            panel15.Controls.Add(button2);
            panel15.Controls.Add(pictureBox2);
            panel15.Location = new Point(301, 295);
            panel15.Name = "panel15";
            panel15.Size = new Size(254, 220);
            panel15.TabIndex = 15;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.FromArgb(255, 255, 128);
            label27.Location = new Point(183, 188);
            label27.Name = "label27";
            label27.Size = new Size(47, 16);
            label27.TabIndex = 15;
            label27.Text = "₱1,479";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label19.Location = new Point(29, 170);
            label19.Name = "label19";
            label19.Size = new Size(49, 16);
            label19.TabIndex = 13;
            label19.Text = "Deluxe";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(29, 157);
            label20.Name = "label20";
            label20.Size = new Size(96, 16);
            label20.TabIndex = 12;
            label20.Text = "Room No: 24";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(171, 153);
            button2.Name = "button2";
            button2.Size = new Size(69, 33);
            button2.TabIndex = 11;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(30, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 131);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(64, 145, 108);
            panel14.Controls.Add(label26);
            panel14.Controls.Add(label18);
            panel14.Controls.Add(label17);
            panel14.Controls.Add(button1);
            panel14.Controls.Add(pictureBox1);
            panel14.Location = new Point(27, 295);
            panel14.Name = "panel14";
            panel14.Size = new Size(254, 220);
            panel14.TabIndex = 14;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(255, 255, 128);
            label26.Location = new Point(181, 189);
            label26.Name = "label26";
            label26.Size = new Size(47, 16);
            label26.TabIndex = 14;
            label26.Text = "₱1,479";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label18.Location = new Point(29, 170);
            label18.Name = "label18";
            label18.Size = new Size(60, 16);
            label18.TabIndex = 13;
            label18.Text = "Premium";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(29, 157);
            label17.Name = "label17";
            label17.Size = new Size(96, 16);
            label17.TabIndex = 12;
            label17.Text = "Room No: 23";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(171, 153);
            button1.Name = "button1";
            button1.Size = new Size(69, 33);
            button1.TabIndex = 11;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(30, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 131);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(27, 269);
            label16.Name = "label16";
            label16.Size = new Size(188, 25);
            label16.TabIndex = 13;
            label16.Text = "Available Rooms";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel4.BackColor = Color.FromArgb(45, 106, 79);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(814, 104);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 145);
            panel4.TabIndex = 12;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel12.BackColor = Color.MediumSeaGreen;
            panel12.Controls.Add(label13);
            panel12.Location = new Point(0, 109);
            panel12.Name = "panel12";
            panel12.Size = new Size(254, 36);
            panel12.TabIndex = 9;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(65, 11);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(121, 15);
            label13.TabIndex = 0;
            label13.Text = "V I E W   D E T A I L S";
            // 
            // panel13
            // 
            panel13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel13.BackgroundImage = (Image)resources.GetObject("panel13.BackgroundImage");
            panel13.BackgroundImageLayout = ImageLayout.Zoom;
            panel13.Location = new Point(11, 29);
            panel13.Name = "panel13";
            panel13.Size = new Size(55, 59);
            panel13.TabIndex = 8;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(72, 46);
            label14.Name = "label14";
            label14.Size = new Size(37, 39);
            label14.TabIndex = 7;
            label14.Text = "8";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.White;
            label15.Location = new Point(72, 20);
            label15.Name = "label15";
            label15.Size = new Size(184, 24);
            label15.TabIndex = 6;
            label15.Text = "Pending Payments";
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(45, 106, 79);
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(label11);
            panel9.Controls.Add(label12);
            panel9.Location = new Point(552, 104);
            panel9.Name = "panel9";
            panel9.Size = new Size(254, 145);
            panel9.TabIndex = 11;
            // 
            // panel10
            // 
            panel10.BackColor = Color.MediumSeaGreen;
            panel10.Controls.Add(label10);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 109);
            panel10.Name = "panel10";
            panel10.Size = new Size(254, 36);
            panel10.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(65, 11);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(121, 15);
            label10.TabIndex = 0;
            label10.Text = "V I E W   D E T A I L S";
            // 
            // panel11
            // 
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.BackgroundImageLayout = ImageLayout.Zoom;
            panel11.Location = new Point(11, 29);
            panel11.Name = "panel11";
            panel11.Size = new Size(55, 59);
            panel11.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(72, 46);
            label11.Name = "label11";
            label11.Size = new Size(37, 39);
            label11.TabIndex = 7;
            label11.Text = "3";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(72, 20);
            label12.Name = "label12";
            label12.Size = new Size(135, 24);
            label12.TabIndex = 6;
            label12.Text = "Cancellations";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 106, 79);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(290, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 145);
            panel3.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.BackColor = Color.MediumSeaGreen;
            panel7.Controls.Add(label7);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 109);
            panel7.Name = "panel7";
            panel7.Size = new Size(254, 36);
            panel7.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(65, 11);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(121, 15);
            label7.TabIndex = 0;
            label7.Text = "V I E W   D E T A I L S";
            // 
            // panel8
            // 
            panel8.BackgroundImage = (Image)resources.GetObject("panel8.BackgroundImage");
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Location = new Point(11, 29);
            panel8.Name = "panel8";
            panel8.Size = new Size(55, 59);
            panel8.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(72, 46);
            label8.Name = "label8";
            label8.Size = new Size(57, 39);
            label8.TabIndex = 7;
            label8.Text = "22";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(72, 20);
            label9.Name = "label9";
            label9.Size = new Size(96, 24);
            label9.TabIndex = 6;
            label9.Text = "Bookings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(27, 30);
            label5.Name = "label5";
            label5.Size = new Size(301, 33);
            label5.TabIndex = 6;
            label5.Text = "Ad Astra Abyssosque!";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 106, 79);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(27, 104);
            panel5.Name = "panel5";
            panel5.Size = new Size(254, 145);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 36);
            panel2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 11);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(121, 15);
            label6.TabIndex = 0;
            label6.Text = "V I E W   D E T A I L S";
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(11, 29);
            panel6.Name = "panel6";
            panel6.Size = new Size(55, 59);
            panel6.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 46);
            label4.Name = "label4";
            label4.Size = new Size(57, 39);
            label4.TabIndex = 7;
            label4.Text = "15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 20);
            label3.Name = "label3";
            label3.Size = new Size(166, 24);
            label3.TabIndex = 6;
            label3.Text = "Available Rooms";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(1008, 65);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 1;
            label1.Text = "Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Right;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1672, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 30, 0, 0);
            label2.Size = new Size(248, 63);
            label2.TabIndex = 0;
            label2.Text = "Month Day, Year";
            // 
            // UC_Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UC_Dashboard";
            Size = new Size(1076, 749);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Panel panel2;
        private Panel panel6;
        private Label label4;
        private Panel panel9;
        private Panel panel10;
        private Label label10;
        private Panel panel11;
        private Label label11;
        private Label label12;
        private Panel panel3;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Label label9;
        private Label label6;
        private Panel panel4;
        private Panel panel12;
        private Label label13;
        private Panel panel13;
        private Label label14;
        private Label label15;
        private Panel panel14;
        private PictureBox pictureBox1;
        private Label label16;
        private Label label18;
        private Label label17;
        private Button button1;
        private Panel panel17;
        private Label label23;
        private Label label24;
        private Button button4;
        private PictureBox pictureBox4;
        private Panel panel16;
        private Label label21;
        private Label label22;
        private Button button3;
        private PictureBox pictureBox3;
        private Panel panel15;
        private Label label19;
        private Label label20;
        private Button button2;
        private PictureBox pictureBox2;
        private Label label25;
        private Panel panel18;
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
        private TextBox textBoxAddressSearch;
        private ComboBox comboBox1;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label30;
    }
}
