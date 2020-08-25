using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using LogReg.Models;

namespace LogReg.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost("Register")]

        public IActionResult Register(User RegisteredUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == RegisteredUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use, did you forget your Password?");
                    return Index();
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                RegisteredUser.Password = hasher.HashPassword(RegisteredUser, RegisteredUser.Password);

                _context.Add(RegisteredUser);
                _context.SaveChanges();

                HttpContext.Session.SetInt32("UserId", RegisteredUser.UserId);

                return RedirectToAction("Success");
            }
            else
            {
                return Index();
            }
        }
        [HttpGet("/Success")]

        public IActionResult Success()
        {
            int? uId = HttpContext.Session.GetInt32("UserId");
            if (uId == null)
            {
                return RedirectToAction("Index");
            }
            return View("Success");
        }
        [HttpPost("Login")]

        public IActionResult Login(LoggedUser LoginForm)
        {
            if (ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == LoginForm.LoggedEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LogEmail", "Invalid username/password");
                    return Index();
                }
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                var result = hasher.VerifyHashedPassword(userInDb, userInDb.Password, LoginForm.LoggedPass);

                if (result == 0)
                {
                    ModelState.AddModelError("LogEmail", "Invalid username/password");
                    return Index();
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Success");
            }
            else
            {
                return Index();
            }
        }


    }
}
