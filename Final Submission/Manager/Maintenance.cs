using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Submission.Manager
{
    internal class Maintenance
    {
        private string maintName;
        private string email;
        private string phoneNum;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Maintenance(string name, string Email, string PhoneNum)
        {
            maintName = Name;
            email = Email;
            phoneNum = PhoneNum;
        }

        public Maintenance(string name)
        {
            maintName = name;
            email = string.Empty;
            phoneNum = string.Empty;
        }

        public string Name
        {
            get { return maintName; }
            set { maintName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public string addMaintenance()
        {
            string status;

            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into MaintenanceStaff(Name, email, PhoneNumber) values(@name, @em,@num)", con);

            SqlCommand cmd2 = new SqlCommand("Insert into Users(username, role, password) values(@name,'Maintenance','123')", con);
            cmd.Parameters.AddWithValue("@name", maintName);
            cmd2.Parameters.AddWithValue("@name", maintName);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@num", phoneNum);

            cmd2.ExecuteNonQuery();
            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                status = "Registration Successsful";

            }
            else
            {
                status = "Unable to Register";
            }

            con.Close();
            return status;
        }

            public static ArrayList viewAll()
        {
            //to create a dynamic array
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from MaintenanceStaff", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }

            con.Close();

            return nm;
        }

        public static void ViewProfile(Maintenance o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from MaintenanceStaff where Name = '" + o1.maintName + "'", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                o1.email = rd.GetString(2);
                o1.phoneNum = rd.GetString(3);
            }

            con.Close();
        }

        public string updateProfile(string em, string num)
        {
            string status;
            con.Open();
            email = em;
            phoneNum = num;
            string mysql;

            mysql = "update MaintenanceStaff set email ='" + email + "', phoneNumber= '" +
                phoneNum + "' where Name='" + maintName + "'";

            SqlCommand cmd = new SqlCommand(mysql, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Updata Successfully";
            }
            else
            {
                status = "Unable to update";
            }

            con.Close();

            return status;
        }

        public string deleteProfile()
        {
            string status;
            con.Open();
            string mysql;
            mysql = "delete from MaintenanceStaff where Name='" + maintName + "'";
            SqlCommand cmd = new SqlCommand(mysql, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                status = "Deleted Successfully";
            }
            else
            {
                status = "Unable to delete";
            }
            con.Close();
            return status;
        }
    }
}
