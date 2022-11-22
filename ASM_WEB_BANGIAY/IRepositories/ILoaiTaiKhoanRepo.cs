using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface ILoaiTaiKhoanRepo
    {
        IEnumerable<LoaiTaiKhoan> GetAllLoaiTaiKhoan();
        LoaiTaiKhoan GetByIdLoaiTaiKhoan(int ma);
        bool AddLoaiTaiKhoan(LoaiTaiKhoan loaitaikhoan);
        bool UpdateLoaiTaiKhoan(LoaiTaiKhoan loaitaikhoan);
        bool DeleteLoaiTaiKhoan(LoaiTaiKhoan loaitaikhoan);
    }
}
