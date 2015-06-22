/// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
/// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 
namespace DefineClasses
{
    using DefineClasses.Enums;
    using System.Collections.Generic;
        
    public class Hero
    {
        private const int PRIMARY_ATTRIBUTE_MULTIPLIER = 2;

        public Weapon Weapon { get; set; }

        public Armor Armor { get; set; }

        public PrimaryAttribute PrimaryAttribute { get; set; }
        
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
            }
        }

        public string Name { get; set; }

        public int Health { get; set; }

        public int Level { get; set; }

        public int Mana { get; set; }

        public int Energy { get; set; }

        public int Rage { get; set; }

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
                    strength = value * PRIMARY_ATTRIBUTE_MULTIPLIER;
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
                    agility = value * PRIMARY_ATTRIBUTE_MULTIPLIER;
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
                    intelligence = (value) * PRIMARY_ATTRIBUTE_MULTIPLIER;
                }
                else
                {
                    intelligence = value;
                }
            }
        }

        public bool IsDead { get; set; }

        public bool IsBlocking { get; set; }

        public bool IsDodging { get; set; }

        public static void UpdateStats(Hero hero, Armor armor)
        {

        }
    }
}