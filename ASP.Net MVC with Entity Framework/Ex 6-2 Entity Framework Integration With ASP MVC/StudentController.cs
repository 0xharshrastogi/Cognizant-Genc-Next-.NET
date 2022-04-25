using ASP_EF_App1.DAL;
using ASP_EF_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_EF_App1.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Placement()
        {
            /**  DO NOT REMOVE THE BELOW 2 LINES **/
            StudentDAO sd = new StudentDAO();
            sd.AddPlacements();
            /**   END OF 2 LINES  **/

            using (var context = new CollegeContext())
            {
                var placements = context.Placements.OrderBy(p => p.PlacementId).ToList();
                return View(placements);
            }
        }
    }
}