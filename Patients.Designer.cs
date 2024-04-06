
namespace COLCARE_HOSPITAL
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            DGVPatients = new DataGridView();
            btnReload = new Button();
            label2 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPatientPhone = new TextBox();
            txtPatientAddress = new TextBox();
            txtPatientName = new TextBox();
            txtPatientId = new TextBox();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel4 = new Panel();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            cmbPatientWard = new ComboBox();
            cmbGender = new ComboBox();
            txtDisease = new TextBox();
            txtPatientAge = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            btnPatients = new Button();
            btnLogout = new Button();
            button3 = new Button();
            btnDiagnosis = new Button();
            btnMedicine = new Button();
            btnDoctors = new Button();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGVPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGVPatients
            // 
            DGVPatients.BackgroundColor = Color.White;
            DGVPatients.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGVPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVPatients.GridColor = Color.White;
            DGVPatients.Location = new Point(174, 360);
            DGVPatients.Name = "DGVPatients";
            DGVPatients.RowTemplate.Height = 25;
            DGVPatients.Size = new Size(800, 152);
            DGVPatients.TabIndex = 9;
            DGVPatients.CellContentClick += DGVDoctors_CellContentClick;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Lime;
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(518, 147);
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
            label2.Location = new Point(393, 88);
            label2.Name = "label2";
            label2.Size = new Size(149, 26);
            label2.TabIndex = 0;
            label2.Text = "Patient's Details";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(413, 147);
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
            btnUpdate.Location = new Point(303, 147);
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
            btnAdd.Location = new Point(163, 147);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPatientPhone
            // 
            txtPatientPhone.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientPhone.Location = new Point(490, 40);
            txtPatientPhone.Name = "txtPatientPhone";
            txtPatientPhone.Size = new Size(107, 27);
            txtPatientPhone.TabIndex = 3;
            // 
            // txtPatientAddress
            // 
            txtPatientAddress.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientAddress.Location = new Point(330, 40);
            txtPatientAddress.Name = "txtPatientAddress";
            txtPatientAddress.Size = new Size(135, 27);
            txtPatientAddress.TabIndex = 2;
            // 
            // txtPatientName
            // 
            txtPatientName.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientName.Location = new Point(87, 38);
            txtPatientName.Name = "txtPatientName";
            txtPatientName.Size = new Size(221, 27);
            txtPatientName.TabIndex = 1;
            // 
            // txtPatientId
            // 
            txtPatientId.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientId.Location = new Point(3, 40);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(70, 27);
            txtPatientId.TabIndex = 0;
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
            btnClose.Location = new Point(785, 0);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cmbPatientWard);
            panel4.Controls.Add(cmbGender);
            panel4.Controls.Add(txtDisease);
            panel4.Controls.Add(txtPatientAge);
            panel4.Controls.Add(btnReload);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(txtPatientPhone);
            panel4.Controls.Add(txtPatientAddress);
            panel4.Controls.Add(txtPatientName);
            panel4.Controls.Add(txtPatientId);
            panel4.Location = new Point(174, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(727, 198);
            panel4.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(518, 78);
            label11.Name = "label11";
            label11.Size = new Size(60, 19);
            label11.TabIndex = 22;
            label11.Text = "Disease";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(518, 14);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 21;
            label10.Text = "Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 78);
            label9.Name = "label9";
            label9.Size = new Size(68, 19);
            label9.TabIndex = 20;
            label9.Text = "Location";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(330, 14);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 19;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 18);
            label7.Name = "label7";
            label7.Size = new Size(24, 19);
            label7.TabIndex = 18;
            label7.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 78);
            label6.Name = "label6";
            label6.Size = new Size(58, 19);
            label6.TabIndex = 17;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 78);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 16;
            label5.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 16);
            label4.Name = "label4";
            label4.Size = new Size(49, 19);
            label4.TabIndex = 15;
            label4.Text = "Name";
            // 
            // cmbPatientWard
            // 
            cmbPatientWard.FormattingEnabled = true;
            cmbPatientWard.Items.AddRange(new object[] { "Siongiroi", "Kong'asis", "Sigor", "Nyongores", "Olbutyo" });
            cmbPatientWard.Location = new Point(330, 100);
            cmbPatientWard.Name = "cmbPatientWard";
            cmbPatientWard.Size = new Size(121, 27);
            cmbPatientWard.TabIndex = 14;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(126, 100);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 27);
            cmbGender.TabIndex = 13;
            // 
            // txtDisease
            // 
            txtDisease.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisease.Location = new Point(490, 100);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new Size(195, 27);
            txtDisease.TabIndex = 12;
            // 
            // txtPatientAge
            // 
            txtPatientAge.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPatientAge.Location = new Point(3, 100);
            txtPatientAge.Name = "txtPatientAge";
            txtPatientAge.Size = new Size(78, 27);
            txtPatientAge.TabIndex = 10;
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
            panel3.TabIndex = 6;
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
            btnPatients.BackColor = Color.White;
            btnPatients.Location = new Point(12, 177);
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
            btnLogout.Location = new Point(12, 460);
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
            btnDiagnosis.Location = new Point(12, 232);
            btnDiagnosis.Name = "btnDiagnosis";
            btnDiagnosis.Size = new Size(89, 34);
            btnDiagnosis.TabIndex = 4;
            btnDiagnosis.Text = "Diagnosis";
            btnDiagnosis.UseVisualStyleBackColor = false;
            // 
            // btnMedicine
            // 
            btnMedicine.BackColor = Color.White;
            btnMedicine.Location = new Point(12, 287);
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
            btnDoctors.Location = new Point(12, 119);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(393, 331);
            label3.Name = "label3";
            label3.Size = new Size(121, 26);
            label3.TabIndex = 8;
            label3.Text = "Patient's List";
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
            panel1.TabIndex = 5;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(986, 533);
            Controls.Add(DGVPatients);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patients";
            Load += Patients_Load;
            ((System.ComponentModel.ISupportInitialize)DGVPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DataGridView DGVPatients;
        private Button btnReload;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtPatientPhone;
        private TextBox txtPatientAddress;
        private TextBox txtPatientName;
        private TextBox txtPatientId;
        private PictureBox pictureBox1;
        private PictureBox btnClose;
        private Panel panel4;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnPatients;
        private Button btnLogout;
        private Button button3;
        private Button btnDiagnosis;
        private Button btnMedicine;
        private Button btnDoctors;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private TextBox txtDisease;
        private TextBox txtPatientAge;
        private ComboBox cmbPatientWard;
        private ComboBox cmbGender;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}