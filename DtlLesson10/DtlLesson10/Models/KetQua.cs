//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class KetQua
    {
        public string DtlMaSV { get; set; }
        public string DtlMaMH { get; set; }
        public Nullable<int> DtlDiem { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual Sinhvien Sinhvien { get; set; }
    }
}
