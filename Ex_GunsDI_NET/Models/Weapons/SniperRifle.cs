using Ex_GunsDI_NET.Models.Interfaces;
using System;

namespace Ex_GunsDI_NET.Models
{
    class SniperRifle : IWeapon
    {
        private string name;

        public SniperRifle()
        {
            this.name = "Rifle de francotirador";
        }

        public void Hit(string target)
        {
            Console.WriteLine("\nBlanco {0} abatido a más de 400 metros.", target);
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
