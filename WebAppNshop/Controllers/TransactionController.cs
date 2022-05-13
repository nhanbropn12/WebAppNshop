using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nshopsolution.Data.EF;
using Nshopsolution.Data.Entities;
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
        readonly EShopDbContext db = new EShopDbContext();
        private readonly ILogger<AccountsController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public TransactionController(ILogger<AccountsController> _logger, UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            this._logger = _logger;
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Pay()
        {
            if (!_signInManager.IsSignedIn(User))//chua dang nhap
            {
                return RedirectToAction("SignIn", "Accounts");
            }
            else
            {
                //kiem tra gio hang co san pham chua
                var myCart = Carts;
                if (myCart.Count() > 0 || myCart != null)//co san pham
                {
                    Guid orderId = new Guid();
                    
                    Order oder = new Order
                    {
                        OrderId = orderId,
                        UserId = _userManager.GetUserAsync(User).Result.Id//so bi loi cho nay
                        //createday and status da chinh kieu du lieu mac dinh trong cau hinh
                    };
                    //lưu vào database
                    db.Orders.Add(oder);
                    db.SaveChanges();
                    List<OrderDetail> orderDetails = new List<OrderDetail>();
                    foreach(var item in myCart)//dua order detail vao co so du lieu
                    {
                        OrderDetail orderDetail = new OrderDetail {
                            OrderId = orderId,
                            OrderDetailId=new Guid(),
                            price=item.ToTalPrice,
                            Quantity=item.Quantity,
                            ProductId=item.ProductId
                        };
                        orderDetails.Add(orderDetail);
                    }
                    db.OrderDetails.AddRange(orderDetails);
                    db.SaveChanges();
                    HttpContext.Session.Set("GioHang", new List<CartItemViewModel>());//xóa gio hàng khi thanh toán thành công
                }
                else
                {
                    ModelState.AddModelError("", "Giỏ hàng rỗng");
                }
                
                return View("GioHang", Carts);//dua ve gio hang rong (tam thoi)
            }    
        }
        public IActionResult CheckOutForm()
        {
            if(Carts.Count()==0)
            {
                /*  ModelState.AddModelError("", "Chưa có sản phẩm trong giỏ hàng");*/
                ViewBag.errcartisEmpty = "*Không thể thanh toán giỏ hàng rỗng";
                return View("ProductCart",Carts);
            }    
            return View("CheckOutForm",Carts);
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
        public IActionResult RemoveToCart(Guid id)//chưa làm
        {
            var myCart = Carts;
            myCart.RemoveAll(x => x.ProductId == id);
            HttpContext.Session.Set("GioHang", myCart);
            return View("ProductCart", Carts);
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
