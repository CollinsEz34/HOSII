namespace COLCARE_HOSPITAL
{
    partial class User_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Login));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnClose = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblUser_Login = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnUser_Login = new Button();
            lnkAdmin = new LinkLabel();
            lblPowered = new Label();
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
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-77, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(624, 103);
            panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(82, 14);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(577, 4);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 53);
            btnClose.SizeMode = PictureBoxSizeMode.Zoom;
            btnClose.TabIndex = 5;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 30);
            label1.TabIndex = 0;
            label1.Text = "Hospital Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 136);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblUser_Login
            // 
            lblUser_Login.AutoSize = true;
            lblUser_Login.BackColor = Color.White;
            lblUser_Login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser_Login.ForeColor = Color.Black;
            lblUser_Login.Location = new Point(157, 156);
            lblUser_Login.Margin = new Padding(4, 0, 4, 0);
            lblUser_Login.Name = "lblUser_Login";
            lblUser_Login.Size = new Size(138, 21);
            lblUser_Login.TabIndex = 14;
            lblUser_Login.Text = "User Login Panel";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.White;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(53, 221);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 21);
            lblUsername.TabIndex = 15;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(157, 220);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(175, 27);
            txtUsername.TabIndex = 16;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.White;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(53, 280);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 21);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(157, 274);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(175, 27);
            txtPassword.TabIndex = 18;
            // 
            // btnUser_Login
            // 
            btnUser_Login.BackColor = SystemColors.MenuHighlight;
            btnUser_Login.BackgroundImageLayout = ImageLayout.Zoom;
            btnUser_Login.ForeColor = Color.FloralWhite;
            btnUser_Login.Location = new Point(190, 336);
            btnUser_Login.Name = "btnUser_Login";
            btnUser_Login.Size = new Size(84, 38);
            btnUser_Login.TabIndex = 19;
            btnUser_Login.Text = "Login";
            btnUser_Login.UseVisualStyleBackColor = false;
            btnUser_Login.Click += btnUser_Login_Click;
            // 
            // lnkAdmin
            // 
            lnkAdmin.AutoSize = true;
            lnkAdmin.Location = new Point(203, 377);
            lnkAdmin.Name = "lnkAdmin";
            lnkAdmin.Size = new Size(53, 19);
            lnkAdmin.TabIndex = 20;
            lnkAdmin.TabStop = true;
            lnkAdmin.Text = "Admin";
            lnkAdmin.LinkClicked += lnkAdmin_LinkClicked;
            // 
            // lblPowered
            // 
            lblPowered.AutoSize = true;
            lblPowered.BackColor = Color.White;
            lblPowered.ForeColor = Color.Black;
            lblPowered.Location = new Point(157, 425);
            lblPowered.Margin = new Padding(4, 0, 4, 0);
            lblPowered.Name = "lblPowered";
            lblPowered.Size = new Size(136, 19);
            lblPowered.TabIndex = 21;
            lblPowered.Text = "Powered by Collins ";
            // 
            // User_Login
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 500);
            Controls.Add(lblPowered);
            Controls.Add(lnkAdmin);
            Controls.Add(btnUser_Login);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblUser_Login);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "User_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User_Login";
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
        private PictureBox pictureBox1;
        private Label lblUser_Login;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnUser_Login;
        private LinkLabel lnkAdmin;
        private Label lblPowered;
        private PictureBox btnClose;
        private PictureBox pictureBox2;
    }
}