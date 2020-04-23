using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public Student Student { get; set; }
        public int? CourseId { get; set; }
        public Course Course { get; set; }
        [StringLength(10)]
        public string Semester { get; set; }
        public int Year { get; set; }
        [Range(1, 10)]
        public int Grade { get; set; }
        [Display(Name = "Seminal Url")]
        [StringLength(255)]
        public string SeminalUrl { get; set; }
        [Display(Name = "Project Url")]
        [StringLength(255)]
        public string ProjectUrl { get; set; }
        [Display(Name = "Exam Points")]
        [Range(0, 100)]
        public int ExamPoints { get; set; }
        [Display(Name = "Seminal Points")]
        [Range(0, 100)]
        public int SeminalPoints { get; set; }
        [Display(Name = "Project Points")]
        [Range(0, 100)]
        public int ProjectPoints { get; set; }
        [Display(Name = "Additional Points")]
        [Range(0, 10)]
        public int AdditionalPoints { get; set; }
        [DataType(DataType.Date)]
        public DateTime FinishDate { get; set; }
    }
}
