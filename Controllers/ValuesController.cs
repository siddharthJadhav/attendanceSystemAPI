using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace attendanceSystemAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        static List<string> strings = new List<string>()
        { "value0", "value1", "value2"};

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return strings;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return strings[id];
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            strings.Add(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            strings[id] = value;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            strings.RemoveAt(id);
        }
    }
}
