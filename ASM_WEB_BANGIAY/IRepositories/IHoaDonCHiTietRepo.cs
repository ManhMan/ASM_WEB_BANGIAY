using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface IHoaDonCHiTietRepo
    {
        IEnumerable<HoaDonChiTiet> GetAllHoaDonChiTiet();
        HoaDonChiTiet GetByIdHoaDonChiTiet(int ma);
        bool AddHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
        bool UpdateHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
        bool DeleteHoaDonChiTiet(HoaDonChiTiet hoadonchitiet);
    }
}
