using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    [Route("Events")]
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Events API";
            return View();
        }
    }
}