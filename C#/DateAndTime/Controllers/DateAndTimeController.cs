using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace DateAndTime
{
    public class DateAndTime : Controller
    {
        [HttpGet("")]
        public DateTime TimeAndDate()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime;
        }
    }
}