using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class HoaDonChiTietRepo : IHoaDonCHiTietRepo
    {
        private ShopDatabaseContext _context;
        public HoaDonChiTietRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public HoaDonChiTietRepo(ShopDatabaseContext context)
        {
            _context = context;
        }
        public bool AddHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            try
            {
                _context.HoaDonChiTiets.Add(hoadonchitiet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            try
            {
                _context.HoaDonChiTiets.Remove(hoadonchitiet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<HoaDonChiTiet> GetAllHoaDonChiTiet()
        {
            return _context.HoaDonChiTiets.ToList();
        }

        public HoaDonChiTiet GetByIdHoaDonChiTiet(int ma)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateHoaDonChiTiet(HoaDonChiTiet hoadonchitiet)
        {
            try
            {
                _context.HoaDonChiTiets.Update(hoadonchitiet);
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
