using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DtlLesson08CF.Models
{
    public class DtlBookStore:DbContext 
    {
        public DtlBookStore():base("DtlBookStoreConnectionString") {
        
        }
        //tạo các bảng
        public DbSet<DtlCategory> DtlCategories { get; set; }
        public DbSet<DtlBook> DtlBooks { get; set; }
    }
}