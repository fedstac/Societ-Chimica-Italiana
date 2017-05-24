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
    using System.ComponentModel.DataAnnotations;

    public partial class Pag : PagMetadata
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pag()
        {
            this.Convenzioni = new HashSet<Convenzioni>();
            this.Divisioni = new HashSet<Divisioni>();
            this.Gruppi = new HashSet<Gruppi>();
            this.Riviste = new HashSet<Riviste>();
        }
    
        public int CodP { get; set; }
        public short AnnoP { get; set; }
        public string Tiscr { get; set; }
        public string Cat { get; set; }

        public decimal Pagato { get; set; }
        public decimal Dovuto { get; set; }

        public Nullable<System.DateTime> DatPag { get; set; }
        public Nullable<System.DateTime> DatReg { get; set; }
        public Nullable<System.DateTime> DatCassa { get; set; }

        public string Tpag { get; set; }
        public string Fuori { get; set; }
        public bool Lode { get; set; }
        public string Carica { get; set; }
        public string Sez { get; set; }
        public string Sett { get; set; }
        public string Pos { get; set; }
        public string Ent { get; set; }
        public Nullable<int> CodSocCol { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Convenzioni> Convenzioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Divisioni> Divisioni { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gruppi> Gruppi { get; set; }
        public virtual Mem Mem { get; set; }
        public virtual TabCarica TabCarica { get; set; }
        public virtual TabCat TabCat { get; set; }
        public virtual TabEnt TabEnt { get; set; }
        public virtual TabPos TabPos { get; set; }
        public virtual TabSet TabSet { get; set; }
        public virtual TabSez TabSez { get; set; }
        public virtual TabTIscr TabTIscr { get; set; }
        public virtual TabTPag TabTPag { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Riviste> Riviste { get; set; }
    }
}