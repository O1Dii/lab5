using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Это страница информации о мне";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Это страница контактов";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
