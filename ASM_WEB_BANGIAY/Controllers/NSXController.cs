using ASM_WEB_BANGIAY.IRepositories;
using ASM_WEB_BANGIAY.Models;
using ASM_WEB_BANGIAY.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ASM_WEB_BANGIAY.Controllers
{
    public class NSXController : Controller
    {
        private ILogger<NSXController> _logger;
        private INSXRepo _sxRepo;
        public NSXController(ILogger<NSXController> logger, INSXRepo nSXRepo)
        {
            _logger = logger;
            _sxRepo = nSXRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var lstNSX = _sxRepo.GetAllNSX();
            return View(lstNSX);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(NSX nsx)
        {
            var nsxNew = _sxRepo.AddNSX(nsx);
            if (nsxNew)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Details(int ma)
         //ăn theo router-id, chuyển chữ id thành ma là ăn theo cái truyền vào 
        {
            var result = _sxRepo.GetByIdNSX(ma);
            return View(result);
        }
       // [HttpDelete]
        public  IActionResult Delete(int ma)
        {
            var respon = _sxRepo.GetByIdNSX(ma);
            var result = _sxRepo.DeleteNSX(respon);
            if (result)
                return RedirectToAction("Index");
            return BadRequest();
        }
        [HttpGet]
        public IActionResult Edit(int ma)
        {
            var result = _sxRepo.GetByIdNSX(ma);
            return View(result);
            
        }
        [HttpPost]
        public IActionResult Edit(NSX nsx) {
            //var respon = _sxRepo.GetByIdNSX(ma);
            var result = _sxRepo.UpdateNSX(nsx);
            if (result)
            {
                return RedirectToAction("Index");
            }
            return BadRequest();
        }
        [HttpGet]
        public IActionResult SearchByName(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                var result = _sxRepo.GetAllNSX().Where(p=>p.TenNSX.Contains(keyword)).ToList();
                if (result.Count > 0)
                {
                    return View("Index", result);
                }
                else
                {
                    ViewData["thongbao"] = "không thấy";

                }
            }
            return RedirectToAction("Index");
           // return View("Index");
        }
    }
}
