using System;
using System.Linq;
using CookiClickerEF.Models;
using CookiClickerEF.Context;
using Projekt.Controllers;
using CookiClickerEF.Models.Transaction;

namespace Projekt.Services
{
    public class GameStateValidation
    {
        protected readonly CookieClickerContext _context;

        public GameStateValidation(CookieClickerContext context)
        {
            this._context = context;
        }

        public bool AreUpgradesValid(GameState state)
        {
            //var UpgradeIds = state.Id;

            //if (UpgradeIds == 0) {
                
            //}

            // this.context.Upgrades.Where((Upgrade upgrade) => UpgradeIds.Contains(upgrade.Id));

            return true;
        }
    }
}
