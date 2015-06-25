namespace DefineClasses2nd.Items.Weapon
{
    public abstract class WeaponFactory
    {
        public abstract Sword GiveSword();
        public abstract Hammer GiveHammer();
        public abstract Staff GiveStaff();
    }
}
