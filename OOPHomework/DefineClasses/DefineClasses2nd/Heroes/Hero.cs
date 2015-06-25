namespace DefineClasses2nd.Heroes
{
    using DefineClasses2nd.Enums;
    using DefineClasses2nd.Items.Armor;
    using DefineClasses2nd.Items.Weapon;
    using System;

    public class Hero
    {
        public Hero(string name, Class klass, int health, int mana, int level, int strength, int agility, int intellect, bool isDead, bool isBlocking)
            : this(name, klass, health, mana, level, strength, agility, intellect, 0, 0, isDead, isBlocking, new Weapon(), new Helm(), new Chest(), new Hands(), new Legs(), new Feet())
        {

        }

        public Hero(string name, Class klass, int health, int mana, int level, int strength, int agility, int intellect, int damage, int damageBlock, bool isDead, bool isBlocking, Weapon weapon, Helm helm, Chest chest, Hands hands, Legs legs, Feet feet)
        {
            this.Name = name;
            this.Class = klass;
            this.Health = health;
            this.Mana = mana;
            this.Level = level;
            this.Strength = strength;
            this.Agility = agility;
            this.Intellect = intellect;
            this.IsDead = isDead;
            this.IsBlocking = isBlocking;
            this.Damage = damage;
            this.DamageBlock = damageBlock;
            this.Weapon = weapon;
            this.Helm = helm;
            this.Chest = chest;
            this.Hands = hands;
            this.Legs = legs;
            this.Feet = feet;
        }

        private int strength;
        private int agility;
        private int intellect;
        private Class heroClass;
        private Random rng;

        public PrimaryAttribute PrimaryAttribute { get; private set; }
        public Class Class
        {
            get
            {
                return heroClass;
            }
            protected set
            {
                heroClass = value;

                switch (heroClass)
                {
                    case Class.Tank:
                        PrimaryAttribute = PrimaryAttribute.Strength;
                        break;
                    case Class.Fighter:
                        PrimaryAttribute = PrimaryAttribute.Agility;
                        break;
                    case Class.Sorcerer:
                        PrimaryAttribute = PrimaryAttribute.Intellect;
                        break;
                    default:
                        break;
                }
            }
        }
        public Weapon Weapon { get; set; }
        public Helm Helm { get; set; }
        public Chest Chest { get; set; }
        public Hands Hands { get; set; }
        public Legs Legs { get; set; }
        public Feet Feet { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }
        public int Mana { get; set; }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                strength = value;
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
                agility = value;
            }
        }
        public int Intellect
        {
            get
            {
                return intellect;
            }
            set
            {
                intellect = value;
            }
        }
        public int Damage { get; set; }
        public int DamageBlock { get; set; }
        public bool IsDead { get; set; }
        public bool IsBlocking { get; set; }

        public void Attack(Hero hero)
        {
            int randomNumber = rng.Next();

            if (randomNumber % 3 == 0)
            {
                hero.Health = hero.Health - this.Damage * (Convert.ToInt32(hero.DamageBlock * 0.3));
            }
        }
    }
}
