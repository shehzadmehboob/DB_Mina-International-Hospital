namespace Hospital_Management_System
{
    partial class Bill
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
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblAdmission = new System.Windows.Forms.Label();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBillDate = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.cmbAdmission = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "lblTitle";
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(264, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 35);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "  Bill / Invoice  ";
            // 
            // lblPatient
            // 
            this.lblPatient.AccessibleName = "lblPatient";
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(116, 108);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(40, 13);
            this.lblPatient.TabIndex = 24;
            this.lblPatient.Text = "Patient";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AccessibleName = "lblDoctor";
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(448, 108);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 25;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblAdmission
            // 
            this.lblAdmission.AccessibleName = "lblAdmission";
            this.lblAdmission.AutoSize = true;
            this.lblAdmission.Location = new System.Drawing.Point(116, 156);
            this.lblAdmission.Name = "lblAdmission";
            this.lblAdmission.Size = new System.Drawing.Size(54, 13);
            this.lblAdmission.TabIndex = 26;
            this.lblAdmission.Text = "Admission";
            // 
            // lblTreatment
            // 
            this.lblTreatment.AccessibleName = "lblTreatment";
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(448, 156);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(55, 13);
            this.lblTreatment.TabIndex = 27;
            this.lblTreatment.Text = "Treatment";
            // 
            // lblAmount
            // 
            this.lblAmount.AccessibleName = "lblAmount";
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(448, 209);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 28;
            this.lblAmount.Text = "Amount";
            // 
            // lblBillDate
            // 
            this.lblBillDate.AccessibleName = "lblBillDate";
            this.lblBillDate.AutoSize = true;
            this.lblBillDate.Location = new System.Drawing.Point(116, 209);
            this.lblBillDate.Name = "lblBillDate";
            this.lblBillDate.Size = new System.Drawing.Size(46, 13);
            this.lblBillDate.TabIndex = 29;
            this.lblBillDate.Text = "Bill Date";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AccessibleName = "lblDiscount";
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(116, 257);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 30;
            this.lblDiscount.Text = "Discount";
            // 
            // lblTax
            // 
            this.lblTax.AccessibleName = "lablTax";
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(448, 257);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 31;
            this.lblTax.Text = "Tax";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AccessibleName = "lblTotalAmount";
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(116, 307);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 32;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // lblStatus
            // 
            this.lblStatus.AccessibleName = "lblStatus";
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(448, 307);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 33;
            this.lblStatus.Text = "Status";
            // 
            // lblNotes
            // 
            this.lblNotes.AccessibleName = "lblNotes";
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(291, 366);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 34;
            this.lblNotes.Text = "Notes";
            // 
            // cmbPatient
            // 
            this.cmbPatient.AccessibleName = "cmbPatient";
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(201, 108);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(200, 21);
            this.cmbPatient.TabIndex = 35;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.AccessibleName = "dptBillDate";
            this.dtpBillDate.Location = new System.Drawing.Point(201, 206);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBillDate.TabIndex = 36;
            // 
            // txtAmount
            // 
            this.txtAmount.AccessibleName = "txtAmount";
            this.txtAmount.Location = new System.Drawing.Point(512, 206);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 20);
            this.txtAmount.TabIndex = 37;
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.AccessibleName = "cmbDoctor";
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(512, 105);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(200, 21);
            this.cmbDoctor.TabIndex = 38;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AccessibleName = "cmbStatus";
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(512, 304);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 39;
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.AccessibleName = "cmbTreatment";
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(512, 153);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(200, 21);
            this.cmbTreatment.TabIndex = 40;
            // 
            // cmbAdmission
            // 
            this.cmbAdmission.FormattingEnabled = true;
            this.cmbAdmission.Location = new System.Drawing.Point(201, 156);
            this.cmbAdmission.Name = "cmbAdmission";
            this.cmbAdmission.Size = new System.Drawing.Size(200, 21);
            this.cmbAdmission.TabIndex = 41;
            // 
            // txtNotes
            // 
            this.txtNotes.AccessibleName = "txttNotes";
            this.txtNotes.Location = new System.Drawing.Point(352, 351);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(200, 50);
            this.txtNotes.TabIndex = 42;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.AccessibleName = "txtTotalAmount";
            this.txtTotalAmount.Location = new System.Drawing.Point(201, 307);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.txtTotalAmount.TabIndex = 43;
            // 
            // txtTax
            // 
            this.txtTax.AccessibleName = "txtTax";
            this.txtTax.Location = new System.Drawing.Point(512, 254);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(200, 20);
            this.txtTax.TabIndex = 44;
            // 
            // txtDiscount
            // 
            this.txtDiscount.AccessibleName = "txtDiscount";
            this.txtDiscount.Location = new System.Drawing.Point(201, 257);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDiscount.TabIndex = 45;
            // 
            // btnBack
            // 
            this.btnBack.AccessibleName = "btnBack";
            this.btnBack.Location = new System.Drawing.Point(119, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleName = "btnClear";
            this.btnClear.Location = new System.Drawing.Point(119, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "btnSave";
            this.btnSave.Location = new System.Drawing.Point(637, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cmbAdmission);
            this.Controls.Add(this.cmbTreatment);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpBillDate);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblBillDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.lblAdmission);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.lblTitle);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblAdmission;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBillDate;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbTreatment;
        private System.Windows.Forms.ComboBox cmbAdmission;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}