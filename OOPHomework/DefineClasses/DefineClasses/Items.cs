namespace DefineClasses
{
    public enum ItemQuality
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public abstract class Items
    {
        public ItemQuality ItemQuality { get; set; }
        
        public int Stamina { get; set; }
        
        public int Strength { get; set; }
        
        public int Agility { get; set; }
        
        public int Intelligence { get; set; }

        public int RequiredLevel { get; set; }
    }
}
