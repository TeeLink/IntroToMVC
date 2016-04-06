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
                classmates.Add(new Classmate() { Name = "Seth Tettah-Quaye", HairColor = "Black", Height = 5.10 });
                classmates.Add (new Classmate() { Name = "Zach Ballard", HairColor = "Blonde", Height = 5.9 });
                classmates.Add(new Classmate() { Name = "Brian Stickney", HairColor = "Black", Height = 5.7 });
                classmates.Add(new Classmate() { Name = "Kate Ramsey", HairColor = "Brown", Height = 5.6 });
                classmates.Add(new Classmate() { Name = "Kevin Mach", HairColor = "Black", Height = 5.7 });
                classmates.Add(new Classmate() { Name = "Trey Holmes", HairColor = "Black", Height = 5.6 });
            }
            
            return View(classmates);

        }
    }
}