using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace TasksManager.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private static List<string> Values { get; } = new List<string>();

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Values;
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string value)
        {
            string postedValue = $"{Values.Count}-{value}";
            Values.Add(postedValue);
            return postedValue;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(404)]
        public IActionResult Get(int id)
        {
            string foundValue = Values.FirstOrDefault(s => s.StartsWith($"{id}-"));
            if (foundValue == null)
            {
                return NotFound();
            }
            return Ok(foundValue);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(200, Type = typeof(string))]
        [ProducesResponseType(404)]
        public IActionResult Put(int id, [FromBody]string value)
        {
            string foundValue = Values.FirstOrDefault(s => s.StartsWith($"{id}-"));
            if (foundValue == null)
            {
                return NotFound();
            }
            string newValue = $"{id}-{value}";
            int index = Values.IndexOf(foundValue);
            Values[index] = newValue;
            return Ok(newValue);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        public void Delete(int id)
        {
            string foundValue = Values.FirstOrDefault(s => s.StartsWith($"{id}-"));
            if (foundValue != null)
            {
                Values.Remove(foundValue);
            }
        }
    }
}
