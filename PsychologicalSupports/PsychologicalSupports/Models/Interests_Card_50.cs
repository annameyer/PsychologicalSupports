//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PsychologicalSupports.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interests_Card_50
    {
        public long StudentID { get; set; }
        public short PhysicsMathematics { get; set; }
        public short ChemistryBiology { get; set; }
        public short RadioEngineeringElectronics { get; set; }
        public short MechanicsDesign { get; set; }
        public short GeographyGeology { get; set; }
        public short LiteratureArt { get; set; }
        public short HistoryPolitics { get; set; }
        public short PedagogyMedicine { get; set; }
        public short EntrepreneurshiHomeEconomics { get; set; }
        public short SportsMilitary { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
