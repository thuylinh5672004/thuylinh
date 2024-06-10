using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace DtlLesson08CF.Models
{
    //tạo ra cấu trúc bảng hook
    public class DtlBook
    {
        [Key]
        public int DtlBookId { get; set; }
        public string DtlTitle { get; set; }
        public string DtlAuthor { get; set;}
        public int DtlYear { get; set;}
        public string DtlPublisher { get; set;}
        public string DtlPicture { get; set;}
        public int DtlCategoryId { get; set;}
        //thuộc tính quan hệ
        public virtual DtlCategory DtlCategory { get; set; }
    }
}