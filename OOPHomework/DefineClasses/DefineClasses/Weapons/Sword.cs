namespace DefineClasses.Weapons
{
    using DefineClasses.Enums;
    using DefineClasses.Interfaces;

    public class Sword
    {
        public static Weapon Initialize()
        {
            Weapon sword = new Weapon();

            sword.Type = Type.Sword;
            sword.Damage = 40;
            sword.Stamina = 10;
            sword.Agility = 15;
            sword.Intelligence = 10;
            sword.Strength = 10;
            sword.ItemQuality = ItemQuality.Common;
            sword.RequiredLevel = 1;

            return sword;
        }
    }
}
