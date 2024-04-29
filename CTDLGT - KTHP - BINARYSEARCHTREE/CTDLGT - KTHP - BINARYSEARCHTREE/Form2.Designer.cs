namespace CTDLGT___KTHP___BINARYSEARCHTREE
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            lbName = new Label();
            lbVaccine = new Label();
            lbLocation = new Label();
            lbRecord = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(118, 84);
            lbName.Name = "lbName";
            lbName.Size = new Size(67, 24);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // lbVaccine
            // 
            lbVaccine.BackColor = Color.Transparent;
            lbVaccine.Location = new Point(302, 151);
            lbVaccine.Name = "lbVaccine";
            lbVaccine.Size = new Size(198, 220);
            lbVaccine.TabIndex = 1;
            lbVaccine.Click += lbVaccine_Click;
            // 
            // lbLocation
            // 
            lbLocation.BackColor = Color.Transparent;
            lbLocation.Location = new Point(550, 151);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(201, 220);
            lbLocation.TabIndex = 2;
            lbLocation.Click += lbLocation_Click;
            // 
            // lbRecord
            // 
            lbRecord.BackColor = Color.Transparent;
            lbRecord.Location = new Point(41, 153);
            lbRecord.Name = "lbRecord";
            lbRecord.Size = new Size(205, 221);
            lbRecord.TabIndex = 3;
            lbRecord.Click += lbRecord_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRecord);
            Controls.Add(lbLocation);
            Controls.Add(lbVaccine);
            Controls.Add(lbName);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbVaccine;
        private Label lbLocation;
        private Label lbRecord;
    }
}