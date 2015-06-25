namespace DefineClasses2nd.Items.Weapon
{
    using DefineClasses2nd.Enums;

    public class Hammer : Weapon
    {
        public Hammer(int damage, ItemQuality quality)
            : base(damage, quality)
        {
            this.Type = WeaponType.Hammer;
        }
    }
}
