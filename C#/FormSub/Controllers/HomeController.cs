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
            if (ModelState.IsValid)
            {
                return View("results", newUser);
            }
            else
            {
                return View("index");
            }
        }

    }
}