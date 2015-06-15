namespace DefineClasses
{
    public class Initialize
    {
        public static void Tank(Hero hero, string name)
        {
            hero.Name = name;
            hero.Class = Class.Tank;
        }

        public static void Fighter(Hero hero, string name)
        {
            hero.Name = name;
            hero.Class = Class.Fighter;
        }

        public static void Sorcerer(Hero hero, string name)
        {
            hero.Name = name;
            hero.Class = Class.Sorcerer;
        }
    }
}
