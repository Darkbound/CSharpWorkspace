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
        Fighter,
        Tank,
        Sorcerer
    }
    
    public class Hero
    {
        public PrimaryAttribute PrimaryAttribute {get; private set;}

        private Class heroClass;
        public Class Class
        {
            get
            {
                return heroClass;
            }
            set
            {
                heroClass = value;
                SetDefaultClassSettings();
            }
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Level { get; set; }

        public int Mana { get; set; }

        private int strength;
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                if (PrimaryAttribute == PrimaryAttribute.Strength)
                {
                    strength = value * 2;
                }
                else
                {
                    strength = value;
                }
            }
        }
        private int agility;
        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                if (PrimaryAttribute == PrimaryAttribute.Agility)
                {
                    agility = value * 2;
                }
                else
                {
                    agility = value;
                }
            }
        }       
        
        private int intelligence;
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                if (PrimaryAttribute == PrimaryAttribute.Intelligence)
                {
                    intelligence = value * 2;
                }
                else
                {
                    intelligence = value;
                }
            }
        }

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

        private void SetDefaultClassSettings()
        {
            if (Class == Class.Tank)
            {
                PrimaryAttribute = PrimaryAttribute.Strength;
                IsBlocking = true;
                IsDodging = true;
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
}
