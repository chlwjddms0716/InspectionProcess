//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InspectionProcess.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.InspectionResults = new HashSet<InspectionResult>();
        }
    
        public int ProductId { get; set; }
        public int ProductionTeam { get; set; }
        public System.DateTime FinishTime { get; set; }
        public int MerchandiseId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionResult> InspectionResults { get; set; }
        public virtual Merchandise Merchandise { get; set; }
        public virtual Team Team { get; set; }
    }
}
