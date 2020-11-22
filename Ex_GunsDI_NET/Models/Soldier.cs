using Ex_GunsDI_NET.Models.Interfaces;
using System;

namespace Ex_GunsDI_NET.Models
{
    class Soldier
    {
        private IWeapon weapon;

        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void Shoot(string target)
        {
            this.weapon.Hit(target);
        }

        public void ChangeWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public void ShowWeapon()
        {
            Console.WriteLine("-- Arma actual " + this.weapon.GetName() + " --");
        }
    }
}
