using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Api.Models
{
    public class Result
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public int ExamId { get; set; }

        public string? Subject { get; set; }
        public string? Grade { get; set; }
        public string? Status { get; set; }

        public int MarksObtained { get; set; }
        public int TotalMarks { get; set; }

        public string? AcademicSession { get; set; }
    }
}