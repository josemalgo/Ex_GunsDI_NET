using Ex_GunsDI_NET.Models.Interfaces;
using System;

namespace Ex_GunsDI_NET.Models
{
    class MachineGun : IWeapon
    {
        private string name;

        public MachineGun()
        {
            this.name = "Ametralladora";
        }

        public void Hit(string target)
        {
            Console.WriteLine("\nDejando al {0} como un colador.", target);
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
