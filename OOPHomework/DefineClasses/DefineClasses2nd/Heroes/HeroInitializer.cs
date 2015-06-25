namespace DefineClasses2nd.Heroes
{
    using DefineClasses2nd.Items.Armor;
    using DefineClasses2nd.Items.Weapon;

    public class HeroInitializer : HeroFactory
    {
        private static ArmorInitializer newArmor = new ArmorInitializer();
        private static WeaponInitializer newWeapon = new WeaponInitializer();

        // General Defaults
        private const int DEFAULT_CHARACTER_LEVEL = 1;
        private const bool DEFAULT_CHARACTER_ISDEAD = false;
       
        // Tank Defaults
        private static Weapon DEFAULT_TANK_WEAPON = newWeapon.GiveHammer();
        private static Helm DEFAULT_TANK_HELM = newArmor.TankHelm();
        private static Chest DEFAULT_TANK_CHEST = newArmor.TankChest();
        private static Hands DEFAULT_TANK_HANDS = newArmor.TankHands();
        private static Legs DEFAULT_TANK_LEGS = newArmor.TankLegs();
        private static Feet DEFAULT_TANK_FEET = newArmor.TankFeet();
        private int DEFAULT_TANK_DAMAGE = DEFAULT_TANK_WEAPON.Damage;
        private int DEFAULT_TANK_DAMAGEBLOCK = DEFAULT_TANK_HELM.DamageBlock + DEFAULT_TANK_CHEST.DamageBlock + DEFAULT_TANK_HANDS.DamageBlock + DEFAULT_TANK_LEGS.DamageBlock + DEFAULT_TANK_FEET.DamageBlock;
        private const int DEFAULT_TANK_HEALTH = 100;
        private const int DEFAULT_TANK_MANA = 100;
        private const int DEFAULT_TANK_STRENGTH = 10;
        private const int DEFAULT_TANK_AGILITY = 10;
        private const int DEFAULT_TANK_INTELLIGENCE = 10;
        private const bool DEFAULT_TANK_ISBLOCKING = true;

        // Fighter Defaults
        private static Weapon DEFAULT_FIGHTER_WEAPON = newWeapon.GiveSword();
        private static Helm DEFAULT_FIGHTER_HELM = newArmor.FighterHelm();
        private static Chest DEFAULT_FIGHTER_CHEST = newArmor.FighterChest();
        private static Hands DEFAULT_FIGHTER_HANDS = newArmor.FighterHands();
        private static Legs DEFAULT_FIGHTER_LEGS = newArmor.FighterLegs();
        private static Feet DEFAULT_FIGHTER_FEET = newArmor.FighterFeet();
        private int DEFAULT_FIGHTER_DAMAGE = DEFAULT_FIGHTER_WEAPON.Damage;
        private int DEFAULT_FIGHTER_DAMAGEBLOCK = DEFAULT_FIGHTER_HELM.DamageBlock + DEFAULT_FIGHTER_CHEST.DamageBlock + DEFAULT_FIGHTER_HANDS.DamageBlock + DEFAULT_FIGHTER_LEGS.DamageBlock + DEFAULT_FIGHTER_FEET.DamageBlock;
        private const int DEFAULT_FIGHTER_HEALTH = 100;
        private const int DEFAULT_FIGHTER_MANA = 100;
        private const int DEFAULT_FIGHTER_STRENGTH = 10;
        private const int DEFAULT_FIGHTER_AGILITY = 10;
        private const int DEFAULT_FIGHTER_INTELLIGENCE = 10;
        private const bool DEFAULT_FIGHTER_ISBLOCKING = false;

        // Sorcerer Defaults
        private static Weapon DEFAULT_SORCERER_WEAPON = newWeapon.GiveStaff();
        private static Helm DEFAULT_SORCERER_HELM = newArmor.SorcererHelm();
        private static Chest DEFAULT_SORCERER_CHEST = newArmor.SorcererChest();
        private static Hands DEFAULT_SORCERER_HANDS = newArmor.SorcererHands();
        private static Legs DEFAULT_SORCERER_LEGS = newArmor.SorcererLegs();
        private static Feet DEFAULT_SORCERER_FEET = newArmor.SorcererFeet();
        private int DEFAULT_SORCERER_DAMAGE = DEFAULT_SORCERER_WEAPON.Damage;
        private int DEFAULT_SORCERER_DAMAGEBLOCK = DEFAULT_SORCERER_HELM.DamageBlock + DEFAULT_SORCERER_CHEST.DamageBlock + DEFAULT_SORCERER_HANDS.DamageBlock + DEFAULT_SORCERER_LEGS.DamageBlock + DEFAULT_SORCERER_FEET.DamageBlock;
        private const int DEFAULT_SORCERER_HEALTH = 100;
        private const int DEFAULT_SORCERER_MANA = 100;
        private const int DEFAULT_SORCERER_STRENGTH = 10;
        private const int DEFAULT_SORCERER_AGILITY = 10;
        private const int DEFAULT_SORCERER_INTELLIGENCE = 10;
        private const bool DEFAULT_SORCERER_ISBLOCKING = false;

        public override Tank CreateTank(string name)
        {
            return new Tank(name, DEFAULT_TANK_HEALTH, DEFAULT_TANK_MANA, DEFAULT_CHARACTER_LEVEL, DEFAULT_TANK_STRENGTH, DEFAULT_TANK_AGILITY, DEFAULT_TANK_INTELLIGENCE,
                DEFAULT_TANK_DAMAGE, DEFAULT_TANK_DAMAGEBLOCK, DEFAULT_CHARACTER_ISDEAD, DEFAULT_TANK_ISBLOCKING, DEFAULT_TANK_WEAPON, DEFAULT_TANK_HELM, 
                DEFAULT_TANK_CHEST, DEFAULT_TANK_HANDS, DEFAULT_TANK_LEGS, DEFAULT_TANK_FEET);
        }

        public override Fighter CreateFighter(string name)
        {
            return new Fighter(name, DEFAULT_FIGHTER_HEALTH, DEFAULT_FIGHTER_MANA, DEFAULT_CHARACTER_LEVEL, DEFAULT_FIGHTER_STRENGTH, DEFAULT_FIGHTER_AGILITY, DEFAULT_FIGHTER_INTELLIGENCE,
                DEFAULT_FIGHTER_DAMAGE, DEFAULT_FIGHTER_DAMAGEBLOCK, DEFAULT_CHARACTER_ISDEAD, DEFAULT_FIGHTER_ISBLOCKING, DEFAULT_FIGHTER_WEAPON, DEFAULT_FIGHTER_HELM, 
                DEFAULT_FIGHTER_CHEST, DEFAULT_FIGHTER_HANDS, DEFAULT_FIGHTER_LEGS, DEFAULT_FIGHTER_FEET);
        }

        public override Sorcerer CreateSorcerer(string name)
        {
            return new Sorcerer(name, DEFAULT_SORCERER_HEALTH, DEFAULT_SORCERER_MANA, DEFAULT_CHARACTER_LEVEL, DEFAULT_SORCERER_STRENGTH, DEFAULT_SORCERER_AGILITY, DEFAULT_SORCERER_INTELLIGENCE, 
                DEFAULT_SORCERER_DAMAGE, DEFAULT_SORCERER_DAMAGEBLOCK, DEFAULT_CHARACTER_ISDEAD, DEFAULT_SORCERER_ISBLOCKING, DEFAULT_SORCERER_WEAPON, DEFAULT_SORCERER_HELM, 
                DEFAULT_SORCERER_CHEST, DEFAULT_SORCERER_HANDS, DEFAULT_SORCERER_LEGS, DEFAULT_SORCERER_FEET);
        }
    }
}
