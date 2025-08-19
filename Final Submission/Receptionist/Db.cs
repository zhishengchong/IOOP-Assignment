using System.Configuration;
using System.Data.SqlClient;

namespace Final_Submission.Receptionist
{
    public static class Db
    {
        public static string CS
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings["ARFMS"];
                return cs != null ? cs.ConnectionString : "";
            }
        }

        public static SqlConnection Conn()
        {
            return new SqlConnection(CS);
        }
    }
}
