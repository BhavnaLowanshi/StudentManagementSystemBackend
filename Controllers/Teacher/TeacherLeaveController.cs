//namespace SchoolManagement.Api.Controllers.Teacher
//{
//    public class TeacherLeaveController
//    {
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using SchoolManagement.Api.DTOs;
//using SchoolManagement.Api.Services;

//[ApiController]
//[Route("teacher/leaves")]
//public class TeacherLeaveController : ControllerBase
//{
//    private readonly LeaveService _service;

//    public TeacherLeaveController(LeaveService service)
//    {
//        _service = service;
//    }

//    [HttpGet]
//    public IActionResult GetLeaves()
//    {
//        return Ok(_service.GetAll());
//    }

//    [HttpPost]
//    public IActionResult ApplyLeave(ApplyLeaveDto dto)
//    {
//        _service.ApplyLeave(dto);
//        return Ok("Leave Applied");
//    }

//    [HttpPut("{id}")]
//    public IActionResult UpdateLeave(int id, ApplyLeaveDto dto)
//    {
//        return Ok("Leave Updated");
//    }

//    [HttpDelete("{id}")]
//    public IActionResult DeleteLeave(int id)
//    {
//        return Ok("Leave Deleted");
//    }
//}


//using Microsoft.AspNetCore.Mvc;
//using SchoolManagement.Api.Services;

//namespace SchoolManagement.Api.Controllers
//{
//    [ApiController]
//    [Route("teacher/leaves")]
//    public class TeacherLeaveController : ControllerBase
//    {
//        private readonly LeaveService _leaveService;

//        public TeacherLeaveController(LeaveService leaveService)
//        {
//            _leaveService = leaveService;
//        }

//        [HttpPost]
//        public IActionResult CreateLeave([FromBody] object data)
//        {
//            return Ok("Leave API Working");
//        }
//    }
//}



//using Microsoft.AspNetCore.Mvc;
//using SchoolManagement.Api.Data;

//[ApiController]
//[Route("teacher")]
//public class TeacherLeaveController : ControllerBase
//{
//    private readonly SchoolDbContext _context;

//    public TeacherLeaveController(SchoolDbContext context)
//    {
//        _context = context;
//    }

//    [HttpPost("leaves")]
//    public async Task<IActionResult> CreateLeave([FromBody] TeacherLeave leave)
//    {
//        _context.TeacherLeaves.Add(leave);
//        await _context.SaveChangesAsync();

//        return Ok(leave);
//    }
//}

using SchoolManagement.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Api.Data;

[ApiController]
[Route("teacher")]
public class TeacherLeaveController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public TeacherLeaveController(SchoolDbContext context)
    {
        _context = context;
    }

    // 1️⃣ POST – Apply Leave
    [HttpPost("leaves")]
    public async Task<IActionResult> CreateLeave([FromBody] TeacherLeave leave)
    {
        _context.TeacherLeaves.Add(leave);
        await _context.SaveChangesAsync();
        return Ok(leave);
    }

    // 2️⃣ GET – Get all leaves of teacher
    [HttpGet("leaves")]
    public async Task<IActionResult> GetLeaves()
    {
        var leaves = await _context.TeacherLeaves.ToListAsync();
        return Ok(leaves);
    }

    // 3️⃣ GET by ID
    [HttpGet("leaves/{id}")]
    public async Task<IActionResult> GetLeaveById(int id)
    {
        var leave = await _context.TeacherLeaves.FindAsync(id);
        if (leave == null)
            return NotFound();

        return Ok(leave);
    }

    // 4️⃣ PUT – Update leave
    [HttpPut("leaves/{id}")]
    public async Task<IActionResult> UpdateLeave(int id, [FromBody] TeacherLeave leave)
    {
        var existingLeave = await _context.TeacherLeaves.FindAsync(id);
        if (existingLeave == null)
            return NotFound();

        existingLeave.TeacherId = leave.TeacherId;
        existingLeave.LeaveDate = leave.LeaveDate;
        existingLeave.Reason = leave.Reason;
        existingLeave.LeaveType = leave.LeaveType;

        await _context.SaveChangesAsync();
        return Ok(existingLeave);
    }

    // 5️⃣ PATCH – Partial Update (example: only Reason)
    [HttpPatch("leaves/{id}")]
    public async Task<IActionResult> UpdateLeaveReason(int id, [FromBody] string reason)
    {
        var leave = await _context.TeacherLeaves.FindAsync(id);
        if (leave == null)
            return NotFound();

        leave.Reason = reason;
        await _context.SaveChangesAsync();

        return Ok(leave);
    }

    // 6️⃣ DELETE – Delete leave
    [HttpDelete("leaves/{id}")]
    public async Task<IActionResult> DeleteLeave(int id)
    {
        var leave = await _context.TeacherLeaves.FindAsync(id);
        if (leave == null)
            return NotFound();

        _context.TeacherLeaves.Remove(leave);
        await _context.SaveChangesAsync();

        return Ok("Leave deleted successfully");
    }
}

