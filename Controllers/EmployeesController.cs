using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using attendanceSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using attendanceSystemAPI.DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace attendanceSystemAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller

    {

        //public IEnumerable<Emo>

        // GET: api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Employee> employeeList = await new EmployeeDAL().GetEmployeeList();
            return Ok(new { employeeList.Count, employeeList });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            Employee employeeDetail = await new EmployeeDAL().GetEmployeeDetail(id);
            return Ok(new { employeeDetail });
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
