using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nshopsolution.Data.EF;
using Nshopsolution.Data.Extention;
using Nshopsolution.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNshop.Controllers
{
    public class TransactionController : Controller
    {
        EShopDbContext db = new EShopDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckOutForm()
        {
            return View("CheckOutForm");
        }
        //Lấy danh sách các sản phẩm trong giỏ hàng và setsession
        public List<CartItemViewModel> Carts{
            get{
                var data = HttpContext.Session.Get<List<CartItemViewModel>>("GioHang");
                if (data == null)
                {
                    data = new List<CartItemViewModel>();
                }
                return data;
            }
        }
        public IActionResult AddToCart(Guid id)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.ProductId == id);
            if (item == null)
            {
                var hangHoa = db.Products.SingleOrDefault(p => p.idproduct == id);
                item = new CartItemViewModel
                {
                    ProductId = hangHoa.idproduct,
                    ProductName = hangHoa.ProductName,
                    Image = hangHoa.ImageProduct,
                    price = (Double)(hangHoa.OriginalPrice - (hangHoa.OriginalPrice*hangHoa.discount)),
                    Quantity=1//số lượng mua 
		        };
                myCart.Add(item);
	        }
            else
            {
                item.Quantity++;
	        }
            //set lai session
            HttpContext.Session.Set("GioHang", myCart);
            return View("ProductCart",Carts);
        }
        public IActionResult ProductCart()
        {
            return View("ProductCart",Carts);
        }
    }
}
