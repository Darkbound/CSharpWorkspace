namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class Armor
    {
        public Armor()
        {

        }

        public Armor(int damageBlock, ItemQuality quality)
        {
            this.DamageBlock = damageBlock;
            this.Quality = quality;
        }

        public int DamageBlock { get; protected set; }

        public ItemQuality Quality { get; protected set; }

        public ArmorType Type { get; protected set; }
    }
}
