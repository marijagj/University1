using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Degree { get; set; }
        [Display(Name = "Academic Rank")]
        [StringLength(25)]
        public string AcademicRank { get; set; }
        [Display(Name = "Office Number")]
        [StringLength(10)]
        public string OfficeNumber { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }
        [NotMapped]
        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }
        [Display(Name = "Courses as First Teacher")]
        public ICollection<Course> FTCourses { get; set; }
        [Display(Name = "Courses as Second Teacher")]
        public ICollection<Course> STCourses { get; set; }
    }
}
