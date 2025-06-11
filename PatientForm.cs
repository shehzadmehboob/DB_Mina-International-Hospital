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
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void frmPatientRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            dtpDOB.Value = DateTime.Now;
            txtAddress.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "INSERT INTO Patients (Name, Gender, DOB, Phone, Address) " +
                               "VALUES (@Name, @Gender, @DOB, @Phone, @Address)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient registered successfully!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
