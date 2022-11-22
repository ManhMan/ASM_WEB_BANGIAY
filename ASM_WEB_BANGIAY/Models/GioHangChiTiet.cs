namespace ASM_WEB_BANGIAY.Models
{
    public class GioHangChiTiet
    {
        public int MaSP { get; set; }
        public int MaGioHang { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaBan { get; set; }
        public GioHang GioHang { get; set; }
        public SanPham SanPham { get; set; }
    }
}
