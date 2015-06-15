//Define a class Hero that holds information about your character: name, health, level, mana, 
//strength, agility, intelligence, primaryAttribute (as an enumeration, one of the previous 3),
//isBlocking, isDead, class (Sorcerer, Fighter, Tank), Weapon (class) and Armor(class).

namespace DefineClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public enum PrimaryAttribute
    {
        Strength,
        Agility,
        Intelligence
    }

    public enum Class
    {
        Tank,
        Fighter,
        Sorcerer
    }

    public class Character
    {
        

        public PrimaryAttribute PrimaryAttribute;

        public Class Class;

        public string Name { get; set; }

        public int Health { get; set; }

        public int Level { get; set; }

        public int Mana { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Intelligence { get; set; }

        public bool IsBlocking { get; set; }

        public bool IsDead { get; set; }

        
    }
}
