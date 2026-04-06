
namespace SchoolManagement.Api.Models

{
    public class Leave
        {
            public int Id { get; set; }
            public int StudentId { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }
            public string Reason { get; set; } = string.Empty;
            public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected

        // public Student Student { get; set; } 
        public Student? Student { get; set; }

    }
}


