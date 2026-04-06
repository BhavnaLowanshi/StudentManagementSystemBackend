namespace SchoolManagement.Api.DTOs
{
    public class NoticeDto
    {
        public string Title { get; set; }= string.Empty;
        public string Description { get; set; }= string.Empty;
        public DateTime NoticeDate { get; set; } = DateTime.Now;
    }
}





