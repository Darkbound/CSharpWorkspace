/// Define a class Armor which holds the following information: damageBlock, type (cask, shield etc), class (same as above).
namespace DefineClasses
{
    public enum ArmorType
    {
        Head,
        Shoulders,
        Chest,
        Wrists,
        Hands,
        Belt,
        Legs,
        Feet
    }

    public class Armor : Items
    {
        public ArmorType ArmorType { get; set; }
        public int Defense { get; set; }
    }
}
