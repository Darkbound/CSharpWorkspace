/// Define a class Armor which holds the following information: damageBlock, type (cask, shield etc), class (same as above).
namespace DefineClasses
{
    using DefineClasses.Armors;
    using DefineClasses.Enums;

    public class Armor : Items
    {
        public ArmorType Type { get; set; }
        
        public int Defense { get; set; }
    }
}
