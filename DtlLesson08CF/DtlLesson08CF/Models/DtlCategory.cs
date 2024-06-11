using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DtlLesson08CF.Models
{
    //tạo cấu trúc bảng dữ liệu
    public class DtlCategory
    {
        [Key]
        public int DtlCategoryId { get; set; }
        public string DtlCategoryName  { get; set; }
        //thuộc tính đièu hướng
        public virtual ICollection<DtlBook> DtlBooks { get; set; }
    }
}
