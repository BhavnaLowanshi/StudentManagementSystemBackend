//namespace SchoolManagement.Api.Controllers.Student
//{
//    public class AttendanceController
//    {
//    }
//}
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Api.Data;

[ApiController]
[Route("student/attendance")]
public class AttendanceController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public AttendanceController(SchoolDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAttendance()
    {
        var attendance = _context.Attendances.ToList();
        return Ok(attendance);
    }
}

