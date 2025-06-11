namespace Hospital_Management_System
{
    partial class AppointmentForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblAppointmentStatus = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(230, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(406, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Appointment Booking";
            // 
            // lblPatient
            // 
            this.lblPatient.AccessibleName = "lblPatient";
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(74, 123);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 1;
            this.lblPatient.Text = "Patient";
            // 
            // lblAppointmentStatus
            // 
            this.lblAppointmentStatus.AccessibleName = "lblAppointmentStatus";
            this.lblAppointmentStatus.AutoSize = true;
            this.lblAppointmentStatus.Location = new System.Drawing.Point(74, 244);
            this.lblAppointmentStatus.Name = "lblAppointmentStatus";
            this.lblAppointmentStatus.Size = new System.Drawing.Size(99, 13);
            this.lblAppointmentStatus.TabIndex = 2;
            this.lblAppointmentStatus.Text = "Appointment Status";
            // 
            // lblTime
            // 
            this.lblTime.AccessibleName = "lblTime";
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(453, 180);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(31, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "TIme";
            this.lblTime.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblDate
            // 
            this.lblDate.AccessibleName = "lblDate";
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(74, 180);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AccessibleName = "lblDoctor";
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(453, 123);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 5;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblNotes
            // 
            this.lblNotes.AccessibleName = "lblNotes";
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(453, 244);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes";
            // 
            // cmbPatient
            // 
            this.cmbPatient.AccessibleName = "cmbPatient";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(197, 123);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(200, 21);
            this.cmbPatient.TabIndex = 7;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AccessibleName = "cmbStatus";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(197, 241);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.AccessibleName = "dtpAppointmentDate";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(197, 174);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentDate.TabIndex = 10;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AccessibleName = "cmbDoctor";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(510, 120);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(200, 21);
            this.cmbDoctor.TabIndex = 11;
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.AccessibleName = "dtpAppointmentTime";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(510, 174);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentTime.TabIndex = 12;
            // 
            // txtNotes
            // 
            this.txtNotes.AccessibleName = "txtNotes";
            this.txtNotes.Location = new System.Drawing.Point(510, 241);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 60);
            this.txtNotes.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(77, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "btnClear";
            this.btnClear.Location = new System.Drawing.Point(77, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBook
            // 
            this.btnBook.AccessibleName = "btnBook";
            this.btnBook.Location = new System.Drawing.Point(599, 336);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(111, 23);
            this.btnBook.TabIndex = 16;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpAppointmentTime);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblAppointmentStatus);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblTitle);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblAppointmentStatus;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBook;
    }
}