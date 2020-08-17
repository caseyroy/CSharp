using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


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
        public IActionResult Results(string name, string dojo, string language, string comment)
        {
            ViewBag.name = name;
            ViewBag.dojo = dojo;
            ViewBag.language = language;
            ViewBag.comment = comment;
            return View("results");
        }

    }
}