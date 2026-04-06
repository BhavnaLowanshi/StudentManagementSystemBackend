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
