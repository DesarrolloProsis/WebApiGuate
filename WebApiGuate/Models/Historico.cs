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
    
    public partial class Historico
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Delegacion { get; set; }
        public string Plaza { get; set; }
        public string Cuerpo { get; set; }
        public string Carril { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Clase { get; set; }
        public string Evento { get; set; }
        public double Saldo { get; set; }
        public string Operador { get; set; }
        public string SaldoAnterior { get; set; }
        public string SaldoActualizado { get; set; }
    }
}
