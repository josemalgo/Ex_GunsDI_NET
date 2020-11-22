using Ex_GunsDI_NET.Models.Interfaces;
using System;

namespace Ex_GunsDI_NET.Models
{
    class GranadeLauncher : IWeapon
    {
        private string name;

        public GranadeLauncher()
        {
            this.name = "Lanza granadas";
        }

        public void Hit(string target)
        {
            Console.WriteLine("\nGrupo {0} ha saltado por los aires.", target);
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
