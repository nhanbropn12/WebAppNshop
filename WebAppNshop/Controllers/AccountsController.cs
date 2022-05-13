﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Nshopsolution.Data.EF;
using Nshopsolution.Data.Entities;
using Nshopsolution.Data.Enum;
using Nshopsolution.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//chưa inject các usermanage
namespace WebAppNshop.Controllers
{
    public class AccountsController : Controller
    {
        
        readonly EShopDbContext db = new EShopDbContext();
        private readonly ILogger<AccountsController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountsController(ILogger<AccountsController> _logger, UserManager<AppUser> _userManager, SignInManager<AppUser> _signInManager)
        {
            this._logger = _logger;
            this._userManager = _userManager;
            this._signInManager = _signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {
            return View("SignUp");
        }
        [HttpPost]
        [AllowAnonymous]
        public async  Task<IActionResult> SignUp(RegisterViewModel appUserModel)//nhưng không đưa xuống dữ liệu
        {
            var user = new AppUser
            {
                Id = new Guid(),
                FirstName = appUserModel.FirstName,
                LastName = appUserModel.LastName,
                DateOfBirth= (DateTime)appUserModel.DateOfBirth,
                Address=appUserModel.Address,
                CardNumber=appUserModel.CardNumber,
                Email=appUserModel.Email,
                UserName=appUserModel.Email
            };
            var result = await _userManager.CreateAsync(user, appUserModel.Password);
            if (result.Succeeded)
            {
                db.AppUsers.Add(user);
                await db.SaveChangesAsync();
                await _signInManager.SignInAsync(user, isPersistent: true);
                return RedirectToAction("Index","Home");
                
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View("SignUp");
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            if(_signInManager.IsSignedIn(User))
            return View("SignIn");
            else
            {
     
             return View("SignIn");
            }    
        }
        public IActionResult Index3()
        {
            var product = db.Products;
            return View("Index3", product);
        }
        [HttpGet]
        public JsonResult getDataCategory()
        {
            var lists = db.Categories;
            var a = JsonConvert.SerializeObject(lists);
            return Json(a);
        }

        [HttpPost]
        public void AddProduct(string IdCategory, string ProductName, string Quantity, string OriginalPrice, string Specifications, string ImageProduct, string Warranty)
        {
            try
            {
                       Product product = new Product();
                        product.idproduct = new Guid();
                        product.IdCategory = IdCategory;
                        product.ProductName = ProductName;
                        product.Quantity = int.Parse(Quantity);
                        product.OriginalPrice = decimal.Parse(OriginalPrice);
                        product.Rating =Rate.fiveStar;
                        product.Specifications = Specifications;
                        product.ImageProduct = Path.GetFileName(ImageProduct);
                        product.Warranty = int.Parse(Warranty);
                        db.Products.Add(product);
                        db.SaveChanges();

            }
            catch
            {
            }

        }
        [AllowAnonymous]
        public async Task<IActionResult> SignIn(LoginViewModel appUserModel)//còn lỗi
        {
            if (ModelState.IsValid)
            {
                var user = db.AppUsers.FirstOrDefault(x => x.Email == appUserModel.Email);
                var password = await _userManager.CheckPasswordAsync(user, appUserModel.Password);

                if (password)//true
                {
                    var result = await _signInManager.PasswordSignInAsync(user,
                    appUserModel.Password, appUserModel.RememberMe, false);
                    if (result.Succeeded)
                    {
                       /* await _signInManager.SignInAsync(user, isPersistent: appUserModel.RememberMe);*/
                        return RedirectToAction("Index", "Home");
                        
                    }
                }
            }
            ModelState.AddModelError("", "Không đăng nhập được. Kiểm tra lại!");
            return View("SignIn");
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
            public IActionResult Index2()
        {
            return View("Index2");
        }
    }
}
