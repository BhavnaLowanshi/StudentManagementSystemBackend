//namespace SchoolManagement.Api.Controllers.Admin
//{
//    public class AdminProfileController
//    {
//    }
//}


//using Microsoft.AspNetCore.Mvc;

//[ApiController]
//[Route("admin/profile")]
//public class AdminProfileController : ControllerBase
//{
//    [HttpGet]
//    public IActionResult GetProfile() => Ok("Admin profile");

//    [HttpPut]
//    public IActionResult UpdateProfile() => Ok("Profile updated");
//}

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("admin")]
public class AdminProfileController : ControllerBase
{
    [HttpGet("profile")]
    public IActionResult GetProfile() => Ok("Admin Profile");

    [HttpPut("profile")]
    public IActionResult UpdateProfile() => Ok("Profile Updated");

    [HttpPost("change-password")]
    public IActionResult ChangePassword() => Ok("Password Changed");

    [HttpPost("profile-image")]
    public IActionResult UploadImage() => Ok("Image Uploaded");
}
