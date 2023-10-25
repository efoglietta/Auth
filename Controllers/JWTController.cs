using Microsoft.AspNetCore.Mvc;
using WebApiJWT.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTController : ControllerBase
    {
        private IJWTHelper _jwtHelper;
        public JWTController(IJWTHelper jwtHelper)
        {

            _jwtHelper=jwtHelper;
        }
        // GET: api/<JWTController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _jwtHelper.GeneraJSONWebToken();
        }

        // GET api/<JWTController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JWTController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<JWTController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JWTController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
