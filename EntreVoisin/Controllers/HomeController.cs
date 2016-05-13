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

        [HttpPost]
        public ActionResult Connexion(LoginModelView model)
        {
            if (ModelState.IsValid)
            {
                if (model.email == "0" && model.mdp == "0")
                {
                    Session["TYPE"] = "A";
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    //CLIENT
                    UTILISATEUR u = (from i in db.UTILISATEUR.ToList()
                              where i.EMAIL.Equals(model.email)
                              & i.PASSWORD.Equals(model.mdp)
                              select i).FirstOrDefault();
                    if (u != null)
                    {
                        Session["TYPE_USER"] = "U";
                        Session["USER"] = u;
                        return RedirectToAction("Index", "User");
                    }

                    else
                    {
                        ModelState.AddModelError("", "Utilisateur non Valide, Vérifiez votre mot de passe et Identifiant");
                        return View(model);
                    }
                }
            }
            else
            {
                return View(model);
            }
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
       
    }
}
