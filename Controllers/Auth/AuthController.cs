//namespace SchoolManagement.Api.Controllers.Auth
//{
//    public class AuthController
//    {
//    }
//}


//using Microsoft.AspNetCore.Mvc;

//namespace SchoolManagement.Api.Controllers.Auth
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class AuthController : ControllerBase
//    {
//        [HttpGet("test")]
//        public IActionResult Test()
//        {
//            return Ok("AuthController working!");
//        }
//    }
//}



//using Microsoft.AspNetCore.Mvc;

//namespace SchoolManagement.Api.Controllers.Auth
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class AuthController : ControllerBase
//    {
//        [HttpGet("test")]
//        public IActionResult Test()
//        {
//            return Ok("Swagger Working");
//        }
//    }
//}


//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Data;
//using SchoolManagement.Api.DTOs;
//using SchoolManagement.Api.Models;

//[ApiController]
//[Route("api/auth")]
//public class AuthController : ControllerBase
//{
//    private readonly SchoolDbContext _context;

//    public AuthController(SchoolDbContext context)
//    {
//        _context = context;
//    }

//    // 🔐 LOGIN
//    [HttpPost("login")]
//    public async Task<IActionResult> Login([FromBody] LoginDto dto)
//    {
//        var admin = await _context.Admins
//            .FirstOrDefaultAsync(a => a.Email == dto.Email && a.Password == dto.Password);

//        if (admin == null)
//            return Unauthorized("Invalid email or password");

//        return Ok(admin);
//    }

//    // 📝 REGISTER
//    [HttpPost("register")]
//    public async Task<IActionResult> Register([FromBody] Admin admin)
//    {
//        _context.Admins.Add(admin);
//        await _context.SaveChangesAsync();
//        return Ok(admin);
//    }
//}






























using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("auth")]
public class AuthController : ControllerBase
{
    [HttpPost("login")]
    public IActionResult Login() => Ok("Login");

    [HttpPost("signup")]
    public IActionResult Signup() => Ok("Signup");

    [HttpGet("role")]
    public IActionResult GetRole() => Ok("Role");

    [HttpPost("forgot-password")]
    public IActionResult ForgotPassword() => Ok("Forgot Password");

    [HttpPost("change-password")]
    public IActionResult ChangePassword() => Ok("Change Password");
}


