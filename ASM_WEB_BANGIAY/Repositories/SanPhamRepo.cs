using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using Microsoft.AspNetCore.Hosting.Server;
using System;
using System.Collections.Generic;
using System.IO;
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
                //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                //File.Copy(sanpham.HinhAnh, Path.Combine(projectDirectory, "IMG", Path.GetFileName(sanpham.HinhAnh)), true);
                //sanpham.HinhAnh = Path.Combine(projectDirectory, "IMG", Path.GetFileName(sanpham.HinhAnh));
                
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
