//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class BusController
//    {
//    }
//}


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin/buses")]
public class BusController : ControllerBase
{
    [HttpPost]
    public IActionResult AddBus() => Ok("Bus added");

    [HttpGet]
    public IActionResult GetBuses() => Ok("Bus list");

    [HttpPut("{id}")]
    public IActionResult UpdateBus(int id) => Ok("Bus updated");
}

