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
    
    public partial class Intellectual_7_Class
    {
        public long Intellectual_7_ClassID { get; set; }
        public long StudentID { get; set; }
        public Nullable<int> IQ { get; set; }
        public string Level { get; set; }
        public Nullable<double> AveragePointСommon { get; set; }
        public Nullable<double> AveragePointMath { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
