namespace DefineClasses2nd.Heroes
{
    public abstract class HeroFactory
    {
        public abstract Tank CreateTank(string name);
        public abstract Fighter CreateFighter(string name);
        public abstract Sorcerer CreateSorcerer(string name);
    }
}
