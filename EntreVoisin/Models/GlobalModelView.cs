using System;
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
}