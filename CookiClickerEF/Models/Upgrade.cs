using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiClickerEF.Models
{
    [Table(nameof(Upgrade))]
    public class Upgrade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int? UpgradeDependencyId { get; set; }

        [ForeignKey(nameof(UpgradeDependencyId))]
        public Upgrade UpgradeDependency { get; set; }
        
        public List<GameStateUpgrade> GameStateUpgrades { get; set; }
        
    }
}
