using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojogachi.Models;

namespace Dojogachi.Controllers     //be sure to use your own project's namespace!
{
    public class HomeController : Controller
    {

        Pet deadpool = new Pet();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpGet("feed")]
        public IActionResult Feed()
        {
            return RedirectToAction("index");
        }
        [HttpGet("play")]
        public IActionResult Play()
        {
            return RedirectToAction("index");
        }
        [HttpGet("work")]
        public IActionResult Work()
        {
            return RedirectToAction("index");
        }
        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            return RedirectToAction("index");
        }
    }
}