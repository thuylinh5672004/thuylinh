using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DTTLBaiDanhGiaGiuaky.Models
{
    public class DTLProduct
    {
        public int dtlID { get; set; }
        [DisplayName("DTL ID")]
        [Required(ErrorMessage = "DTL: Chưa nhập dữ liệu")]
         [RegularExpression("[1-10]{10}", ErrorMessage = "DTL: Hãy nhập 10 ký tự từ số")]
         [Range(1, 10, ErrorMessage = "DTL: Hãy nhập giá trị trong khoảng [1-10]")]    
        public string dtlFullName { get; set; }
        [DisplayName("DTL Họ và tên")]
        [Required(ErrorMessage = "DTL: Chưa nhập dữ liệu")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "DTL: Họ tên chứa tối thiểu 2 ký tự tối đa 25")]
        [RegularExpression(@"[A-Za-z]+", ErrorMessage = "DTL: Họ tên chỉ chưa các ký tự hoặc khoảng trắng")]
        public string dtlImage { get; set; }
        [DisplayName("DTL: ảnh")]
        [Required(ErrorMessage = ": Chưa nhập dữ liệu")]
        
        
        public int  dtlQuantity { get; set; }
        [DisplayName("DTL nhập số lượng")]
        [Required(ErrorMessage = "DTL: Hãy nhập số lượng")]
        [RegularExpression(@"[1-100]{2}", ErrorMessage = "DTL: Hãy nhập 2 ký tự từ số")]
        [Range(1, 100, ErrorMessage = "DTL: Hãy nhập giá trị trong khoảng [1-100]")]
        public int dtlPrice { get; set; }
        [DisplayName("DTL nhập giá")]
        [Required(ErrorMessage = "DTL: Hãy nhập giá tiền")]
        [RegularExpression(@"\d+\.\d+", ErrorMessage = "DTL: Hãy nhập giá tiền ")]
        [Range(1, 100, ErrorMessage = "DTL: giá tiền của sản phẩm ")]
        public bool dtlisActive { get; set; }


    }
}
