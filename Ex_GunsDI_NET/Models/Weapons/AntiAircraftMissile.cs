using Ex_GunsDI_NET.Models.Interfaces;
using System;

namespace Ex_GunsDI_NET.Models.Weapons
{
    class AntiAircraftMissile : IWeapon
    {
        private string name;

        public AntiAircraftMissile()
        {
            this.name = "Misil antiaereo";
        }

        public void Hit(string target)
        {
            Console.WriteLine("\nAvión {0} interceptdo y abatido.", target);
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
