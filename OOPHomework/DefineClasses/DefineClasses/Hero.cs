/// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
/// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 
namespace DefineClasses
{
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
        private const int PRIMARY_ATTRIBUTE_MULTIPLIER = 2;

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
                    intelligence = value * PRIMARY_ATTRIBUTE_MULTIPLIER;
                }
                else
                {
                    intelligence = value;
                }
            }
        }

        public bool IsDead { get; private set; }

        public bool IsBlocking { get; private set; }

        public bool IsDodging { get; private set; }

        private void SetDefaultClassSettings()
        {
            if (Class == Class.Tank)
            {
                PrimaryAttribute = PrimaryAttribute.Strength;
                Rage = 100;
                IsBlocking = true;
                IsDodging = true;
            }
            else if (Class == Class.Fighter)
            {
                PrimaryAttribute = PrimaryAttribute.Agility;
                Energy = 100;
                IsBlocking = false;
                IsDodging = true;
            }
            else if (Class == Class.Sorcerer)
            {
                PrimaryAttribute = PrimaryAttribute.Intelligence;
                Mana = 100;
                IsBlocking = false;
                IsDodging = false;
            }

            Health = 100;
            Strength = 10;
            Agility = 10;
            Intelligence = 10;
            IsDead = false;
        }
    }
}