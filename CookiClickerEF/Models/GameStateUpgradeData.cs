using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CookiClickerEF.Models
{
    [Table("GameUpgrade")]
    public class GameStateUpgradeData
    {
        public int UpgradeId { get; set; }

        public int GameStateId { get; set; }

        public int Amount { get; set; }
        
        public GameStateData GameState { get; set; }
        
        public UpgradeData Upgrade { get; set; }
    }
}
