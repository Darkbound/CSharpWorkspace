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

            sorcerer.Class = Class.Sorcerer;
            sorcerer.PrimaryAttribute = PrimaryAttribute.Intelligence;
            sorcerer.Health = DEFAULT_SORCERER_HEALTH;
            sorcerer.Mana = DEFAULT_SORCERER_MANA;
            sorcerer.Strength = DEFAULT_SORCERER_STRENGTH;
            sorcerer.Agility = DEFAULT_SORCERER_AGILITY;
            sorcerer.Intelligence = DEFAULT_SORCERER_INTELLIGENCE;
            sorcerer.IsDead = false;
            sorcerer.IsBlocking = false;
            sorcerer.IsDodging = false;

            sorcerer.Weapon = Staff.Add(sorcerer);
            sorcerer.Head = Head.Initialize();
            sorcerer.Shoulders = Shoulders.Initialize();
            sorcerer.Chest = Chest.Initialize();
            sorcerer.Wrists = Wrists.Initialize();
            sorcerer.Hands = Hands.Initialize();
            sorcerer.Belt = Belt.Initialize();
            sorcerer.Legs = Legs.Initialize();
            sorcerer.Feet = Feet.Initialize();

            return sorcerer;
        }
    }
}
