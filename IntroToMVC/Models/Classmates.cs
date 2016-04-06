using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntroToMVC.Controllers;

namespace IntroToMVC.Models
{
    public class Classmate : HomeController
    {
        public Classmate(string name, string hairColor, double height)
        {
            Name = name;
            HairColor = hairColor;
            Height = height;
        }
        //public int Id { get; set; }
        public string Name { get; set; }
        public string HairColor { get; set; }
        public double Height { get; set; }
    }
}