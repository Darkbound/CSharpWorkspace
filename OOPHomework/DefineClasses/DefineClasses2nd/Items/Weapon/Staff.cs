namespace DefineClasses2nd.Items.Weapon
{
    using DefineClasses2nd.Enums;

    public class Staff : Weapon
    {
        public Staff(int damage, ItemQuality quality)
            : base(damage, quality)
        {
            this.Type = WeaponType.Staff;
        }
    }
}
