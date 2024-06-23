namespace PleasePleasePlease
{
    partial class UC_Guest1 : UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Guest1));
            panel9 = new Panel();
            panelAddGuest = new Panel();
            panelListofGuest = new Panel();
            panelFilters = new Panel();
            comboBoxFilterGender = new ComboBox();
            dataGridViewGuest = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            panel16 = new Panel();
            buttonMore = new Button();
            buttonSearch = new Button();
            textBox1 = new TextBox();
            buttonAddGuest = new Button();
            panel6 = new Panel();
            textBoxContactNo = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            textBoxNationality = new TextBox();
            label5 = new Label();
            panel8 = new Panel();
            comboBoxGender = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            textBoxEmail = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBoxAddress = new TextBox();
            label8 = new Label();
            panel11 = new Panel();
            dateTimePickerBirthdate = new DateTimePicker();
            label9 = new Label();
            panel12 = new Panel();
            textBoxMiddleInitial = new TextBox();
            label10 = new Label();
            panel13 = new Panel();
            textBoxFirstName = new TextBox();
            label11 = new Label();
            panel14 = new Panel();
            textBoxLastName = new TextBox();
            label12 = new Label();
            panel15 = new Panel();
            textBoxGuestID = new TextBox();
            label13 = new Label();
            label7 = new Label();
            panelAddaGuest = new Panel();
            panelContainer = new Panel();
            labelAddGuest = new Label();
            panel10 = new Panel();
            labelListofGuest = new Label();
            comboBoxNationality = new ComboBox();
            comboBoxCity = new ComboBox();
            comboBoxState = new ComboBox();
            panel9.SuspendLayout();
            panelAddGuest.SuspendLayout();
            panelListofGuest.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuest).BeginInit();
            panel16.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.BackgroundImage = (Image)resources.GetObject("panel9.BackgroundImage");
            panel9.Controls.Add(panelAddGuest);
            panel9.Controls.Add(label7);
            panel9.Controls.Add(panelAddaGuest);
            panel9.Controls.Add(panel10);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1076, 749);
            panel9.TabIndex = 23;
            // 
            // panelAddGuest
            // 
            panelAddGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelAddGuest.Controls.Add(panelListofGuest);
            panelAddGuest.Controls.Add(buttonAddGuest);
            panelAddGuest.Controls.Add(panel6);
            panelAddGuest.Controls.Add(panel7);
            panelAddGuest.Controls.Add(panel8);
            panelAddGuest.Controls.Add(panel1);
            panelAddGuest.Controls.Add(panel2);
            panelAddGuest.Controls.Add(panel11);
            panelAddGuest.Controls.Add(panel12);
            panelAddGuest.Controls.Add(panel13);
            panelAddGuest.Controls.Add(panel14);
            panelAddGuest.Controls.Add(panel15);
            panelAddGuest.Location = new Point(54, 123);
            panelAddGuest.Name = "panelAddGuest";
            panelAddGuest.Size = new Size(958, 593);
            panelAddGuest.TabIndex = 23;
            // 
            // panelListofGuest
            // 
            panelListofGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelListofGuest.BackgroundImageLayout = ImageLayout.Zoom;
            panelListofGuest.Controls.Add(panelFilters);
            panelListofGuest.Controls.Add(dataGridViewGuest);
            panelListofGuest.Controls.Add(panel16);
            panelListofGuest.Location = new Point(-6, 0);
            panelListofGuest.Name = "panelListofGuest";
            panelListofGuest.Size = new Size(964, 593);
            panelListofGuest.TabIndex = 20;
            panelListofGuest.Visible = false;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxState);
            panelFilters.Controls.Add(comboBoxCity);
            panelFilters.Controls.Add(comboBoxNationality);
            panelFilters.Controls.Add(comboBoxFilterGender);
            panelFilters.Location = new Point(111, 78);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 15;
            panelFilters.Visible = false;
            // 
            // comboBoxFilterGender
            // 
            comboBoxFilterGender.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterGender.FormattingEnabled = true;
            comboBoxFilterGender.Location = new Point(13, 10);
            comboBoxFilterGender.Name = "comboBoxFilterGender";
            comboBoxFilterGender.Size = new Size(112, 27);
            comboBoxFilterGender.TabIndex = 9;
            comboBoxFilterGender.Text = "Gender";
            // 
            // dataGridViewGuest
            // 
            dataGridViewGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGuest.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9 });
            dataGridViewGuest.Location = new Point(69, 134);
            dataGridViewGuest.Name = "dataGridViewGuest";
            dataGridViewGuest.Size = new Size(823, 260);
            dataGridViewGuest.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Guest ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Last Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "First Name";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "M.I.";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Gender";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 90;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Birth Date";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewTextBoxColumn6.Width = 90;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Age";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Nationality";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 110;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Address";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 190;
            // 
            // panel16
            // 
            panel16.Controls.Add(buttonMore);
            panel16.Controls.Add(buttonSearch);
            panel16.Controls.Add(textBox1);
            panel16.Location = new Point(191, 19);
            panel16.Name = "panel16";
            panel16.Size = new Size(624, 53);
            panel16.TabIndex = 13;
            // 
            // buttonMore
            // 
            buttonMore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMore.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMore.Location = new Point(569, 12);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(28, 27);
            buttonMore.TabIndex = 4;
            buttonMore.UseVisualStyleBackColor = true;
            buttonMore.Click += buttonMore_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearch.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(535, 12);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(28, 27);
            buttonSearch.TabIndex = 3;
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.WindowFrame;
            textBox1.Location = new Point(9, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search";
            textBox1.WordWrap = false;
            // 
            // buttonAddGuest
            // 
            buttonAddGuest.BackColor = Color.FromArgb(27, 67, 50);
            buttonAddGuest.FlatAppearance.BorderColor = Color.FromArgb(27, 67, 50);
            buttonAddGuest.FlatStyle = FlatStyle.Flat;
            buttonAddGuest.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddGuest.ForeColor = Color.White;
            buttonAddGuest.Location = new Point(725, 512);
            buttonAddGuest.Name = "buttonAddGuest";
            buttonAddGuest.Size = new Size(186, 49);
            buttonAddGuest.TabIndex = 11;
            buttonAddGuest.Text = "Add Guest";
            buttonAddGuest.UseVisualStyleBackColor = false;
            buttonAddGuest.Click += buttonAddGuest_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxContactNo);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(421, 401);
            panel6.Name = "panel6";
            panel6.Size = new Size(317, 67);
            panel6.TabIndex = 5;
            // 
            // textBoxContactNo
            // 
            textBoxContactNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactNo.Location = new Point(9, 34);
            textBoxContactNo.Name = "textBoxContactNo";
            textBoxContactNo.Size = new Size(279, 27);
            textBoxContactNo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 6);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 0;
            label4.Text = "Contact Number";
            // 
            // panel7
            // 
            panel7.Controls.Add(textBoxNationality);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(610, 215);
            panel7.Name = "panel7";
            panel7.Size = new Size(226, 67);
            panel7.TabIndex = 6;
            // 
            // textBoxNationality
            // 
            textBoxNationality.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNationality.Location = new Point(9, 36);
            textBoxNationality.Name = "textBoxNationality";
            textBoxNationality.Size = new Size(199, 27);
            textBoxNationality.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 6);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 0;
            label5.Text = "Nationality";
            // 
            // panel8
            // 
            panel8.Controls.Add(comboBoxGender);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(350, 215);
            panel8.Name = "panel8";
            panel8.Size = new Size(194, 67);
            panel8.TabIndex = 5;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DisplayMember = "Male";
            comboBoxGender.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(9, 36);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(157, 27);
            comboBoxGender.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 6);
            label1.Name = "label1";
            label1.Size = new Size(75, 23);
            label1.TabIndex = 0;
            label1.Text = "Gender";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 67);
            panel1.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.AllowDrop = true;
            textBoxEmail.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(9, 34);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(279, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 6);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 0;
            label2.Text = "Email";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxAddress);
            panel2.Controls.Add(label8);
            panel2.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(24, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 67);
            panel2.TabIndex = 4;
            // 
            // textBoxAddress
            // 
            textBoxAddress.AllowDrop = true;
            textBoxAddress.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(9, 34);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(511, 27);
            textBoxAddress.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 8);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 0;
            label8.Text = "Address";
            // 
            // panel11
            // 
            panel11.Controls.Add(dateTimePickerBirthdate);
            panel11.Controls.Add(label9);
            panel11.Location = new Point(24, 215);
            panel11.Name = "panel11";
            panel11.Size = new Size(288, 67);
            panel11.TabIndex = 4;
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerBirthdate.Location = new Point(8, 36);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(277, 27);
            dateTimePickerBirthdate.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(9, 6);
            label9.Name = "label9";
            label9.Size = new Size(91, 23);
            label9.TabIndex = 0;
            label9.Text = "Birthdate";
            // 
            // panel12
            // 
            panel12.Controls.Add(textBoxMiddleInitial);
            panel12.Controls.Add(label10);
            panel12.Location = new Point(610, 122);
            panel12.Name = "panel12";
            panel12.Size = new Size(226, 67);
            panel12.TabIndex = 5;
            // 
            // textBoxMiddleInitial
            // 
            textBoxMiddleInitial.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMiddleInitial.Location = new Point(9, 34);
            textBoxMiddleInitial.Name = "textBoxMiddleInitial";
            textBoxMiddleInitial.Size = new Size(199, 27);
            textBoxMiddleInitial.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 6);
            label10.Name = "label10";
            label10.Size = new Size(121, 23);
            label10.TabIndex = 0;
            label10.Text = "Middle Initial";
            // 
            // panel13
            // 
            panel13.Controls.Add(textBoxFirstName);
            panel13.Controls.Add(label11);
            panel13.Location = new Point(318, 122);
            panel13.Name = "panel13";
            panel13.Size = new Size(226, 67);
            panel13.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(9, 34);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(199, 27);
            textBoxFirstName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(9, 6);
            label11.Name = "label11";
            label11.Size = new Size(104, 23);
            label11.TabIndex = 0;
            label11.Text = "First Name";
            // 
            // panel14
            // 
            panel14.Controls.Add(textBoxLastName);
            panel14.Controls.Add(label12);
            panel14.Location = new Point(24, 122);
            panel14.Name = "panel14";
            panel14.Size = new Size(226, 67);
            panel14.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.Location = new Point(9, 34);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(199, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(9, 6);
            label12.Name = "label12";
            label12.Size = new Size(102, 23);
            label12.TabIndex = 0;
            label12.Text = "Last Name";
            // 
            // panel15
            // 
            panel15.Controls.Add(textBoxGuestID);
            panel15.Controls.Add(label13);
            panel15.Location = new Point(24, 28);
            panel15.Name = "panel15";
            panel15.Size = new Size(226, 67);
            panel15.TabIndex = 2;
            // 
            // textBoxGuestID
            // 
            textBoxGuestID.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxGuestID.Location = new Point(9, 34);
            textBoxGuestID.Name = "textBoxGuestID";
            textBoxGuestID.Size = new Size(199, 27);
            textBoxGuestID.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(9, 6);
            label13.Name = "label13";
            label13.Size = new Size(85, 23);
            label13.TabIndex = 0;
            label13.Text = "Guest ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 33);
            label7.Name = "label7";
            label7.Size = new Size(328, 42);
            label7.TabIndex = 20;
            label7.Text = "Guest Management";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelAddaGuest.Controls.Add(panelContainer);
            panelAddaGuest.Controls.Add(labelAddGuest);
            panelAddaGuest.Location = new Point(54, 92);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(153, 32);
            panelAddaGuest.TabIndex = 21;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(0, 31);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(958, 593);
            panelContainer.TabIndex = 24;
            // 
            // labelAddGuest
            // 
            labelAddGuest.AutoSize = true;
            labelAddGuest.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddGuest.Location = new Point(18, 5);
            labelAddGuest.Name = "labelAddGuest";
            labelAddGuest.Size = new Size(116, 23);
            labelAddGuest.TabIndex = 8;
            labelAddGuest.Text = "Add a Guest";
            labelAddGuest.Click += labelAddGuest_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.MediumSeaGreen;
            panel10.Controls.Add(labelListofGuest);
            panel10.Location = new Point(204, 92);
            panel10.Name = "panel10";
            panel10.Size = new Size(170, 32);
            panel10.TabIndex = 22;
            // 
            // labelListofGuest
            // 
            labelListofGuest.AutoSize = true;
            labelListofGuest.BackColor = Color.Transparent;
            labelListofGuest.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListofGuest.Location = new Point(18, 5);
            labelListofGuest.Name = "labelListofGuest";
            labelListofGuest.Size = new Size(131, 23);
            labelListofGuest.TabIndex = 9;
            labelListofGuest.Text = "List of Guests";
            labelListofGuest.Click += labelListofGuest_Click;
            // 
            // comboBoxNationality
            // 
            comboBoxNationality.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxNationality.FormattingEnabled = true;
            comboBoxNationality.Location = new Point(131, 11);
            comboBoxNationality.Name = "comboBoxNationality";
            comboBoxNationality.Size = new Size(112, 27);
            comboBoxNationality.TabIndex = 10;
            comboBoxNationality.Text = "Nationality";
            // 
            // comboBoxCity
            // 
            comboBoxCity.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(249, 11);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(112, 27);
            comboBoxCity.TabIndex = 11;
            comboBoxCity.Text = "City";
            // 
            // comboBoxState
            // 
            comboBoxState.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(367, 11);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(112, 27);
            comboBoxState.TabIndex = 12;
            comboBoxState.Text = "State";
            // 
            // UC_Guest1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel9);
            Name = "UC_Guest1";
            Size = new Size(1076, 749);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panelAddGuest.ResumeLayout(false);
            panelListofGuest.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGuest).EndInit();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
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
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel9;
        private Label label7;
        private Panel panelAddaGuest;
        private Label labelAddGuest;
        private Panel panel10;
        private Label labelListofGuest;
        private Panel panelAddGuest;
        private Button buttonAddGuest;
        private Panel panel6;
        private TextBox textBoxContactNo;
        private Label label4;
        private Panel panel7;
        private TextBox textBoxNationality;
        private Label label5;
        private Panel panel8;
        private ComboBox comboBoxGender;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxEmail;
        private Label label2;
        private Panel panel2;
        private TextBox textBoxAddress;
        private Label label8;
        private Panel panel11;
        private DateTimePicker dateTimePickerBirthdate;
        private Label label9;
        private Panel panel12;
        private TextBox textBoxMiddleInitial;
        private Label label10;
        private Panel panel13;
        private TextBox textBoxFirstName;
        private Label label11;
        private Panel panel14;
        private TextBox textBoxLastName;
        private Label label12;
        private Panel panel15;
        private TextBox textBoxGuestID;
        private Label label13;
        private Panel panelContainer;
        private Panel panelListofGuest;
        private Panel panelFilters;
        private ComboBox comboBoxFilterGender;
        private DataGridView dataGridViewGuest;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Panel panel16;
        private Button buttonMore;
        private Button buttonSearch;
        private TextBox textBox1;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxNationality;
        private ComboBox comboBoxState;
    }
}
