using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//main class that coordinates Entity Framework functionality for a given data model is the database context class


namespace ContosoUniversity.Data
{
    public class SchoolContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        // Course, Enrollments, students are entity set(database table) , entity by itself is a row of the table.
        // You could have omitted the DbSet<Enrollment> and DbSet<Course> statements and it would work the same. The Entity Framework would include them implicitly because the Student entity references the Enrollment entity and the Enrollment entity references the Course entity.
        public DbSet<Course> Course { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set;  }
    }
}
