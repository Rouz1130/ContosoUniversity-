using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        //StringLength attribute most amount of characters allowed for name 
        [StringLength(50)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="First name cannot be longer than 50 characters.")]
        // Column attribute specifes that when DB is created the column of student table maps to the firstmidname property will be named FirstName. Beacuse DB queries will be by name if we allow midname it will get messy.
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        // DataType attribute used to specify a data type more specific and db intrinsic type.
        // DataType provides various types e.g Date, Time, PhoneNumber, Currency, EmailAddress etc.
        // DataType.Date does not specify date fromat it has a default, That is why we use the DisplayFormat attribute to specify the date format to our liking.
        [DataType(DataType.Date)]                         // Below specifies for value in textbox for editing.
        [DisplayFormat(DataFormatString ="{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        // Required attribute makes the name properties required fields. The Required attribute is not needed for non-nullable types such as value types (DateTime, int, double, float, etc.


        // navaigation property: hold other entities that are related to this student entity.
        // for many-to-many or one-to-many relationships the type must be a list like below
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
