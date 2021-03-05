using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SendMail.Api.Web.Controllers
{
    [Route("api/mail")]
    [ApiController]
    public class MailController : ControllerBase
    {
        // GET: api/mail
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/mail/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/mail
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/mail/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/mail/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
