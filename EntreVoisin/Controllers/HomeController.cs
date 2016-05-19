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
        public ActionResult Inscription()
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
                        ModelState.AddModelError("", "Utilisateur non valide. Vérifiez votre email et mot de passe");
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
            return RedirectToAction("Index", "Home");
        }

        public ActionResult NousContacter()
        {
            return View();
        }

        public string TellMeDate()
        {
            test(1, 2, "Comment ca va");
            return DateTime.Now.ToString();
        }

        public void test (short UserSend, short UserReceive, string message)
        {
            MESSAGEPRIVE templien = (from i in db.MESSAGEPRIVE
                              where i.IDUSER_1.Equals(UserSend) && i.IDUSER_2.Equals(UserReceive) || i.IDUSER_1.Equals(UserSend) && i.IDUSER_2.Equals(UserReceive)
                              select i).FirstOrDefault();
            if(templien == null)
            {
                MESSAGEPRIVE lien = new MESSAGEPRIVE();
                lien.IDUSER_1 = UserSend;
                lien.IDUSER_2 = UserReceive;
                lien.IDUSER_SEND = UserSend;
                lien.CONTENU = message;
                lien.DATEENVOI = DateTime.Now;
                db.MESSAGEPRIVE.Add(lien);
                db.SaveChanges();
            }
            else
            {
                MESSAGEPRIVE m = new MESSAGEPRIVE();
                m.IDUSER_1 = templien.IDUSER_1;
                m.IDUSER_2 = templien.IDUSER_2;
                m.IDUSER_SEND = UserSend;
                m.CONTENU = message;
                m.DATEENVOI = DateTime.Now;
                db.MESSAGEPRIVE.Add(m);
                db.SaveChanges();
            }
        }
       
    }
}
