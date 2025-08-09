using System.Data;

namespace Maintenance_Schedule
{
    public partial class Equipment_Form : Form
    {
        private DataTable table;
        public Equipment_Form()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Request ID", typeof(int));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Purpose", typeof(string));

            table.Rows.Add(1, "Mop", "5", "Replace worn-out cleaning mops for sports hall");
            table.Rows.Add(2, "Detergent", "10", "Refill stock for swimming pool cleaning");
            table.Rows.Add(3, "Floor Polisher", "1", "Purchase for basketball court maintenance");
            table.Rows.Add(4, "Trash Bags", "200", "Stock up for monthly facility cleaning");
            table.Rows.Add(5, "Lights Bulb", "15", "Replace burnt-out lights in badminton courts");
            table.Rows.Add(6, "Ladder", "1", "Required for ceiling maintenance in gym");
            table.Rows.Add(7, "Gloves", "50", "Safety equipment for cleaning staff");
            table.Rows.Add(8, "Sanitizer", "10", "For sanitizing gym equipment");

            DataGridView.DataSource = table;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.AllowUserToDeleteRows = false;
        }

        private void Equipment_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            int newId = table.Rows.Count > 0 ? (int)table.Rows[table.Rows.Count - 1]["Request ID"] + 1:1;
            table.Rows.Add(newId, "New Item", 0, "Purpose here");
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow != null)
            {
                DataGridView.BeginEdit(true);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow != null)
            {
                DataGridView.Rows.Remove(DataGridView.CurrentRow);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnSaveRequest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved in memory (not to database).");
        }
    }
}
