using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IntroToMVC.Controllers;

namespace IntroToMVC.Models
{
    public class Classmate
    {
        public Classmate(string name, string hairColor, int height)
        {
            Name = name;
            HairColor = hairColor;
            Height = height;
        }

        public Classmate()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string HairColor { get; set; }
        public int Height { get; set; }
    }
}