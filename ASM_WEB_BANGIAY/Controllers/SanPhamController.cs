using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using ASM_WEB_BANGIAY.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class SanPhamController : Controller
    {
        private ISanPhamRepo _spRepo;
        private INSXRepo _sxRepo;
        public SanPhamController(ISanPhamRepo spRepo, INSXRepo nSXRepo)
        {
            _spRepo = spRepo; 
            _sxRepo = nSXRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<NSX> lstNSX = new List<NSX>();
            foreach (var item in _sxRepo.GetAllNSX())
            {
                lstNSX.Add(item);
            }
            ViewData["lstNSX"] = lstNSX;
            var result = _spRepo.GetAllSanPham();
            
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //List<int> manhasx = new List<int>();
            //foreach (var item in _sxRepo.GetAllNSX())
            //{
            //    manhasx.Add(item.Ma);
            //}
            //ViewData["mansx"] = manhasx;
            List<NSX> lstNSX = _sxRepo.GetAllNSX().ToList(); //1 thằng này là đủ lấy đc cả mã + tên
            ViewData["lstNSX"] = lstNSX;
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham sp)
        {           
            var result = _spRepo.AddSanPham(sp);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult SearchSanPham(decimal a, decimal b)
        {
            decimal tam;
            if (a > b)
            {
                tam = a;
                a = b;
                b = tam;
            }
            
            var result = _spRepo.GetAllSanPham().Where(p => p.GiaBan>=a && p.GiaBan<=b).ToList();
            if (result.Count > 0)
            {
                ViewData["result"] = "Tìm thấy" + result.Count + "sản phẩm";
                return View("Index", result);
            }
            else
            {
               ViewData["thongbao"] = "Không thấy sản phẩm nào trong khoảng bạn vừa nhập";

            }
           
           return View("Index");
        }

        [HttpGet]
        public IActionResult Details(int ma)
        //ăn theo router-id, chuyển chữ id thành ma là ăn theo cái truyền vào 
        {
            var result = _spRepo.GetByIdSanPham(ma);
            return View(result);
        }

        public IActionResult Delete(int ma)
        {
            var respon = _spRepo.GetByIdSanPham(ma);
            var result = _spRepo.DeleteSanPham(respon);
            if (result)
                return RedirectToAction("Index");
            return BadRequest();
        }

        [HttpGet]
        public IActionResult Edit(int ma)
        {
            List<NSX> lstNSX = _sxRepo.GetAllNSX().ToList();
            ViewData["lstNSX"] = lstNSX;
            var result = _spRepo.GetByIdSanPham(ma);
            return View(result);

        }
        [HttpPost]
        public IActionResult Edit(SanPham sp)
        {
            var result = _spRepo.UpdateSanPham(sp);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}
