using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendingWeapon
{
    class Sniper : Weapon
    {
        public override void DoAction()
        {
            Console.WriteLine("shoots you down with a sniper");
        }
    }
}
