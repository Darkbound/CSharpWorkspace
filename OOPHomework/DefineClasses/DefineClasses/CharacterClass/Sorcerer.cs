namespace DefineClasses.CharacterClass
{
    using DefineClasses;
    using DefineClasses.Armors;
    using DefineClasses.Enums;
    using DefineClasses.Weapons;

    public class Sorcerer
    {
        public static Hero Initialize()
        {
            Hero sorcerer = new Hero();

            //sorcerer.Armor = Head.Initialize();
            
            //sorcerer.Armor = Shoulders.Initialize();
            //sorcerer.Armor = Chest.Initialize();
            //sorcerer.Armor = Wrists.Initialize();
            //sorcerer.Armor = Hands.Initialize();
            //sorcerer.Armor;
            //sorcerer.Armor = Legs.Initialize();
            //sorcerer.Armor = Feet.Initialize();

            sorcerer.Weapon = Staff.Add();
            
            
            sorcerer.Class = Class.Sorcerer;
            sorcerer.PrimaryAttribute = PrimaryAttribute.Intelligence;
            sorcerer.Health = 100;
            sorcerer.Mana = 100;
            sorcerer.Strength = 10;
            sorcerer.Agility = 10;
            sorcerer.Intelligence = 10;
            sorcerer.IsDead = false;
            sorcerer.IsBlocking = false;
            sorcerer.IsDodging = false;

            sorcerer.Intelligence = 10 + sorcerer.Weapon.Intelligence;

            return sorcerer;
        }
    }
}
