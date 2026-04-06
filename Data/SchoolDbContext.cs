//namespace SchoolManagement.Api.Data
//{
//    public class SchoolDbContext
//    {
//    }
//}


//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Models;
//using System.Collections.Generic;

//public class SchoolDbContext : DbContext
//{
//    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
//        : base(options) { }

//    public DbSet<TeacherLeave> TeacherLeaves { get; set; }
//    public DbSet<Notice> Notices { get; set; }
//    public DbSet<User> Users { get; set; }
//}


//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Models;





//namespace SchoolManagement.Api.Data
//{
//    public class SchoolDbContext : DbContext
//    {
//        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
//            : base(options)
//        {
//        }

//        // public DbSet<Leave> Leaves { get; set; }
//        public DbSet<Leave> Leaves { get; set; }

//    }
//}


//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Models;

//namespace SchoolManagement.Api.Data
//{
//    public class SchoolDbContext : DbContext
//    {
//        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
//            : base(options)
//        {
//        }

//        public DbSet<Leave> Leaves { get; set; }
//    }
//}




//using Microsoft.EntityFrameworkCore;
//namespace SchoolManagement.Api.Data
//{
//    public class SchoolDbContext : DbContext
//    {
//        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
//            : base(options)
//        {
//        }


//        public DbSet<TeacherLeave> TeacherLeaves { get; set; }

//        public DbSet<Student> Students { get; set; }

//       // public DbSet<Teacher> Teachers { get; set; }

//        public DbSet<User> Users { get; set; }

//        public DbSet<Leave> Leaves { get; set; }
//    }
//}




//using Microsoft.EntityFrameworkCore;

//public class SchoolDbContext : DbContext
//{
//    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

//    public DbSet<Leave> Leaves { get; set; } // table name
//}




//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Models;
//using SchoolManagement.Api.Models;
//using SchoolManagement.Api.Models.SchoolManagement.Api.Models;

//namespace SchoolManagement.Api.Data
//{
//    public class SchoolDbContext : DbContext
//    {
//        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

//        public DbSet<Student> Students { get; set; }
//        public DbSet<Teacher> Teachers { get; set; }
//        public DbSet<Admin> Admins { get; set; }
//        public DbSet<User> Users { get; set; }
//        public DbSet<Notice> Notices { get; set; }
//        public DbSet<Attendance> Attendances { get; set; }
//        public DbSet<Timetable> Timetables { get; set; }
//        public DbSet<Leave> Leaves { get; set; }
//        public DbSet<TeacherLeave> TeacherLeaves { get; set; }
//    }
//}



using Microsoft.EntityFrameworkCore;
using SchoolManagement.Api.Models;


namespace SchoolManagement.Api.Data
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }          // Ensure Admin model exists
        //public DbSet<User> Users { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Timetable> Timetables { get; set; }
        public DbSet<Leave> Leaves { get; set; }          // Ensure Leave model exists
        public DbSet<TeacherLeave> TeacherLeaves { get; set; }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Result> Results { get; set; }



    }
}
