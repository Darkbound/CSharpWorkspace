namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class Legs : Armor
    {
        public Legs()
        {

        }

        public Legs(int damageBlock, ItemQuality quality)
            :base(damageBlock, quality)
        {
            this.Type = ArmorType.Legs;
        }
    }
}
