using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_IOOP
{
    public partial class Form1 : Form
    {
        List<MaintenanceTask> tasks = new List<MaintenanceTask>();

        public class MaintenanceTask
        {
            public int ScheduleID { get; set; }
            public string FacilityName { get; set; }
            public string TaskDescription { get; set; }
            public string Status { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateStatusForm_Load(object sender, EventArgs e)
        {
            tasks.Add(new MaintenanceTask { ScheduleID = 1, FacilityName = "Basketball Court A", TaskDescription = "Floor cleaning", Status = "Pending" });
            tasks.Add(new MaintenanceTask { ScheduleID = 2, FacilityName = "Swimming Pool", TaskDescription = "Water quality check", Status = "In Progress" });

            comboBoxSelectScheduleID.DataSource = tasks;
            comboBoxSelectScheduleID.DisplayMember = "ScheduleID";
            comboBoxSelectScheduleID.ValueMember = "ScheduleID";
        }

    }
}
