﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class HealingPotion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; } //Sometimes is more then one 
        public int AmountToHeal { get; set; }

    }
}
