﻿using System;
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

        public ActionResult Index(string type)
        {
            UTILISATEUR u = (UTILISATEUR)Session["USER"];
            short s = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
            if(type == null || type == "")
            {
                ViewData.Model = db.ACTIVITE.Where(a => a.IDCOMMUNAUTE.Equals(s)).OrderByDescending(a=> a.DATECREATION).ToList();
            }
            else
            {
                ViewData.Model = db.ACTIVITE.Where(a => a.TYPEACTIVITE.Equals(type) && a.IDCOMMUNAUTE.Equals(s)).OrderByDescending(a=> a.DATECREATION).ToList();
                
            }
            ViewBag.TypeServices = db.TYPESERVICE.ToList();
            ViewBag.TypeObjets = db.TYPEOBJET.ToList();
            ViewBag.TypePropoServices = db.TYPEPROPOSITIONSERVICE.ToList();
            ViewBag.TypePropoObjets = db.TYPEPROPOSITIONOBJET.ToList();
            ViewBag.TypeActus = db.TYPEACTUS.ToList();
            return View();
            
        }

        public ActionResult Message()
        {
            return View();
        }

        public ActionResult Actus(short id)
        {
            ACTUS a = db.ACTUS.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;

            ViewBag.Actus = a;
            ViewBag.Activity = ac;

            return View();
        }

        public ActionResult BonPlan(short id)
        {
            BONPLAN a = db.BONPLAN.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

        public ActionResult Covoiturage(short id)
        {
            COVOITURAGE a = db.COVOITURAGE.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

        public ActionResult Service(short id)
        {
            SERVICE a = db.SERVICE.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

        public ActionResult Objet(short id)
        {
            OBJET a = db.OBJET.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

        public ActionResult ObjetPerdu(short id)
        {
            OBJETPERDU a = db.OBJETPERDU.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

        public ActionResult Event(short id)
        {
            EVENEMENT a = db.EVENEMENT.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

        public ActionResult Sondage(short id)
        {
            SONDAGE a = db.SONDAGE.Where(m => m.IDACTIVITE.Equals(id)).FirstOrDefault();
            ACTIVITE ac = a.ACTIVITE;
            ViewData.Model = a;
            ViewBag.Activity = ac;
            return View();
        }

    }
}
