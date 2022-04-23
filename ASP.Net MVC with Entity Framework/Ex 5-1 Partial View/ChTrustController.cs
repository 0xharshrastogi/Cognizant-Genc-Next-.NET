using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers
{
    public class ChTrustController : Controller
    {
        public ActionResult ChTrust() => View();

        public PartialViewResult _HeaderNavBar() => PartialView(nameof(_HeaderNavBar));

        public PartialViewResult _FooterNavBar() => PartialView(nameof(_FooterNavBar));
    }
}