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

namespace Manager
{
    internal class Receptionist
    {
        private string receptName;
        private string email;
        private string phoneNum;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Receptionist(string name, string Email, string PhoneNum)
        {
            this.receptName = Name;
            this.email = Email;
            this.phoneNum = PhoneNum;
        }

        public Receptionist(string name)
        {
            this.receptName = name;
            this.email = string.Empty;
            this.phoneNum = string.Empty;
        }

        public string Name
        {
            get { return this.receptName; }
            set { this.receptName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
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

            SqlCommand cmd = new SqlCommand("Insert into ReceptionistStaff(Name, email, PhoneNumber) values(@name, @em,@num)", con);

            SqlCommand cmd2 = new SqlCommand("Insert into Users(username, role, password) values(@name,'Maintenance','123')", con);
            cmd.Parameters.AddWithValue("@name", this.receptName);
            cmd2.Parameters.AddWithValue("@name", this.receptName);
            cmd.Parameters.AddWithValue("@em", this.email);
            cmd.Parameters.AddWithValue("@num", this.phoneNum);

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
            SqlCommand cmd = new SqlCommand("select Name from ReceptionistStaff", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }

            con.Close();

            return nm;
        }

        public static void ViewProfile(Receptionist o1)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ReceptionistStaff where Name = '" + o1.receptName + "'", con);
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

            mysql = "update ReceptionistStaff set email ='" + email + "', phoneNumber= '" +
                phoneNum + "' where Name='" + receptName + "'";

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
    }

}
