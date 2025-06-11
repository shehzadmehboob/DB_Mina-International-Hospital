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
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbPatient.SelectedIndex = 0;
            cmbDoctor.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            dtpAppointmentDate.Value = DateTime.Now;
            dtpAppointmentTime.Value = DateTime.Now;
            txtNotes.Clear();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "INSERT INTO Appointments (DoctorID, PatientID, AppointmentDate, AppointmentTime, Status, Notes) " +
                                "VALUES (@DoctorID, @PatientID, @Date, @Time, @Status, @Notes)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DoctorID", cmbDoctor.SelectedValue);
                cmd.Parameters.AddWithValue("@PatientID", cmbPatient.SelectedValue);
                cmd.Parameters.AddWithValue("@Date", dtpAppointmentDate.Value.Date);
                cmd.Parameters.AddWithValue("@Time", dtpAppointmentTime.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Appointment saved successfully.");
            }
        }

        private void LoadDoctors()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT DoctorID, Name FROM Doctors";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDoctor.DataSource = dt;
                cmbDoctor.DisplayMember = "Name";
                cmbDoctor.ValueMember = "DoctorID";
            }
        }

        private void LoadPatients()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT PatientID, Name FROM Patients";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "PatientID";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
