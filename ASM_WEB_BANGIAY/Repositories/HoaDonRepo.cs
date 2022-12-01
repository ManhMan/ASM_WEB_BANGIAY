using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class HoaDonRepo : IHoaDonRepo
    {
        private ShopDatabaseContext _context;
        public HoaDonRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public HoaDonRepo(ShopDatabaseContext context)
        {
            _context = context;
        }
        public bool AddHoaDon(HoaDon hoadon)
        {
            try
            {
                _context.HoaDons.Add(hoadon);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDon(HoaDon hoadon)
        {
            try
            {
                _context.HoaDons.Remove(hoadon);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<HoaDon> GetAllHoaDon()
        {
            return _context.HoaDons.ToList();

        }

        public HoaDon GetByIdHoaDon(int ma)
        {
            return _context.HoaDons.FirstOrDefault(p => p.Ma == ma);
        }

        public bool UpdateHoaDon(HoaDon hoadon)
        {
            try
            {
                _context.HoaDons.Update(hoadon);
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
