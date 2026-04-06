namespace SchoolManagement.Api.DTOs
{
    public class ChangePasswordDto
    {
        public int StudentId { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
