﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<B_Cliente> B_Cliente { get; set; }
        public DbSet<B_Credito> B_Credito { get; set; }
        public DbSet<B_Institucion> B_Institucion { get; set; }
        public DbSet<B_Proyeccion> B_Proyeccion { get; set; }
        public DbSet<P_Cuota> P_Cuota { get; set; }
        public DbSet<P_Empleado> P_Empleado { get; set; }
        public DbSet<G_Usuarios> G_Usuarios { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
