namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbName = new Label();
            txbName = new TextBox();
            lbPassword = new Label();
            txbPassword = new TextBox();
            btnSignIn = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(26, 14);
            lbName.Name = "lbName";
            lbName.Size = new Size(150, 22);
            lbName.TabIndex = 0;
            lbName.Text = "Tên đăng nhập";
            // 
            // txbName
            // 
            txbName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbName.Location = new Point(26, 39);
            txbName.Multiline = true;
            txbName.Name = "txbName";
            txbName.Size = new Size(289, 28);
            txbName.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.Transparent;
            lbPassword.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(26, 83);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(95, 22);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Mật khẩu";
            // 
            // txbPassword
            // 
            txbPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbPassword.Location = new Point(26, 108);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(289, 27);
            txbPassword.TabIndex = 3;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.OldLace;
            btnSignIn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(127, 155);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(91, 33);
            btnSignIn.TabIndex = 4;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(224, 155);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(91, 33);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(txbPassword);
            panel1.Controls.Add(lbPassword);
            panel1.Controls.Add(txbName);
            panel1.Controls.Add(lbName);
            panel1.Location = new Point(75, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 194);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.Login;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbName;
        private TextBox txbName;
        private Label lbPassword;
        private TextBox txbPassword;
        private Button btnSignIn;
        private Button btnExit;
        private Panel panel1;
    }
}
