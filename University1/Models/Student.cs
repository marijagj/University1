using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Student ID")]
        public string StudentId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Acquired Credits")]
        public int AcquiredCredits { get; set; }
        [Display(Name = "Current Semester")]
        public int CurrentSemester { get; set; }
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
        public ICollection<Enrollment> Courses { get; set; }
    }
}
