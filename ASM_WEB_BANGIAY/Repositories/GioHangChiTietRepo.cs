using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class GioHangChiTietRepo : IGioHangChiTietRepo
    {
        private ShopDatabaseContext _context;
        public GioHangChiTietRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public GioHangChiTietRepo(ShopDatabaseContext context)
        {
            _context = context;
        }
        public bool AddGioHangChiTiet(GioHangChiTiet giohangchitiet)
        {
            try
            {
                _context.GioHangChiTiets.Add(giohangchitiet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteGioHangChiTiet(GioHangChiTiet giohangchitiet)
        {
            try
            {
                _context.GioHangChiTiets.Remove(giohangchitiet);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<GioHangChiTiet> GetAllGioHangChiTiet()
        {
            return _context.GioHangChiTiets.ToList();
        }

        public GioHangChiTiet GetByIdGioHangChiTiet(int ma)
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateGioHangChiTiet(GioHangChiTiet giohangchitiet)
        {
            try
            {
                _context.GioHangChiTiets.Update(giohangchitiet);
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
