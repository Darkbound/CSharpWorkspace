namespace DefineClasses2nd
{
    using DefineClasses2nd.Heroes;
    using DefineClasses2nd.Items.Weapon;
    using System;

    public class EntryPoint
    {
        static void Main()
        {
            HeroInitializer newHero = new HeroInitializer();

            Tank tank = newHero.CreateTank("Pesho");
            Fighter fighter = newHero.CreateFighter("Gosho");
            Sorcerer sorcerer = newHero.CreateSorcerer("Stanka");

        }
    }
}
