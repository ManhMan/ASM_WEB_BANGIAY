using ASM_WEB_BANGIAY.Context;
using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using ASM_WEB_BANGIAY.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class HomeController : Controller
    {
        private ILogger<HomeController> _logger;
        private ISanPhamRepo _sanPhamRepo;
        private INSXRepo _sxRepo;
        private INguoiDungReop _nguoiDungReop;
        private IGioHangChiTietRepo _giohangchitietRepo;
        private IGioHangRepo _giohangRepo;
        private string _errorname = "";
        public HomeController(ILogger<HomeController> logger, ISanPhamRepo sanPhamRepo, INSXRepo nSXRepo, INguoiDungReop nguoiDungReop, IGioHangChiTietRepo gioHangChiTietRepo, IGioHangRepo gioHangRepo)
        {
            _logger = logger;
            _sanPhamRepo = sanPhamRepo;
            _sxRepo = nSXRepo;
            _nguoiDungReop= nguoiDungReop;
            _giohangchitietRepo = gioHangChiTietRepo;
            _giohangRepo=gioHangRepo;

        }  

        public IActionResult Index()
        {
            List<NSX> lstNSX = _sxRepo.GetAllNSX().ToList();
            ViewData["lstNSX"] = lstNSX;
            ViewData["thongbao"] = HttpContext.Session.GetString("user");
            var result = _sanPhamRepo.GetAllSanPham();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _errorname = "Đăng nhập thất bại, tài khoản hoặc mật khẩu không chính xác!";
            return View(new ErrorViewModel { RequestId = "1102", Errorname =_errorname  });
        }

        public IActionResult ErrorKHchuadangnhap()
        {
            return View(new ErrorViewModel { RequestId = "1101", Errorname = "Bạn chưa đăng nhập" });
        }
        [HttpGet]
        public IActionResult AllGioHang()
        {
            if (HttpContext.Session.GetString("user") == null)
            {
               return RedirectToAction("ErrorKHchuadangnhap");
            }
            else
            {
                //phải lọc theo mã giỏ hàng của khách hàng đang đăng nhập
                var maND = _nguoiDungReop.GetAllNguoiDung().FirstOrDefault(p => p.TaiKhoan == HttpContext.Session.GetString("user")).Ma;
                ViewBag.maND = maND;
                var laymaGH = _giohangRepo.GetAllGioHang().FirstOrDefault(p => p.MaNguoiDung == maND).Ma;
                decimal tongtien = 0;
                var lstGHCT = _giohangchitietRepo.GetAllGioHangChiTiet().Where(p => p.MaGioHang == laymaGH);
                foreach (var item in lstGHCT)
                {
                    tongtien += item.SoLuong * item.GiaBan;
                }
                ViewBag.tt = tongtien;
                var gh = _giohangRepo.GetAllGioHang();
                return View(gh);
            }
            
        }
        [HttpGet]
        public IActionResult AllGioHangchitiet()
        {
            if (HttpContext.Session.GetString("user") ==null)
            {
                return RedirectToAction("ErrorKHchuadangnhap");
            }
            else
            {
                //phải lọc theo mã giỏ hàng chứa chi tiết
                var maND = _nguoiDungReop.GetAllNguoiDung().FirstOrDefault(p => p.TaiKhoan == HttpContext.Session.GetString("user")).Ma;
                var laymaGH = _giohangRepo.GetAllGioHang().FirstOrDefault(p => p.MaNguoiDung == maND).Ma;
                ViewBag.maGH = laymaGH;
                List<SanPham> lstsp = _sanPhamRepo.GetAllSanPham().ToList();
                ViewData["lstSP"] = lstsp;

                decimal tongtien = 0;
                var lstGHCT = _giohangchitietRepo.GetAllGioHangChiTiet().Where(p => p.MaGioHang == laymaGH);
                foreach (var item in lstGHCT)
                {
                    tongtien += item.SoLuong * item.GiaBan;
                }
                ViewBag.tt = tongtien;
                var gh = _giohangchitietRepo.GetAllGioHangChiTiet();
                return View(gh);
            }
            
        }
        public IActionResult Addtocard(int ma)
        {   string login = HttpContext.Session.GetString("user");
            if (login == null)
            {
                return Ok("Bạn chưa đăng nhập");
            }
            else
            {                            
                var maND = _nguoiDungReop.GetAllNguoiDung().FirstOrDefault(p => p.TaiKhoan == HttpContext.Session.GetString("user")).Ma;
                var laymaGH = _giohangRepo.GetAllGioHang().FirstOrDefault(p => p.MaNguoiDung == maND).Ma;
                //////////////////////////////////////////////////////////////
                var sp = _sanPhamRepo.GetAllSanPham().FirstOrDefault(p => p.Ma == ma);
                var data = _giohangchitietRepo.GetAllGioHangChiTiet().FirstOrDefault(p => p.MaSP == sp.Ma && p.MaGioHang == laymaGH);
                if (data == null)
                {                   
                    GioHangChiTiet ghct = new GioHangChiTiet()
                    {
                        MaGioHang = laymaGH,
                        MaSP = sp.Ma,
                        GiaBan = sp.GiaBan,
                        SoLuong = 1
                    };
                    _giohangchitietRepo.AddGioHangChiTiet(ghct);
                    return RedirectToAction("AllGioHangchitiet");
                }
                else
                {
                    data.SoLuong++;
                    _giohangchitietRepo.UpdateGioHangChiTiet(data);
                    return RedirectToAction("AllGioHangchitiet");
                }
            }
            return Ok();
        }
        public IActionResult Delete(int masp, int magh)
        {
            var respon = _giohangchitietRepo.GetGHCTbyMa(masp, magh);
            var result = _giohangchitietRepo.DeleteGioHangChiTiet(respon);
            if (result)
                return RedirectToAction("AllGioHangchitiet");           
            return BadRequest();
        }
        public IActionResult TangSL(int masp, int magh)
        {
            var respon = _giohangchitietRepo.GetGHCTbyMa(masp, magh);
            respon.SoLuong++;
            _giohangchitietRepo.UpdateGioHangChiTiet(respon);
            return RedirectToAction("AllGioHangchitiet");
        }
        public IActionResult GiamSL(int masp, int magh)
        {
            var respon = _giohangchitietRepo.GetGHCTbyMa(masp, magh);
            respon.SoLuong--;
            if (respon.SoLuong <=0)
            {
                ViewBag.thongbao = "Số lượng mua ít nhất là 1 sản phẩm";
               return RedirectToAction("AllGioHangchitiet");
            }
            _giohangchitietRepo.UpdateGioHangChiTiet(respon);
            return RedirectToAction("AllGioHangchitiet");
        }
    }
}
