using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiClickerEF.Models
{
    [Table("Upgrade")]
    public class UpgradeData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string FileName { get; set; }

        public int ActiveAddition { get; set; }

        public int PassiveAddition { get; set; }
        
        public int Price { get; set; }

        public int? DependencyId { get; set; }

        [ForeignKey(nameof(DependencyId))]
        public UpgradeData Dependency { get; set; }
        
        public List<GameStateUpgradeData> GameStateUpgrades { get; set; }
        
    }
}
