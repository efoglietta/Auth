using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServizioProtettoController : ControllerBase
    {
        // GET: api/<ServizioProtettoController>
        [HttpGet]
        public ActionResult<string[]> Get()
        {
            string auth = Request.Headers[HeaderNames.Authorization];
            if(!string.IsNullOrWhiteSpace(auth))
            {
                var token = auth.Split(" ")[1];
                if (token=="..") return new string[] { "value1", "value2" };
                else return Unauthorized();
            }
            return NotFound();
           
        }

    }
}
