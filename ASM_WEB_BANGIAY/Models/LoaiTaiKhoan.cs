using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.Models
{
    public class LoaiTaiKhoan
    {
        public int Ma { get; set; }
        public string TenLoaiTK { get; set; }
        public List<NguoiDung> NguoiDungs { get; set; }
    }
}
