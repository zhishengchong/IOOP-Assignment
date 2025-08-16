using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class FacilityManagement : Form
    {
        public FacilityManagement()
        {
            InitializeComponent();
        }

        private void FacilityManagement_Load(object sender, EventArgs e)
        {
            ArrayList facilities = new ArrayList();
            facilities = Facilities.viewAll();

            foreach (var item in facilities)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
