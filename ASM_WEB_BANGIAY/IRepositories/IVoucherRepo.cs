using ASM_WEB_BANGIAY.Models;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.IRepositories
{
    public interface IVoucherRepo
    {
        IEnumerable<Voucher> GetAllVoucher();
        Voucher GetByIdVoucher(int ma);
        bool AddVoucher(Voucher voucher);
        bool UpdateVoucher(Voucher voucher);
        bool DeleteVoucher(Voucher voucher);
    }
}
