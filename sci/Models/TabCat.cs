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
    
    public partial class TabCat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TabCat()
        {
            this.Pag = new HashSet<Pag>();
        }
    
        public short AnnoCat { get; set; }
        public string CodCat { get; set; }
        public string NCodCat { get; set; }
        public string DescrCat { get; set; }
        public Nullable<decimal> ImportoCat { get; set; }
        public Nullable<bool> SelCat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pag> Pag { get; set; }
    }
}
