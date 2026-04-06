using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Api.DTOs;
using SchoolManagement.Api.Services;

namespace SchoolManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            // For common cases, we can hardcode for testing. 
            // In real app, check against DB.
            if (dto.Email == "admin@school.com" && dto.Password == "Admin@123")
            {
                var token = _authService.GenerateJwtToken(dto.Email);
                return Ok(new { token });
            }
            return Unauthorized("Invalid credentials. Use admin@school.com / Admin@123 for testing.");
        }
    }
}
