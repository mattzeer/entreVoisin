using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntreVoisin.Models;

namespace EntreVoisin.Controllers
{
    public class UserController : Controller
    {
        entrevoisinEntities db;
        public UserController()
        {
            db = new entrevoisinEntities();
        }
        //
        // GET: /User/

        public ActionResult Index()
        {
            ViewData.Model = db.ACTIVITE.ToList();
            return View();
            
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Actus(short id)
        {
            ACTUS a = db.ACTUS.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ViewData.Model = a;
            return View();
        }
    }
}
