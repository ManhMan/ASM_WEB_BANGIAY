using ASM_WEB_BANGIAY.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class AdminController : Controller
    {
        private ISanPhamRepo _sanPhamRepo;
        private INSXRepo _nsxRepo;
        private INguoiDungReop _nguoiDungReop;
        private ILoaiTaiKhoanRepo _loaitkRepo;
        public AdminController(ISanPhamRepo sanPhamRepo, INSXRepo nsxRepo, INguoiDungReop nguoiDungReop, ILoaiTaiKhoanRepo loaitkRepo)
        {
            _sanPhamRepo = sanPhamRepo;
            _nsxRepo = nsxRepo;
            _nguoiDungReop = nguoiDungReop;
            _loaitkRepo = loaitkRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
