using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class NguoiDungRepo : INguoiDungReop
    {
        private ShopDatabaseContext _context;
        public NguoiDungRepo(ShopDatabaseContext context)
        {
            _context = context;
        }
        public bool AddNguoiDung(NguoiDung nguoidung)
        {
            try
            {
                _context.NguoiDungs.Add(nguoidung);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNguoiDung(NguoiDung nguoidung)
        {
            try
            {
                _context.NguoiDungs.Remove(nguoidung);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<NguoiDung> GetAllNguoiDung()
        {
            return _context.NguoiDungs.ToList();
        }

        public NguoiDung GetByIdNguoiDung(int ma)
        {
            return _context.NguoiDungs.FirstOrDefault(p => p.Ma == ma);
        }

        public bool UpdateNguoiDung(NguoiDung nguoidung)
        {
            try
            {
                _context.NguoiDungs.Update(nguoidung);
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
