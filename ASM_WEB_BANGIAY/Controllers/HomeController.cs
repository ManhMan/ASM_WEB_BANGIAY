﻿using ASM_WEB_BANGIAY.Context;
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
        public HomeController(ILogger<HomeController> logger, ISanPhamRepo sanPhamRepo, INSXRepo nSXRepo)
        {
            _logger = logger;
            _sanPhamRepo = sanPhamRepo;
            _sxRepo = nSXRepo;
        }  

        public IActionResult Index()
        {
            ViewData["thongbao"] = HttpContext.Session.GetString("user");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult Login(string user, string pass) 
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                ViewData["loginfalse"] = "Đăng nhập thất bại";
                return View();
                //return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Session.SetString("user", user);
                return RedirectToAction("Index");
            }
            return View();
        }
       
    }
}
