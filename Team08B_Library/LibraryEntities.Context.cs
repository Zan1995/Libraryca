﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team08B_Library
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SA45_Team08B_LibraryEntities : DbContext
    {
        public SA45_Team08B_LibraryEntities()
            : base("name=SA45_Team08B_LibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<IssueTran> IssueTrans { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
