using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;



namespace PortfolioOne.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View("index");
        }
        [HttpGet("projects")]
        public ViewResult Projects()
        {
            return View("projects");
        }
        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View("contact");
        }
    }

}

