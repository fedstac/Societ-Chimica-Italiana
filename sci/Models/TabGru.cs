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
    
    public partial class TabGru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TabGru()
        {
            this.Gruppi = new HashSet<Gruppi>();
        }
    
        public short AnnoGru { get; set; }
        public string CodGru { get; set; }
        public string NCodGru { get; set; }
        public string DescrGruppo { get; set; }
        public Nullable<decimal> ImportoGru { get; set; }
        public Nullable<bool> SelGru { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gruppi> Gruppi { get; set; }
    }
}
