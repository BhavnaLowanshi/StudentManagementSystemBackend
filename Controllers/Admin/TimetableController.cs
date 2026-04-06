//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class TimetableController
//    {
//    }
//}
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin/timetable")]
public class TimetableController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateTimetable() => Ok("Timetable created");

    [HttpGet]
    public IActionResult GetTimetable() => Ok("Timetable list");

    [HttpPut("{id}")]
    public IActionResult UpdateTimetable(int id) => Ok("Timetable updated");
}

