using Microsoft.AspNetCore.Mvc;
using IS_413.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS_413.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]

        public IActionResult GradeCalculator()
        {
            return View();
        }

        [HttpPost]

        public IActionResult GradeCalculator(GradeCalculatorModel model)
        {
            return View();
        }


    }
}
