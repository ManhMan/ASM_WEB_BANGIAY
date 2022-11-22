using System;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.Models
{
    public class SanPham
    {
        public int Ma { get; set; }
        public int MaNSX { get; set; }
        public string TenSP { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public string HinhAnh { get; set; }
        public bool TrangThai { get; set; }
        public NSX NSX { get; set; }
        public List<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public List<GioHangChiTiet> GioHangChiTiets { get; set; }
    }
}
