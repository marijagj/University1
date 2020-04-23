using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace University1.Models
{
    public class StudentNameIdViewModel
    {
        public IList<Student> Students { get; set; }
        public SelectList IDs { get; set; }
        public string StudentIDs { get; set; }
        public string StudentName { get; set; }
    }
}
