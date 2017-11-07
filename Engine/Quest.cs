using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public int RewardXP { get; set; }
        public int RewardGold { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public Item RewardItem { get; set; }

        public List<QuestCompletionItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string desc, int rewardXP, int rewardGold)
        {
            ID = id;
            Name = name;
            Desc = desc;
            RewardXP = rewardXP;
            RewardGold = rewardGold;

            QuestCompletionItems = new List<QuestCompletionItem>();

        }
    }
}
