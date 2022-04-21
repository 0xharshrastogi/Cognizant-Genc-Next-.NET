using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers
{
    public class Ex1Controller : Controller
    {
        List<String> breakingNews = new List<String>()
        {
            "PM visit brings business",
            "10% slash in GST",
            "Top Player announced retirement",
            "India wins series"
        };

        public ActionResult NewsByChoice(int id) => base.Content(breakingNews[id - 1]);

        public ActionResult AllNews() => base.Content(string.Join("\n", breakingNews));
    }
}
