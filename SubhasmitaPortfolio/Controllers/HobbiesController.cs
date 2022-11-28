using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubhasmitaPortfolio.Controllers
{
    public class HobbiesController : Controller
    {
        // GET: Hobbies
        public ActionResult Hobbies()
        {
           
            string[] hobbies = new string[4] { "cooking", "playing Badminton", "Travelling", "Study" };

            ViewBag.Hobbies = hobbies;

            return View();
        }
    }
}