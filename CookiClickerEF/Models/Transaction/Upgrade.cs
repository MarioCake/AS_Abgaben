using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models.Transaction
{
    public class Upgrade
    {
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

        public static explicit operator Upgrade(UpgradeData other)
        {
            if (other == null)
                return null;

            return new Upgrade()
            {
                Name = other.Name,
                FileName = other.FileName,
                ActiveAddition = other.ActiveAddition,
                PassiveAddition = other.PassiveAddition,
                Price = other.Price
            };
        }
    }
}
