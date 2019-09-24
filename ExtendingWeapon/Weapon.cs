using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendingWeapon
{
    abstract class Weapon
    {
        public string Name { get; set; }

        public abstract void DoAction();
    }
}
