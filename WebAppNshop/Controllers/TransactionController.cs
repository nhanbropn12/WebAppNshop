﻿using Microsoft.AspNetCore.Http;
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
using Microsoft.AspNetCore.Authorization;

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
       /* [Authorize]//check whever signin*/
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                ViewBag.listproduct = db.Products.Where(x => 1 < 2).ToList();
                var listOrder = db.Orders.Where(x => x.UserId == _userManager.GetUserAsync(User).Result.Id);
                return View(listOrder.ToList().Reverse<Order>());
            }
            else
                return View(null);
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
                    
                    var user = db.AppUsers.FirstOrDefault(x => x.Email == User.Identity.Name);
                    Order order = new Order//bi lỗi khi đăng nhập bằng tài khoản mình tạo, tài khoản đăng ký thì ko sao
                    {
                        OrderId = new Guid(),
                        UserId = user.Id//so bi loi cho nay
                        //createday and status da chinh kieu du lieu mac dinh trong cau hinh
                    };
                    //lưu vào database
                  /*  var orderId = order.OrderId;*/
                    db.Orders.Add(order);
                    /*db.SaveChanges();*/
                    List<OrderDetail> orderDetails = new List<OrderDetail>();
                    foreach (var item in myCart)//dua order detail vao co so du lieu
                    {
                        OrderDetail orderDetail = new OrderDetail
                        {
                            OrderId = (Guid)order.OrderId,
                            OrderDetailId = new Guid(),
                            price = item.ToTalPrice,
                            Quantity = item.Quantity,
                            ProductId = (Guid)item.ProductId
                        };
                        orderDetails.Add(orderDetail);
                    }
                    db.OrderDetails.AddRange(orderDetails);
                    db.SaveChanges();
                    HttpContext.Session.Set("GioHang", new List<CartItemViewModel>());//xóa gio hàng khi thanh toán thành công
                }
                else
                {
                  
                }

                return View("CheckoutSuccess");//dua ve gio hang rong (tam thoi)
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
                //set lai session so luong gio hang
                /*var data = HttpContext.Session.Get<List<CartItemViewModel>>("GioHang");*/
                if (data == null)
                {
                    HttpContext.Session.Set("CountOfCart", 0);
                }
                else
                {
                    HttpContext.Session.Set("CountOfCart", data.Count());
                }
                return data;
            }
           

        }
        
       
        public IActionResult RemoveToCart(Guid id)//chưa làm
        {
            var myCart = Carts;
            myCart.RemoveAll(x => x.ProductId == id);
            HttpContext.Session.Set("GioHang", myCart);
            return RedirectToAction("ProductCart");
        }
        
        public IActionResult AddToCart(Guid id)//bị vấn đề là khi load lại chính trang này thì số lượng tự tăng thêm
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
           /* return View("ProductCart",Carts);*/
           return RedirectToAction("ProductCart");
        }
        public IActionResult MinusToCart(Guid id)
        {
            var myCart = Carts;
            var item = myCart.SingleOrDefault(p => p.ProductId == id);
            if (item != null&&item.Quantity>1)
            {
                item.Quantity--;
                HttpContext.Session.Set("GioHang", myCart);
            }
            return RedirectToAction("ProductCart");
        }
        [Route("Transaction/ProductCart")]
        public IActionResult ProductCart()
        {
            return View("ProductCart",Carts);
        }
        
        public IActionResult CheckoutSuccess()
        {
            return View("CheckoutSuccess");
        }
        public IActionResult CancelOrder(Guid id)
        {
            var ordermodify = db.Orders.FirstOrDefault(x => x.OrderId == id);
            ordermodify.status = Nshopsolution.Data.Enum.Status.Canceled;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
