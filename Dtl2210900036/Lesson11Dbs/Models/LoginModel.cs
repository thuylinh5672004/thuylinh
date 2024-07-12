using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dtl2210900036.Models
{
    public partial class LoginModel : DbContext
    {
        public LoginModel()
            : base("name=LoginModel")
        {
        }

        public virtual DbSet<DtlTaiKhoan> DtlTaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
