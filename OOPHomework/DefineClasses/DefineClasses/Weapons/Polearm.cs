namespace DefineClasses.Weapons
{
    using DefineClasses.Enums;
    using DefineClasses.Interfaces;

    public class Polearm
    {
        public static Weapon Initialize()
        {
            Weapon polearm = new Weapon();

            polearm.Type = Type.Polearm;
            polearm.Damage = 65;
            polearm.Stamina = 15;
            polearm.Agility = 10;
            polearm.Intelligence = 10;
            polearm.Strength = 20;
            polearm.ItemQuality = ItemQuality.Common;
            polearm.RequiredLevel = 1;

            return polearm;
        }
    }
}
