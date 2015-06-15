namespace DefineClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EntryPoint
    {
        static void Main()
        {
            Character hero = new Character();

            Weapon weapon = new Weapon();

            weapon.itemQuality = Quality.Common;
            weapon.Damage = 5;



            //Quality qduality = Quality.Common;
        }
    }
}
