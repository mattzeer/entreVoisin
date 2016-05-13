using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntreVoisin.Models;


namespace EntreVoisin.Controllers
{
    public class HomeController : Controller
    {
        entrevoisinEntities db;
        public HomeController()
        {
            db = new entrevoisinEntities();
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Connexion()
        {
            return View();
        }

        public ActionResult Deconnexion()
        {
            Session["TYPE_USER"] = null;
            return View();
        }

        public ActionResult NousContacter()
        {
            return View();
        }

        public string TellMeDate()
        {
            return DateTime.Now.ToString();
        }

        [HttpPost]
        public JsonResult ValidateUser(string mail, string password)
        {
            var data = from c in db.UTILISATEUR where c.EMAIL == mail && c.PASSWORD == password select c;
            if (data.Count() > 0)
                return Json(new { Success = true }, JsonRequestBehavior.AllowGet);
            else
                return Json(new { Success = false }, JsonRequestBehavior.AllowGet);
        }
    }
}
