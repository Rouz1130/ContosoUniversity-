using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // becaue Enrollment is a navagation property , meaning course and student class have a one-to-many relationshiip with enrollment we put the list here and for the student class but we do not have to p;ut the list for the navigation property class which is enrollment class
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
