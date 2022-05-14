using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nshopsolution.Data.EF;
using Nshopsolution.Data.Extention;
using Nshopsolution.Data.ViewModels;
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
            var data = HttpContext.Session.Get<List<CartItemViewModel>>("GioHang");
            if (data == null)
{
                HttpContext.Session.Set("CountOfCart", 0);
            }
            else
            {
                HttpContext.Session.Set("CountOfCart", data.Count());
            }
            var products = db.Products;
            return View("HomePage",products);
        }
        public IActionResult ProductList(string id)
        {
            var products = db.Products.Where(x=>x.IdCategory==id);
            return View("ProductList",products);
        }
        public IActionResult DetailProduct(Guid id)
        {
            var product = db.Products.Find(id);
            return View("DetailProduct",product);
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
