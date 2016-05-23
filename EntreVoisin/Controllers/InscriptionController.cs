using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntreVoisin.Controllers
{
    public class InscriptionController : Controller
    {

        string tempLat;
        string tempLng;
        int tempIdCommun;
        //
        // GET: /Inscription/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Etape2(string lat, string lng)
        {
            tempLat = lat;
            tempLng = lng;
            ViewBag.lat = lat;
            ViewBag.lng = lng;
            return View();
        }

        public ActionResult Etape3()
        {
            ViewBag.Lng = tempLng;
            ViewBag.Lat = tempLat;
            return View();
        }

    }
}
