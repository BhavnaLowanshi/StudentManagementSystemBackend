//namespace SchoolManagement.Api.Controllers.Student
//{
//    public class StudentTimetableController
//    {
//    }
//}


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("student")]
public class StudentTimetableController : ControllerBase
{
    [HttpGet("timetable")]
    public IActionResult GetTimetable() => Ok("Student Timetable");

    [HttpGet("timetable/day/{day}")]
    public IActionResult GetTimetableByDay(string day)
        => Ok($"Timetable for {day}");
}
