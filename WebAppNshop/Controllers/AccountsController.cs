﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNshop.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View("SignUp");
        }
        public IActionResult SignIn()
        {
            return View("SignIn");
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
