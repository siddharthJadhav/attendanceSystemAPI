using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace attendanceSystemAPI.Models
{
    public class Employee
    {
        //public List<Employee> ListEmployee { get; set; }

        //public Employee()
        //{
        //    ListEmployee = new List<Employee>();
        //}

        //public int EmpID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string Gender { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //public DateTime CreationDate { get; set; }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

    }
}
