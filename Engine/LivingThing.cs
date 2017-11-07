using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingThing
    {
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public LivingThing(int currentHitPoints, int maxHitPoints)
        {
            CurrentHitPoints = currentHitPoints;
            MaxHitPoints = maxHitPoints;
        }
    }
}
