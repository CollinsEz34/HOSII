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
    public partial class Medicine : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40");
        public Medicine()
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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            Patients obj = new Patients();
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

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineId.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtMedicineName.Text = DGVMedicine.SelectedRows[0].Cells[1].Value.ToString();
            txtMedicineType.Text = DGVMedicine.SelectedRows[0].Cells[2].Value.ToString();
            txtByDoctor.Text = DGVMedicine.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void txtMedicineId_TextChanged(object sender, EventArgs e)
        {

        }
        void populate()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40")) // Create and open connection
                {
                    connection.Open();

                    string query = "Select * from MedicineTb";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables.Count > 0)
                    {
                        DGVMedicine.DataSource = ds.Tables[0];
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
            txtMedicineId.Text = "";
            txtMedicineName.Text = "";
            txtMedicineType.Text = "";
            txtByDoctor.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text == "" || txtMedicineName.Text == "" || txtMedicineType.Text == "" || txtByDoctor.Text == "")
                MessageBox.Show("Missing Information!Fill all Details Carefully");

            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                    {
                        conn.Open();

                        // Use parameterized query to prevent SQL injection
                        string query = "INSERT INTO MedicineTb (MedicineId, MedicineName, MedicineType, ByDoctor) VALUES (@MedicineId, @MedicineName, @MedicineType, @ByDoctor)";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@MedicineId", int.Parse(txtMedicineId.Text)); // Validate type for numeric fields
                        cmd.Parameters.AddWithValue("@MedicineName", txtMedicineName.Text);
                        cmd.Parameters.AddWithValue("@MedicineType", int.Parse(txtMedicineType.Text)); // Validate type for numeric fields
                        cmd.Parameters.AddWithValue("@ByDoctor", txtByDoctor.Text);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Medicine added successfully!");

                        // ... (rest of the code)
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    // Log the exception for further debugging
                }
            }
        }

        private void lblMedicineList_Click(object sender, EventArgs e)
        {

        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMedicineId.Text) ||
                string.IsNullOrEmpty(txtMedicineName.Text) ||
                string.IsNullOrEmpty(txtMedicineType.Text) ||
                string.IsNullOrEmpty(txtByDoctor.Text))
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
                    string query = "UPDATE MedicineTb SET MedicineName = @MedicineName, MedicineType = @MedicineType, ByDoctor = @ByDoctor WHERE MedicineId = @MedicineId";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Add parameters with appropriate data types
                    int medicineId;
                    int medicineType;
                    if (int.TryParse(txtMedicineId.Text, out medicineId) && int.TryParse(txtMedicineType.Text, out medicineType))
                    {
                        cmd.Parameters.AddWithValue("@MedicineId", medicineId);
                        cmd.Parameters.AddWithValue("@MedicineName", txtMedicineName.Text);
                        cmd.Parameters.AddWithValue("@MedicineType", medicineType); // Assuming integer field
                        cmd.Parameters.AddWithValue("@ByDoctor", txtByDoctor.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine record updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Medicine ID or MedicineType. Please enter numeric values or string.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error updating Medicine: " + ex.Message);
            }

            // Clear input fields or refresh data grid (optional)
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMedicineId.Text == "")
            {
                MessageBox.Show("Enter the Medicine Id");
                return; // Exit if ID is empty
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Users\Raymond\OneDrive\Desktop\COLCARE HOSPITAL\COLCARE HOSPITAL\COLCAREdb.mdf"";Integrated Security=True;Connection Timeout=40"))
                {
                    connection.Open();

                    string query = "DELETE FROM MedicineTb WHERE MedicineId = @MedicineId"; // Use parameterized query
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MedicineId", txtMedicineId.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Medicine Deleted Successfully");
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

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            populate();
        }

        private void Medicine_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 170);
            populate();
            
        }
    }
}

