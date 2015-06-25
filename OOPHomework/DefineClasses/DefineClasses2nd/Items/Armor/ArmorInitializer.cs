namespace DefineClasses2nd.Items.Armor
{
    using DefineClasses2nd.Enums;

    public class ArmorInitializer : ArmorFactory
    {
        private const ItemQuality DEFAULT_ARMOR_QUALITY = ItemQuality.Uncommon;

        // Helm defaults
        private const int DEFAULT_TANK_HELM_DAMAGEBLOCK = 5;
        private const int DEFAULT_FIGHTER_HELM_DAMAGEBLOCK = 5;
        private const int DEFAULT_SORCERER_HELM_DAMAGEBLOCK = 5;

        // Chest defaults
        private const int DEFAULT_TANK_CHEST_DAMAGEBLOCK = 5;
        private const int DEFAULT_FIGHTER_CHEST_DAMAGEBLOCK = 5;
        private const int DEFAULT_SORCERER_CHEST_DAMAGEBLOCK = 5;
                                  
        // Hands defaults         
        private const int DEFAULT_TANK_HANDS_DAMAGEBLOCK = 5;
        private const int DEFAULT_FIGHTER_HANDS_DAMAGEBLOCK = 5;
        private const int DEFAULT_SORCERER_HANDS_DAMAGEBLOCK = 5;
                                  
        // Legs defaults          
        private const int DEFAULT_TANK_LEGS_DAMAGEBLOCK = 5;
        private const int DEFAULT_FIGHTER_LEGS_DAMAGEBLOCK = 5;
        private const int DEFAULT_SORCERER_LEGS_DAMAGEBLOCK = 5;
                                   
        // Feet defaults           
        private const int DEFAULT_TANK_FEET_DAMAGEBLOCK = 5;
        private const int DEFAULT_FIGHTER_FEET_DAMAGEBLOCK = 5;
        private const int DEFAULT_SORCERER_FEET_DAMAGEBLOCK = 5;

        public override Helm TankHelm()
        {
            return new Helm(DEFAULT_TANK_HELM_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Helm FighterHelm()
        {
            return new Helm(DEFAULT_FIGHTER_HELM_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Helm SorcererHelm()
        {
            return new Helm(DEFAULT_SORCERER_HELM_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Chest TankChest()
        {
            return new Chest(DEFAULT_TANK_CHEST_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Chest FighterChest()
        {
            return new Chest(DEFAULT_FIGHTER_CHEST_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Chest SorcererChest()
        {
            return new Chest(DEFAULT_SORCERER_CHEST_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Hands TankHands()
        {
            return new Hands(DEFAULT_TANK_HANDS_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Hands FighterHands()
        {
            return new Hands(DEFAULT_FIGHTER_HANDS_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Hands SorcererHands()
        {
            return new Hands(DEFAULT_SORCERER_HANDS_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Legs TankLegs()
        {
            return new Legs(DEFAULT_TANK_LEGS_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Legs FighterLegs()
        {
            return new Legs(DEFAULT_FIGHTER_LEGS_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Legs SorcererLegs()
        {
            return new Legs(DEFAULT_SORCERER_LEGS_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Feet TankFeet()
        {
            return new Feet(DEFAULT_TANK_FEET_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Feet FighterFeet()
        {
            return new Feet(DEFAULT_FIGHTER_FEET_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }

        public override Feet SorcererFeet()
        {
            return new Feet(DEFAULT_SORCERER_FEET_DAMAGEBLOCK, DEFAULT_ARMOR_QUALITY);
        }
    }
}
