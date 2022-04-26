using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult Course() => View(new Course());

        [HttpPost]
        public ActionResult Course(Course course) => View(course);
    }
}