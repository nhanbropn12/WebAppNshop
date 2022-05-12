using Microsoft.AspNetCore.Mvc;
using Nshopsolution.Data.EF;
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
        EShopDbContext db = new EShopDbContext();
        public IActionResult Index()
        {
            return View("HomePage");
        }
        public IActionResult ProductList()
        {
            var product = db.Products;
            return View("ProductList",product);
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
