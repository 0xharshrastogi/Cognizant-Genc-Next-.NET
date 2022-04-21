using System.Reflection.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ASP_App1.Controllers
{

    enum CourseType
    {
        JavaCourse = 1, DotNetCourse
    }

    public class Ex2Controller : Controller
    {
        public ActionResult Course(int id) => base.RedirectToAction(((CourseType)id).ToString());

        public ActionResult JavaCourse() => base.View();

        public ActionResult DotNetCourse() => base.View();
    }
}