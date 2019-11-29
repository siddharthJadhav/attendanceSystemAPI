using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace attendanceSystemAPI.Models
{
    public class attendanceSystemDBContextFactory
    {

        public static MySqlConnection GetattendanceSystemDBConnection(string connectionString = null)
        {
            if (connectionString == null)
            {
                return new MySqlConnection(Environment.GetEnvironmentVariable("ConStr"));
            }
            else
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}
