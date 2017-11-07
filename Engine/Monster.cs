using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingThing
    {
        public int ID { get; set; }
        public int MaxDamage { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public string Name { get; set; }
        public List<LootItem> LootTable { get; set; }

        public Monster(int id, string name, int maxDamage, int rewardXP, int rewardGold, int currentHitPoints, int maxHitPoints) : base(currentHitPoints, maxHitPoints)
        {
            ID = id;
            Name = name;
            MaxDamage = maxDamage;
            RewardXP = rewardXP;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
