//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIB_BASE
{
    using System;
    using System.Collections.Generic;
    
    public partial class C_GUITARE
    {
        public int ID_GUITARE { get; set; }
        public Nullable<int> IdClient { get; set; }
        public Nullable<int> IdVibrato { get; set; }
        public Nullable<int> IdBois_Corps { get; set; }
        public Nullable<int> IdBois_Manche { get; set; }
        public Nullable<int> IdBois_Touche { get; set; }
        public Nullable<int> IdMicro_Neck { get; set; }
        public Nullable<int> IdMicro_Central { get; set; }
        public Nullable<int> IdMicro_Bridge { get; set; }
    
        public virtual C_BOIS Le_Bois_Corps { get; set; }
        public virtual C_BOIS Le_Bois_Manche { get; set; }
        public virtual C_BOIS Le_Bois_Touche { get; set; }
        public virtual C_CLIENT Le_Proprietaire { get; set; }
        public virtual C_MICRO Le_Micro_Neck { get; set; }
        public virtual C_MICRO Le_Micro_Central { get; set; }
        public virtual C_MICRO Le_Micro_Bridge { get; set; }
        public virtual C_VIBRATO Le_Vibrato { get; set; }
    }
}
