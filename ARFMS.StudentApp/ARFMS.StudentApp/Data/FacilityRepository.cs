#nullable enable
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ARFMS.StudentApp.Models;

namespace ARFMS.StudentApp.Data
{
    public class FacilityRepository
    {
        public List<Facility> Search(string? type, string? location)
        {
            var list = new List<Facility>();
            using var conn = Db.GetConnection();
            conn.Open();

            var sql = @"
                SELECT FacilityID, Name, Type, Location, Rate, IsAvailable
                FROM Facilities
                WHERE IsAvailable = 1
                  AND (@t IS NULL OR Type LIKE '%' + @t + '%')
                  AND (@l IS NULL OR Location LIKE '%' + @l + '%')
                ORDER BY Name;";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@t", (object?)type ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@l", (object?)location ?? (object)DBNull.Value);

            using var r = cmd.ExecuteReader();
            while (r.Read())
            {
                list.Add(new Facility
                {
                    FacilityID = r.GetInt32(0),
                    Name = r.GetString(1),
                    Type = r.GetString(2),
                    Location = r.GetString(3),
                    Rate = r.GetDecimal(4),
                    IsAvailable = r.GetBoolean(5)
                });
            }
            return list;
        }

        public List<Facility> GetAll()
        {
            return Search(null, null);
        }
    }
}
