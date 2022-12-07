using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class NguoiDungController : Controller
    {
        private INguoiDungReop _nguoidungRepo;
        private ILoaiTaiKhoanRepo _lktRepo;
        private IGioHangRepo _ghRepo;
        public NguoiDungController(INguoiDungReop nguoiDungReop, ILoaiTaiKhoanRepo lktRepo, IGioHangRepo ghRepo)
        {
            _nguoidungRepo = nguoiDungReop;
            _lktRepo = lktRepo;
            _ghRepo = ghRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<LoaiTaiKhoan> lstLTK = _lktRepo.GetAllLoaiTaiKhoan().ToList();
            ViewData["lstLTK"] = lstLTK;
            var result = _nguoidungRepo.GetAllNguoiDung();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            List<LoaiTaiKhoan> lstLTK = _lktRepo.GetAllLoaiTaiKhoan().ToList();
            ViewData["lstLTK"] = lstLTK;
            return View();
        }
        [HttpPost]
        public IActionResult Create(NguoiDung nguoiDung)
        {
            var newLTK = _nguoidungRepo.AddNguoiDung(nguoiDung);
            if (newLTK)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }

        [HttpGet]
        public IActionResult CreateKH()
        {
            List<LoaiTaiKhoan> lstLTK = _lktRepo.GetAllLoaiTaiKhoan().ToList();
            ViewData["lstLTK"] = lstLTK;
            return View();
        }
        [HttpPost]
        public IActionResult CreateKH(NguoiDung nguoiDung)
        {       
            
                var newLTK = _nguoidungRepo.AddNguoiDung(nguoiDung);
                if (newLTK)
                {
                    GioHang newgh = new GioHang() { 
                    //Ma = nguoiDung.Ma,
                    MaNguoiDung = nguoiDung.Ma,
                    NgayTao = DateTime.Now,
                    TongTien = 0,
                    TrangThai =false
                    };
                    _ghRepo.AddGioHang(newgh);
                    return RedirectToAction("Index");
                }                     
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Details(int ma)
        {
            List<LoaiTaiKhoan> lstLTK = _lktRepo.GetAllLoaiTaiKhoan().ToList();
            ViewData["lstLTK"] = lstLTK;
            var result = _nguoidungRepo.GetByIdNguoiDung(ma);
            return View(result);
        }
        public IActionResult Delete(int ma)
        {
            var respon = _nguoidungRepo.GetByIdNguoiDung(ma);
            var result = _nguoidungRepo.DeleteNguoiDung(respon);
            if (result)
                return RedirectToAction("Index");
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Edit(int ma)
        {
            List<LoaiTaiKhoan> lstLTK = _lktRepo.GetAllLoaiTaiKhoan().ToList();
            ViewData["lstLTK"] = lstLTK;
            var result = _nguoidungRepo.GetByIdNguoiDung(ma);
            return View(result);

        }
        [HttpPost]
        public IActionResult Edit(NguoiDung nguoiDung)
        {
            var result = _nguoidungRepo.UpdateNguoiDung(nguoiDung);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
    }
}
