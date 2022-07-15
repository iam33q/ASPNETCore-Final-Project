using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace build.Controllers
{
    [Route("[controller]")]
    public class NavButtonController : Controller
    {
        private readonly ILogger<NavButtonController> _logger;

        public NavButtonController(ILogger<NavButtonController> logger)
        {
            _logger = logger;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        [HttpGet]
        public IActionResult Next(){
            return View("PropertyView");
        }
        public IActionResult Previous(){
            return View("PropertyView");
        }
    }
}