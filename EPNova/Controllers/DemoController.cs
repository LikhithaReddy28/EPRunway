using Microsoft.AspNetCore.Mvc;

namespace EPNova.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet("hello")]
        public ActionResult<string> GetHello()
        {
            return Ok("Hello from DemoController!");
        }

        [HttpGet("hello/{name}")]
        public ActionResult<string> GetHelloWithName(string name)
        {
            return Ok($"Hello, {name}!");
        }

        [HttpGet("test")]
        public ActionResult<object> GetTest()
        {
            return Ok(new { 
                Message = "Test endpoint", 
                Timestamp = DateTime.UtcNow 
            });
        }
    }
}