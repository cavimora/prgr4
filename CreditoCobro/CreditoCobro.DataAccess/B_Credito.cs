//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CreditoCobro.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class B_Credito
    {
        public B_Credito()
        {
            this.B_Proyeccion = new HashSet<B_Proyeccion>();
        }
    
        public int IdCredito { get; set; }
        public string IdCliente { get; set; }
        public Nullable<decimal> MontoAprobado { get; set; }
        public Nullable<decimal> Tasa { get; set; }
        public Nullable<decimal> Plazo { get; set; }
    
        public virtual B_Cliente B_Cliente { get; set; }
        public virtual ICollection<B_Proyeccion> B_Proyeccion { get; set; }
    }
}
