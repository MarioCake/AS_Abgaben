using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CookiClickerEF.Context;
using CookiClickerEF.Models;
using Microsoft.AspNetCore.Mvc;
using Projekt.Models;

namespace Projekt.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(CookieClickerContext context) : base(context) { }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SaveCookies(GameState state)
        {
            return View();
        }
    }
}
