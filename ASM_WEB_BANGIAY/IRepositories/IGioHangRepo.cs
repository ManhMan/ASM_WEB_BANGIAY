using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface IGioHangRepo
    {
        IEnumerable<GioHang> GetAllGioHang();
        GioHang GetByIdGioHang(int ma);
        bool AddGioHang(GioHang giohang);
        bool UpdateGioHang(GioHang giohang);
        bool DeleteGioHang(GioHang giohang);
    }
}
