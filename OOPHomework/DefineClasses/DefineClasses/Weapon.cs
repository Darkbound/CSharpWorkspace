/// Define a class Weapon which holds the following information: type (enumeration – Sword, Hammer, Staff, etc. ), class (common, rare, mythical), damage
namespace DefineClasses
{
    public enum WeaponType
    {
        Sword,
        Dagger,
        Hammer,
        Staff,
        Polearm
    }

    public class Weapon : Items
    {
        public WeaponType WeaponType { get; set; }

        public int Damage { get; set; }
    }
}
