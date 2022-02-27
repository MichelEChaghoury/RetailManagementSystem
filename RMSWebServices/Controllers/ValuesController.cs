using System.Collections.Generic;
using System.Web.Http;
using Microsoft.AspNet.Identity;

namespace RMSWebServices.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            string userId = RequestContext.Principal.Identity.GetUserId(); 
            string userName = RequestContext.Principal.Identity.GetUserName();

            return Ok(new { UserId = userId, UserName = userName, Values = new string[] { "First", "Second" } });
        }

        // GET api/values/5
        public string Get(int id)
        {
            return $"value ID: {id}";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}