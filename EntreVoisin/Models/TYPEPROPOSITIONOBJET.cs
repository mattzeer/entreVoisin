//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntreVoisin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TYPEPROPOSITIONOBJET
    {
        public TYPEPROPOSITIONOBJET()
        {
            this.OBJET = new HashSet<OBJET>();
        }
    
        public string CDPROPOSITIONOBJET { get; set; }
        public string LIBELLE { get; set; }
    
        public virtual ICollection<OBJET> OBJET { get; set; }
    }
}
