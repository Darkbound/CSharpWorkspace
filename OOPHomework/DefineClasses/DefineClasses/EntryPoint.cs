

namespace DefineClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
    /// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 
    /// </summary>
    class EntryPoint
    {
        static void Main()
        {
            Hero hero = new Hero();
            Armor armor = new Armor();
            Weapon weapon = new Weapon(WeaponType.Dagger, ItemQuality.Epic, 10);

            hero.Class = Class.Fighter;
        }
    }
}
