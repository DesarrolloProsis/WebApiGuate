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
    
    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            this.CuentasTelepeajes = new HashSet<CuentasTelepeajes>();
        }
    
        public long Id { get; set; }
        public string NumCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string EmailCliente { get; set; }
        public string AddressCliente { get; set; }
        public string PhoneCliente { get; set; }
        public bool StatusCliente { get; set; }
        public System.DateTime DateTCliente { get; set; }
        public string IdCajero { get; set; }
        public string Empresa { get; set; }
        public string CP { get; set; }
        public string Pais { get; set; }
        public string City { get; set; }
        public string Departamento { get; set; }
        public string NIT { get; set; }
        public string PhoneOffice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CuentasTelepeajes> CuentasTelepeajes { get; set; }
    }
}