using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendingWeapon
{
    class Revolver : Weapon
    {
        public override void DoAction()
        {
            Console.WriteLine("puts a hole in you with a revolver");
        }
    }
}
