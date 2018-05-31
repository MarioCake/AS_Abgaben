using System;
using Microsoft.AspNetCore.Mvc;
using CookiClickerEF.Models;
using CookiClickerEF.Context;

namespace Projekt.Controllers
{
    public class UpgradeController : Controller
    {
        private CookiClickerContext context;

        public UpgradeController()
        {
            this.context = new CookiClickerContext();
        }

        public IActionResult Get()
        {
            this.context.Add(upgrade);
            this.context.SaveChanges();

            return View();
        }

        public IActionResult Get(int upgradeId)
        {
            this.context.Upgrade.First;
            return View();
        }
    }
}
