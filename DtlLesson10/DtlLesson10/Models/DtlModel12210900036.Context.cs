﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DtlLesson10.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DtlK22CNT1Lesson10Entities : DbContext
    {
        public DtlK22CNT1Lesson10Entities()
            : base("name=DtlK22CNT1Lesson10Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KetQua> KetQua { get; set; }
        public virtual DbSet<khoa> khoa { get; set; }
        public virtual DbSet<MonHoc> MonHoc { get; set; }
        public virtual DbSet<Sinhvien> Sinhvien { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
