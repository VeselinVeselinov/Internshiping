using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendingWeapon
{
    class PlasmaGun : Weapon
    {
        public override void DoAction()
        {
            Console.WriteLine("melts your face off with a plasma gun");
        }
    }
}
