﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelCarServiceContainer : DbContext
    {
        public ModelCarServiceContainer()
            : base("name=ModelCarServiceContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> ClientSet { get; set; }
        public virtual DbSet<Auto> AutoSet { get; set; }
        public virtual DbSet<Sasiu> SasiuSet { get; set; }
        public virtual DbSet<Mecanic> MecanicSet { get; set; }
        public virtual DbSet<Material> MaterialSet { get; set; }
        public virtual DbSet<Imagine> ImagineSet { get; set; }
        public virtual DbSet<Operatie> OperatieSet { get; set; }
        public virtual DbSet<Comanda> ComandaSet { get; set; }
        public virtual DbSet<DetaliuComanda> DetaliuComandaSet { get; set; }
    }
}
