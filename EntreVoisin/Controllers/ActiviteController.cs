using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntreVoisin.Models;

namespace EntreVoisin.Controllers
{
    
    public class ActiviteController : Controller
    {
        entrevoisinEntities db;
        public ActiviteController()
        {
            db = new entrevoisinEntities();
        }


        [HttpPost]
        public ActionResult AddActus(ActusActiviteModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            if(ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "ACTUS";
                a.DATECREATION = DateTime.Now;
                a.ACTUS = new ACTUS();
                a.ACTUS.CDTYPEACTUS = "BAS";
                db.ACTIVITE.Add(a);
                db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult AddBonPlan(BonPlanActiviteModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "BONPLAN";
                a.DATECREATION = DateTime.Now;
                a.BONPLAN = new BONPLAN();
                a.BONPLAN.SITE = model.site;
                db.ACTIVITE.Add(a);
                db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View();
            }
        }

    }
}
