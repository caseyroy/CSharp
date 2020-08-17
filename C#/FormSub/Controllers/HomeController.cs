using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using FormSub.Models;


namespace FormSub.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost("results")]
        public IActionResult Results(User newUser)
        {
            return View("results", newUser);
        }

    }
}