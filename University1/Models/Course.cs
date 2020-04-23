using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class Course
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        [Range(1,8)]
        public int Semester { get; set; }
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Programme { get; set; }
        [StringLength(100)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Display(Name = "Education Level")]
        public string EducationLevel { get; set; }
        [Display(Name = "First Teacher")]
        public int? FirstTeacherId { get; set; }
        [Display(Name = "First Teacher")]
        public Teacher FirstTeacher { get; set; }
        [Display(Name = "Second Teacher")]
        public int? SecondTeacherId { get; set; }
        [Display(Name = "Second Teacher")]
        public Teacher SecondTeacher { get; set; }
        [Display(Name = "Listened By")]
        public ICollection<Enrollment> Students { get; set; }
    }
}
