using ASP_EF_App1.DAL;
using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_EF_App1.Controllers   //DO NOT change the namespace name
{
    public class StudentController : Controller     //DO NOT change the class name
    {

        public ActionResult Index()
        {
            var student = new Student
            {
                StudentName = "Johana",
                Department = "Art",
                PhoneNumber = 9876565434,
                EnrolledDate = Convert.ToDateTime("06/25/2018")
            };

            return RedirectToAction(nameof(AddDetail), student);
        }

        public ActionResult AddDetail(Student student)
        {
            using (var context = new CollegeContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }

            return View("ViewDetails", student);
        }

    }
}