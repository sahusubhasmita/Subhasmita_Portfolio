using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubhasmitaPortfolio.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        public ActionResult Skills()
        {
            ViewBag.ClentSideSkill = "React JS";

            ViewBag.ServerSideSkill = "Node JS";

            ViewBag.DataBaseSideSkill = "MongoDB and SQL";

            return View();
        }
    }
}