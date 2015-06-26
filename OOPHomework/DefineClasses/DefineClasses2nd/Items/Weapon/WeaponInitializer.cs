namespace DefineClasses2nd.Items.Weapon
{
    using DefineClasses2nd.Enums;

    public class WeaponInitializer : WeaponFactory
    {
        private const ItemQuality DEFAULT_WEAPON_QUALITY = ItemQuality.Uncommon;

        // Sword defaults
        private const int DEFAULT_SWORD_DAMAGE = 50;

        // Hammer defaults
        private const int DEFAULT_HAMMER_DAMAGE = 40;

        // Staff defaults
        private const int DEFAULT_STAFF_DAMAGE = 65;

        public override Sword GiveSword()
        {
            return new Sword(DEFAULT_SWORD_DAMAGE, DEFAULT_WEAPON_QUALITY);
        }

        public override Hammer GiveHammer()
        {
            return new Hammer(DEFAULT_HAMMER_DAMAGE, DEFAULT_WEAPON_QUALITY);
        }

        public override Staff GiveStaff()
        {
            return new Staff(DEFAULT_STAFF_DAMAGE, DEFAULT_WEAPON_QUALITY);
        }
    }
}
