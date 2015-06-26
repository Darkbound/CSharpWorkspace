namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class Helm : Armor
    {
        public Helm()
        {

        }

        public Helm(int damageBlock, ItemQuality quality)
            : base(damageBlock, quality)
        {
            this.Type = ArmorType.Helm;
        }
    }
}
