using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Simulator.Models;

namespace Simulator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Results()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }


        public IActionResult Task2()
        {
            return View();
        }

        public IActionResult Task()
        {
            return View();
        }

        public IActionResult Instruction()
        {
            return View();
        }

        public IActionResult RegistrToExem()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }
        public IActionResult Start()
        {
            return View();
        }

        public IActionResult Index()
        {
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
    }
}
