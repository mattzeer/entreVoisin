using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntreVoisin.Models;

namespace EntreVoisin.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        entrevoisinEntities db;

        public AdminController ()
        {
            db = new entrevoisinEntities();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Types()
        {
            ViewData.Model = db;
            return View();
        }

    }
}
