namespace DefineClasses2nd.Items.Weapon
{
    using DefineClasses2nd.Enums;

    public class Sword : Weapon
    {
        public Sword(int damage, ItemQuality quality)
            :base(damage, quality)
        {
            this.Type = WeaponType.Sword;
        }
    }
}
