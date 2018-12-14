using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESDD.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            esdd_layer.tesst tesst = new esdd_layer.tesst();
            return View();
        }
        public ActionResult Intent()
        {
            return View();
        }

        public ActionResult Management()
        {
            return View();
        }
        public ActionResult We()
        {
            return View();
        }

        public ActionResult Media()
        {
            return View();
        }
        public ActionResult Activity()
        {
            return View();
        }
        public ActionResult Announcement()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Prodes()
        {
            return View();
        }
        public ActionResult Gsb()
        {
            return View();
        }
        public ActionResult Ab()
        {
            return View();
        }
    }
}