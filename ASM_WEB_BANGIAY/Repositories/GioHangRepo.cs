using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class GioHangRepo : IGioHangRepo
    {
        private ShopDatabaseContext _context;
        public GioHangRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public GioHangRepo(ShopDatabaseContext context)
        {
            _context = context;
        }
        public bool AddGioHang(GioHang giohang)
        {
            try
            {
                _context.GioHangs.Add(giohang);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteGioHang(GioHang giohang)
        {
            try
            {
                _context.GioHangs.Remove(giohang);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<GioHang> GetAllGioHang()
        {
            return _context.GioHangs.ToList();
        }

        public GioHang GetGioHangByMaNgDung(int ma)
        {
            return _context.GioHangs.FirstOrDefault(p => p.MaNguoiDung == ma);
        }

        public bool UpdateGioHang(GioHang giohang)
        {
            try
            {
                _context.GioHangs.Update(giohang);
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
