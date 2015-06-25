namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class Feet : Armor
    {
        public Feet()
        {

        }

        public Feet(int damageBlock, ItemQuality quality)
            :base(damageBlock, quality)
        {
            this.Type = ArmorType.Feet;
        }
    }
}
