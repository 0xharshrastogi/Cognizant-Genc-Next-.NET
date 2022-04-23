using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_App1.Controllers
{
    public class Ex3Controller : Controller
    {
        private Course CreateJavaCourse() => new Course { CourseId = "C101", CourseName = "Java", Duration = 40, Level = "Beginner" };

        private Department CreateFakeDept() => new Department() { CourseList = new List<string>() { "Java", "DotNet", "Python", "Ruby" } };

        public ActionResult Index()
        {
            return base.RedirectToAction(nameof(CourseDescription), this.CreateJavaCourse());
        }

        public ActionResult IndexChoice(int id)
        {
            if (id == 1)
            {
                return base.RedirectToAction(nameof(CourseDescription), this.CreateJavaCourse());
            }
            else if (id == 2)
            {
                return base.RedirectToAction(nameof(CourseList), this.CreateFakeDept());
            }
            return null;
        }

        public ActionResult CourseDescription(Course course)
        {
            return View(course);
        }

        public ActionResult CourseList(Department department)
        {
            return View(department);
        }
    }
}