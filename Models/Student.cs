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
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

