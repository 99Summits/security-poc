using Microsoft.AspNetCore.Mvc;

namespace SecurityPoC.Controllers
{
    public class TestController : Controller
    {
        [HttpGet("/test")]
        public IActionResult Index([FromQuery] string jsonString)
        {
            var myObject = Newtonsoft.Json.JsonConvert.DeserializeObject<MyObject>(jsonString);
            return Ok(myObject.Value);
        }

        public class MyObject 
        {
            public string? Value { get; set; }
        }
    }
}
