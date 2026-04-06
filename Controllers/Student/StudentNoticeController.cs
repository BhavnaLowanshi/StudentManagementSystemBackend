//namespace SchoolManagement.Api.Controllers.Student
//{
//    public class StudentNoticeController
//    {
//    }
//}
//using Microsoft.AspNetCore.Mvc;
//using SchoolManagement.Api.Data;

//[ApiController]
//[Route("student/notices")]
//public class StudentNoticeController : ControllerBase
//{
//    private readonly SchoolDbContext _context;

//    public StudentNoticeController(SchoolDbContext context)
//    {
//        _context = context;
//    }

//    [HttpGet]
//    public IActionResult GetNotices()
//    {
//        var notices = _context.Notices
//            .Where(n => n.IsActive)
//            .ToList();

//        return Ok(notices);
//    }
//}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Api.Data;

[ApiController]
[Route("student/notices")]
public class StudentNoticeController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public StudentNoticeController(SchoolDbContext context)
    {
        _context = context;
    }

    // GET /student/notices
    [HttpGet]
    public async Task<IActionResult> GetNotices()
    {
        var notices = await _context.Notices
            .Where(n => n.IsActive)
            .OrderByDescending(n => n.CreatedDate)
            .Select(n => new
            {
                n.Id,
                n.Title,
                n.Description,
                n.CreatedDate
            })
            .ToListAsync();

        return Ok(notices);
    }
}
