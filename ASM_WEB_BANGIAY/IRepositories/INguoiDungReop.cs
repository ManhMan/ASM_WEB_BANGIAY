using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface INguoiDungReop
    {
        IEnumerable<NguoiDung> GetAllNguoiDung();
        NguoiDung GetByIdNguoiDung(int ma);
        bool AddNguoiDung(NguoiDung nguoidung);
        bool UpdateNguoiDung(NguoiDung nguoidung);
        bool DeleteNguoiDung(NguoiDung nguoidung);
    }
}
