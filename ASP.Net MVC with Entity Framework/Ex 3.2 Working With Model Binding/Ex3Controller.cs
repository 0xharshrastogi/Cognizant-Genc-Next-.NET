using ASP_App1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_App1.Controllers
{
    public class Ex3Controller : Controller
    {
        List<ShoppingCart> carts = new List<ShoppingCart>()
        {
            new ShoppingCart("CA1","Shoe", 3000,"Sport"),
            new ShoppingCart("CA2", "Shirt", 1500, "Men's Wear"),
            new ShoppingCart("CA3","Watch", 4000,"Accessories"),
            new ShoppingCart("CA4","Samsung",15000,"Mobiles")
        };

        public ActionResult Cart(int id) => View(nameof(Cart), carts[id - 1]);

        [HttpPost]
        public ActionResult Cart([Bind] ShoppingCart cart) => View(nameof(Cart), cart);
    }
}