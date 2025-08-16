using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    internal class Schedule
    {
        private string staff;
        private string facility;
        private string date;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Schedule(string Staff, string Facility, string Date)
        {
            this.staff = Staff;
            this.facility = Facility;
            this.date = Date;
        }
        public Schedule()
        {
            this.staff = string.Empty;
            this.facility = string.Empty;
            this.date = string.Empty;
        }
        public string Staff
        {
            get { return this.staff; }
            set { this.staff = value; }
        }
        public string Facility
        {
            get { return this.facility; }
            set { this.facility = value; }
        }
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string GetSchedule(ListView req)
        {
            string result = string.Empty;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Schedule", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                result += "Staff: " + dr["Staff"].ToString()
                       + ", Facility: " + dr["Facility"].ToString()
                       + ", Date: " + dr["Date"].ToString() + "\n";
                       

                ListViewItem item = new ListViewItem(dr["Staff"].ToString());
                item.SubItems.Add(dr["Facility"].ToString());
                item.SubItems.Add(dr["Date"].ToString());
                req.Items.Add(item);
            }
            dr.Close();
            con.Close();
            return result;
        }

        public void AddSchedule()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Schedule (Staff, Facility, Date/Time) VALUES (@Staff, @Facility, @Date)", con);
            cmd.Parameters.AddWithValue("@Staff", staff);
            cmd.Parameters.AddWithValue("@Facility", facility);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
