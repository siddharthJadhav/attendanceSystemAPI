using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using attendanceSystemAPI.DAL;
using attendanceSystemAPI.Models;


namespace attendanceSystemAPI.DAL
{
    public class EmployeeDAL
    {

        public async Task<List<Employee>> GetEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            using (DbConnection cnn = attendanceSystemDBContextFactory.GetattendanceSystemDBConnection())
            {

                DbCommand cmd = cnn.CreateDbCMD(CommandType.Text, $"SELECT * FROM Employees;");
                cnn.Open();
                using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        Employee oData = new Employee();
                        oData.ID = Convert.ToInt32(reader["id"]);
                        oData.FirstName = reader["FirstName"].ToString();
                        oData.LastName = reader["LastName"].ToString();
                        oData.Gender = reader["Gender"].ToString();
                        oData.Salary = Convert.ToInt32(reader["Salary"]);
                        employeeList.Add(oData);
                    }
                }
                cnn.Close();
            }
            return employeeList;
        }

        public async Task<Employee> GetEmployeeDetail(int id)
        {
            Employee employeeDetail = new Employee();
            using (DbConnection cnn = attendanceSystemDBContextFactory.GetattendanceSystemDBConnection())
            {

                DbCommand cmd = cnn.CreateDbCMD(CommandType.Text, $"SELECT * FROM Employees where ID = " + id + ";");
                cnn.Open();
                using (DbDataReader reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        employeeDetail.ID = Convert.ToInt32(reader["id"]);
                        employeeDetail.FirstName = reader["FirstName"].ToString();
                        employeeDetail.LastName = reader["LastName"].ToString();
                        employeeDetail.Gender = reader["Gender"].ToString();
                        employeeDetail.Salary = Convert.ToInt32(reader["Salary"]);
                    }
                }
                cnn.Close();
            }
            return employeeDetail;
        }

    }
}
