using Helicopter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Helicopter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _dataContext;


        public HomeController(ILogger<HomeController> logger, DataContext dataContext)
        {
            _logger = logger;
            _dataContext = dataContext;

        }


        public IActionResult Index()
        {
            ViewBag.Person = _dataContext.Users;

            ViewBag.Airs = _dataContext.Vehicles;
            return View();
        }

        public IActionResult Shop()
        {
            ViewBag.Person = _dataContext.Users;

            ViewBag.Airs = _dataContext.Vehicles;
            return View();
        }
        public IActionResult Single(int inputId)
        {
            ViewBag.Person = _dataContext.Users;

            ViewBag.Airs = _dataContext.Vehicles;
            ViewBag.inputId = inputId;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
