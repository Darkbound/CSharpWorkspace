namespace DefineClasses2nd.Heroes
{
    using System;
    using DefineClasses2nd.Enums;
    using DefineClasses2nd.Items.Armor;
    using DefineClasses2nd.Items.Weapon;

    public class Hero
    {
        private int strength;
        private int agility;
        private int intellect;
        private double damage;
        private bool isBlocking;
        private bool blockedLastTurn;
        private Class heroClass;

        public Hero()
        {
        }

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

        public PrimaryAttribute PrimaryAttribute { get; private set; }

        public Class Class
        {
            get
            {
                return this.heroClass;
            }

            protected set
            {
                this.heroClass = value;

                switch (this.heroClass)
                {
                    case Class.Tank:
                        this.PrimaryAttribute = PrimaryAttribute.Strength;
                        break;
                    case Class.Fighter:
                        this.PrimaryAttribute = PrimaryAttribute.Agility;
                        break;
                    case Class.Sorcerer:
                        this.PrimaryAttribute = PrimaryAttribute.Intellect;
                        break;
                    default:
                        break;
                }
            }
        }

        public Weapon Weapon { get; protected set; }

        public Helm Helm { get; protected set; }

        public Chest Chest { get; protected set; }

        public Hands Hands { get; protected set; }

        public Legs Legs { get; protected set; }

        public Feet Feet { get; protected set; }

        public string Name { get; set; }

        public double Health { get; protected set; }

        public int Level { get; protected set; }

        public int Mana { get; protected set; }

        public int Strength
        {
            get
            {
                return this.strength;
            }

            protected set
            {
                this.strength = value;

                if (this.PrimaryAttribute == PrimaryAttribute.Strength)
                {
                    this.strength = this.strength * 2;
                }
            }
        }

        public int Agility
        {
            get
            {
                return this.agility;
            }

            protected set
            {
                this.agility = value;

                if (this.PrimaryAttribute == PrimaryAttribute.Agility)
                {
                    this.agility = this.agility * 2;
                }
            }
        }

        public int Intellect
        {
            get
            {
                return this.intellect;
            }

            protected set
            {
                this.intellect = value;

                if (this.PrimaryAttribute == PrimaryAttribute.Intellect)
                {
                    this.intellect = this.intellect * 2;
                }
            }
        }

        public double Damage 
        { 
            get
            {
                return this.damage;
            }

            protected set
            {
                this.damage = value;

                if (this.PrimaryAttribute == PrimaryAttribute.Strength)
                {
                    this.damage = this.damage + (this.strength / 2);
                }
                else if (this.PrimaryAttribute == PrimaryAttribute.Agility)
                {
                    this.damage = this.damage + (this.agility / 2);
                }
                else if (this.PrimaryAttribute == PrimaryAttribute.Intellect)
                {
                    this.damage = this.damage + (this.intellect / 2);
                }
            }
        }

        public int DamageBlock { get; protected set; }

        public bool IsDead { get; protected set; }

        public bool IsBlocking 
        { 
            get
            {
                return this.isBlocking;
            }

            protected set
            {
                this.isBlocking = value;
            }
        }

        public void Attack(Hero hero)
        {
            int randomNumber = EntryPoint.rng.Next();

            if (hero.blockedLastTurn == true)
            {
                hero.Damage = hero.Damage * 1.4285; // restoring the original dmg (almost, rounding problems)
                hero.DamageBlock = hero.DamageBlock / 2;
                hero.blockedLastTurn = false;
                Console.WriteLine("{0} damage is restored to {1, 2}!", hero.Name, hero.Damage);
            }
            
            if (randomNumber % 3 == 0)
            {
                hero.Block();
            }
            else
            {
                hero.IsBlocking = false;
            }

            hero.Health = hero.Health - this.Damage + hero.DamageBlock;

            if (hero.Health < 0)
            {
                hero.IsDead = true;
            }

            Console.WriteLine("{0} attacked {1} for {2} Damage! {1}'s damageblock reduced it to {3}!", this.Name, hero.Name, this.Damage, this.Damage - hero.DamageBlock);
            Console.WriteLine("{0} now has {1} Health!", hero.Name, hero.Health);
        }

        public void Block()
        {
            this.isBlocking = true;

            if (this.isBlocking == true)
            {
                this.DamageBlock = this.DamageBlock * 2;
                this.Damage = this.Damage * 0.7;
                this.isBlocking = false;
                this.blockedLastTurn = true;
            }

            Console.WriteLine("{0} Blocked! Block increased {0}'s damageblock to {1}! \n{0}'s damage is reduced to {2}!", this.Name, this.DamageBlock, this.Damage);
        }
    }
}
