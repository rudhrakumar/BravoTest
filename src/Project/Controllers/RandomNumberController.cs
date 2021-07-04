using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("RandomNumber")]
    public class RandomNumberController : Controller
    {
        private IRandomNumberGenerator _randomNumberGenerator;
        public RandomNumberController(IRandomNumberGenerator randomNumberGenerator)
        {
            _randomNumberGenerator = randomNumberGenerator;
        }
        public IActionResult Index()
        {
            ViewData["RandomNumber"] = _randomNumberGenerator.GetRandomNumber();
            ViewBag.Title = "Random Number Generator";
            return View();
        }
    }
}
