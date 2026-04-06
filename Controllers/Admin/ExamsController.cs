//using Microsoft.AspNetCore.Mvc;

//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class ExamsController
//    {
//    }
//}


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin/exams")]
public class ExamsController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateExam() => Ok("Exam created");

    [HttpGet]
    public IActionResult GetExams() => Ok("Exam list");
}
