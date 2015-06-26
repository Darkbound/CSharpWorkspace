namespace DefineClasses2nd
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using DefineClasses2nd.Heroes;
    using DefineClasses2nd.Items.Weapon;

    public class EntryPoint
    {
        public static Random rng = new Random();

        public static void Main()
        {
            bool isGameOver = false;

            HeroInitializer newHero = new HeroInitializer();

            Tank tank = newHero.CreateTank("Pesho");
            Fighter fighter = newHero.CreateFighter("Gosho");
            Sorcerer sorcerer = newHero.CreateSorcerer("Stanka");

            Hero attackingHero = new Hero();
            Hero defendingHero = new Hero();

            List<Hero> heroes = new List<Hero>()
            {
                tank,
                fighter,
                sorcerer
            };
                       
            while (!isGameOver)
            {
                attackingHero = heroes[rng.Next(0, heroes.Count)];
                heroes.Remove(attackingHero);
                defendingHero = heroes[rng.Next(0, heroes.Count)];
                attackingHero.Attack(defendingHero);
                
                if (defendingHero.IsDead == true)
                {
                    heroes.Remove(defendingHero);
                }
           
                if (heroes.Count == 0)
                {
                    isGameOver = true;
                }
           
                heroes.Add(attackingHero);
           
                Console.WriteLine();
                Thread.Sleep(200);
            }
           
            Console.WriteLine("{0} won!", heroes[0].Name);
        }
    }
}
