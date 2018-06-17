using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models.Transaction
{
    public class GameState
    {
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("money")]
        public int Money { get; set; }

        [JsonProperty("upgrades")]
        public List<Upgrade> Upgrades { get; set; }


        public static explicit operator GameState(GameStateData other)
        {
            if (other == null)
                return null;

            return new GameState()
            {
                CreatedAt = other.CreatedAt,
                Money = other.Money,
                Upgrades = other.GameStateUpgrades.Select(model => model.Upgrade).ToList().ConvertAll(upgrade => (Upgrade)upgrade)
            };
        }
    }
}
