using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "C# Technical Test";
            return View();
        }
    }
}