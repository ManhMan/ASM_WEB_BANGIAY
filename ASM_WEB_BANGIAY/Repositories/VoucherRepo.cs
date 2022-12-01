using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class VoucherRepo : IVoucherRepo
    {
        private ShopDatabaseContext _context;
        public VoucherRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public VoucherRepo(ShopDatabaseContext context)
        {
           _context = context;
        }

        public bool AddVoucher(Voucher voucher)
        {
            try
            {
                _context.Vouchers.Add(voucher);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteVoucher(Voucher voucher)
        {
            try
            {
                _context.Vouchers.Remove(voucher);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Voucher> GetAllVoucher()
        {
            return _context.Vouchers.ToList();
        }

        public Voucher GetByIdVoucher(int ma)
        {
            //return _context.Vouchers.Find(id);
            return _context.Vouchers.FirstOrDefault(p => p.Ma == ma);
        }

        public bool UpdateVoucher(Voucher voucher)
        {
            try
            {
                _context.Vouchers.Update(voucher);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
