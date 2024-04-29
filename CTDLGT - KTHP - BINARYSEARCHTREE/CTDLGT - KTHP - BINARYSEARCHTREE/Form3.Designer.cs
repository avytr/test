namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    partial class Form3
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
            dtgvVaccine = new DataGridView();
            VaccineID = new DataGridViewTextBoxColumn();
            VaccineName = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            Origin = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnExit = new Button();
            btnAdd = new Button();
            txbOrigin = new TextBox();
            lbOrigin = new Label();
            txbCapacity = new TextBox();
            lbCapacity = new Label();
            txbName = new TextBox();
            lbName = new Label();
            txbID = new TextBox();
            lbID = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvVaccine).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvVaccine
            // 
            dtgvVaccine.BackgroundColor = Color.FromArgb(225, 237, 237);
            dtgvVaccine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvVaccine.Columns.AddRange(new DataGridViewColumn[] { VaccineID, VaccineName, Capacity, Origin });
            dtgvVaccine.Location = new Point(14, 265);
            dtgvVaccine.Margin = new Padding(3, 4, 3, 4);
            dtgvVaccine.Name = "dtgvVaccine";
            dtgvVaccine.RowHeadersWidth = 51;
            dtgvVaccine.Size = new Size(887, 319);
            dtgvVaccine.TabIndex = 0;
            // 
            // VaccineID
            // 
            VaccineID.DataPropertyName = "vaccine_id";
            VaccineID.HeaderText = "Số lô";
            VaccineID.MinimumWidth = 6;
            VaccineID.Name = "VaccineID";
            VaccineID.Width = 150;
            // 
            // VaccineName
            // 
            VaccineName.DataPropertyName = "vaccine_name";
            VaccineName.HeaderText = "Tên Vacxin";
            VaccineName.MinimumWidth = 6;
            VaccineName.Name = "VaccineName";
            VaccineName.Width = 200;
            // 
            // Capacity
            // 
            Capacity.DataPropertyName = "capacity";
            Capacity.HeaderText = "Số lượng";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            Capacity.Width = 125;
            // 
            // Origin
            // 
            Origin.DataPropertyName = "origin";
            Origin.HeaderText = "Xuất xứ";
            Origin.MinimumWidth = 6;
            Origin.Name = "Origin";
            Origin.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txbOrigin);
            panel1.Controls.Add(lbOrigin);
            panel1.Controls.Add(txbCapacity);
            panel1.Controls.Add(lbCapacity);
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(lbName);
            panel1.Controls.Add(txbID);
            panel1.Controls.Add(lbID);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 241);
            panel1.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(751, 117);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 44);
            btnExit.TabIndex = 10;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(225, 237, 237);
            btnAdd.Location = new Point(618, 117);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 44);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txbOrigin
            // 
            txbOrigin.Location = new Point(618, 65);
            txbOrigin.Margin = new Padding(3, 4, 3, 4);
            txbOrigin.Name = "txbOrigin";
            txbOrigin.Size = new Size(245, 27);
            txbOrigin.TabIndex = 7;
            // 
            // lbOrigin
            // 
            lbOrigin.AutoSize = true;
            lbOrigin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOrigin.Location = new Point(488, 65);
            lbOrigin.Name = "lbOrigin";
            lbOrigin.Size = new Size(84, 24);
            lbOrigin.TabIndex = 6;
            lbOrigin.Text = "Xuất xứ";
            // 
            // txbCapacity
            // 
            txbCapacity.Location = new Point(618, 24);
            txbCapacity.Margin = new Padding(3, 4, 3, 4);
            txbCapacity.Name = "txbCapacity";
            txbCapacity.Size = new Size(245, 27);
            txbCapacity.TabIndex = 5;
            // 
            // lbCapacity
            // 
            lbCapacity.AutoSize = true;
            lbCapacity.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCapacity.Location = new Point(488, 24);
            lbCapacity.Name = "lbCapacity";
            lbCapacity.Size = new Size(98, 24);
            lbCapacity.TabIndex = 4;
            lbCapacity.Text = "Số lượng";
            // 
            // txbName
            // 
            txbName.Location = new Point(127, 60);
            txbName.Margin = new Padding(3, 4, 3, 4);
            txbName.Name = "txbName";
            txbName.Size = new Size(245, 27);
            txbName.TabIndex = 3;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(14, 65);
            lbName.Name = "lbName";
            lbName.Size = new Size(114, 24);
            lbName.TabIndex = 2;
            lbName.Text = "Tên Vacxin";
            // 
            // txbID
            // 
            txbID.Location = new Point(127, 19);
            txbID.Margin = new Padding(3, 4, 3, 4);
            txbID.Name = "txbID";
            txbID.Size = new Size(245, 27);
            txbID.TabIndex = 1;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(14, 24);
            lbID.Name = "lbID";
            lbID.Size = new Size(58, 24);
            lbID.TabIndex = 0;
            lbID.Text = "Số lô";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(225, 237, 237);
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(dtgvVaccine);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách Vacxin";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvVaccine).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvVaccine;
        private DataGridViewTextBoxColumn VaccineID;
        private DataGridViewTextBoxColumn VaccineName;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn Origin;
        private Panel panel1;
        private Label lbName;
        private TextBox txbID;
        private Label lbID;
        private TextBox txbOrigin;
        private Label lbOrigin;
        private TextBox txbCapacity;
        private Label lbCapacity;
        private TextBox txbName;
        private Button btnAdd;
        private Button btnExit;
    }
}