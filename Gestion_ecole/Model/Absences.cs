//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_ecole.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Absences
    {
        public int idAbsence { get; set; }
        public int idEleve { get; set; }
        public int idCours { get; set; }
        public System.DateTime DateAbsence { get; set; }
        public string Justifie { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Eleves Eleves { get; set; }
    }
}