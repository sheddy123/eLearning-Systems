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
    
    public partial class TestXQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestXQuestion()
        {
            this.TestXPapers = new HashSet<TestXPaper>();
        }
    
        public int TestXQuestionId { get; set; }
        public int TestId { get; set; }
        public int QuestNumbers { get; set; }
        public bool IsActive { get; set; }
        public int QuestionId { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual QuestionXDuration QuestionXDuration { get; set; }
        public virtual Test Test { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TestXPaper> TestXPapers { get; set; }
    }
}