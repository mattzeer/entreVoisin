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
    
    public partial class COVOITURAGE
    {
        public short IDACTIVITE { get; set; }
        public short IDCOMMUNAUTE { get; set; }
        public string LIEUDEPART { get; set; }
        public Nullable<System.DateTime> DATEDEPART { get; set; }
        public string LIEUARRIVE { get; set; }
        public Nullable<System.DateTime> DATEARRIVE { get; set; }
        public string VEHICULE { get; set; }
        public Nullable<short> PARTICIPATION { get; set; }
    
        public virtual ACTIVITE ACTIVITE { get; set; }
    }
}
