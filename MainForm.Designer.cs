namespace Hospital_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.22543F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.77457F));
            this.tableLayoutPanel1.Controls.Add(this.btnBill, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRecords, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAppointment, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDoctor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPatient, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(218, 204);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 223);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRecords
            // 
            this.btnRecords.AccessibleName = "btnRecords";
            this.btnRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecords.Location = new System.Drawing.Point(59, 141);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(229, 23);
            this.btnRecords.TabIndex = 6;
            this.btnRecords.Text = "Load Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.AccessibleName = "btnAppointment";
            this.btnAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAppointment.Location = new System.Drawing.Point(61, 10);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(225, 23);
            this.btnAppointment.TabIndex = 5;
            this.btnAppointment.Text = "Book Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.AccessibleName = "btnDoctor";
            this.btnDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoctor.Location = new System.Drawing.Point(61, 53);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(225, 23);
            this.btnDoctor.TabIndex = 3;
            this.btnDoctor.Text = "Add New Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.AccessibleName = "btnPatient";
            this.btnPatient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatient.Location = new System.Drawing.Point(59, 96);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(229, 23);
            this.btnPatient.TabIndex = 2;
            this.btnPatient.Text = "Add New Patient";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AccessibleName = "lblTitle";
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Castellar", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(121, 150);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(543, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Mina International Hospital";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(243, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnBill
            // 
            this.btnBill.AccessibleName = "btnBill";
            this.btnBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBill.Location = new System.Drawing.Point(59, 188);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(229, 23);
            this.btnBill.TabIndex = 7;
            this.btnBill.Text = "Add New Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBill;
    }
}