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
    
    public partial class USEROBJET
    {
        public short NOOBJET { get; set; }
        public short IDUSER { get; set; }
        public string CDOBJET { get; set; }
        public Nullable<bool> CONFIDENTIEL { get; set; }
        public string NOM { get; set; }
    
        public virtual TYPEOBJET TYPEOBJET { get; set; }
        public virtual UTILISATEUR UTILISATEUR { get; set; }
    }
}
