using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppNshop.Models;

namespace WebAppNshop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("HomePage");
        }
        public IActionResult ProductList()
        {
            return View("ProductList");
        }
        public IActionResult DetailProduct()
        {
            return View("DetailProduct");
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
