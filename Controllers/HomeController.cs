//  AUTHOR:     Judy Nguyen and Megan Konvicka
//  COURSE:     ISTM 415
//  PROGRAM:    Narwhal Dental Web App
//  PURPOSE:    The home controller manages the HttpRequests received by the web server
//  HONOR CODE: On my honor, as an Aggie, I have neither given 
//              nor received unauthorized aid on this academic work.

using DTC_Dental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DTC_Dental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}