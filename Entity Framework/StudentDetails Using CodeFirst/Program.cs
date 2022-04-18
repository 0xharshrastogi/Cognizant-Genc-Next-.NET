using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = new Student();

            Console.WriteLine("Enter Student Id");
            s.StudentID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name");
            s.StudentName = Console.ReadLine();

            Console.WriteLine("Enter Department");
            s.Department = Console.ReadLine();

            Console.WriteLine("Enter Enrollment Date");
            s.EnrolledDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

            Console.WriteLine("Enter PhoneNumber");
            s.PhoneNumber = long.Parse(Console.ReadLine());

            new Program().AddStudent(s);
            Console.WriteLine("Details Added Successfully");
        }

        public void AddStudent(Student student)
        {
            using (var db = new CollegeContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
