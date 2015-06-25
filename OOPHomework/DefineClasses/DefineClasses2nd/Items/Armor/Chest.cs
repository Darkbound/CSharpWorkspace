namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class Chest : Armor
    {
        public Chest()
        {

        }

        public Chest(int damageBlock, ItemQuality quality)
            :base(damageBlock, quality)
        {
            this.Type = ArmorType.Chest;
        }
    }
}
