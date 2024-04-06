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
    public partial class Diagnosis : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""D:\USERS\RAYMOND\ONEDRIVE\DESKTOP\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREDB.MDF"";Integrated Security=True;Connect Timeout=30");


        public Diagnosis()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctor obj = new Doctor();
            obj.Show();
            this.Hide();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
            obj.Show();
            this.Hide();
        }


        private void btnDiagnosis_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Admin_Login obj = new Admin_Login();
            obj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMedicine_Click_1(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
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

                    using (SqlDataAdapter da = new SqlDataAdapter("Select * from DiagnosisTb", connection))
                    {
                        SqlCommandBuilder builder = new SqlCommandBuilder(da);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables.Count > 0)
                        {
                            DGVDiagnosis.DataSource = ds.Tables[0];
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
                MessageBox.Show("Error retrieving diagnosis data: " + ex.Message);
                // Log the exception for further analysis (optional)
            }


        }
        private void Reset()
        {
            txtDiagnosisId.Text = "";
            txtPatientName1.Text = "";
            txtSymptoms.Text = "";
            txtDiagnosis.Text = "";
            txtMedicine.Text = "";
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDiagnosisId.Text == "" || txtPatientName1.Text == "" || txtSymptoms.Text == "" || txtSymptoms.Text == "" || txtMedicine.Text == "")
            {
                MessageBox.Show("Missing Information!Fill all Details Carefully");
            }
            else
            {

                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""D:\USERS\RAYMOND\ONEDRIVE\DESKTOP\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREDB.MDF"";Integrated Security=True;Connect Timeout=30"))
                {
                    try
                    {
                        connection.Open();
                        string query = "INSERT INTO DiagnosisTb(DiagnosisID, PatientId, Patientname, Symptoms, Diagnosis, Medicine) VALUES (@DiagnosisId, @PatientId, @Patientname, @Symptoms, @Diagnosis, @Medicine)";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters with values from text boxes and combo boxes
                        command.Parameters.AddWithValue("@DiagnosisId", txtDiagnosisId.Text);
                        command.Parameters.AddWithValue("@PatientId", cmbPatientId.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Patientname", txtPatientName1.Text);
                        command.Parameters.AddWithValue("@Symptoms", txtSymptoms.Text);
                        command.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                        command.Parameters.AddWithValue("@Medicine", txtMedicine.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Diagnosis added Successfully!");

                        // Error handling can be added here for potential exceptions
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding Diagnosis: " + ex.Message);
                        // Log the exception for further analysis (optional)
                    }
                    connection.Close();
                    populate();
                    Reset();
                

                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
            {
                connection.Open();

                // Use parameterized query to prevent SQL injection
                string query = "UPDATE DiagnosisTb SET PatientId = @PatientId, PatientName =  @PatientName, Symptoms = @Symptoms, Diagnosis = @Diagnosis, Medicine = @Medicine WHERE DiagnosisId = @DiagnosisId";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@DiagnosisId", txtDiagnosisId.Text);
                command.Parameters.AddWithValue("@PatientId", cmbPatientId.SelectedItem.ToString());
                command.Parameters.AddWithValue("@PatientName", txtPatientName1.Text);
                command.Parameters.AddWithValue("@Symptoms", txtSymptoms.Text);
                command.Parameters.AddWithValue("@Diagnosis", txtDiagnosis.Text);
                command.Parameters.AddWithValue("@Medicine", txtMedicine.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Updated Successfully!");



            }
        }

        private void DGVDiagnosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDiagnosisId.Text = DGVDiagnosis.SelectedRows[0].Cells[0].Value.ToString();
            txtPatientName1.Text = DGVDiagnosis.SelectedRows[0].Cells[1].Value.ToString();
            txtSymptoms.Text = DGVDiagnosis.SelectedRows[0].Cells[2].Value.ToString();
            txtDiagnosis.Text = DGVDiagnosis.SelectedRows[0].Cells[3].Value.ToString();
            txtMedicine.Text = DGVDiagnosis.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                if (txtDiagnosisId.Text == "")
                    MessageBox.Show("Enter the Diagnosis Id");
                else
                {
                    if (txtDiagnosisId.Text == "")
                        MessageBox.Show("Enter the Diagnosis Id");
                    else
                    {
                        connection.Open();
                        string query = "delete from DiagnosisTb where DiagnosisId=" + txtDiagnosisId.Text + "";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Diagnosis Deleted Successfully!");
                        connection.Close();
                        populate();
                        Reset();
                    }

                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();  
        }
    }
}
