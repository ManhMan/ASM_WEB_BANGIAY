using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASM_WEB_BANGIAY.Models
{
    public class NguoiDung
    {
        public int Ma { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống")]
        public string Ten { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống")]

        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống")]

        public string SDT { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống")]

        public string TaiKhoan { get; set; }
        [Required(ErrorMessage = "Vui lòng không để trống")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = " ít nhất 6 ký tự")]
        public string MatKhau { get; set; }
        public int MaLoaiTaiKhoan { get; set; }
        public LoaiTaiKhoan LoaiTaiKhoan { get; set; }
        public List<HoaDon> HoaDons { get; set; }
        public List<GioHang> GioHangs { get; set; }
       
    }
}
