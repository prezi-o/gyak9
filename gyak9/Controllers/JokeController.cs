﻿using gyak9.JokeModels;
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
        public IActionResult Get(int id)
        {
            FunnyDatabaseContext context = new FunnyDatabaseContext();
            var keresettvicc = (from x in context.Jokes
                                where x.JokeSk==id
                                select x).FirstOrDefault();
            if (keresettvicc==null) 
            { return NotFound($"Nincs #{id} azonosítóval vicc"); }
            else
            {
                return Ok(keresettvicc);
            }
        }

        // POST api/<JokeController>
        [HttpPost]
        public void Post([FromBody] Joke ujvicc)
        {
            FunnyDatabaseContext context = new();
            context.Jokes.Add(ujvicc);
            context.SaveChanges();
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
