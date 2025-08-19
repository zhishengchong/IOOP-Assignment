using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Manager
{
    public partial class DeleteFacility : Form
    {
        public DeleteFacility()
        {
            InitializeComponent();
        }

        private void btnDelFac_Click(object sender, EventArgs e)
        {
            Facilities m = new Facilities(tbxFac.Text);
            string status = m.deleteFacilities();
            if (status == "Success")
            {
                MessageBox.Show("Facility deleted successfully.");
            }
            else
            {
                MessageBox.Show("Error deleting facility.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
