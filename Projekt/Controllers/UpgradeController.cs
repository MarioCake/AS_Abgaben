using System;
using Microsoft.AspNetCore.Mvc;
using CookiClickerEF.Models;
using CookiClickerEF.Context;

namespace Projekt.Controllers
{
    public class UpgradeController : BaseController
    {

        public UpgradeController(CookieClickerContext context) : base(context)
        {
        }

        public IActionResult Get()
        {
            // this.context.Add(upgrade);
            this._context.SaveChanges();

            return View();
        }

        public IActionResult Get(int upgradeId)
        {
            // this.context.Upgrade.First;
            return View();
        }
    }
}
