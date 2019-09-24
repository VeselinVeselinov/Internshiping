using System;
using System.Collections.Generic;
using System.Text;

namespace ExtendingWeapon
{
    class Player
    {
        private Weapon weapon;
        private string name;

        public Player(String name, Weapon weapon)
        {
            this.name = name;
            this.weapon = weapon;
        }

        public void setWeapon(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public void doAction()
        {
            Console.Write(name + " ");
            weapon.DoAction();
        }
    }
}
