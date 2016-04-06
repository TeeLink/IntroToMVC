using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToMVC.Models;

namespace IntroToMVC.Controllers
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

        public ActionResult Classmates()
        {
            List<Classmate> classmates = new List<Classmate>();
            {
                new Classmate("Seth", "Black", 5.10);
                new Classmate("Zach", "Blonde", 5.9);
                new Classmate("Brian", "Black", 5.7);
                new Classmate("Kate", "Brown", 5.6);
                new Classmate("Kevin", "Black", 5.7);
                new Classmate("Trey", "Black", 5.6);
            }
            return View();

        }
    }
}