//namespace SchoolManagement.Api.Controllers.Student
//{
//    public class StudentAccountController
//    {
//    }
//}

//using Microsoft.AspNetCore.Mvc;

//[ApiController]
//[Route("student")]
//public class StudentAccountController : ControllerBase
//{
//    [HttpPost("change-password")]
//    public IActionResult ChangePassword(ChangePasswordDto dto)
//    {
//        // Password validation + update logic
//        return Ok("Password changed successfully");
//    }
//}


//using Microsoft.AspNetCore.Mvc;
//using SchoolManagement.Api.DTOs;

//namespace SchoolManagement.Api.Controllers.Student
//{
//    [ApiController]
//    [Route("student")]
//    public class StudentAccountController : ControllerBase
//    {
//        [HttpPost("change-password")]
//        public IActionResult ChangePassword(ChangePasswordDto dto)
//        {
//            // 🔹 Abhi dummy logic
//            // Yahan later DB se password verify & update karenge

//            if (string.IsNullOrEmpty(dto.OldPassword) || string.IsNullOrEmpty(dto.NewPassword))
//            {
//                return BadRequest("Old password and New password are required");
//            }

//            return Ok("Password changed successfully");
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Api.Data;
using SchoolManagement.Api.DTOs;
using SchoolManagement.Api.Models;

[ApiController]
[Route("api/student-account")]
public class StudentAccountController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public StudentAccountController(SchoolDbContext context)
    {
        _context = context;
    }

    // 1️⃣ Register
    [HttpPost("register")]
    public IActionResult Register(RegisterStudentDto dto)
    {
        if (_context.Students.Any(x => x.Email == dto.Email))
            return BadRequest("Email already exists");

        var student = new Student
        {
            FullName = dto.FullName,
            Email = dto.Email,
            PasswordHash = PasswordHelper.HashPassword(dto.Password)
        };

        _context.Students.Add(student);
        _context.SaveChanges();

        return Ok("Student registered successfully");
    }

    // 2️⃣ Login
    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var student = _context.Students.FirstOrDefault(x => x.Email == dto.Email);

        if (student == null)
            return Unauthorized("Invalid email");

        if (!PasswordHelper.Verify(dto.Password, student.PasswordHash))
            return Unauthorized("Invalid password");

        return Ok(new
        {
            student.Id,
            student.FullName,
            student.Email
        });
    }

    // 3️⃣ Change Password
    [HttpPost("change-password")]
    public IActionResult ChangePassword(ChangePasswordDto dto)
    {
        var student = _context.Students.Find(dto.StudentId);

        if (student == null)
            return NotFound("Student not found");

        if (!PasswordHelper.Verify(dto.OldPassword, student.PasswordHash))
            return BadRequest("Old password incorrect");

        student.PasswordHash = PasswordHelper.HashPassword(dto.NewPassword);
        _context.SaveChanges();

        return Ok("Password changed successfully");
    }

    // 4️⃣ Forgot Password
    [HttpPost("forgot-password")]
    public IActionResult ForgotPassword(ForgotPasswordDto dto)
    {
        var student = _context.Students.FirstOrDefault(x => x.Email == dto.Email);

        if (student == null)
            return NotFound("Email not registered");

        student.PasswordHash = PasswordHelper.HashPassword(dto.NewPassword);
        _context.SaveChanges();

        return Ok("Password reset successful");
    }

    // 5️⃣ Profile
    [HttpGet("profile/{id}")]
    public IActionResult Profile(int id)
    {
        var student = _context.Students
            .Where(x => x.Id == id)
            .Select(x => new
            {
                x.Id,
                x.FullName,
                x.Email,
                x.CreatedAt
            })
            .FirstOrDefault();

        if (student == null)
            return NotFound();

        return Ok(student);
    }
}
