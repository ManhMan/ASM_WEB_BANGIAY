using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface ISanPhamRepo
    {
        IEnumerable<SanPham> GetAllSanPham();
        SanPham GetByIdSanPham(int ma);
        bool AddSanPham(SanPham sanpham);
        bool UpdateSanPham(SanPham sanpham);
        bool DeleteSanPham(SanPham sanpham);
       
    }
}
