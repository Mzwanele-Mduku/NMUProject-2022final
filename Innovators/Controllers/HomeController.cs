using Innovators.Data;
using Innovators.Migrations;
using Innovators.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Innovators.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       
       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult CourseLogin()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateAccount()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult HodLogin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult LecturerLogin()
        {
            
            return View();



           
        }
        
       
        public IActionResult SubCoLogin()
        {
            return View();
        }
       
        public IActionResult Registration()
        {
            return View();
        }
       
        public IActionResult UserSelect()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
