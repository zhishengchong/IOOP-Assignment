
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Maintenance_Schedule
{
    public partial class Equipment_Form : Form
    {
        private DataTable table;
        public Equipment_Form()
        {
            InitializeComponent();
        }



        private void Equipment_Form_Load(object sender, EventArgs e)
        {
            string filePath = "equipment_form.xml";
            table = new DataTable("Equipment_Form");
            if (System.IO.File.Exists(filePath) && new System.IO.FileInfo(filePath).Length > 0)
            {
                try
                {
                    table = new DataTable();
                    table.ReadXml(filePath);
                    DataGridView1.DataSource = table;

                    if (table.Columns.Count == 0)
                    {
                        LoadDefaultTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading saved data. Loading default data.\n" + ex.Message);
                    LoadDefaultTable();
                }
            }
            else
            {
                LoadDefaultTable();
            }

            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
         }

        private void LoadDefaultTable()
        {
            table = new DataTable("Equipment_Form");

            table.Columns.Add("Request ID", typeof(int));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Purpose", typeof(string));

            table.Rows.Add(1, "Mop", 5, "Replace worn-out cleaning mops for sports hall");
            table.Rows.Add(2, "Detergent", 10, "Refill stock for swimming pool cleaning");
            table.Rows.Add(3, "Floor Polisher", 1, "Purchase for basketball court maintenance");
            table.Rows.Add(4, "Trash Bags", 200, "Stock up for monthly facility cleaning");
            table.Rows.Add(5, "Lights Bulb", 15, "Replace burnt-out lights in badminton courts");
            table.Rows.Add(6, "Ladder", 1, "Required for ceiling maintenance in gym");
            table.Rows.Add(7, "Gloves", 50, "Safety equipment for cleaning staff");
            table.Rows.Add(8, "Sanitizer", 10, "For sanitizing gym equipment");

            DataGridView1.DataSource = table;
        }
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int newId = table.Rows.Count > 0
            ? (int)table.Rows[table.Rows.Count - 1]["Request ID"] + 1
            : 1;
            MessageBox.Show("Column count: " + table.Columns.Count);
            table.Rows.Add(newId, "New Item", 0, "Purpose here");
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView1.CurrentRow != null)
            {
                DataGridView1.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView1.CurrentRow != null)
            {
                DataGridView1.Rows.Remove(DataGridView1.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnSaveRequest_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "equipment_form.xml";
                table.WriteXml(filePath, XmlWriteMode.WriteSchema);
                MessageBox.Show("Data saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
    }
}
