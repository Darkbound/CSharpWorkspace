using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Armor()
        {

        }

        public Armor(ArmorType type, ItemQuality quality, int defense)
        {
            this.ArmorType = type;
            this.ItemQuality = quality;
            this.Defense = defense;
        }

        public Armor(ArmorType type, ItemQuality quality, int defense, int stamina, int agility)
        {
            this.ArmorType = type;
            this.ItemQuality = quality;
            this.Defense = defense;
            this.Stamina = stamina;
            this.Agility = agility;
        }
    }
}
