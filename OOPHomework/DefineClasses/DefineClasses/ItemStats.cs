using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
    public abstract class ItemStats 
    {
        public int Damage { get; set; }
        
        public int Armor { get; set; }

        public int Stamina { get; set; }

        public int Agility { get; set; }

        public int Intellect { get; set; }
    }
}
