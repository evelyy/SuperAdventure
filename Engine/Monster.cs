using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster
    {
        public int ID { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaxDamage { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public string Name { get; set; }
    }
}
