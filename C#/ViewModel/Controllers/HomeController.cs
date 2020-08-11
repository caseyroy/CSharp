using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult MyMessage()
        {
            string myMessage = "This is my rifle. There are many like it, but this one is mine. My rifle is my best friend. It is my life. I must master it as I must master my life. My rifle, without me, is useless. Without my rifle, I am useless. I must fire my rifle true. I must shoot straighter than my enemy who is trying to kill me. I must shoot him before he shoots me. I will... My rifle and myself know that what counts in this war is not the rounds we fire, the noise of our burst, nor the smoke we make. We know that it is the hits that count. We will hit... My rifle is human, even as I, because it is my life. Thus, I will learn it as a brother. I will learn its weaknesses, its strength, its parts, its accessories, its sights and its barrel. I will ever guard it against the ravages of weather and damage as I will ever guard my legs, my arms, my eyes and my heart against damage. I will keep my rifle clean and ready. We will become part of each other. We will... Before God, I swear this creed. My rifle and myself are the defenders of my country. We are the masters of our enemy. We are the saviors of my life. So be it, until victory is America's and there is no enemy, but peace!";
            return View("index", myMessage);
        }
        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers =
            {
                1, 2, 3,10, 43, 5
            };
            return View("numbers", numbers);
        }
        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            User someUser = new User()
            {
                FirstName = "Jin",
                LastName = "Sakai"
            };
            return View("user", someUser);
        }
        // public IActionResult NameList()
        // {
        //     List<KeyValuePair<string, string>> namelist = new List<KeyValuePair<string, string>>()
        //     namelist.
        // }
    };
}