/// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
/// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 

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
    
    public class Hero
    {
        public PrimaryAttribute PrimaryAttribute { get; private set; }
        public Class Class 
        {
            get
            {
                return Class;
            }
            set
            {
                if (Class == Class.Tank)
                {
                    PrimaryAttribute = PrimaryAttribute.Strength;
                    IsBlocking = true;
                }
                else if (Class == Class.Fighter)
                {
                    PrimaryAttribute = PrimaryAttribute.Agility;
                    IsBlocking = false;
                    IsDodging = true;
                }
                else if (Class == Class.Sorcerer)
                {
                    PrimaryAttribute = PrimaryAttribute.Intelligence;
                    IsBlocking = false;
                    IsDodging = false;
                }
            }
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Mana { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public bool IsDead { get; set; }
        public bool IsBlocking { get; private set; }
        public bool IsDodging { get; private set; }

        public Hero()
        {

        }

        public Hero(Class heroClass, string name, int health)
        {
            this.Class = heroClass;
            this.Name = name;
            this.Health = health;
        }

        public Hero(Class heroClass, string name, int health, int level)
        {
            this.Class = heroClass;
            this.Name = name;
            this.Health = health;
            this.Level = level;
        }

        public Hero(Class heroClass, string name, int health, int level, bool isDead)
        {
            this.Class = heroClass;
            this.Name = name;
            this.Health = health;
            this.Level = level;
            this.IsDead = isDead;
        }
    }
}
