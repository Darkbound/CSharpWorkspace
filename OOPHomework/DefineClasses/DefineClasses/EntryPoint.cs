namespace DefineClasses
{
    using DefineClasses.Enums;
    using DefineClasses.CharacterClass;
    /// <summary>
    /// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
    /// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 
    /// </summary>
    class EntryPoint
    {
        static void Main()
        {
            Hero pesho = Sorcerer.Initialize();

            System.Console.WriteLine(pesho.Class);
            System.Console.WriteLine(pesho.Strength);
            System.Console.WriteLine(pesho.Agility);
            System.Console.WriteLine(pesho.Intelligence);
            System.Console.WriteLine(pesho.Weapon.Type);
            System.Console.WriteLine(pesho.Weapon.Intelligence);

            System.Console.WriteLine(pesho.Intelligence);
       }
    }
}
