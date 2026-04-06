//namespace SchoolManagement.Api.Controllers
//{
//    public class TestController
//    {
//    }
//}

using Microsoft.AspNetCore.Mvc;

namespace SchoolManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Swagger OK");
        }
    }
}


