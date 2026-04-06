//using System.ComponentModel.DataAnnotations;

//namespace SchoolManagement.Api.Models
//{
//    public class Exam
//    {
//    }
//}

using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Api.Models
{
    public class Exam
    {
        public int Id { get; set; }

        public string? ExamName { get; set; }
        public string? Subject { get; set; }
        public string? ClassName { get; set; }
        public string? AcademicSession { get; set; }

        public DateTime ExamDate { get; set; }
        public int TotalMarks { get; set; }
    }
}


