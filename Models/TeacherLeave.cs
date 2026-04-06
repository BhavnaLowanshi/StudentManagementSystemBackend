
namespace SchoolManagement.Api.Models
{
    public class TeacherLeave
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public DateTime LeaveDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string LeaveType { get; set; } = string.Empty;
    }
}




