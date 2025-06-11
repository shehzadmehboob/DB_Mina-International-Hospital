Group Members:
Shehzad Mehboob (241893)
Ahmed Raza (241923)

# DB_Mina-International-Hospital

This is a Windows Forms (WinForms) based Hospital Management System developed using C# and SQL Server. The system is designed to handle essential hospital operations such as managing doctors, patients, appointments, admissions, treatments, billing, and more.

📚 Features

👨‍⚕️ Doctor Management (with specialization & department)

🧑‍🤝‍🧑 Patient Registration

📅 Appointment Booking

🏨 Patient Admission & Discharge

💉 Treatment & Prescription Records

💊 Medicine Management

🧾 Billing & Payments

🔍 View and Search Records

💬 Notes and Status Handling

🛠️ Technologies Used
💻 C# .NET (WinForms)

🗃️ Microsoft SQL Server

📦 ADO.NET for database connectivity

🗂️ Database Tables
The system includes the following tables:

Departments

Specializations

Doctors

Patients

Appointments

Admission

Treatment

Medicine

Prescription

Bill

Payment

Ward

All tables are interlinked using appropriate primary and foreign keys for data integrity.

🚀 Setup Instructions
Clone the repository or copy project files.

Open the solution in Visual Studio.

Configure the database connection:

Update the connection string in DBHelper.cs or App.config:

<connectionStrings>
  <add name="HospitalDB" connectionString="Data Source=DESKTOP-9MQ7O2S\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>
Run SQL scripts (provided in SQL folder or above) to create and populate tables.

Run the project.

📋 Usage
Use the main dashboard to navigate to different modules.

Add doctors, patients, and set up appointments.

View detailed reports via “Load Records” module.

🔐 Notes
Ensure SQL Server is running and the database is properly attached.

Default design is responsive to resizing except for minor alignments (e.g., title label in main form).
