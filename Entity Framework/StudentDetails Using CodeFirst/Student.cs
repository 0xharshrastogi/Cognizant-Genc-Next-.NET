using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string Department { get; set; }
        public long PhoneNumber { get; set; }
    }
}
