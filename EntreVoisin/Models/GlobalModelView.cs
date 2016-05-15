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
        [Display(Name = "Addresse")]
        public String addresseInscription { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mot de passe")]
        public String motDePasseInscription { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmation de Mot de passe")]
        [Compare("motDePasseInscription", ErrorMessage = "Les mot de passe ne correspondent pas !")]
        public String confirmMotDePasseInscription { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date de naissance")]
        public DateTime ageInscription { get; set; }

        [Required]
        [Display(Name = "Enregistrer votre mail")]
        public String engEmail { get; set; }

    }
}