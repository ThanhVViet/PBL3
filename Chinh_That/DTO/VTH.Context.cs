﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinh_That.DTO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLiQuanNetEntities : DbContext
    {
        public QuanLiQuanNetEntities()
            : base("name=QuanLiQuanNetEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<computer> computers { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<game> games { get; set; }
        public virtual DbSet<game_category> game_category { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<payment_detail> payment_detail { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<record> records { get; set; }
        public virtual DbSet<user_role> user_role { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<worktime> worktimes { get; set; }
    }
}
