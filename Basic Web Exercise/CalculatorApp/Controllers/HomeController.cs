using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator); // works without passing calculator WHY???
        }

        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            if (calculator.Operator == "/" && calculator.RightOperand == 0m)
            {
                TempData["ErrorMsg"] = "Dividing by 0 is not allowed!";
            }
            else
            {
                calculator.CalculateResult();
                DataStorage.Calculations.Add(calculator);
            }

            return RedirectToAction("Index", calculator);
        }

        public IActionResult History()
        {
            return View(DataStorage.Calculations);
        }

    }
}
