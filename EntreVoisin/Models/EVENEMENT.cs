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
    
    public partial class EVENEMENT
    {
        public short IDACTIVITE { get; set; }
        public short IDCOMMUNAUTE { get; set; }
        public string TITRE { get; set; }
        public Nullable<System.DateTime> DATEEVENT { get; set; }
        public string LIEU { get; set; }
        public string DESCRIP { get; set; }
        public Nullable<System.DateTime> DATECREATION { get; set; }
    
        public virtual ACTIVITE ACTIVITE { get; set; }
    }
}
