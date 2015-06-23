/// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
/// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 
namespace DefineClasses
{
    using DefineClasses.Armors;
    using DefineClasses.Enums;
    using System.Collections.Generic;
        
    public class Hero
    {
        private const int PRIMARY_ATTRIBUTE_MULTIPLIER = 2;

        private int strength;
        private int agility;
        private int intelligence;
        private Class heroClass;
        private Weapon weapon;
        private Armor head;
        private Armor shoulders;
        private Armor chest;
        private Armor wrists;
        private Armor hands;
        private Armor belt;
        private Armor legs;
        private Armor feet;

        public Weapon Weapon 
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
                UpdateStatsOnItemAdd(weapon);
            }
        }
        public Armor Head 
        { 
            get
            {
                return head;
            }
            set
            {
                head = value;
                UpdateStatsOnItemAdd(head);
            }
        }
        public Armor Shoulders
        {
            get
            {
                return shoulders;
            }
            set
            {
                shoulders = value;
                UpdateStatsOnItemAdd(shoulders);
            }
        }
        public Armor Chest
        {
            get
            {
                return chest;
            }
            set
            {
                chest = value;
                UpdateStatsOnItemAdd(chest);
            }
        }
        public Armor Wrists
        {
            get
            {
                return wrists;
            }
            set
            {
                wrists = value;
                UpdateStatsOnItemAdd(wrists);
            }
        }
        public Armor Hands
        {
            get
            {
                return hands;
            }
            set
            {
                hands = value;
                UpdateStatsOnItemAdd(hands);
            }
        }
        public Armor Belt
        {
            get
            {
                return belt;
            }
            set
            {
                belt = value;
                UpdateStatsOnItemAdd(belt);
            }
        }
        public Armor Legs
        {
            get
            {
                return legs;
            }
            set
            {
                legs = value;
                UpdateStatsOnItemAdd(legs);
            }
        }
        public Armor Feet
        {
            get
            {
                return feet;
            }
            set
            {
                feet = value;
                UpdateStatsOnItemAdd(feet);
            }
        }

        public PrimaryAttribute PrimaryAttribute { get; set; }
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
                    strength = (strength + value) * PRIMARY_ATTRIBUTE_MULTIPLIER; 
                }
                else
                {
                    strength = value;
                }
            }
        }
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
                    agility = (agility + value) * PRIMARY_ATTRIBUTE_MULTIPLIER;
                }
                else
                {
                    agility = value;
                }
            }
        }       
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



        //possible to do it with events?
        public void UpdateStatsOnItemAdd(Armor armor)
        {
            Intelligence = (Intelligence / 2) + armor.Intelligence;
        }

        public void UpdateStatsOnItemAdd(Weapon weapon)
        {
            Intelligence = (Intelligence / 2) + weapon.Intelligence;
        }

        //need to check the primary attribute

        public void UpdateStatsOnItemRemove(Armor armor)
        {
            Intelligence = Intelligence + armor.Intelligence;
        }

        public void UpdateStatsOnItemRemove(Weapon weapon)
        {
            Intelligence = Intelligence + weapon.Intelligence;
        }
    }
}