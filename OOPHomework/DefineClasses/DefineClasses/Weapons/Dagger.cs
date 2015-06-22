namespace DefineClasses.Weapons
{
    using DefineClasses.Enums;
    using DefineClasses.Interfaces;
    
    public class Dagger 
    {
        public static Weapon Initialize()
        {
            Weapon dagger = new Weapon();

            dagger.Type = Type.Dagger;
            dagger.Damage = 30;
            dagger.Stamina = 12;
            dagger.Agility = 20;
            dagger.Intelligence = 10;
            dagger.Strength = 10;
            dagger.ItemQuality = ItemQuality.Common;
            dagger.RequiredLevel = 1;

            return dagger;
        }
    }
}
