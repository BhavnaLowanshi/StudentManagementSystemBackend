//namespace SchoolManagement.Api.DTOs
//{
//    public class ApplyLeaveDto
//    {
//    }
//}





namespace SchoolManagement.Api.DTOs
{
    public class ApplyLeaveDto
    {
        public int TeacherId { get; set; }
        //public string Reason { get; set; }

        public string Reason { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        
    }
}
