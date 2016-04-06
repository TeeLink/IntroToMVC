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
                //new Classmate() {Name = "Seth", HairColor = "Black", Height = 5.10};
                //new Classmate() {Name = "Zach", HairColor = "Blonde", Height = 5.9};
                //new Classmate() {Name = "Brian", HairColor = "Black", Height = 5.7};
                //new Classmate() {Name = "Kate", HairColor = "Brown", Height = 5.6};
                //new Classmate() {Name = "Kevin", HairColor = "Black", Height = 5.7};
                //new Classmate() {Name = "Trey", HairColor = "Black", Height = 5.6};
                new Classmate("Seth", "Black", 5.10);
                new Classmate("Zach", "Blonde", 5.9);
                new Classmate("Brian", "Black", 5.7);
                new Classmate("Kate", "Brown", 5.6);
                new Classmate("Kevin", "Black", 5.7);
                new Classmate("Trey", "Black", 5.6);
            }
            ;

            return View();

        }
    }
}