using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Repositories
{
    public class NSXRepo : INSXRepo
    {
        public ShopDatabaseContext _context;
        public NSXRepo()
        {
            _context = new ShopDatabaseContext();
        }
        public NSXRepo(ShopDatabaseContext context)
        {
            _context = context;
        }

        public bool AddNSX(NSX nsx)
        {
            try
            {
                _context.NSXs.Add(nsx);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNSX(NSX nsx)
        {
            try
            {
                _context.NSXs.Remove(nsx);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<NSX> GetAllNSX()
        {
            return _context.NSXs.ToList();
        }

        public NSX GetByIdNSX(int ma)
        {
            return _context.NSXs.FirstOrDefault(p => p.Ma == ma);
        }

        public bool UpdateNSX(NSX nsx)
        {
            try
            {
                _context.NSXs.Update(nsx);
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
