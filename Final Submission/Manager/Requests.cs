using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Submission.Manager
{
    internal class Requests
    {
        private string staff;
        private string request;
        private string date;
        private string status;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Requests(string Staff, string Request, string Date, string Status)
        {
            staff = Staff;
            request = Request;
            date = Date;
            status = Status;
        }
        public Requests()
        {
            staff = string.Empty;
            request = string.Empty;
            date = string.Empty;
            status = string.Empty;
        }

        public string Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        public string Request
        {
            get { return request; }
            set { request = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string GetRequest(ListView req)
        {
            string result = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Requests", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                result += "Staff: " + dr["Staff"].ToString()
                       + ", Request: " + dr["Request"].ToString()
                       + ", Date: " + dr["Date"].ToString()
                       + ", Status: " + dr["Status"].ToString() + "\n";

                ListViewItem item = new ListViewItem(dr["Staff"].ToString());
                item.SubItems.Add(dr["Request"].ToString());
                item.SubItems.Add(dr["Date"].ToString());
                item.SubItems.Add(dr["Status"].ToString());
                req.Items.Add(item);
            }
            dr.Close();
            con.Close();
            return result;
        }

        public string editStatus(string staff, string request, string date, string status)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Requests SET Status = @Status WHERE Staff = @Staff AND Request = @Request AND Date/Time = @Date", con);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@Staff", staff);
            cmd.Parameters.AddWithValue("@Request", request);
            cmd.Parameters.AddWithValue("@Date", date);
            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected > 0 ? "Status updated successfully." : "No matching record found.";
        }
    }
}
