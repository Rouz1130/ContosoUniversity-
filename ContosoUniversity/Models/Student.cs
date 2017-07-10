using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        //StringLength attribute most amount of characters allowed for name 
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50, ErrorMessage ="First name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }
        // DataType attribute used to specify a data type more specific and db intrinsic type.
        // DataType provides various types e.g Date, Time, PhoneNumber, Currency, EmailAddress etc.
        // DataType.Date does not specify date fromat it has a default, That is why we use the DisplayFormat attribute to specify the date format to our liking.
        [DataType(DataType.Date)]                         // Below specifies for value in textbox for editing.
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        // navaigation property: hold other entities that are related to this student entity.
        // for many-to-many or one-to-many relationships the type must be a list like below
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
