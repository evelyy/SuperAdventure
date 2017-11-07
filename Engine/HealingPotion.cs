using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {
        public int AmountHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int amountHeal) : base(id,name, namePlural)
        {
            AmountHeal = amountHeal;
        }
    }
}
