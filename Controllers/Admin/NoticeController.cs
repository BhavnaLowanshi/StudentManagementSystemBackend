//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class NoticeController
//    {
//    }
//}



//using Microsoft.AspNetCore.Mvc;

//[ApiController]
//[Route("admin")]
//public class NoticeController : ControllerBase
//{
//    [HttpPost("notice")]
//    public IActionResult AddNotice() => Ok("Notice Added");

//    [HttpGet("notices/{id}")]
//    public IActionResult GetNotice(int id) => Ok($"Notice {id}");

//    [HttpPut("notices/{id}")]
//    public IActionResult UpdateNotice(int id) => Ok($"Updated {id}");

//    [HttpDelete("notices/{id}")]
//    public IActionResult DeleteNotice(int id) => Ok($"Deleted {id}");
//}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Api.Data;
using SchoolManagement.Api.Models;

[ApiController]
[Route("admin")]
public class NoticeController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public NoticeController(SchoolDbContext context)
    {
        _context = context;
    }

    // POST /admin/notice
    [HttpPost("notice")]
    public async Task<IActionResult> AddNotice([FromBody] Notice notice)
    {
        if (notice == null)
            return BadRequest("Notice data is required");

        notice.CreatedDate = DateTime.Now;
        notice.IsActive = true;

        _context.Notices.Add(notice);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Notice added successfully",
            data = notice
        });
    }

    // GET /admin/notices/{id}
    [HttpGet("notices/{id}")]
    public async Task<IActionResult> GetNotice(int id)
    {
        var notice = await _context.Notices.FindAsync(id);

        if (notice == null)
            return NotFound("Notice not found");

        return Ok(notice);
    }

    // PUT /admin/notices/{id}
    [HttpPut("notices/{id}")]
    public async Task<IActionResult> UpdateNotice(int id, [FromBody] Notice updatedNotice)
    {
        var notice = await _context.Notices.FindAsync(id);

        if (notice == null)
            return NotFound("Notice not found");

        notice.Title = updatedNotice.Title;
        notice.Description = updatedNotice.Description;
        notice.IsActive = updatedNotice.IsActive;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Notice updated successfully",
            data = notice
        });
    }

    // DELETE /admin/notices/{id}
    [HttpDelete("notices/{id}")]
    public async Task<IActionResult> DeleteNotice(int id)
    {
        var notice = await _context.Notices.FindAsync(id);

        if (notice == null)
            return NotFound("Notice not found");

        _context.Notices.Remove(notice);
        await _context.SaveChangesAsync();

        return Ok("Notice deleted successfully");
    }
}
