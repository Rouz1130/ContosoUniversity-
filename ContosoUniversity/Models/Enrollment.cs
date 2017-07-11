using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }



    public class Enrollment
    {
       // primary key , also we can simply use ID but for this example we used EnrollmentID unlike the student class file were we used Id both work this is for illustrative purpose.
       // Although note that using ID without the name makes it easier to implement inheritance.
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        
        // the foreign key from the student class.
        // Beacuse enrollment is associated with one student this object class(enrollment) can hold a single student vs in the student class were we have list and therfore we can hold multiple enrollments. Same goes for the CourseId in this class.
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText ="No grade")]

        // Grade property is an enum declared at the top. ? declares the Grade property as nullable. Meaning the Grade has not been assigned as of yet. 
        // If we dont put the ? mark the grade would not be nullabe and be assigned a value of 0 which we do not want.
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
