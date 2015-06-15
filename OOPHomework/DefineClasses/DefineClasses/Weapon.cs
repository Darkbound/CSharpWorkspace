using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Weapon()
        {

        }

        public Weapon(WeaponType type, ItemQuality quality, int damage)
        {
            this.WeaponType = type;
            this.ItemQuality = quality;
            this.Damage = damage;
        }

        public Weapon(WeaponType type, ItemQuality quality, int damage, int stamina, int agility)
        {
            this.WeaponType = type;
            this.ItemQuality = quality;
            this.Damage = damage;
            this.Stamina = stamina;
            this.Agility = agility;
        }
    }
}
