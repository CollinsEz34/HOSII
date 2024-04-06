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
    public partial class Patients : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40");
        public Patients()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
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
        void populate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                {
                    connection.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter("Select * from PatientsTb", connection))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            DGVPatients.DataSource = ds.Tables[0];
                        }
                        else
                        {
                            // Handle the case where no data is retrieved (optional)
                            MessageBox.Show("No patient data found!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during database operations
                MessageBox.Show("Error retrieving patient data: " + ex.Message);
                // Log the exception for further analysis (optional)
            }


        }
        private void Reset()
        {
            txtPatientId.Text = "";
            txtPatientName.Text = "";
            txtPatientAddress.Text = "";
            txtPatientPhone.Text = "";
            txtPatientAge.Text = "";
            txtDisease.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text == "" || txtPatientName.Text == "" || txtPatientAddress.Text == "" || txtPatientPhone.Text == "" || txtPatientAge.Text == "" || txtDisease.Text == "")
            {
                MessageBox.Show("Missing Information!Fill all Details Carefully");
            }
            else
            {
                connection.Close();
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40")) // Improved connection management
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO PatientsTb (PatientId, PatientName, PatientAddress, PatientPhone, PatientAge, PatientGender, PatientWard, PatientDisease) VALUES (@PatientId, @PatientName, @PatientAddress, @PatientPhone, @PatientAge, @Gender, @PatientWard, @Disease)";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters with values from text boxes and combo boxes
                        command.Parameters.AddWithValue("@PatientId", txtPatientId.Text);
                        command.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                        command.Parameters.AddWithValue("@PatientAddress", txtPatientAddress.Text);
                        command.Parameters.AddWithValue("@PatientPhone", txtPatientPhone.Text);
                        command.Parameters.AddWithValue("@PatientAge", txtPatientAge.Text);
                        command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@PatientWard", cmbPatientWard.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Disease", txtDisease.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Patient added Successfully!");

                        // Error handling can be added here for potential exceptions
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding patient: " + ex.Message);
                        // Log the exception for further analysis (optional)
                    }
                }
                connection.Close();
                populate();
                Reset();
            }

        }
        private void DGVPatients_CellContentClick(Object sender, DataGridViewCellCancelEventArgs e)
        {
            txtPatientId.Text = DGVPatients.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientName.Text = DGVPatients.SelectedRows[0].Cells[1].Value.ToString();
            txtPatientAddress.Text = DGVPatients.SelectedRows[0].Cells[2].Value.ToString();
            txtPatientPhone.Text = DGVPatients.SelectedRows[0].Cells[3].Value.ToString();
            txtPatientAge.Text = DGVPatients.SelectedRows[0].Cells[4].Value.ToString();
            txtDisease.Text = DGVPatients.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void Patients_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 170);
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                {
                    connection.Open();

                    // Use parameterized query to prevent SQL injection
                    string query = "UPDATE PatientsTb SET PatientName = @PatientName, PatientAddress = @PatientAddress, PatientPhone = @PatientPhone, PatientAge = @PatientAge, PatientGender = @Gender, PatientWard = @PatientWard, PatientDisease = @Disease WHERE PatientId = @PatientId";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                    command.Parameters.AddWithValue("@PatientAddress", txtPatientAddress.Text);
                    command.Parameters.AddWithValue("@PatientPhone", txtPatientPhone.Text);
                    command.Parameters.AddWithValue("@PatientAge", txtPatientAge.Text);
                    command.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@PatientWard", cmbPatientWard.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Disease", txtDisease.Text);
                    command.Parameters.AddWithValue("@PatientId", txtPatientId.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Patient Updated Successfully!");
                    populate();
                    Reset();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating patient: " + ex.Message);
                // Log the exception for further debugging
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPatientId.Text == "")
                MessageBox.Show("Enter the Patient Id");
            else
            {
                connection.Open();
                string query = "delete from PatientsTb where PatientId=" + txtPatientId.Text + "";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Patient Deleted Successfully!");
                connection.Close();
                populate();
                Reset();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {

        }
    }
}
