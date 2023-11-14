using gyak9.JokeModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gyak9.Controllers
{
    [Route("api/jokes")]
    [ApiController]
    public class JokeController : ControllerBase
    {
        // GET: api/<JokeController>
        [HttpGet]
        public IActionResult Get()
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            return Ok(context.Jokes.ToList());
        }

        // GET api/<JokeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JokeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JokeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JokeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
