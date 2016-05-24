using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntreVoisin.Models;

namespace EntreVoisin.Controllers
{
    public class InscriptionController : Controller
    {
        entrevoisinEntities db;
        public InscriptionController()
        {
            db = new entrevoisinEntities();
        }
        //
        // GET: /Inscription/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Etape2(string lat, string lng, string street_number, string route, string locality, string postal_code)
        {
            Session["lat"] = lat;
            Session["lng"] = lng;
            Session["street_number"] = street_number;
            Session["route"] = route;
            Session["locality"] = locality;
            Session["postal_code"] = postal_code;
            return View();

        }
        [HttpPost]
        public ActionResult Etape3()
        {
            string address = (string)Session["street_number"] + " , " + (string)Session["route"] + " " + (string)Session["locality"] + " " + (string)Session["postal_code"];
            ViewBag.address = address;
            return View();
        }

        [HttpPost]
        public ActionResult Final(InscriptionModelView model)
        {
            if (ModelState.IsValid)
            {
                CONFIRMATION c = new CONFIRMATION();
                c.CDCONFIRMATION = "NOCONF";
                db.CONFIRMATION.Add(c);
                db.SaveChanges();
                UTILISATEUR u = new UTILISATEUR();
                u.IDCONFIRMATION = c.IDCONFIRMATION;
                u.EMAIL = model.mailInscription;
                u.PSEUDO = model.pseudo;
                u.PASSWORD = model.motDePasseInscription;
                u.NOM = model.nomInscription;
                u.PRENOM = model.prenomInscription;
                u.DATENAISSANCE = model.ageInscription;
                u.COMMUNAUTE.Add(db.COMMUNAUTE.Where(m => m.IDCOMMUNAUTE.Equals(1)).FirstOrDefault());

                u.ADDRESSNO = (string)Session["street_number"];
                u.ADDRESSPOSTALCODE = (string)Session["postal_code"];
                u.ADDRESSROUTE = (string)Session["route"];
                u.ADDRESSLOCALITY = (string)Session["locality"];
                string sLat = (string)Session["lat"];
                Decimal lat = Decimal.Parse(sLat, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                string sLng = (string)Session["lng"];
                Decimal lng = Decimal.Parse(sLng, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
                u.ADDRESSLATITUDE = lat;
                u.ADDRESSLONGITUDE = lng;
                db.UTILISATEUR.Add(u);
                db.SaveChanges();
                return RedirectToAction("Confirm", "Inscription");


            }
            else
            {
                return View(model);
            }

        }

        public ActionResult Confirm()
        {
            return View();
        }
    }
}
