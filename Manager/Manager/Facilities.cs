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
    internal class Facilities
    {
        private string facility;
        private string facilityType;
        private string maintenanceRate;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Facilities(string Fac, string FacType, string MaintenanceRate)
        {
            this.facility = Fac;
            this.facilityType = FacType;
            this.maintenanceRate = MaintenanceRate;
        }

        public Facilities(string Fac)
        {
            this.facility = Fac;
            this.facilityType = string.Empty;
            this.maintenanceRate = string.Empty;
        }

        public string Facility
        {
            get { return this.facility; }
            set { this.facility = value; }
        }

        public string FacilityType
        {
            get { return this.facilityType; }
            set { this.facilityType = value; }
        }

        public string MaintenanceRate
        {
            get { return maintenanceRate; }
            set { maintenanceRate = value; }
        }

        public string addFacility()
        {
            string status;

            con.Open();

            SqlCommand cmd = new SqlCommand("Insert into Facility(Facility, FacilityType, MaintenanceRate) values(@fac, @facType,@rate)", con);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                status = "Addition Successsful";

            }
            else
            {
                status = "Unable to Add";
            }

            con.Close();
            return status;
        }

        public static ArrayList viewAll()
        {
            //to create a dynamic array
            ArrayList nm = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select Facility from Facility", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                nm.Add(rd.GetString(0));
            }

            con.Close();

            return nm;
        }


        public string editFacility(string em, string num)
        {
            string status;
            con.Open();
            facilityType = em;
            maintenanceRate = num;
            string mysql;

            mysql = "update Facility set FacilityType ='" + facilityType + "', MaintenanceRate= '" +
                maintenanceRate + "' where Facility='" + facility + "'";

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

        public string deleteFacilities()
        {
            string status;
            con.Open();
            string mysql;
            mysql = "delete from Facility where Name='" + facility + "'";
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
