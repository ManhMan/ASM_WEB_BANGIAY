using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.Models
{
    public class NguoiDung
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int MaLoaiTaiKhoan { get; set; }
        public LoaiTaiKhoan LoaiTaiKhoan { get; set; }
        public List<HoaDon> HoaDons { get; set; }
        public List<GioHang> GioHangs { get; set; }
       
    }
}
