using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using ASM_WEB_BANGIAY.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
            var result = _spRepo.GetAllSanPham();
            
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham sp)
        {
            //var layMaNSX = 
            ViewBag.LayMaNSX = "15";
            var result = _spRepo.AddSanPham(sp);
            /////////////var lstNSX = _sxRepo.GetAllNSX();
            if (result)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
        
    }
}
