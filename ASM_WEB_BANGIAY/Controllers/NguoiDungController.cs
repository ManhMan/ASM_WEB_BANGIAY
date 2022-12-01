using ASM_WEB_BANGIAY.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class NguoiDungController : Controller
    {
        private INguoiDungReop _nguoidungRepo;
        public NguoiDungController(INguoiDungReop nguoiDungReop)
        {
            _nguoidungRepo= nguoiDungReop;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var result = _nguoidungRepo.GetAllNguoiDung();
            return View(result);
        }
    }
}
