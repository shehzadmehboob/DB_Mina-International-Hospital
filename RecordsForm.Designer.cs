namespace Hospital_Management_System
{
    partial class RecordsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPatientRecords = new System.Windows.Forms.Button();
            this.btnAppointmentRecords = new System.Windows.Forms.Button();
            this.btnDoctorsRecords = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatientRecords
            // 
            this.btnPatientRecords.AccessibleName = "btnPatientRecords";
            this.btnPatientRecords.Location = new System.Drawing.Point(292, 95);
            this.btnPatientRecords.Name = "btnPatientRecords";
            this.btnPatientRecords.Size = new System.Drawing.Size(223, 23);
            this.btnPatientRecords.TabIndex = 26;
            this.btnPatientRecords.Text = "Patients Records";
            this.btnPatientRecords.UseVisualStyleBackColor = true;
            this.btnPatientRecords.Click += new System.EventHandler(this.btnPatientRecords_Click);
            // 
            // btnAppointmentRecords
            // 
            this.btnAppointmentRecords.AccessibleName = "btnAppointmentRecords";
            this.btnAppointmentRecords.Location = new System.Drawing.Point(565, 95);
            this.btnAppointmentRecords.Name = "btnAppointmentRecords";
            this.btnAppointmentRecords.Size = new System.Drawing.Size(223, 23);
            this.btnAppointmentRecords.TabIndex = 25;
            this.btnAppointmentRecords.Text = "Appointments Records";
            this.btnAppointmentRecords.UseVisualStyleBackColor = true;
            this.btnAppointmentRecords.Click += new System.EventHandler(this.btnAppointmentRecords_Click);
            // 
            // btnDoctorsRecords
            // 
            this.btnDoctorsRecords.AccessibleName = "btnDoctorsRecords";
            this.btnDoctorsRecords.Location = new System.Drawing.Point(12, 95);
            this.btnDoctorsRecords.Name = "btnDoctorsRecords";
            this.btnDoctorsRecords.Size = new System.Drawing.Size(223, 23);
            this.btnDoctorsRecords.TabIndex = 24;
            this.btnDoctorsRecords.Text = "Doctors Records";
            this.btnDoctorsRecords.UseVisualStyleBackColor = true;
            this.btnDoctorsRecords.Click += new System.EventHandler(this.btnDoctorsRecords_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 277);
            this.dataGridView1.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(292, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 35);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "   Records   ";
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(12, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPatientRecords);
            this.Controls.Add(this.btnAppointmentRecords);
            this.Controls.Add(this.btnDoctorsRecords);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTitle);
            this.Name = "RecordsForm";
            this.Text = "RecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientRecords;
        private System.Windows.Forms.Button btnAppointmentRecords;
        private System.Windows.Forms.Button btnDoctorsRecords;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
    }
}