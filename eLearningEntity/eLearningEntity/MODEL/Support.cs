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
    
    public partial class Support
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Support()
        {
            this.FileDetailds = new HashSet<FileDetaild>();
            this.FileDetailds1 = new HashSet<FileDetaild>();
            this.FileDetais = new HashSet<FileDetai>();
        }
    
        public int SupportId { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int CoursesId { get; set; }
        public Nullable<int> Course_Id { get; set; }
        public Nullable<System.Guid> FileDetail_Id { get; set; }
    
        public virtual Cours Cours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileDetaild> FileDetailds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileDetaild> FileDetailds1 { get; set; }
        public virtual FileDetaild FileDetaild { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileDetai> FileDetais { get; set; }
    }
}