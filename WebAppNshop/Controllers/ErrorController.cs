using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppNshop.Controllers
{
    public class ErrorController : Controller
    {
        [Route("ErrorPage/{statuscode}")]
        public IActionResult Index(int statuscode)
        {
            switch (statuscode)
            {
                case 404:
                    ViewData["error"] = "Page not found";
                    break;
                default:
                    break;
            }
            return View("ErrorPage");
        }
    }
}
