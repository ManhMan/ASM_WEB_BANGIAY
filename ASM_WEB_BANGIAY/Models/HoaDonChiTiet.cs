namespace ASM_WEB_BANGIAY.Models
{
    public class HoaDonChiTiet
    {
        public int MaSP { get; set; }
        public int MaHoaDon { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
    }
}
