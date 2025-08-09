using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Maintenance_Schedule
{
    public partial class Form1 : Form
    {
        private int staffId;
        private string connectionString = "Data Source=localhost;Initial Catalog=Maintenance_Schedule;Integrated Security=True;TrustServerCertificate=True";
        public Form1(int currentStaffId)
        {
            InitializeComponent();
            staffId = currentStaffId;
        }
    }
}

 