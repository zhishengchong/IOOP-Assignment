using System.Data;

namespace Equipment_Form
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Request ID", typeof(int));
            table.Columns.Add("Item Name", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Purpose", typeof(string));

            table.Rows.Add(1, "Mop", "5", "Replace worn-out cleaning mops for sports hall");
            table.Rows.Add(2, "Detergent",  "10", "Refill stock for swimming pool cleaning");
            table.Rows.Add(3, "Floor Polisher",  "1", "Purchase for basketball court maintenance");
            table.Rows.Add(4, "Trash Bags",  "200", "Stock up for monthly facility cleaning");
            table.Rows.Add(5, "Lights Bulb",  "15", "Replace burnt-out lights in badminton courts");
            table.Rows.Add(6, "Ladder",  "1", "Required for ceiling maintenance in gym");
            table.Rows.Add(7, "Gloves", "50", "Safety equipment for cleaning staff");
            table.Rows.Add(8, "Sanitizer","10", "For sanitizing gym equipment");

            DataGridView.DataSource = table;
            DataGridView.AllowUserToAddRows = true;
            DataGridView.AllowUserToDeleteRows = true;
        }
    }
}
