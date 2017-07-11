using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {

        // Key attribute 
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name="Office Location")]
        public string Location { get; set; }


        // both Insturctor and officeAssinment entities aer nullable because instructor might not have office space
        // and therfore cannot exist without and instructor or officeassingment
        public Instructor Instructor { get; set; }
    }
}
