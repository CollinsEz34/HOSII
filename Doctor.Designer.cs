namespace COLCARE_HOSPITAL
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnPatients = new Button();
            btnLogout = new Button();
            button3 = new Button();
            btnDiagnosis = new Button();
            btnMedicine = new Button();
            btnDoctors = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnReload = new Button();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPassword = new TextBox();
            txtYearsOfExperience = new TextBox();
            txtDoctorName = new TextBox();
            txtDoctorId = new TextBox();
            label3 = new Label();
            DGVDoctors = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDoctors).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnPatients);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnDiagnosis);
            panel1.Controls.Add(btnMedicine);
            panel1.Controls.Add(btnDoctors);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 553);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.White;
            btnPatients.Location = new Point(22, 155);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(89, 37);
            btnPatients.TabIndex = 7;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Location = new Point(22, 514);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(89, 36);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(22, 129);
            button3.Name = "button3";
            button3.Size = new Size(0, 0);
            button3.TabIndex = 5;
            button3.Text = "Patient";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnDiagnosis
            // 
            btnDiagnosis.BackColor = Color.White;
            btnDiagnosis.Location = new Point(22, 215);
            btnDiagnosis.Name = "btnDiagnosis";
            btnDiagnosis.Size = new Size(89, 34);
            btnDiagnosis.TabIndex = 4;
            btnDiagnosis.Text = "Diagnosis";
            btnDiagnosis.UseVisualStyleBackColor = false;
            btnDiagnosis.Click += btnDiagnosis_Click;
            // 
            // btnMedicine
            // 
            btnMedicine.BackColor = Color.White;
            btnMedicine.Location = new Point(22, 265);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new Size(89, 38);
            btnMedicine.TabIndex = 3;
            btnMedicine.Text = "Medicine";
            btnMedicine.UseVisualStyleBackColor = false;
            btnMedicine.Click += btnMedicine_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.White;
            btnDoctors.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctors.Location = new Point(22, 103);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(89, 35);
            btnDoctors.TabIndex = 2;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(266, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 66);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(118, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(789, 81);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(742, 4);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 1;
            label1.Text = "Hospital Management System";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(btnReload);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(txtYearsOfExperience);
            panel4.Controls.Add(txtDoctorName);
            panel4.Controls.Add(txtDoctorId);
            panel4.Location = new Point(205, 114);
            panel4.Name = "panel4";
            panel4.Size = new Size(633, 135);
            panel4.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 28);
            label7.Name = "label7";
            label7.Size = new Size(67, 19);
            label7.TabIndex = 13;
            label7.Text = "Passwod";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 28);
            label6.Name = "label6";
            label6.Size = new Size(49, 19);
            label6.TabIndex = 12;
            label6.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 28);
            label5.Name = "label5";
            label5.Size = new Size(24, 19);
            label5.TabIndex = 11;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 28);
            label4.Name = "label4";
            label4.Size = new Size(137, 19);
            label4.TabIndex = 10;
            label4.Text = "Years of experience";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Lime;
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(418, 83);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(89, 37);
            btnReload.TabIndex = 9;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, -1);
            label2.Name = "label2";
            label2.Size = new Size(146, 26);
            label2.TabIndex = 0;
            label2.Text = "Doctor's Details";
            label2.Click += label2_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(323, 83);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(89, 37);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Lime;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(228, 82);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 37);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(134, 82);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(460, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(78, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtYearsOfExperience
            // 
            txtYearsOfExperience.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtYearsOfExperience.Location = new Point(275, 50);
            txtYearsOfExperience.Name = "txtYearsOfExperience";
            txtYearsOfExperience.Size = new Size(167, 27);
            txtYearsOfExperience.TabIndex = 2;
            // 
            // txtDoctorName
            // 
            txtDoctorName.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctorName.Location = new Point(149, 50);
            txtDoctorName.Name = "txtDoctorName";
            txtDoctorName.Size = new Size(106, 27);
            txtDoctorName.TabIndex = 1;
            // 
            // txtDoctorId
            // 
            txtDoctorId.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDoctorId.Location = new Point(47, 50);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(70, 27);
            txtDoctorId.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(396, 265);
            label3.Name = "label3";
            label3.Size = new Size(118, 26);
            label3.TabIndex = 3;
            label3.Text = "Doctor's List";
            // 
            // DGVDoctors
            // 
            DGVDoctors.BackgroundColor = Color.White;
            DGVDoctors.BorderStyle = BorderStyle.None;
            DGVDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDoctors.Location = new Point(133, 294);
            DGVDoctors.Name = "DGVDoctors";
            DGVDoctors.RowTemplate.Height = 25;
            DGVDoctors.Size = new Size(714, 189);
            DGVDoctors.TabIndex = 4;
            DGVDoctors.CellContentClick += DGVDoctors_CellContentClick;
            // 
            // Doctor
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(907, 553);
            Controls.Add(DGVDoctors);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor";
            Load += Doctor_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnDoctors;
        private Button btnLogout;
        private Button button3;
        private Button btnDiagnosis;
        private Button btnMedicine;
        private Label label1;
        private PictureBox btnClose;
        private Button btnPatients;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label2;
        private TextBox txtDoctorId;
        private TextBox txtYearsOfExperience;
        private TextBox txtDoctorName;
        private TextBox txtPassword;
        private Button btnReload;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private DataGridView DGVDoctors;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}