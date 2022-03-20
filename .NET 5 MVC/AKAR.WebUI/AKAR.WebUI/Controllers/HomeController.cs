using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AKAR.WebUI.Models;
using System.Collections.Generic;
using System;

namespace AKAR.WebUI.Controllers
{
    public class HomeController:Controller
    {

        // depency incejtion bölümü 
        private ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
           _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Date = DateTime.Now;
            ViewBag.Selamlama = (DateTime.Now.Hour> 12) ? "İyi Akşamlar " : "İyi Günler ";
            ViewBag.Kullanici = "Berkay AKAR";
            ViewBag.Cinsiyet = "Erkek";



            return View();
        }

      
    }
}
