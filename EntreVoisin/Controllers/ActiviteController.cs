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
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
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
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
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

        [HttpPost]
        public ActionResult AddObjetPerdu(ObjetPerduModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "OBJETPERDU";
                a.DATECREATION = DateTime.Now;
                a.OBJETPERDU = new OBJETPERDU();
                a.OBJETPERDU.LIEU = model.lieu;
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
        public ActionResult AddService(ServiceModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            TYPESERVICE ts = db.TYPESERVICE.Where(m => m.LIBELLESERVICE.Equals("type")).FirstOrDefault();
            TYPEPROPOSITIONSERVICE tps = db.TYPEPROPOSITIONSERVICE.Where(m => m.LIBELLE.Equals("type")).FirstOrDefault();
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "SERVICE";
                a.DATECREATION = DateTime.Now;
                a.SERVICE = new SERVICE();
                a.SERVICE.CDPROPOSITIONSERVICE = ts.CDSERVICE;
                a.SERVICE.CDSERVICE = tps.CDPROPOSITIONSERVICE;
                a.SERVICE.TITRE = model.TitreService;
                a.SERVICE.PRIX = model.PrixService;
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
        public ActionResult AddObjet(ObjetActiviteModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            TYPEOBJET to = db.TYPEOBJET.Where(m => m.LIBELLEOBJET.Equals("meuble")).FirstOrDefault(); // à revoir
            TYPEPROPOSITIONOBJET tpo = db.TYPEPROPOSITIONOBJET.Where(m => m.LIBELLE.Equals("jesaispas")).FirstOrDefault(); // à revoir
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "OBJET";
                a.DATECREATION = DateTime.Now;
                a.OBJET = new OBJET();
                a.OBJET.CDOBJET = to.CDOBJET;
                a.OBJET.CDPROPOSITIONOBJET = tpo.CDPROPOSITIONOBJET;
                a.OBJET.TITRE = model.titreObjet;
                a.OBJET.PRIX = model.prixObjet;
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
        public ActionResult AddCovoiturage(CovoiturageActiviteModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "COVOIT";
                a.DATECREATION = DateTime.Now;
                a.COVOITURAGE = new COVOITURAGE();
                a.COVOITURAGE.DATEDEPART = model.dateDep;
                a.COVOITURAGE.DATEARRIVE = model.dateArriv;
                a.COVOITURAGE.LIEUARRIVE = model.lieuArriv;
                a.COVOITURAGE.LIEUDEPART = model.lieuDep;
                a.COVOITURAGE.PARTICIPATION = model.participation;
                a.COVOITURAGE.VEHICULE = model.vehicule;
                db.ACTIVITE.Add(a);
                db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("Index", "User", model);
            }
        }
        public ActionResult AddEvenement(EvenementActiviteModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "EVENT";
                a.DATECREATION = DateTime.Now;
                a.EVENEMENT = new EVENEMENT();
                a.EVENEMENT.DATEEVENT = model.dateEve;
                a.EVENEMENT.TITRE = model.titreEvenement;
                a.EVENEMENT.LIEU = model.lieuEvenement;

                db.ACTIVITE.Add(a);
                db.SaveChanges();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("Index", "User", model);
            }
        }

        [HttpPost]
        public ActionResult AddSondage(SondageModelView model)
        {
            UTILISATEUR u = db.UTILISATEUR.Where(m => m.IDUSER.Equals(model.idUser)).FirstOrDefault();
            if (ModelState.IsValid)
            {
                ACTIVITE a = new ACTIVITE();
                a.IDUSER = u.IDUSER;
                a.IDCOMMUNAUTE = u.COMMUNAUTE1.FirstOrDefault().IDCOMMUNAUTE;
                a.DESCRIP = model.message;
                a.TYPEACTIVITE = "SONDAGE";
                a.DATECREATION = DateTime.Now;
                a.SONDAGE = new SONDAGE();
                a.SONDAGE.DATEFIN = model.DateSondage;
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
        public ActionResult AddComment(string type, short idActivite, string message, short idUser)
        {
            COMMENTAIREACTIVITE comment = new COMMENTAIREACTIVITE();
            comment.UTILISATEUR = db.UTILISATEUR.Where(m => m.IDUSER.Equals(idUser)).FirstOrDefault();
            comment.ACTIVITE = db.ACTIVITE.Where(m => m.IDACTIVITE.Equals(idActivite)).FirstOrDefault();
            comment.DATEENVOIE = DateTime.Now;
            comment.CONTENU = message;
            db.COMMENTAIREACTIVITE.Add(comment);
            db.SaveChanges();

            switch (type)
            {
                case "SERVICE" :
                    return RedirectToAction("Service", "User", new { id = idActivite });
                case "SONDAGE":
                    return RedirectToAction("Sondage", "User", new { id = idActivite });
                    
                case "BONPLAN":
                    return RedirectToAction("BonPlan", "User", new { id = idActivite });
                    
                case "OBJET":
                    return RedirectToAction("Objet", "User", new { id = idActivite });
                    
                case "OBJETPERDU":
                    return RedirectToAction("ObjetPerdu", "User", new { id = idActivite });
                    
                case "ACTUS":
                    return RedirectToAction("Actus", "User", new { id = idActivite });
                case "EVENT":
                    return RedirectToAction("event", "User", new { id = idActivite });
                    
                case "COVOIT":
                    return RedirectToAction("Covoiturage", "User", new { id = idActivite });

                default: return View();//TODO ERROR;     
                   
            }
        }
    }
}
