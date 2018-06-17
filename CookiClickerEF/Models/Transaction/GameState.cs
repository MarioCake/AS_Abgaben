using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models.Transaction
{
    public class GameState
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("money")]
        public int Money { get; set; }

        [JsonProperty("upgrades")]
        public List<Upgrade> Upgrades { get; set; }

        [JsonProperty("clickAmount")]
        public int ClickAmount { get; set; }

        [JsonProperty("income")]
        public int Income { get; set; }


        public static explicit operator GameState(GameStateData other)
        {
            if (other == null)
                return null;

            GameState gs = new GameState()
            {
                Id = other.Id,
                CreatedAt = other.CreatedAt,
                Money = other.Money,
                Upgrades = other.GameStateUpgrades?.ConvertAll(upgrade => (Upgrade)upgrade).Where(upgrade => upgrade != null).ToList() ?? new List<Upgrade>()
            };

            gs.Income = gs.Upgrades.Select(upgrade => upgrade.PassiveAddition).DefaultIfEmpty(0).Sum();
            gs.ClickAmount = gs.Upgrades.Select(upgrade => upgrade.ActiveAddition).DefaultIfEmpty(1).Sum();

            return gs;
        }
    }
}
