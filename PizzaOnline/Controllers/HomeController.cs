using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaOnline.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult OrderProduct()
        {
            return View();
        }

        public ActionResult Promotion()
        {
            return View();
        }

        public ActionResult Payment()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Chicken()
        {
            return View();
        }
        public ActionResult Spaghetti()
        {
            return View();
        }

        public ActionResult Icecream()
        {
            return View();
        }
        public ActionResult Appetizers() {

            return View();

        }
        
        public ActionResult OneDish()
        {
            return View();
        }

        public ActionResult Billing()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}
