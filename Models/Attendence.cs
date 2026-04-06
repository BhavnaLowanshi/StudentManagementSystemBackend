

namespace SchoolManagement.Api.Models

{
    public class Attendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; } 
        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }

        // Navigation Property
        // public Student Student { get; set; } 
        public Student? Student { get; set; }

    }
}
