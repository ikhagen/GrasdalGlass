using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrasdalGlass.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Annet()
        {
            ViewBag.Message = "Your annet glass page";

            return View();
        }

        public ActionResult Nybygg()
        {
            ViewBag.Message = "Your nybygg page.";

            return View();
        }

        public ActionResult Proff()
        {
            ViewBag.Message = "Your proff page.";

            return View();
        }

        public ActionResult Reparasjoner()
        {
            ViewBag.Message = "Your reparasjoner page.";

            return View();
        }

        public ActionResult Vindu()
        {
            ViewBag.Message = "Your vindu page.";

            return View();
        }
    }
}