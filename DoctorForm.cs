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

namespace Hospital_Management_System
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadSpecializations();
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
            cmbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
            cmbSpecialization.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            dtpJoiningDate.Value = DateTime.Now;
            txtAddress.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string gender = cmbGender.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            DateTime joiningDate = dtpJoiningDate.Value;

            int departmentID = ((dynamic)cmbDepartment.SelectedItem).Value;
            int specializationID = ((dynamic)cmbSpecialization.SelectedItem).Value;

            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = @"INSERT INTO Doctors 
                         (Name, Gender, Phone, Email, Address, JoiningDate, DepartmentID, SpecializationID)
                         VALUES 
                         (@Name, @Gender, @Phone, @Email, @Address, @JoiningDate, @DepartmentID, @SpecializationID)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@JoiningDate", joiningDate);
                cmd.Parameters.AddWithValue("@DepartmentID", departmentID);
                cmd.Parameters.AddWithValue("@SpecializationID", specializationID);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();

                if (result > 0)
                    MessageBox.Show("Doctor registered successfully!");
                else
                    MessageBox.Show("Failed to register doctor.");
            }
        }

        private void LoadDepartments()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT DepartmentID, Name FROM Departments";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbDepartment.Items.Add(new
                    {
                        Text = reader["Name"].ToString(),
                        Value = reader["DepartmentID"]
                    });
                }
                reader.Close();
            }
            cmbDepartment.DisplayMember = "Text";
            cmbDepartment.ValueMember = "Value";
        }


        private void LoadSpecializations()
        {
            using (SqlConnection con = new SqlConnection(DBHelper.ConnectionString))
            {
                string query = "SELECT SpecializationID, Title FROM Specializations";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbSpecialization.Items.Add(new
                    {
                        Text = reader["Title"].ToString(),
                        Value = reader["SpecializationID"]
                    });
                }
                reader.Close();
            }
            cmbSpecialization.DisplayMember = "Text";
            cmbSpecialization.ValueMember = "Value";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
