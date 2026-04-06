
namespace SchoolManagement.Api.Models

{
    public class Notice
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true; // ✅ ADD THIS

        public DateTime CreatedDate { get; set; }
    }
}
