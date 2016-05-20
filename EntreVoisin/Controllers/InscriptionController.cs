using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntreVoisin.Controllers
{
    public class InscriptionController : Controller
    {
        //
        // GET: /Inscription/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Etape2(string lat, string lng)
        {
            ViewBag.lat = lat;
            ViewBag.lng = lng;
            return View();
        }

        public ActionResult Etape3()
        {
            return View();
        }

    }
}
