using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;


namespace DateAndTime
{
    public class DateAndTime : Controller
    {
        [HttpGet("")]
        public IActionResult TimeAndDate()
        {
            DateTime currentTime = new DateTime();
            currentTime = DateTime.Now;
            currentTime.ToString("F");
            ViewBag.Time = currentTime;
            return View("index");
        }
        // public IActionResult TimePage()
        // {
        //     ViewBag.Time = currentTime;
        //     return View("index");
        // }
    }
}