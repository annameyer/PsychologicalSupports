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
    
    public partial class Intellectual_8_Class
    {
        public long StudentID { get; set; }
        public string InterestMap { get; set; }
        public string RecommendedProfile { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
