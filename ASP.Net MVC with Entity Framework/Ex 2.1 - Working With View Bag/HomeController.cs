using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers
{

    public class HomeController : Controller
    {

        string business = "Flipkart";
        string type = "E-commerce";
        int founded = 2007;
        string website = "www.flipkart.com";


        [Route("flipkart/info")]
        public ActionResult About()
        {
            ViewBag.Business = business;
            ViewBag.Type = type;
            ViewBag.Founded = founded;
            ViewBag.Website = website;

            return View();
        }
        // Implement 'About' action with Route 'flipkart/info'
    }
}