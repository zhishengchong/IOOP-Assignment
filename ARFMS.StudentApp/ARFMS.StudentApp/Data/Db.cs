using System.Configuration;
using System.Data.SqlClient;

namespace ARFMS.StudentApp.Data
{
    public static class Db
    {
        public static SqlConnection GetConnection()
        {
            var cs = ConfigurationManager.ConnectionStrings["ARFMS"].ConnectionString;
            return new SqlConnection(cs);
        }
    }
}
