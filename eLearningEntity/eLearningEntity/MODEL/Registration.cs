//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eLearningEntity.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Registration()
        {
            this.Instructors = new HashSet<Instructor>();
            this.QuestionXDurations = new HashSet<QuestionXDuration>();
            this.TestXPapers = new HashSet<TestXPaper>();
        }
    
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int InstructorId { get; set; }
        public int TestId { get; set; }
        public System.DateTime RegistrationDate { get; set; }
        public System.Guid Token { get; set; }
        public System.DateTime ExpireTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instructor> Instructors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionXDuration> QuestionXDurations { get; set; }
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestXPaper> TestXPapers { get; set; }
    }
}
