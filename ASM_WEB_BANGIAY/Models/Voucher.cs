using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.Models
{
    public class Voucher
    {
        public int Ma { get; set; }
        public string TenVoucher { get; set; }
        public int SoLuong { get; set; }
        public List<HoaDon> HoaDons { get; set; }
    }
}
