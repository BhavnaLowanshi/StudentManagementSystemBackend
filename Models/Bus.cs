using System.ComponentModel.DataAnnotations;

//namespace SchoolManagement.Api.Models
//{
//    public class Bus
//    {
//    }
//}




namespace SchoolManagement.Api.Models
{
    public class Bus
    {
        public int Id { get; set; }

        public string? BusNumber { get; set; }
        public string? DriverName { get; set; }
        public string? DriverContact { get; set; }
        public string? Route { get; set; }

        public int Capacity { get; set; }
        public bool IsActive { get; set; }
    }
}


