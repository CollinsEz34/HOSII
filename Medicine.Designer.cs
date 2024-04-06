namespace COLCARE_HOSPITAL
{
    partial class Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medicine));
            DGVMedicine = new DataGridView();
            btnReload = new Button();
            lblMedicineDetails = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtByDoctor = new TextBox();
            txtMedicineType = new TextBox();
            txtMedicineName = new TextBox();
            txtMedicineId = new TextBox();
            pictureBox1 = new PictureBox();
            btnClose = new PictureBox();
            panel4 = new Panel();
            lblByDoctor = new Label();
            lblMedicineType = new Label();
            lblMedicineName = new Label();
            lblId = new Label();
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
            lblMedicineList = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGVMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGVMedicine
            // 
            DGVMedicine.BackgroundColor = Color.White;
            DGVMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVMedicine.Location = new Point(124, 357);
            DGVMedicine.Name = "DGVMedicine";
            DGVMedicine.RowTemplate.Height = 25;
            DGVMedicine.Size = new Size(850, 164);
            DGVMedicine.TabIndex = 9;
            DGVMedicine.CellContentClick += DGVDoctors_CellContentClick;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Lime;
            btnReload.ForeColor = Color.White;
            btnReload.Location = new Point(550, 162);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(89, 37);
            btnReload.TabIndex = 9;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click_1;
            // 
            // lblMedicineDetails
            // 
            lblMedicineDetails.AutoSize = true;
            lblMedicineDetails.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedicineDetails.Location = new Point(324, 88);
            lblMedicineDetails.Name = "lblMedicineDetails";
            lblMedicineDetails.Size = new Size(165, 26);
            lblMedicineDetails.TabIndex = 0;
            lblMedicineDetails.Text = "Medicine's Details";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Lime;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(550, 109);
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
            btnUpdate.Location = new Point(550, 56);
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
            btnAdd.Location = new Point(550, 4);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtByDoctor
            // 
            txtByDoctor.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtByDoctor.Location = new Point(157, 154);
            txtByDoctor.Name = "txtByDoctor";
            txtByDoctor.Size = new Size(159, 27);
            txtByDoctor.TabIndex = 3;
            // 
            // txtMedicineType
            // 
            txtMedicineType.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicineType.Location = new Point(157, 106);
            txtMedicineType.Name = "txtMedicineType";
            txtMedicineType.Size = new Size(159, 27);
            txtMedicineType.TabIndex = 2;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicineName.Location = new Point(157, 66);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(159, 27);
            txtMedicineName.TabIndex = 1;
            // 
            // txtMedicineId
            // 
            txtMedicineId.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMedicineId.Location = new Point(157, 22);
            txtMedicineId.Name = "txtMedicineId";
            txtMedicineId.Size = new Size(159, 27);
            txtMedicineId.TabIndex = 0;
            txtMedicineId.TextChanged += txtMedicineId_TextChanged;
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
            btnClose.Location = new Point(821, 4);
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
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblByDoctor);
            panel4.Controls.Add(lblMedicineType);
            panel4.Controls.Add(lblMedicineName);
            panel4.Controls.Add(lblId);
            panel4.Controls.Add(btnReload);
            panel4.Controls.Add(btnDelete);
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(txtByDoctor);
            panel4.Controls.Add(txtMedicineType);
            panel4.Controls.Add(txtMedicineName);
            panel4.Controls.Add(txtMedicineId);
            panel4.Location = new Point(177, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(713, 208);
            panel4.TabIndex = 7;
            // 
            // lblByDoctor
            // 
            lblByDoctor.AutoSize = true;
            lblByDoctor.Location = new Point(31, 162);
            lblByDoctor.Name = "lblByDoctor";
            lblByDoctor.Size = new Size(77, 19);
            lblByDoctor.TabIndex = 13;
            lblByDoctor.Text = "By Doctor";
            // 
            // lblMedicineType
            // 
            lblMedicineType.AutoSize = true;
            lblMedicineType.Location = new Point(31, 109);
            lblMedicineType.Name = "lblMedicineType";
            lblMedicineType.Size = new Size(105, 19);
            lblMedicineType.TabIndex = 12;
            lblMedicineType.Text = "Medicine Type";
            // 
            // lblMedicineName
            // 
            lblMedicineName.AutoSize = true;
            lblMedicineName.Location = new Point(31, 69);
            lblMedicineName.Name = "lblMedicineName";
            lblMedicineName.Size = new Size(113, 19);
            lblMedicineName.TabIndex = 11;
            lblMedicineName.Text = "Medicine Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(31, 22);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 19);
            lblId.TabIndex = 10;
            lblId.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 23);
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
            panel3.Location = new Point(118, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(868, 81);
            panel3.TabIndex = 6;
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
            btnLogout.Location = new Point(22, 485);
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
            // lblMedicineList
            // 
            lblMedicineList.AutoSize = true;
            lblMedicineList.Font = new Font("Corbel", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMedicineList.Location = new Point(324, 328);
            lblMedicineList.Name = "lblMedicineList";
            lblMedicineList.Size = new Size(137, 26);
            lblMedicineList.TabIndex = 8;
            lblMedicineList.Text = "Medicine's List";
            lblMedicineList.Click += lblMedicineList_Click;
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
            panel1.Size = new Size(118, 533);
            panel1.TabIndex = 5;
            // 
            // Medicine
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(986, 533);
            Controls.Add(DGVMedicine);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(lblMedicineList);
            Controls.Add(panel1);
            Controls.Add(lblMedicineDetails);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Medicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicine";
            Load += Medicine_Load;
            ((System.ComponentModel.ISupportInitialize)DGVMedicine).EndInit();
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

        #endregion

        private DataGridView DGVMedicine;
        private Button btnReload;
        private Label lblMedicineDetails;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtByDoctor;
        private TextBox txtMedicineType;
        private TextBox txtMedicineName;
        private TextBox txtMedicineId;
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
        private Label lblMedicineList;
        private Panel panel1;
        private Label lblByDoctor;
        private Label lblMedicineType;
        private Label lblMedicineName;
        private Label lblId;
    }
}