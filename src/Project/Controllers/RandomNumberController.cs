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
            //var randomNumber = _randomNumberGenerator.GetRandomNumber();
            ViewData["RandomNumber"] = _randomNumberGenerator.GetRandomNumber();
            return View();
        }
    }
}
