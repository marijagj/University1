using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class TeacherNameDegreeViewModel
    {
        public IList<Teacher> Teachers { get; set; }
        public SelectList Degrees { get; set; }
        public SelectList Ranks { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDegree { get; set; }
        public string TeacherRank { get; set; }

    }
}
