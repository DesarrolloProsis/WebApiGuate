//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiGuate.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CortesCajeroes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CortesCajeroes()
        {
            this.OperacionesCajeroes = new HashSet<OperacionesCajeroes>();
        }
    
        public long Id { get; set; }
        public string NumCorte { get; set; }
        public System.DateTime DateTApertura { get; set; }
        public Nullable<System.DateTime> DateTCierre { get; set; }
        public Nullable<double> MontoTotal { get; set; }
        public string Comentario { get; set; }
        public string IdCajero { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperacionesCajeroes> OperacionesCajeroes { get; set; }
    }
}