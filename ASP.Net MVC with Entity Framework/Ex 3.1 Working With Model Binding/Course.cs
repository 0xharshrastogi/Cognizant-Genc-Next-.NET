// THIS IS FOR REFERENCE ONLY. YOU ARE NOT REQUIRED TO MAKE ANY CHANGES HERE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_App1.Models
{
    public class Course
    {
        public String CourseName { get; set; }
        public String CourseId { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }

    }

    public class Department
    {
        public List<String> CourseList { get; set; }
    }
}