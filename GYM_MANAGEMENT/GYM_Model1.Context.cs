﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM_MANAGEMENT
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GYM_MANAGEMEN_dbEntities : DbContext
    {
        public GYM_MANAGEMEN_dbEntities()
            : base("name=GYM_MANAGEMEN_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<equipment> equipments { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<vendor> vendors { get; set; }
    }
}
