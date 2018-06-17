using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models.Transaction
{
    public class Upgrade
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("activeAddition")]
        public int ActiveAddition { get; set; }

        [JsonProperty("passiveAddition")]
        public int PassiveAddition { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        public static explicit operator Upgrade(GameStateUpgradeData other)
        {
            if (other == null || other.Upgrade == null)
                return null;

            return new Upgrade()
            {
                Id = other.UpgradeId,
                Name = other.Upgrade.Name,
                FileName = other.Upgrade.FileName,
                ActiveAddition = other.Upgrade.ActiveAddition,
                PassiveAddition = other.Upgrade.PassiveAddition,
                Price = other.Upgrade.Price,
                Amount = other.Amount
            };
        }
    }
}
