using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubhasmitaPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Experience()
        {
            ViewBag.Experience = "I have knowledge of .Net MVC and SQL Server and i have worked on Employee Management Project on client side";

            return View();
        }
    }
}