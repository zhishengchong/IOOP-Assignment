using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ARFMS_Reception
{
    public partial class Reception : Form
    {
        // 数据库连接字符串
        private string connStr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\ARFMS_DB.mdf;Integrated Security=True";

        public Reception()
        {
            InitializeComponent();
        }

        // 窗体加载时，显示学生列表
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();

            // 设置 DataGridView 属性，防止用户直接修改
            dgvStudents.ReadOnly = true;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.MultiSelect = false;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
        }

        // 加载学生数据到 DataGridView
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT StudentID, Name, Email, Phone, University FROM Student";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvStudents.DataSource = dt;
            }
        }

        // 获取选中行的 StudentID
        private int? GetSelectedStudentId()
        {
            if (dgvStudents.CurrentRow == null) return null;
            var cellValue = dgvStudents.CurrentRow.Cells["StudentID"].Value;
            if (cellValue == null || cellValue == DBNull.Value) return null;
            return Convert.ToInt32(cellValue);
        }

        // 点击 Add Student 按钮
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "INSERT INTO Student (Name, Email, Phone, University) VALUES (@Name, @Email, @Phone, @University)";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@University", txtUniversity.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Student added successfully!");
            LoadStudents(); // 刷新表格

            // 清空输入框
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtUniversity.Clear();
            txtName.Focus();
        }

        // 点击 Delete Student 按钮
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            var id = GetSelectedStudentId();
            if (id == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            string name = "";
            try
            {
                name = dgvStudents.CurrentRow.Cells["Name"].Value?.ToString() ?? "";
            }
            catch { }

            var confirm = MessageBox.Show(
                string.IsNullOrEmpty(name) ? $"Delete StudentID = {id} ?" : $"Delete \"{name}\" (ID = {id}) ?",
                "Confirm", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes) return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "DELETE FROM Student WHERE StudentID = @id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Student deleted successfully!");
            LoadStudents(); // 刷新列表
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
guguhpmouu