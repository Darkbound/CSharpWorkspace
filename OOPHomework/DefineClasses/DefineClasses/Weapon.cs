/// Define a class Weapon which holds the following information: type (enumeration – Sword, Hammer, Staff, etc. ), class (common, rare, mythical), damage
namespace DefineClasses
{
    using DefineClasses.Enums;

    public class Weapon : Items
    {
        private Type type;
        public Type Type 
        { 
            get
            {
                return type;
            }
            
            set
            {
                this.type = value;

                if (type == Type.Sword)
                {
                    //Initialize.Sword();
                }
                else if (type == Type.Dagger)
                {
                    //Initialize.Dagger();
                }

                //Default initializations for the different types of weapons
            }
        }
        
        public int Damage { get; set; }
    }
}
