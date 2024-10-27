using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace DAHQTCSDL.Models
{
    public class Employee
    {
        [Key]
        public int manv { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên nhân viên")]
        [RegularExpression(@"^[aAàÀảẢãÃáÁạẠăĂằẰẳẲẵẴắẮặẶâÂầẦẩẨẫẪấẤậẬbBcCdDđĐeEèÈẻẺẽẼéÉẹẸêÊềỀểỂễỄếẾệỆfFgGhHiIìÌỉỈĩĨíÍịỊjJkKlLmMnNoOòÒỏỎõÕóÓọỌôÔồỒổỔỗỖốỐộỘơƠờỜởỞỡỠớỚợỢpPqQrRsStTuUùÙủỦũŨúÚụỤưƯừỪửỬữỮứỨựỰvVwWxXyYỳỲỷỶỹỸýÝỵỴzZ ]*$", ErrorMessage = "Tên không được có ký tự đặc biệt")]
        public string tennv { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập ngày sinh")]

        public string ngaysinh { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ nhân viên")]
        public string diachi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập sô điện thoại")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Số điện thoại phải là 10 ")]
        public string sdt { get; set; }
    }
}