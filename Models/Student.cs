//namespace SchoolManagement.Api.Models
//{
////    public class Student
namespace SchoolManagement.Api.Models
{

    //{
    //    public class Student
    //    {
    //        public int Id { get; set; }   // 👈 PRIMARY KEY (must)

    //        public string Name { get; set; } = string.Empty;
    //        public int Age { get; set; }
    //        public string Class { get; set; } = string.Empty;
    //    }
    //}


    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Course { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}

