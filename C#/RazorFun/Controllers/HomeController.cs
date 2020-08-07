using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace RazorFun
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("index");
        }
    }
}
