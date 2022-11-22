using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class SanPhamRepo : ISanPhamRepo
    {
        public ShopDatabaseContext _context;
        public SanPhamRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public SanPhamRepo(ShopDatabaseContext context)
        {
            _context = context;   
        }
        public bool AddSanPham(SanPham sanpham)
        {
            try
            {
                _context.SanPhams.Add(sanpham);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteSanPham(SanPham sanpham)
        {

            try
            {
                _context.SanPhams.Remove(sanpham);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<SanPham> GetAllSanPham()
        {
            return _context.SanPhams.ToList();
        }

        public SanPham GetByIdSanPham(int ma)
        {
            return _context.SanPhams.FirstOrDefault(p => p.Ma == ma);
        }

        public bool UpdateSanPham(SanPham sanpham)
        {

            try
            {
                _context.SanPhams.Update(sanpham);
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
