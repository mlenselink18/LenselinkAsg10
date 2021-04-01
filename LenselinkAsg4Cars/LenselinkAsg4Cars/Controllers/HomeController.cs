using LenselinkAsg4Cars.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LenselinkAsg4Cars.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }
    }
}
