//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sci.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TabTitStu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TabTitStu()
        {
            this.Mem = new HashSet<Mem>();
        }
    
        public string TCodTitStu { get; set; }
        public string DescrTitStu { get; set; }
        public Nullable<bool> SelTitStu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mem> Mem { get; set; }
    }
}