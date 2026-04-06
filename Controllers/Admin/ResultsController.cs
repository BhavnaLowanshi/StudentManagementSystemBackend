//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class ResultsController
//    {
//    }
//}


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin/results")]
public class ResultsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetResults() => Ok("All results");

    [HttpGet("session/{session}")]
    public IActionResult GetResultsBySession(string session)
        => Ok($"Results for {session}");
}

