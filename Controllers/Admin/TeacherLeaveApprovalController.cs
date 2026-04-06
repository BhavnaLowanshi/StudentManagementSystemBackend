//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class TeacherLeaveApprovalController
//    {
//    }
//}
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin/teacher")]
public class TeacherLeaveApprovalController : ControllerBase
{
    [HttpGet("leaves")]
    public IActionResult GetAllLeaves() => Ok("All Teacher Leaves");

    [HttpPut("leaves/{id}")]
    public IActionResult ApproveRejectLeave(int id)
        => Ok($"Leave {id} Approved/Rejected");
}
