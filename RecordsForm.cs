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
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {
            InitializeComponent();
        }

        private void btnDoctorsRecords_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT * FROM Doctors";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnPatientRecords_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT * FROM Patients";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAppointmentRecords_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT * FROM Appointments";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
