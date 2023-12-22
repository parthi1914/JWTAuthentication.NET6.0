﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTAuthentication.NET6._0.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesControllerAuthoize : ControllerBase
    {
        // GET: api/<ValuesControllerAuthoize>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesControllerAuthoize>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesControllerAuthoize>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesControllerAuthoize>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesControllerAuthoize>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
