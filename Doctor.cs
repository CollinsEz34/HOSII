using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace COLCARE_HOSPITAL
{
    public partial class Doctor : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40");
        public Doctor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
            obj.Show();
            this.Hide();
        }

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin_Login obj = new Admin_Login();
            obj.Show();
            this.Hide();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {

        }
        void populate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40")) // Create and open connection
                {
                    connection.Open();

                    string query = "Select * from DoctorTb";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        DGVDoctors.DataSource = ds.Tables[0];
                    }
                    else
                    {
                        // Handle the case where no data is retrieved (optional)
                        MessageBox.Show("No doctor data found!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during database operations
                MessageBox.Show("Error retrieving doctor data: " + ex.Message);
                // Log the exception for further analysis (optional)
            }
        }
        private void Reset()
        {
            txtDoctorId.Text = "";
            txtDoctorName.Text = "";
            txtYearsOfExperience.Text = "";
            txtPassword.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text == "" || txtDoctorName.Text == "" || txtYearsOfExperience.Text == "" || txtPassword.Text == "")
                MessageBox.Show("Missing Information!Fill all Details Carefully");

            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                    {
                        conn.Open();

                        // Use parameterized query to prevent SQL injection
                        string query = "INSERT INTO DoctorTb (DoctorId, DoctorName, DoctorExp, DoctorPassword) VALUES (@DoctorId, @DoctorName, @YearsOfExperience, @Password)";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@DoctorId", int.Parse(txtDoctorId.Text)); // Validate type for numeric fields
                        cmd.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text);
                        cmd.Parameters.AddWithValue("@YearsOfExperience", int.Parse(txtYearsOfExperience.Text)); // Validate type for numeric fields
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Doctor added successfully!");

                        // ... (rest of the code)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    // Log the exception for further debugging
                }
                populate();
                Reset();
            }
        }

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDoctorId.Text = DGVDoctors.SelectedRows[0].Cells[0].Value.ToString();
            txtDoctorName.Text = DGVDoctors.SelectedRows[0].Cells[1].Value.ToString();
            txtYearsOfExperience.Text = DGVDoctors.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text = DGVDoctors.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Validate input fields to prevent empty values
            if (string.IsNullOrEmpty(txtDoctorId.Text) ||
                string.IsNullOrEmpty(txtDoctorName.Text) ||
                string.IsNullOrEmpty(txtYearsOfExperience.Text) ||
                string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Missing Information! Fill all Details Carefully");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                {
                    connection.Open();

                    // Use parameterized query for security and clarity
                    string query = "UPDATE DoctorTb SET DoctorName = @DoctorName, DoctorExp = @DoctorExp, DoctorPassword = @DoctorPassword WHERE DoctorId = @DoctorId";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Add parameters with appropriate data types
                    int doctorId;
                    int doctorExp; // Assuming YearsOfExperience is an integer field
                    if (int.TryParse(txtDoctorId.Text, out doctorId) && int.TryParse(txtYearsOfExperience.Text, out doctorExp))
                    {
                        cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                        cmd.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text);
                        cmd.Parameters.AddWithValue("@DoctorExp", doctorExp); // Assuming integer field
                        cmd.Parameters.AddWithValue("@DoctorPassword", txtPassword.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor record updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Doctor ID or Years of Experience. Please enter numeric values.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating doctor: " + ex.Message);
            }

            // Clear input fields or refresh data grid (optional)
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text == "")
            {
                MessageBox.Show("Enter the Doctor Id");
                return; // Exit if ID is empty
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                {
                    connection.Open();

                    string query = "DELETE FROM DoctorTb WHERE DoctorId = @DoctorId"; // Use parameterized query
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DoctorId", txtDoctorId.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Doctor Deleted Successfully");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error deleting doctor: " + ex.Message);
            }
            finally
            {
                populate(); // Refresh data
                Reset();
            }
        }
        private void Doctor_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 170);
            User_Login ns = new User_Login();
            ns.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
