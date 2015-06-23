namespace DefineClasses.CharacterClass
{
    using DefineClasses;
    using DefineClasses.Armors;
    using DefineClasses.Enums;
    using DefineClasses.Weapons;
    using System.Collections.Generic;

    public class Sorcerer
    {
        private const int DEFAULT_SORCERER_STRENGTH = 10;
        private const int DEFAULT_SORCERER_AGILITY = 10;
        private const int DEFAULT_SORCERER_INTELLIGENCE = 10;
        private const int DEFAULT_SORCERER_HEALTH = 10;
        private const int DEFAULT_SORCERER_MANA = 10;


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

            sorcerer.Head = Head.Initialize();
            sorcerer.Shoulders = Shoulders.Initialize();
            sorcerer.Chest = Chest.Initialize();
            sorcerer.Wrists = Wrists.Initialize();
            sorcerer.Hands = Hands.Initialize();
            sorcerer.Belt = Belt.Initialize();
            sorcerer.Legs = Legs.Initialize();
            sorcerer.Feet = Feet.Initialize();

            sorcerer.Class = Class.Sorcerer;
            sorcerer.PrimaryAttribute = PrimaryAttribute.Intelligence;
            sorcerer.Health = DEFAULT_SORCERER_HEALTH;
            sorcerer.Mana = DEFAULT_SORCERER_MANA;

            sorcerer.Strength = DEFAULT_SORCERER_STRENGTH + sorcerer.Weapon.Strength + sorcerer.Head.Strength + sorcerer.Shoulders.Strength + 
                sorcerer.Chest.Strength + sorcerer.Wrists.Strength + sorcerer.Hands.Strength + sorcerer.Belt.Strength + 
                sorcerer.Legs.Strength + sorcerer.Feet.Strength;

            sorcerer.Agility = DEFAULT_SORCERER_AGILITY + sorcerer.Weapon.Agility + sorcerer.Head.Agility + sorcerer.Shoulders.Agility + 
                sorcerer.Chest.Agility + sorcerer.Wrists.Agility + sorcerer.Hands.Agility + sorcerer.Belt.Agility + 
                sorcerer.Legs.Agility + sorcerer.Feet.Agility;

            sorcerer.Intelligence = DEFAULT_SORCERER_INTELLIGENCE + sorcerer.Weapon.Intelligence + sorcerer.Head.Intelligence + sorcerer.Shoulders.Intelligence + 
                sorcerer.Chest.Intelligence + sorcerer.Wrists.Intelligence + sorcerer.Hands.Intelligence + sorcerer.Belt.Intelligence + 
                sorcerer.Legs.Intelligence + sorcerer.Feet.Intelligence; 

            sorcerer.IsDead = false;
            sorcerer.IsBlocking = false;
            sorcerer.IsDodging = false;


            return sorcerer;
        }
    }
}
