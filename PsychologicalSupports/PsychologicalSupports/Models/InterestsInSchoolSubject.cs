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
    
    public partial class InterestsInSchoolSubject
    {
        public long StudentID { get; set; }
        public short Russian { get; set; }
        public short Belorussian { get; set; }
        public short Physics { get; set; }
        public short Story { get; set; }
        public short SocialScientist { get; set; }
        public short Biology { get; set; }
        public short Chemistry { get; set; }
        public short ComputerScience { get; set; }
        public short English { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
