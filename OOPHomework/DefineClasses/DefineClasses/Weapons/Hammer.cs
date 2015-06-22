namespace DefineClasses.Weapons
{
    using DefineClasses.Enums;
    using DefineClasses.Interfaces;

    public class Hammer 
    {
        public static Weapon Initialize()
        {
            Weapon hammer = new Weapon();

            hammer.Type = Type.Hammer;
            hammer.Damage = 60;
            hammer.Stamina = 18;
            hammer.Agility = 15;
            hammer.Intelligence = 10;
            hammer.Strength = 13;
            hammer.ItemQuality = ItemQuality.Common;
            hammer.RequiredLevel = 1;

            return hammer;
        }
    }
}
