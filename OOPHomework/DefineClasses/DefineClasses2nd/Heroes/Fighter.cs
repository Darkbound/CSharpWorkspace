﻿namespace DefineClasses2nd.Heroes
{
    using DefineClasses2nd.Enums;
    using DefineClasses2nd.Items.Armor;
    using DefineClasses2nd.Items.Weapon;

    public class Fighter : Hero
    {
        public Fighter(string name, int health, int mana, int level, int strength, int agility, int intellect, bool isDead, bool isBlocking)
            : base(name, Class.Fighter, health, mana, level, strength, agility, intellect, isDead, isBlocking)
        {

        }

        public Fighter(string name, int health, int mana, int level, int strength, int agility, int intellect, int damage, int damageBlock, bool isDead, bool isBlocking, Weapon weapon, Helm helm, Chest chest, Hands hands, Legs legs, Feet feet)
            : base(name, Class.Fighter, health, mana, level, strength, agility, intellect, damage, damageBlock, isDead, isBlocking, weapon, helm, chest, hands, legs, feet)
        {

        }
    }
}
