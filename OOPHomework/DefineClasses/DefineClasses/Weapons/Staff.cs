namespace DefineClasses.Weapons
{
    using DefineClasses.Enums;
    using DefineClasses.Interfaces;

    public class Staff
    {
        public static Weapon Add()
        {
            Weapon staff = new Weapon();

            staff.Type = Type.Staff;
            staff.Damage = 50;
            staff.Stamina = 15;
            staff.Agility = 10;
            staff.Intelligence = 25;
            staff.Strength = 10;
            staff.ItemQuality = ItemQuality.Common;
            staff.RequiredLevel = 1;

            return staff;
        }


    }
}
