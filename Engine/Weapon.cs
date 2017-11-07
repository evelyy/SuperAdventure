﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon
    {
        public int ID { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
    }
}
