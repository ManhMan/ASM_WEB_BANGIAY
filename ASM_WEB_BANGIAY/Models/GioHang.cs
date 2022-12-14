using System;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.Models
{
    public class GioHang
    {
        public int Ma { get; set; }
        public int MaNguoiDung { get; set; }
        public int MaVoucher { get; set; }
        public DateTime NgayTao { get; set; }
        public bool TrangThai { get; set; }
        public decimal TongTien { get; set; }
        public List<GioHangChiTiet> GioHangChiTiets { get; set; }
        public NguoiDung NguoiDung { get; set; }
    }
}
