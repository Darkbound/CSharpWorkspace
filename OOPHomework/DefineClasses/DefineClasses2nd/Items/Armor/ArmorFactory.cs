namespace DefineClasses2nd.Items.Armor
{
    public abstract class ArmorFactory
    {
        public abstract Helm TankHelm();

        public abstract Helm FighterHelm();

        public abstract Helm SorcererHelm();

        public abstract Chest TankChest();

        public abstract Chest FighterChest();

        public abstract Chest SorcererChest();

        public abstract Hands TankHands();

        public abstract Hands FighterHands();

        public abstract Hands SorcererHands();

        public abstract Legs TankLegs();

        public abstract Legs FighterLegs();

        public abstract Legs SorcererLegs();

        public abstract Feet TankFeet();

        public abstract Feet FighterFeet();

        public abstract Feet SorcererFeet();
    }
}
