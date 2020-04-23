using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class CourseSemesterProgrammeViewModel
    {
        public IList<Course> Courses { get; set; }
        public SelectList Programmes { get; set; }
        public SelectList Semesters { get; set; }
        public string CourseProgramme { get; set; }
        public string CourseSemester { get; set; }
        public string SearchString { get; set; }
        
    }
}
