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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("����� ���������� �������")]
    public partial class PersonaAnxietyScale
    {
        [key]
        public long StudentID { get; set; }

        [Display(Name = "��������")]
        public string School { get; set; }
        [Display(Name = "�������������")]
        public string Interpersonal { get; set; }
        [Display(Name = "�������������")]
        public string Self_assessment { get; set; }
        [Display(Name = "�����")]
        public string General { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
