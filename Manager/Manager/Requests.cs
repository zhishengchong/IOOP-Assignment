using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager
{
    internal class Requests
    {
        private string staff;
        private string request;
        private string date;
        private string status;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Requests(string Staff, string Request, string Date,string Status)
        {
            this.staff = Staff;
            this.request = Request;
            this.date = Date;
            this.status = Status;
        }

        public string Staff
        {
            get { return this.staff; }
            set { this.staff = value; }
        }

        public string Request
        {
            get { return this.request; }
            set { this.request = value; }
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
    }
}
