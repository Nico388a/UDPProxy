using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensorRest.Controllers
{
    [Route("api/Test")]
    [ApiController]
    public class ValuesControllerNo2 : ControllerBase
    {
        // GET: api/<ValuesControllerNo2>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesControllerNo2>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesControllerNo2>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesControllerNo2>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesControllerNo2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
