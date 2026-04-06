//namespace SchoolManagement.Api.Services
//{
//    public class LeaveService
//    {
//    }
//}




//using SchoolManagement.Api.Models;

//var leave = new Leave
//{
//    TeacherId = dto.TeacherId,
//    Reason = dto.Reason,
//    StartDate = dto.StartDate,
//    EndDate = dto.EndDate,
//    Status = "Pending"
//};


using SchoolManagement.Api.Data;

namespace SchoolManagement.Api.Services
{
    public class LeaveService
    {
        private readonly SchoolDbContext _context;

        public LeaveService(SchoolDbContext context)
        {
            _context = context;
        }
    }
}
