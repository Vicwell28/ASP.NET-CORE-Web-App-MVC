using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2_MVC.Models;

namespace WebApplication2_MVC.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contactos()
        {
            return View();
        }


        [HttpGet]
        public JsonResult GetDate()
        {
            DateTime date = DateTime.Now;
            return Json("{ \"Time\": \""+date+"\"}");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}