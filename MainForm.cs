using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            df.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            af.Show();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            RecordsForm rf = new RecordsForm();
            rf.Show();
        }
    }
}
