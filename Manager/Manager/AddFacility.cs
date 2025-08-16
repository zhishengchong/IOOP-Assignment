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
    public partial class AddFacility : Form
    {
        public AddFacility()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Facilities m = new Facilities(tbxFac.Text, tbxFacType.Text, tbxMaintRate.Text);
            m.addFacility();
            tbxFac.Text = String.Empty;
            tbxFacType.Text = String.Empty;
            tbxMaintRate.Text = String.Empty;
        }
    }
}
