namespace COLCARE_HOSPITAL
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            label11 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            pictureBox2 = new PictureBox();
            btnPatients = new Button();
            btnLogout = new Button();
            button3 = new Button();
            btnDiagnosis = new Button();
            btnMedicine = new Button();
            btnDoctors = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            DGVDiagnosis = new DataGridView();
            label5 = new Label();
            label4 = new Label();
            cmbPatientId = new ComboBox();
            txtMedicine = new TextBox();
            txtDiagnosis = new TextBox();
            btnReload = new Button();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtSymptoms = new TextBox();
            txtPatientName1 = new TextBox();
            txtDiagnosisId = new TextBox();
            panel4 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVDiagnosis).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(282, 78);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 22;
            label11.Text = "Medicine";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(519, 14);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 19;
            label8.Text = "Symptoms";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 14);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 18;
            label7.Text = "Diagnosis Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(401, 295);
            label3.Name = "label3";
            label3.Size = new Size(142, 26);
            label3.TabIndex = 14;
            label3.Text = "Diagnosis's List";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 1;
            label1.Text = "Hospital Management System";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(156, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(830, 81);
            panel3.TabIndex = 12;
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
            btnClose.Location = new Point(783, 3);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.FromArgb(255, 255, 192);
            btnPatients.Font = new Font("Corbel", 12F, FontStyle.Underline, GraphicsUnit.Point);
            btnPatients.Location = new Point(12, 164);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(89, 37);
            btnPatients.TabIndex = 7;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 255, 192);
            btnLogout.Location = new Point(12, 449);
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
            btnDiagnosis.BackColor = Color.FromArgb(255, 255, 192);
            btnDiagnosis.Font = new Font("Corbel", 12F, FontStyle.Underline, GraphicsUnit.Point);
            btnDiagnosis.Location = new Point(12, 231);
            btnDiagnosis.Name = "btnDiagnosis";
            btnDiagnosis.Size = new Size(89, 34);
            btnDiagnosis.TabIndex = 4;
            btnDiagnosis.Text = "Diagnosis";
            btnDiagnosis.UseVisualStyleBackColor = false;
            btnDiagnosis.Click += btnDiagnosis_Click;
            // 
            // btnMedicine
            // 
            btnMedicine.BackColor = Color.FromArgb(255, 255, 192);
            btnMedicine.Location = new Point(12, 295);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new Size(89, 38);
            btnMedicine.TabIndex = 3;
            btnMedicine.Text = "Medicine";
            btnMedicine.UseVisualStyleBackColor = false;
            btnMedicine.Click += btnMedicine_Click_1;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.FromArgb(255, 255, 192);
            btnDoctors.Location = new Point(12, 108);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(89, 38);
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
            panel1.Size = new Size(156, 533);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(131, 14);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 17;
            label6.Text = "Patient Id";
            // 
            // DGVDiagnosis
            // 
            DGVDiagnosis.BackgroundColor = Color.White;
            DGVDiagnosis.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGVDiagnosis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVDiagnosis.GridColor = Color.White;
            DGVDiagnosis.Location = new Point(183, 324);
            DGVDiagnosis.Name = "DGVDiagnosis";
            DGVDiagnosis.RowTemplate.Height = 25;
            DGVDiagnosis.Size = new Size(778, 178);
            DGVDiagnosis.TabIndex = 15;
            DGVDiagnosis.CellContentClick += DGVDiagnosis_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 78);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 16;
            label5.Text = "Diagnosis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 14);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 15;
            label4.Text = "Patient Name";
            // 
            // cmbPatientId
            // 
            cmbPatientId.FormattingEnabled = true;
            cmbPatientId.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "9" });
            cmbPatientId.Location = new Point(131, 44);
            cmbPatientId.Name = "cmbPatientId";
            cmbPatientId.Size = new Size(121, 23);
            cmbPatientId.TabIndex = 13;
            // 
            // txtMedicine
            // 
            txtMedicine.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicine.Location = new Point(282, 100);
            txtMedicine.Name = "txtMedicine";
            txtMedicine.Size = new Size(257, 27);
            txtMedicine.TabIndex = 12;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiagnosis.Location = new Point(23, 100);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(229, 27);
            txtDiagnosis.TabIndex = 10;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Lime;
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(494, 132);
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
            label2.Location = new Point(391, 79);
            label2.Name = "label2";
            label2.Size = new Size(170, 26);
            label2.TabIndex = 10;
            label2.Text = "Diagnosis's Details";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(382, 132);
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
            btnUpdate.Location = new Point(256, 133);
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
            btnAdd.Location = new Point(120, 132);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSymptoms
            // 
            txtSymptoms.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSymptoms.Location = new Point(519, 38);
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.Size = new Size(135, 27);
            txtSymptoms.TabIndex = 2;
            // 
            // txtPatientName1
            // 
            txtPatientName1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientName1.Location = new Point(282, 38);
            txtPatientName1.Name = "txtPatientName1";
            txtPatientName1.Size = new Size(221, 27);
            txtPatientName1.TabIndex = 1;
            // 
            // txtDiagnosisId
            // 
            txtDiagnosisId.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiagnosisId.Location = new Point(23, 41);
            txtDiagnosisId.Name = "txtDiagnosisId";
            txtDiagnosisId.Size = new Size(70, 27);
            txtDiagnosisId.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cmbPatientId);
            panel4.Controls.Add(txtMedicine);
            panel4.Controls.Add(txtDiagnosis);
            panel4.Controls.Add(btnReload);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(txtSymptoms);
            panel4.Controls.Add(txtPatientName1);
            panel4.Controls.Add(txtDiagnosisId);
            panel4.Location = new Point(172, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 177);
            panel4.TabIndex = 13;
            // 
            // Diagnosis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 533);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(DGVDiagnosis);
            Controls.Add(label2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Diagnosis";
            Text = "Diagnosis";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVDiagnosis).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Label label8;
        private Label label7;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private PictureBox pictureBox2;
        private Button btnPatients;
        private Button btnLogout;
        private Button button3;
        private Button btnDiagnosis;
        private Button btnMedicine;
        private Button btnDoctors;
        private Panel panel2;
        private Panel panel1;
        private Label label6;
        private DataGridView DGVDiagnosis;
        private Label label5;
        private Label label4;
        private ComboBox cmbPatientId;
        private TextBox txtMedicine;
        private TextBox txtDiagnosis;
        private Button btnReload;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSymptoms;
        private TextBox txtPatientName1;
        private TextBox txtDiagnosisId;
        private Panel panel4;
    }
}