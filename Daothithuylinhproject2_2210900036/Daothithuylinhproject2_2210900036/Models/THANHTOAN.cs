//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daothithuylinhproject2_2210900036.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THANHTOAN
    {
        public string MaTT { get; set; }
        public string MaDH { get; set; }
        public string PhuongThucTT { get; set; }
        public Nullable<System.DateTime> NgayTT { get; set; }
        public Nullable<decimal> Sotien { get; set; }
    
        public virtual DONHANG DONHANG { get; set; }
    }
}
