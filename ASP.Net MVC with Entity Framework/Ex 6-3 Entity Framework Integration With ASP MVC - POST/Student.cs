//THIS IS FOR REFERENCE ONLY. YOU ARE NOT REQUIRED TO MAKE ANY CHANGES HERE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_EF_App1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public String StudentName { get; set; }
        public DateTime EnrolledDate { get; set; }
        public String Department { get; set; }
        public long PhoneNumber { get; set; }
    }
}