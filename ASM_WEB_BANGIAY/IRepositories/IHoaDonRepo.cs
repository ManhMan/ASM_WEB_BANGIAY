using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface IHoaDonRepo
    {
        IEnumerable<HoaDon> GetAllHoaDon();
        HoaDon GetByIdHoaDon(int ma);
        bool AddHoaDon(HoaDon hoadon);
        bool UpdateHoaDon(HoaDon hoadon);
        bool DeleteHoaDon(HoaDon hoadon);
    }
}
