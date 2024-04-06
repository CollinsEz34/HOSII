namespace COLCARE_HOSPITAL
{
    partial class Admin_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnClose = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            lblAdmin_Login = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnAdmin_Login = new Button();
            lblPowered = new Label();
            lnkUser = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-77, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 99);
            panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(78, 14);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(562, 0);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lime;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(182, 34);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(306, 30);
            label2.TabIndex = 4;
            label2.Text = "Hospital Management System";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospital Management System";
            // 
            // lblAdmin_Login
            // 
            lblAdmin_Login.AutoSize = true;
            lblAdmin_Login.BackColor = Color.White;
            lblAdmin_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmin_Login.ForeColor = Color.Black;
            lblAdmin_Login.Location = new Point(133, 129);
            lblAdmin_Login.Margin = new Padding(4, 0, 4, 0);
            lblAdmin_Login.Name = "lblAdmin_Login";
            lblAdmin_Login.Size = new Size(155, 21);
            lblAdmin_Login.TabIndex = 7;
            lblAdmin_Login.Text = "Admin Login Panel";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Black;
            lblUsername.ImageAlign = ContentAlignment.MiddleLeft;
            lblUsername.Location = new Point(36, 182);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(36, 236);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(133, 179);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(175, 29);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(133, 233);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '4';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(175, 29);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 113);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // btnAdmin_Login
            // 
            btnAdmin_Login.BackColor = SystemColors.MenuHighlight;
            btnAdmin_Login.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdmin_Login.ForeColor = Color.FloralWhite;
            btnAdmin_Login.Location = new Point(170, 268);
            btnAdmin_Login.Name = "btnAdmin_Login";
            btnAdmin_Login.Size = new Size(84, 38);
            btnAdmin_Login.TabIndex = 13;
            btnAdmin_Login.Text = "Login";
            btnAdmin_Login.UseVisualStyleBackColor = false;
            btnAdmin_Login.Click += btnAdmin_Login_Click;
            // 
            // lblPowered
            // 
            lblPowered.AutoSize = true;
            lblPowered.BackColor = Color.White;
            lblPowered.ForeColor = Color.Black;
            lblPowered.Location = new Point(133, 363);
            lblPowered.Margin = new Padding(4, 0, 4, 0);
            lblPowered.Name = "lblPowered";
            lblPowered.Size = new Size(160, 21);
            lblPowered.TabIndex = 14;
            lblPowered.Text = "Powered by Collins ";
            // 
            // lnkUser
            // 
            lnkUser.AutoSize = true;
            lnkUser.Location = new Point(188, 321);
            lnkUser.Name = "lnkUser";
            lnkUser.Size = new Size(44, 21);
            lnkUser.TabIndex = 15;
            lnkUser.TabStop = true;
            lnkUser.Text = "User";
            lnkUser.LinkClicked += lnkUser_LinkClicked;
            // 
            // Admin_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(531, 461);
            Controls.Add(lnkUser);
            Controls.Add(lblPowered);
            Controls.Add(btnAdmin_Login);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblAdmin_Login);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Lime;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Admin_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Login";
            Load += Admin_Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblAdmin_Login;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnAdmin_Login;
        private Label lblPowered;
        private LinkLabel lnkUser;
        private Label label2;
        private PictureBox btnClose;
        private PictureBox pictureBox2;
    }
}