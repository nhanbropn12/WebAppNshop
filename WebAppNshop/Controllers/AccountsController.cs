using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nshopsolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//chưa inject các usermanage
namespace WebAppNshop.Controllers
{
    public class AccountsController : Controller
    {
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
        public async  Task<IActionResult> SignUp(AppUser appUserModel)
        {
            var user = new AppUser
            {
                Id = new Guid(),
                FirstName = appUserModel.FirstName,
                LastName = appUserModel.LastName,
                DateOfBirth=appUserModel.DateOfBirth,
                Address=appUserModel.Address,
                CardNumber=appUserModel.CardNumber,
                PasswordHash=appUserModel.PasswordHash
            };
            var result = await _userManager.CreateAsync(user, user.PasswordHash);
            if (result.Succeeded)
            {
                var SignIn = await _signInManager.PasswordSignInAsync(user, user.PasswordHash, false, false);
                if (SignIn.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
            }
            return View("SignUp");
        }
        [HttpGet]
        public IActionResult SignIn()
        {
            return View("SignIn");
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUser appUserModel)
        {
            var user = await _userManager.FindByNameAsync(appUserModel.UserName);
            if (user != null)
            {
                var signin = await _signInManager.PasswordSignInAsync(user, user.PasswordHash, false, false);
                if(signin.Succeeded)
                {
                  return  RedirectToAction("Index", "Home");
                }

            }
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
        public IActionResult Index3()
        {
            return View("Index3");
        }
    }
}
