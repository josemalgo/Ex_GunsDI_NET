using Ex_GunsDI_NET.Models.Interfaces;
using System;

namespace Ex_GunsDI_NET.Models.Weapons
{
    class Cannon : IWeapon
    {
        private string name;

        public Cannon()
        {
            this.name = "Cañon";
        }

        public void Hit(string target)
        {
            Console.WriteLine("\nHaciendo estragos en las lineas del {0}", target);
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
