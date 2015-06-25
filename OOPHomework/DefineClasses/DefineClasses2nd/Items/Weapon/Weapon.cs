namespace DefineClasses2nd.Items.Weapon
{
    using DefineClasses2nd.Enums;

    public class Weapon
    {
        public Weapon()
        {

        }

        public Weapon(int damage, ItemQuality quality)
        {
            this.Damage = damage;
            this.Quality = quality;
        }

        public int Damage { get; protected set; }

        public WeaponType Type { get; protected set; }

        public ItemQuality Quality { get; protected set; }
    }
}
