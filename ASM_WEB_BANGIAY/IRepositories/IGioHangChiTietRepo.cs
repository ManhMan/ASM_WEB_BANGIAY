using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface IGioHangChiTietRepo
    {
        IEnumerable<GioHangChiTiet> GetAllGioHangChiTiet();
        GioHangChiTiet GetByIdGioHangChiTiet(int ma);
        bool AddGioHangChiTiet(GioHangChiTiet giohangchitiet);
        bool UpdateGioHangChiTiet(GioHangChiTiet giohangchitiet);
        bool DeleteGioHangChiTiet(GioHangChiTiet giohangchitiet);
    }
}
