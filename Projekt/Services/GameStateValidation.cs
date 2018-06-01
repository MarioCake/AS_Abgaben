using System;
using System.Linq;
using CookiClickerEF.Models;
using CookiClickerEF.Context;

namespace Projekt.Services
{
    public class GameStateValidation
    {
        private CookieClickerContext context;

        public GameStateValidation()
        {
            this.context = new CookieClickerContext();
        }

        public bool AreUpgradesValid(GameState state)
        {
            var UpgradeIds = state.Id;

            if (UpgradeIds == 0) {
                
            }

            // this.context.Upgrades.Where((Upgrade upgrade) => UpgradeIds.Contains(upgrade.Id));

            return false;
        }
    }
}
