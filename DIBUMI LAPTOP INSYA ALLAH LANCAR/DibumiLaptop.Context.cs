﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIBUMI_LAPTOP_INSYA_ALLAH_LANCAR
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dibumilaptopEntities : DbContext
    {
        public dibumilaptopEntities()
            : base("name=dibumilaptopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<garansi> garansis { get; set; }
        public virtual DbSet<gudang> gudangs { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<kondisi> kondisis { get; set; }
        public virtual DbSet<merek> mereks { get; set; }
        public virtual DbSet<@return> returns { get; set; }
        public virtual DbSet<transaksi> transaksis { get; set; }
    }
}
