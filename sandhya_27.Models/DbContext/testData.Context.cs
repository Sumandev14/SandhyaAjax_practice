﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sandhya_27.Models.DbContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Sandhya_380TestEntities : DbContext
    {
        public Sandhya_380TestEntities()
            : base("name=Sandhya_380TestEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Answer> Answer { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<studentTable> studentTable { get; set; }
    }
}
