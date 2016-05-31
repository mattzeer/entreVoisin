﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntreVoisin.Models
{
    public class LoginModelView
    {
        [Required]
        [Display(Name="Email")]
        public string email { get; set; }

        [Required]
        [Display(Name="Mot de passe")]
        public string mdp { get; set; }
    }

    public class InscriptionModelView
    {
        [Required]
        [Display(Name = "Pseudo")]
        public String pseudo { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public String nomInscription { get; set; }

        [Required]
        [Display(Name = "Prenom")]
        public String prenomInscription { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Veuillez entrer une addresse")]
        [Display(Name = "Email")]
        public String mailInscription { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public String motDePasseInscription { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation de Mot de passe")]
        [Compare("motDePasseInscription", ErrorMessage = "Les mot de passe ne correspondent pas.")]
        public String confirmMotDePasseInscription { get; set; }

        [Required]

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Date de naissance")]
        public DateTime ageInscription { get; set; }


    }
    public class CovoiturageActiviteModelView
    {
        [Required]
        public short idUser { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "date")]
        public DateTime dateDep { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "date")]
        public DateTime dateArriv { get; set; }

        [Required]
        public short participation { get; set; }

        [Required]
        public string lieuDep { get; set; }

        [Required]
        public string lieuArriv { get; set; }

        [Required]
        public string vehicule { get; set; }

        [Required]
        public string message { get; set; }


    }
    public class EvenementActiviteModelView
    {
        [Required]
        public short idUser { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "date")]
        public DateTime dateEve { get; set; }

        [Required]
        public string titreEvenement { get; set; }

        [Required]
        public string lieuEvenement { get; set; }

        [Required]
        public string message { get; set; }


    }
    public class ObjetActiviteModelView
    {
        [Required]
        public short idUser { get; set; }

        [Required]
        public string titreObjet { get; set; }

        [Required]
        public short prixObjet { get; set; }

        [Required]
        public string message { get; set; }
        public string cdObjet { get; set; }

        public string cdPropositionObjet { get; set; }


    }

    public class ActusActiviteModelView
    {
        [Required]
        public string message { get; set; }

      
        public string cdTypeActus { get; set; }

        [Required]
        public short idUser { get; set; }
    }
    public class BonPlanActiviteModelView
    {
        [Required]
        public string site { get; set; }
        
        [Required]
        public string message { get; set; }

        [Required]
        public short idUser { get; set; }
    }

    public class ObjetPerduModelView
    {
        [Required]
        public string message { get; set; }

        [Required]
        public string lieu { get; set; }


        [Required]
        public short idUser { get; set; }

    }

    public class ServiceModelView
    {
        [Required]
        public string message { get; set; }

        [Required]
        public short idUser { get; set; }

        public string cdTypeService { get; set; }

        public string cdTypePropositionService { get; set; }

        [Required]
        public string TitreService { get; set; }

        [Required]
        public short PrixService { get; set; }
    }

    public class SondageModelView
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateSondage { get; set; }


        [Required]
        public short idUser { get; set; }

        [Required]
        public string message { get; set; }

    }

}