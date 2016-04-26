using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroToMVC.Models;

namespace IntroToMVC.Controllers
{
    public class ClassmatesController : Controller
    {
        // GET: Classmates
        public ActionResult Index()
        {
            List<Classmate> classmates = new List<Classmate>();
            {

                classmates.Add(new Classmate() { Name = "Seth Tettah-Quaye", HairColor = "Black", Height = 70 });
                classmates.Add(new Classmate() { Name = "Zach Ballard", HairColor = "Blonde", Height = 69 });
                classmates.Add(new Classmate() { Name = "Brian Stickney", HairColor = "Black", Height = 67 });
                classmates.Add(new Classmate() { Name = "Kate Ramsey", HairColor = "Brown", Height = 66 });
                classmates.Add(new Classmate() { Name = "Kevin Mach", HairColor = "Black", Height = 67 });
                classmates.Add(new Classmate() { Name = "Trey Holmes", HairColor = "Black", Height = 66 });
            }

            return View(classmates);
        }
    }
}