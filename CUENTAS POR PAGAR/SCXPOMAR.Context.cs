﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CUENTAS_POR_PAGAR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SCXPOMAREntities : DbContext
    {
        public SCXPOMAREntities()
            : base("name=SCXPOMAREntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHEQUESOMAR> CHEQUESOMAR { get; set; }
        public virtual DbSet<FACTURASOMAR> FACTURASOMAR { get; set; }
        public virtual DbSet<PROVEEDORESOMAR> PROVEEDORESOMAR { get; set; }
        public virtual DbSet<USUARIOSOMAR> USUARIOSOMAR { get; set; }
        public virtual DbSet<ESTADODECUENTASOMAR> ESTADODECUENTASOMAR { get; set; }
    }
}