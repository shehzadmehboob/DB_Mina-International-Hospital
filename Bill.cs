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

namespace Hospital_Management_System
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();
            LoadAdmissions();
            LoadTreatments();
            LoadStatus();
        }

        private void LoadPatients()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT PatientID, Name FROM Patients";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "PatientID";
            }
        }

        private void LoadDoctors()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT DoctorID, Name FROM Doctors";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDoctor.DataSource = dt;
                cmbDoctor.DisplayMember = "Name";
                cmbDoctor.ValueMember = "DoctorID";
            }
        }

        private void LoadAdmissions()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT AdmissionID, CAST(AdmissionID AS VARCHAR) + ' - ' + CONVERT(VARCHAR, AdmissionDate, 103) AS Display FROM Admission";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbAdmission.DataSource = dt;
                cmbAdmission.DisplayMember = "Display";
                cmbAdmission.ValueMember = "AdmissionID";
            }
        }

        private void LoadTreatments()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT TreatmentID, LEFT(Description, 50) + '...' AS Display FROM Treatment";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTreatment.DataSource = dt;
                cmbTreatment.DisplayMember = "Display";
                cmbTreatment.ValueMember = "TreatmentID";
            }
        }

        private void LoadStatus()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Paid");
            cmbStatus.Items.Add("Unpaid");
            cmbStatus.Items.Add("Pending");
            cmbStatus.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            cmbPatient.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            txtAmount.Clear();
            dtpBillDate.Value = DateTime.Today;
            cmbStatus.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbAdmission.SelectedIndex = -1;
            cmbTreatment.SelectedIndex = -1;
            txtDiscount.Clear();
            txtTax.Clear();
            txtTotalAmount.Clear();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "INSERT INTO Bill (PatientID, DoctorID, Amount, BillDate, Status) " +
                               "VALUES (@PatientID, @DoctorID, @Amount, @BillDate, @Status)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PatientID", cmbPatient.SelectedValue);
                cmd.Parameters.AddWithValue("@DoctorID", cmbDoctor.SelectedValue);
                cmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text));
                cmd.Parameters.AddWithValue("@BillDate", dtpBillDate.Value.Date);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text); // or txtStatus.Text if using textbox

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Bill saved successfully.");
                ClearForm();
            }
        }
    }


    

}
