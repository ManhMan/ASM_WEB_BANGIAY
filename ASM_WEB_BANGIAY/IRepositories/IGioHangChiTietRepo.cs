using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface IGioHangChiTietRepo
    {
        IEnumerable<GioHangChiTiet> GetAllGioHangChiTiet();
        GioHangChiTiet GetGHCTbyMa(int masp, int magh);
        bool AddGioHangChiTiet(GioHangChiTiet giohangchitiet);
        bool UpdateGioHangChiTiet(GioHangChiTiet giohangchitiet);
        bool DeleteGioHangChiTiet(GioHangChiTiet giohangchitiet);
    }
}
