﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSLWebProject.Data
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
    
        public virtual DbSet<ACCOUNT_SETTINGS> ACCOUNT_SETTINGS { get; set; }
        public virtual DbSet<BALANCE> BALANCE { get; set; }
        public virtual DbSet<CHEQUE> CHEQUE { get; set; }
        public virtual DbSet<COMMISSION> COMMISSION { get; set; }
        public virtual DbSet<COVER> COVER { get; set; }
        public virtual DbSet<OBSERVATION> OBSERVATION { get; set; }
        public virtual DbSet<OPERATION> OPERATION { get; set; }
        public virtual DbSet<POLICY_HOLDER> POLICY_HOLDER { get; set; }
        public virtual DbSet<RECEIPT> RECEIPT { get; set; }
        public virtual DbSet<RECEIPT_COLLECTION> RECEIPT_COLLECTION { get; set; }
        public virtual DbSet<RECEIPT_STATUS> RECEIPT_STATUS { get; set; }
        public virtual DbSet<TRANSACTION_DETAIL> TRANSACTION_DETAIL { get; set; }
        public virtual DbSet<REFERENCE_DATA> REFERENCE_DATA { get; set; }
    }
}