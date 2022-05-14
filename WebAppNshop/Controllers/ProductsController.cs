using Microsoft.AspNetCore.Mvc;
using Nshopsolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNshop.Controllers
{
    public class ProductsController : Controller
    {
        EShopDbContext db = new EShopDbContext();
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult ArticleProduct(Guid id)
        {
            var product = db.Products.SingleOrDefault(x => x.idproduct == id);
            return View("ArticleProduct",product);
        }
    }
}
