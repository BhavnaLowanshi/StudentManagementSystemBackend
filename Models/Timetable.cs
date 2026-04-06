namespace SchoolManagement.Api.Models
{
    public class Timetable
    {
        public int Id { get; set; }
        public string Class { get; set; } = string.Empty;
        public string Section { get; set; } = string.Empty;
        public string Day { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public string TeacherName { get; set; } = string.Empty;
        public string StartTime { get; set; } = string.Empty;
        public string EndTime { get; set; } = string.Empty;
    }
}