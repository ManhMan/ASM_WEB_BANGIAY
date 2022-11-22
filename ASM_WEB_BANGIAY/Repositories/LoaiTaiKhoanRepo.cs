using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class LoaiTaiKhoanRepo : ILoaiTaiKhoanRepo
    {
        private ShopDatabaseContext _context;
        public LoaiTaiKhoanRepo(ShopDatabaseContext context)
        {
            _context = context;
        }
        public bool AddLoaiTaiKhoan(LoaiTaiKhoan loaitaikhoan)
        {
            try
            {
                _context.LoaiTaiKhoans.Add(loaitaikhoan);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteLoaiTaiKhoan(LoaiTaiKhoan loaitaikhoan)
        {
            try
            {
                _context.LoaiTaiKhoans.Remove(loaitaikhoan);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<LoaiTaiKhoan> GetAllLoaiTaiKhoan()
        {
            return _context.LoaiTaiKhoans.ToList();
        }

        public LoaiTaiKhoan GetByIdLoaiTaiKhoan(int ma)
        {
            return _context.LoaiTaiKhoans.FirstOrDefault(p => p.Ma == ma);
        }

        public bool UpdateLoaiTaiKhoan(LoaiTaiKhoan loaitaikhoan)
        {
            try
            {
                _context.LoaiTaiKhoans.Update(loaitaikhoan);
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
