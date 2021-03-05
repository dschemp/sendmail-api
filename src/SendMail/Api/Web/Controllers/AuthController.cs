using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SendMail.Api.Web.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // GET: api/auth
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Array.Empty<string>();
        }

        // GET api/auth/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return null;
        }

        // POST api/auth
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/auth/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/auth/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
