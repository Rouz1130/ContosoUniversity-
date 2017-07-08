using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // navaigation property: hold other entities that are related to this student entity.
        // for many-to-many or one-to-many relationships the type must be a list like below
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
