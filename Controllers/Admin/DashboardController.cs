using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Api.Controllers.Admin
{
    [ApiController]
    [Route("admin/dashboard")]
    public class DashboardController : ControllerBase
    {
        private readonly SchoolDbContext _context;

        public DashboardController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: admin/dashboard
        [HttpGet]
        public async Task<IActionResult> GetDashboardData()
        {
            var dashboardData = new
            {
                TotalStudents = await _context.Students.CountAsync(),
                TotalTeachers = await _context.Teachers.CountAsync(),
                TotalNotices = await _context.Notices.CountAsync(),
                PendingTeacherLeaves = await _context.Leaves
                    .Where(l => l.Status == "Pending")
                    .CountAsync()
            };

            return Ok(dashboardData);
        }
    }
}

