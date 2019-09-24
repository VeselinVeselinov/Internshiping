using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendingWeapon
{
    class Knife : Weapon
    {
        public override void DoAction()
        {
            Console.WriteLine("hits you with a knife");
        }
    }
}
