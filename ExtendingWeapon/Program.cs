using System;

namespace ExtendingWeapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon deadlyWeapon = new Knife();
            Weapon plasma = new PlasmaGun();
            Weapon sniper = new Sniper();
            Weapon revolver = new Revolver();
            Player somebody = new Player("Koko",revolver);
            somebody.doAction();
        }
    }
}
