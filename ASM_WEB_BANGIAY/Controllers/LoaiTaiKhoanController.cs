using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using ASM_WEB_BANGIAY.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class LoaiTaiKhoanController : Controller
    {
        private ILoaiTaiKhoanRepo _loaitkRepo;
        public LoaiTaiKhoanController(ILoaiTaiKhoanRepo loaiTaiKhoanRepo)
        {
            _loaitkRepo= loaiTaiKhoanRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _loaitkRepo.GetAllLoaiTaiKhoan();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LoaiTaiKhoan loaiTaiKhoan) {
            var newLTK = _loaitkRepo.AddLoaiTaiKhoan(loaiTaiKhoan);
            if (newLTK)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
        public IActionResult Details(int ma)
        {
            var result = _loaitkRepo.GetByIdLoaiTaiKhoan(ma);
            return View(result);
        }

        public IActionResult Delete(int ma)
        {
            var respon = _loaitkRepo.GetByIdLoaiTaiKhoan(ma);
            var result = _loaitkRepo.DeleteLoaiTaiKhoan(respon);
            if (result)
                return RedirectToAction("Index");
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Edit(int ma)
        {
           
            var result = _loaitkRepo.GetByIdLoaiTaiKhoan(ma);
            return View(result);

        }
        [HttpPost]
        public IActionResult Edit(LoaiTaiKhoan ltk)
        {
            var result = _loaitkRepo.UpdateLoaiTaiKhoan(ltk);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}
