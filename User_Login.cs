using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLCARE_HOSPITAL
{
    public partial class User_Login : Form
    {
        string connectionString = "Data Source=your_server_address;Initial Catalog=your_database_name;User ID=your_username;Password=your_password";
        SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40");
        public User_Login()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void lnkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_Login Page = new Admin_Login();
            Page.Show();
            this.Hide();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Enter Username and Password to Proceed");
                return; // Exit the method if empty fields
            }

            // Use parameterized queries to prevent SQL injection attacks
            string sql = "select Count(*) from DoctorTb where DoctorName=@username and DoctorPassword=@password";
            using (SqlCommand cmd = new SqlCommand(sql, Connection))
            {
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                Connection.Open();
                int count = (int)cmd.ExecuteScalar(); // Get single result

                if (count == 1)
                {
                    Doctor Page = new Doctor();
                    Page.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username and Password");
                }
            }
            Connection.Close();
        }
    }
}
