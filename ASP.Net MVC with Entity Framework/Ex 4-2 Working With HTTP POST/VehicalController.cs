using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers                      //DO NOT change the namespace name
{
    public class VehicleController : Controller
    {
        public ActionResult Registration() => View(new Registration());

        [HttpPost]
        public ActionResult Registration(Registration r)
        {
            ViewBag.CustomerName = r.CustomerName;
            ViewBag.VehicleNo = r.VehicleNo;
            ViewBag.PhoneNumber = r.PhoneNumber;
            ViewBag.City = r.City;

            return View("./Confirm");
        }
    }
}