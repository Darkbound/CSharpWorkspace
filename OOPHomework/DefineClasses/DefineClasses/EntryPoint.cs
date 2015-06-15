namespace DefineClasses
{
    /// <summary>
    /// Define a class Hero that holds information about your character: name, health, level, mana, strength, agility, 
    /// intelligence, primaryAttribute (as an enumeration, one of the previous 3), isBlocking, isDead, class (Sorcerer, Fighter, Tank), 
    /// </summary>
    class EntryPoint
    {
        static void Main()
        {
            Hero pesho = new Hero();
            Initialize.Tank(pesho, "Pesho");
            Weapon weapon = new Weapon();

        }
    }
}
