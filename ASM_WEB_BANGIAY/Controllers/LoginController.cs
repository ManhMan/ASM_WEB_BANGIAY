using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using ASM_WEB_BANGIAY.Repositories;
using ASM_WEB_BANGIAY.RequestModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class LoginController : Controller
    {
        private ISanPhamRepo _spRepo;
        private INSXRepo _sxRepo;
        private INguoiDungReop _nguoiDungReop;
        private ILoaiTaiKhoanRepo _ltkRepo;
        private IGioHangRepo _gioHangRepo;
        public LoginController(ISanPhamRepo spRepo, INSXRepo nSXRepo, INguoiDungReop nguoiDungReop, ILoaiTaiKhoanRepo ltkRepo, IGioHangRepo gioHangRepo)
        {
            _spRepo = spRepo;
            _sxRepo = nSXRepo;
            _nguoiDungReop = nguoiDungReop;
            _ltkRepo = ltkRepo;
            _gioHangRepo = gioHangRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Loging(LoginRequest request)
        {  
            ViewData["loginfalse"] = "";
            if (HttpContext.Session.GetString("user") != null)
            {
                ViewData["loginfalse"] = "Bạn đã đăng nhập rồi";
                return View("Login");
            }
            else
            {
                var acc = _nguoiDungReop.GetAllNguoiDung().FirstOrDefault(p => p.TaiKhoan == request.TaiKhoan && p.MatKhau == request.MatKhau);
                if (string.IsNullOrEmpty(request.TaiKhoan) || string.IsNullOrEmpty(request.MatKhau))
                {
                    ViewData["loginfalse"] = "Tài khoản hoặc mật khẩu không được để trống";
                    return View("Login");
                }
                else
                {
                    if (acc == null)
                    {

                        return RedirectToAction("Error", "Home");
                    }
                    else
                    {
                        var maltk = _nguoiDungReop.GetAllNguoiDung().FirstOrDefault(p => p.TaiKhoan == request.TaiKhoan).MaLoaiTaiKhoan;

                        if (maltk == 2)
                        {
                            HttpContext.Session.SetString("user", request.TaiKhoan);
                            return RedirectToAction("Index", "Admin");
                        }
                        else
                        {
                            HttpContext.Session.SetString("user", request.TaiKhoan);
                           //var maND = _nguoiDungReop.GetAllNguoiDung().FirstOrDefault(p=>p.TaiKhoan == HttpContext.Session.GetString("user")).Ma;
                            return RedirectToAction("Index", "Home");
                        }
                    }
                }
            }           
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("user");
            return View("Login");
        }
    }
}
