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
    
    public partial class Sinhvien
    {
        public string DtlMaSV { get; set; }
        public string DtlHoSV { get; set; }
        public string DtlTenSV { get; set; }
        public Nullable<bool> DtlPhai { get; set; }
        public Nullable<System.DateTime> DtlNgaysinh { get; set; }
        public string DtlNoisinh { get; set; }
        public string DtlMaKH { get; set; }
        public string DtlHocBong { get; set; }
        public Nullable<int> DtlDiemTB { get; set; }
    
        public virtual KetQua KetQua { get; set; }
        public virtual khoa khoa { get; set; }
    }
}
