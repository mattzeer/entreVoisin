using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntreVoisin.Models;

namespace EntreVoisin.Controllers
{
    public class ActualiteController : Controller
    {
        //
        // GET: /Actualite/
        entrevoisinEntities db;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddActualite(ActiviteModelView model)
        {
            ACTUS a = new ACTUS();
            a.DESCRIP = model.Description;
            a.TYPEACTUS = model.Type;
            a.DATECREATION = DateTime.Now;
            db.ACTUS.Add(a);
            db.SaveChanges();
            return View();
        }

        public ActionResult showActualite()
        {
            var tenActus = (from m in db.ACTUS
                                orderby m.DATECREATION descending
                               select m).Take(10);
            return View(tenActus);
            //return View(db.ACTUS.Take(10).ToList());
        }

    }
}
