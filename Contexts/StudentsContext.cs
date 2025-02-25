using Microsoft.EntityFrameworkCore;
using StudentMenegment.Course;
using StudentMenegment.Entities;
using StudentMenegment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenegment.Contexts
{
 public class StudentsContext : DbContext
    {
        public DbSet<StudentMenegment.Entities.Student> Students { get; set; }
        ///public DbSet<StudentMenegment.Entities.  > Courses { get; set; }
        public StudentsContext() { 
        Database.EnsureCreated ();
                }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=5432;Database=students_management;User Id=postgres;Password=hulkarbonu2005;";

            optionsBuilder.UseNpgsql(connectionString);
        }
        //public DbSet<StudentMenegment.Entities.> courses { get; set; }
        //public kurslar ()
        //{
        //    Database.EnsureCreated();
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionString = "Server=localhost;Port=5432;Database=students_management;User Id=postgres;Password=hulkarbonu2005;";

        //    optionsBuilder.UseNpgsql(connectionString);
        //}
    }
}
