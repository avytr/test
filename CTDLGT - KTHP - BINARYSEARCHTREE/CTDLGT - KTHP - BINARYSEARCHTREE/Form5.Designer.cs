namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    partial class Form5
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgvRecord = new DataGridView();
            RecordID = new DataGridViewTextBoxColumn();
            RecordName = new DataGridViewTextBoxColumn();
            GenderColumn = new DataGridViewTextBoxColumn();
            RecordBirthday = new DataGridViewTextBoxColumn();
            RecordAddress = new DataGridViewTextBoxColumn();
            RecordDose1 = new DataGridViewTextBoxColumn();
            RecordDose2 = new DataGridViewTextBoxColumn();
            RecordDose3 = new DataGridViewTextBoxColumn();
            RecordDose4 = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            btnExit = new Button();
            btnSortOldNew = new Button();
            cbbNewOld = new ComboBox();
            label2 = new Label();
            btnFindDate = new Button();
            dtpUntil = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            btnFindName = new Button();
            label1 = new Label();
            lbDate = new Label();
            txbName = new TextBox();
            lbName = new Label();
            tabPage2 = new TabPage();
            btnP2Exit = new Button();
            btnRemove = new Button();
            btnAdjust = new Button();
            btnAdd = new Button();
            label13 = new Label();
            panel3 = new Panel();
            txbP2Reaction = new TextBox();
            cbbP2VaccineName = new ComboBox();
            cbbP2ID = new ComboBox();
            cbbP2Location = new ComboBox();
            dtpP2Date = new DateTimePicker();
            lbM1Reaction = new Label();
            label11 = new Label();
            lbM1Address = new Label();
            label10 = new Label();
            lbM1Date = new Label();
            lb = new Label();
            lbM1VaccineID = new Label();
            lbVaccine_ID = new Label();
            lbM1Vaccine_name = new Label();
            label12 = new Label();
            cbbP2Dose = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            cbbP2Gender = new ComboBox();
            txbP2Address = new TextBox();
            dtpP2Birthday = new DateTimePicker();
            txbP2ID = new TextBox();
            txbP2Name = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvRecord).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvRecord
            // 
            dtgvRecord.BackgroundColor = Color.FromArgb(225, 237, 237);
            dtgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvRecord.Columns.AddRange(new DataGridViewColumn[] { RecordID, RecordName, GenderColumn, RecordBirthday, RecordAddress, RecordDose1, RecordDose2, RecordDose3, RecordDose4 });
            dtgvRecord.Location = new Point(16, 316);
            dtgvRecord.Name = "dtgvRecord";
            dtgvRecord.RowHeadersWidth = 51;
            dtgvRecord.Size = new Size(768, 122);
            dtgvRecord.TabIndex = 0;
            dtgvRecord.CellClick += dtgvRecord_CellContentClick;
            dtgvRecord.CellContentClick += dtgvRecord_CellContentClick;
            // 
            // RecordID
            // 
            RecordID.DataPropertyName = "id";
            RecordID.HeaderText = "ID";
            RecordID.MinimumWidth = 6;
            RecordID.Name = "RecordID";
            RecordID.Width = 125;
            // 
            // RecordName
            // 
            RecordName.DataPropertyName = "name";
            RecordName.HeaderText = "Họ và tên";
            RecordName.MinimumWidth = 6;
            RecordName.Name = "RecordName";
            RecordName.Width = 125;
            // 
            // GenderColumn
            // 
            GenderColumn.DataPropertyName = "gender";
            GenderColumn.HeaderText = "Giới tính";
            GenderColumn.MinimumWidth = 6;
            GenderColumn.Name = "GenderColumn";
            GenderColumn.Width = 125;
            // 
            // RecordBirthday
            // 
            RecordBirthday.DataPropertyName = "birthday";
            RecordBirthday.HeaderText = "Ngày sinh";
            RecordBirthday.MinimumWidth = 6;
            RecordBirthday.Name = "RecordBirthday";
            RecordBirthday.Width = 125;
            // 
            // RecordAddress
            // 
            RecordAddress.DataPropertyName = "address";
            RecordAddress.HeaderText = "Địa chỉ";
            RecordAddress.MinimumWidth = 6;
            RecordAddress.Name = "RecordAddress";
            RecordAddress.Width = 125;
            // 
            // RecordDose1
            // 
            RecordDose1.DataPropertyName = "dose1";
            RecordDose1.HeaderText = "Thông tin Mũi 1";
            RecordDose1.MinimumWidth = 6;
            RecordDose1.Name = "RecordDose1";
            RecordDose1.Width = 125;
            // 
            // RecordDose2
            // 
            RecordDose2.DataPropertyName = "dose2";
            RecordDose2.HeaderText = "Thông tin Mũi 2";
            RecordDose2.MinimumWidth = 6;
            RecordDose2.Name = "RecordDose2";
            RecordDose2.Width = 125;
            // 
            // RecordDose3
            // 
            RecordDose3.DataPropertyName = "dose3";
            RecordDose3.HeaderText = "Thông tin Mũi 3";
            RecordDose3.MinimumWidth = 6;
            RecordDose3.Name = "RecordDose3";
            RecordDose3.Width = 125;
            // 
            // RecordDose4
            // 
            RecordDose4.DataPropertyName = "dose4";
            RecordDose4.HeaderText = "Thông tin Mũi 4";
            RecordDose4.MinimumWidth = 6;
            RecordDose4.Name = "RecordDose4";
            RecordDose4.Width = 125;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 298);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 270);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Tìm kiếm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSortOldNew);
            panel1.Controls.Add(cbbNewOld);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnFindDate);
            panel1.Controls.Add(dtpUntil);
            panel1.Controls.Add(dtpFrom);
            panel1.Controls.Add(btnFindName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbDate);
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(lbName);
            panel1.Location = new Point(6, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 192);
            panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(687, 139);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(51, 40);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSortOldNew
            // 
            btnSortOldNew.BackColor = Color.FromArgb(225, 237, 237);
            btnSortOldNew.Location = new Point(687, 89);
            btnSortOldNew.Name = "btnSortOldNew";
            btnSortOldNew.Size = new Size(51, 24);
            btnSortOldNew.TabIndex = 13;
            btnSortOldNew.Text = "OK";
            btnSortOldNew.UseVisualStyleBackColor = false;
            btnSortOldNew.Click += btnSortOldNew_Click;
            // 
            // cbbNewOld
            // 
            cbbNewOld.FormattingEnabled = true;
            cbbNewOld.Items.AddRange(new object[] { "Mới nhất", "Cũ nhất" });
            cbbNewOld.Location = new Point(193, 89);
            cbbNewOld.Margin = new Padding(3, 2, 3, 2);
            cbbNewOld.Name = "cbbNewOld";
            cbbNewOld.Size = new Size(488, 23);
            cbbNewOld.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(159, 19);
            label2.TabIndex = 11;
            label2.Text = "Hiển thị theo hồ sơ:";
            // 
            // btnFindDate
            // 
            btnFindDate.BackColor = Color.FromArgb(225, 237, 237);
            btnFindDate.Location = new Point(687, 14);
            btnFindDate.Name = "btnFindDate";
            btnFindDate.Size = new Size(51, 52);
            btnFindDate.TabIndex = 9;
            btnFindDate.Text = "Tìm";
            btnFindDate.UseVisualStyleBackColor = false;
            btnFindDate.Click += btnFindDate_Click;
            // 
            // dtpUntil
            // 
            dtpUntil.Location = new Point(490, 43);
            dtpUntil.Name = "dtpUntil";
            dtpUntil.Size = new Size(189, 23);
            dtpUntil.TabIndex = 8;
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(490, 11);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(189, 23);
            dtpFrom.TabIndex = 7;
            // 
            // btnFindName
            // 
            btnFindName.BackColor = Color.FromArgb(225, 237, 237);
            btnFindName.Location = new Point(324, 9);
            btnFindName.Name = "btnFindName";
            btnFindName.Size = new Size(51, 24);
            btnFindName.TabIndex = 2;
            btnFindName.Text = "Tìm";
            btnFindName.UseVisualStyleBackColor = false;
            btnFindName.Click += btnFindName_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 43);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 6;
            label1.Text = "Đến ngày:";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDate.Location = new Point(397, 11);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(79, 19);
            lbDate.TabIndex = 4;
            lbDate.Text = "Từ ngày:";
            // 
            // txbName
            // 
            txbName.Location = new Point(121, 10);
            txbName.Name = "txbName";
            txbName.Size = new Size(197, 23);
            txbName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(12, 14);
            lbName.Name = "lbName";
            lbName.Size = new Size(94, 19);
            lbName.TabIndex = 2;
            lbName.Text = "Tên Hồ sơ:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnP2Exit);
            tabPage2.Controls.Add(btnRemove);
            tabPage2.Controls.Add(btnAdjust);
            tabPage2.Controls.Add(btnAdd);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(panel3);
            tabPage2.Controls.Add(cbbP2Dose);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 270);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Chỉnh sửa";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnP2Exit
            // 
            btnP2Exit.Location = new Point(713, 221);
            btnP2Exit.Name = "btnP2Exit";
            btnP2Exit.Size = new Size(48, 41);
            btnP2Exit.TabIndex = 24;
            btnP2Exit.Text = "Thoát";
            btnP2Exit.UseVisualStyleBackColor = true;
            btnP2Exit.Click += btnP2Exit_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(225, 237, 237);
            btnRemove.Location = new Point(657, 221);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(50, 41);
            btnRemove.TabIndex = 23;
            btnRemove.Text = "Xóa Hồ sơ";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdjust
            // 
            btnAdjust.BackColor = Color.FromArgb(225, 237, 237);
            btnAdjust.Location = new Point(601, 222);
            btnAdjust.Name = "btnAdjust";
            btnAdjust.Size = new Size(50, 41);
            btnAdjust.TabIndex = 22;
            btnAdjust.Text = "Thêm mũi";
            btnAdjust.UseVisualStyleBackColor = false;
            btnAdjust.Click += btnAdjust_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(225, 237, 237);
            btnAdd.Location = new Point(545, 222);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 41);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "Thêm Hồ sơ";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(7, 254);
            label13.Name = "label13";
            label13.Size = new Size(405, 13);
            label13.TabIndex = 20;
            label13.Text = "(*): Khi xóa hoặc cập nhật thêm thông tin các mũi sau cần nhập Số CCCD";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txbP2Reaction);
            panel3.Controls.Add(cbbP2VaccineName);
            panel3.Controls.Add(cbbP2ID);
            panel3.Controls.Add(cbbP2Location);
            panel3.Controls.Add(dtpP2Date);
            panel3.Controls.Add(lbM1Reaction);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(lbM1Address);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lbM1Date);
            panel3.Controls.Add(lb);
            panel3.Controls.Add(lbM1VaccineID);
            panel3.Controls.Add(lbVaccine_ID);
            panel3.Controls.Add(lbM1Vaccine_name);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(7, 144);
            panel3.Name = "panel3";
            panel3.Size = new Size(757, 72);
            panel3.TabIndex = 19;
            // 
            // txbP2Reaction
            // 
            txbP2Reaction.Location = new Point(632, 40);
            txbP2Reaction.Margin = new Padding(3, 2, 3, 2);
            txbP2Reaction.Name = "txbP2Reaction";
            txbP2Reaction.Size = new Size(110, 23);
            txbP2Reaction.TabIndex = 27;
            // 
            // cbbP2VaccineName
            // 
            cbbP2VaccineName.FormattingEnabled = true;
            cbbP2VaccineName.Location = new Point(105, 8);
            cbbP2VaccineName.Margin = new Padding(3, 2, 3, 2);
            cbbP2VaccineName.Name = "cbbP2VaccineName";
            cbbP2VaccineName.Size = new Size(145, 23);
            cbbP2VaccineName.TabIndex = 26;
            // 
            // cbbP2ID
            // 
            cbbP2ID.FormattingEnabled = true;
            cbbP2ID.Location = new Point(352, 8);
            cbbP2ID.Margin = new Padding(3, 2, 3, 2);
            cbbP2ID.Name = "cbbP2ID";
            cbbP2ID.Size = new Size(133, 23);
            cbbP2ID.TabIndex = 25;
            // 
            // cbbP2Location
            // 
            cbbP2Location.FormattingEnabled = true;
            cbbP2Location.Location = new Point(352, 38);
            cbbP2Location.Margin = new Padding(3, 2, 3, 2);
            cbbP2Location.Name = "cbbP2Location";
            cbbP2Location.Size = new Size(133, 23);
            cbbP2Location.TabIndex = 24;
            // 
            // dtpP2Date
            // 
            dtpP2Date.Location = new Point(107, 37);
            dtpP2Date.Margin = new Padding(3, 2, 3, 2);
            dtpP2Date.Name = "dtpP2Date";
            dtpP2Date.Size = new Size(143, 23);
            dtpP2Date.TabIndex = 22;
            // 
            // lbM1Reaction
            // 
            lbM1Reaction.AutoSize = true;
            lbM1Reaction.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbM1Reaction.Location = new Point(117, 78);
            lbM1Reaction.Name = "lbM1Reaction";
            lbM1Reaction.Size = new Size(0, 17);
            lbM1Reaction.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(511, 40);
            label11.Name = "label11";
            label11.Size = new Size(99, 18);
            label11.TabIndex = 20;
            label11.Text = "Triệu chứng:";
            // 
            // lbM1Address
            // 
            lbM1Address.AutoSize = true;
            lbM1Address.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbM1Address.Location = new Point(100, 56);
            lbM1Address.Name = "lbM1Address";
            lbM1Address.Size = new Size(0, 17);
            lbM1Address.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(265, 40);
            label10.Name = "label10";
            label10.Size = new Size(72, 18);
            label10.TabIndex = 18;
            label10.Text = "Nơi tiêm:";
            // 
            // lbM1Date
            // 
            lbM1Date.AutoSize = true;
            lbM1Date.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbM1Date.Location = new Point(100, 34);
            lbM1Date.Name = "lbM1Date";
            lbM1Date.Size = new Size(0, 17);
            lbM1Date.TabIndex = 14;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb.Location = new Point(11, 40);
            lb.Name = "lb";
            lb.Size = new Size(81, 18);
            lb.TabIndex = 17;
            lb.Text = "Ngày tiêm:";
            // 
            // lbM1VaccineID
            // 
            lbM1VaccineID.AutoSize = true;
            lbM1VaccineID.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbM1VaccineID.Location = new Point(275, 10);
            lbM1VaccineID.Name = "lbM1VaccineID";
            lbM1VaccineID.Size = new Size(0, 17);
            lbM1VaccineID.TabIndex = 16;
            // 
            // lbVaccine_ID
            // 
            lbVaccine_ID.AutoSize = true;
            lbVaccine_ID.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbVaccine_ID.Location = new Point(265, 12);
            lbVaccine_ID.Name = "lbVaccine_ID";
            lbVaccine_ID.Size = new Size(50, 18);
            lbVaccine_ID.TabIndex = 15;
            lbVaccine_ID.Text = "Mã lô:";
            // 
            // lbM1Vaccine_name
            // 
            lbM1Vaccine_name.AutoSize = true;
            lbM1Vaccine_name.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbM1Vaccine_name.Location = new Point(100, 10);
            lbM1Vaccine_name.Name = "lbM1Vaccine_name";
            lbM1Vaccine_name.Size = new Size(0, 17);
            lbM1Vaccine_name.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 10);
            label12.Name = "label12";
            label12.Size = new Size(89, 18);
            label12.TabIndex = 14;
            label12.Text = "Tên Vacxin:";
            // 
            // cbbP2Dose
            // 
            cbbP2Dose.FormattingEnabled = true;
            cbbP2Dose.Items.AddRange(new object[] { "Mũi 1", "Mũi 2", "Mũi 3", "Mũi 4" });
            cbbP2Dose.Location = new Point(115, 118);
            cbbP2Dose.Margin = new Padding(3, 2, 3, 2);
            cbbP2Dose.Name = "cbbP2Dose";
            cbbP2Dose.Size = new Size(91, 23);
            cbbP2Dose.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 121);
            label9.Name = "label9";
            label9.Size = new Size(82, 19);
            label9.TabIndex = 5;
            label9.Text = "Thông tin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 14);
            label8.Name = "label8";
            label8.Size = new Size(147, 19);
            label8.TabIndex = 4;
            label8.Text = "Thông tin cá nhân";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cbbP2Gender);
            panel2.Controls.Add(txbP2Address);
            panel2.Controls.Add(dtpP2Birthday);
            panel2.Controls.Add(txbP2ID);
            panel2.Controls.Add(txbP2Name);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(5, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 74);
            panel2.TabIndex = 3;
            // 
            // cbbP2Gender
            // 
            cbbP2Gender.FormattingEnabled = true;
            cbbP2Gender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbbP2Gender.Location = new Point(653, 8);
            cbbP2Gender.Margin = new Padding(3, 2, 3, 2);
            cbbP2Gender.Name = "cbbP2Gender";
            cbbP2Gender.Size = new Size(91, 23);
            cbbP2Gender.TabIndex = 17;
            // 
            // txbP2Address
            // 
            txbP2Address.Location = new Point(416, 42);
            txbP2Address.Margin = new Padding(3, 2, 3, 2);
            txbP2Address.Name = "txbP2Address";
            txbP2Address.Size = new Size(328, 23);
            txbP2Address.TabIndex = 16;
            // 
            // dtpP2Birthday
            // 
            dtpP2Birthday.Location = new Point(416, 8);
            dtpP2Birthday.Margin = new Padding(3, 2, 3, 2);
            dtpP2Birthday.Name = "dtpP2Birthday";
            dtpP2Birthday.Size = new Size(143, 23);
            dtpP2Birthday.TabIndex = 15;
            // 
            // txbP2ID
            // 
            txbP2ID.Location = new Point(108, 42);
            txbP2ID.Margin = new Padding(3, 2, 3, 2);
            txbP2ID.Name = "txbP2ID";
            txbP2ID.Size = new Size(183, 23);
            txbP2ID.TabIndex = 14;
            // 
            // txbP2Name
            // 
            txbP2Name.Location = new Point(108, 9);
            txbP2Name.Margin = new Padding(3, 2, 3, 2);
            txbP2Name.Name = "txbP2Name";
            txbP2Name.Size = new Size(183, 23);
            txbP2Name.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(564, 10);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 12;
            label6.Text = "Giới tính:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(315, 46);
            label4.Name = "label4";
            label4.Size = new Size(60, 18);
            label4.TabIndex = 10;
            label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 46);
            label3.Name = "label3";
            label3.Size = new Size(79, 18);
            label3.TabIndex = 8;
            label3.Text = "Số CCCD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(315, 10);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 6;
            label5.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(80, 18);
            label7.TabIndex = 4;
            label7.Text = "Họ và tên:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(225, 237, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(dtgvRecord);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvRecord).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvRecord;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button btnFindName;
        private Label label1;
        private Label lbDate;
        private TextBox txbName;
        private Label lbName;
        private DateTimePicker dtpUntil;
        private DateTimePicker dtpFrom;
        private Button btnFindDate;
        private DataGridViewTextBoxColumn RecordID;
        private DataGridViewTextBoxColumn RecordName;
        private DataGridViewTextBoxColumn GenderColumn;
        private DataGridViewTextBoxColumn RecordBirthday;
        private DataGridViewTextBoxColumn RecordAddress;
        private DataGridViewTextBoxColumn RecordDose1;
        private DataGridViewTextBoxColumn RecordDose2;
        private DataGridViewTextBoxColumn RecordDose3;
        private DataGridViewTextBoxColumn RecordDose4;
        private Button btnSortOldNew;
        private ComboBox cbbNewOld;
        private Label label2;
        private Panel panel2;
        private TextBox txbP2Name;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label7;
        private ComboBox cbbP2Gender;
        private TextBox txbP2Address;
        private DateTimePicker dtpP2Birthday;
        private TextBox txbP2ID;
        private ComboBox cbbP2Dose;
        private Label label9;
        private Label label8;
        private Panel panel3;
        private DateTimePicker dtpP2Date;
        private Label lbM1Reaction;
        private Label label11;
        private Label lbM1Address;
        private Label label10;
        private Label lbM1Date;
        private Label lb;
        private Label lbM1VaccineID;
        private Label lbVaccine_ID;
        private Label lbM1Vaccine_name;
        private Label label12;
        private TextBox txbP2Reaction;
        private ComboBox cbbP2VaccineName;
        private ComboBox cbbP2ID;
        private ComboBox cbbP2Location;
        private Label label13;
        private Button btnRemove;
        private Button btnAdjust;
        private Button btnAdd;
        private Button btnExit;
        private Button btnP2Exit;
    }
}