//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RH_TPA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Staff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Staff()
        {
            this.RaiseRequest = new HashSet<RaiseRequest>();
            this.Evidence = new HashSet<Evidence>();
            this.Resignation = new HashSet<Resignation>();
        }
    
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffPassword { get; set; }
        public int StaffSalary { get; set; }
        public string StaffPosition { get; set; }
        public int Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RaiseRequest> RaiseRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evidence> Evidence { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resignation> Resignation { get; set; }
    }
}