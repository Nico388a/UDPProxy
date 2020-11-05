using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SensorRest.Controllers
{
    [Route("api/sensor")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<SensorData> _listOfData = new List<SensorData>()
        {
            new SensorData(1, "Sensor1", 28.2,15.5),
            new SensorData(2, "Sensor1", 32.4,12.1),
            new SensorData(3, "Sensor1", 12,17.9),
            new SensorData(4, "Sensor1", 46.1,52.1)

        };




        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<SensorData> GetAll()
        {
            return _listOfData;
        }

        // GET api/<ValuesController>/5
        [HttpGet]
        [Route("{id}")]
        public SensorData Get(int id)
        {
            return _listOfData.Find(i => i.Id == id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] SensorData value)
        {
            _listOfData.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
