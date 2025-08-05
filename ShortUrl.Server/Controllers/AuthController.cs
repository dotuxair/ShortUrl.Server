using Microsoft.AspNetCore.Mvc;


namespace ShortUrl.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ["value1", "value2"];
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
