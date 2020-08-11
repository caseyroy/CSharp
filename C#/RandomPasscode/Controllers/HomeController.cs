using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("passcode") != null)
            {
                string password = HttpContext.Session.GetString("passcode");
                ViewBag.password = password;

                int? passesgenerated = HttpContext.Session.GetInt32("counter");
                ViewBag.counter = passesgenerated;
            }

            return View("index");
        }
        [HttpPost("generate")]
        public IActionResult generate()
        {
            Random rand = new Random();
            string pool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string pass = "";
            int counter = 0;
            while (pass.Length < 15)
            {
                pass += pool[rand.Next(0, 36)];
            }
            counter++;
            HttpContext.Session.SetString("passcode", pass);
            HttpContext.Session.SetInt32("counter", counter);

            return RedirectToAction("index");
        }

    }
}