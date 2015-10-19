using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrasdalGlass.Controllers
{
    public class VinduController : Controller
    {
        public ActionResult Energispareglass()
        {
            return View();
        }

        public ActionResult Selvrensende_glass()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Sikkerhetsglass_sikringsglass()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Solbeskyttende_glass()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Støydempende_glass()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}