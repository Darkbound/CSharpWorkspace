namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class Hands : Armor
    {
        public Hands()
        {

        }

        public Hands(int damageBlock, ItemQuality quality)
            :base(damageBlock, quality)
        {
            this.Type = ArmorType.Hands;
        }
    }
}
