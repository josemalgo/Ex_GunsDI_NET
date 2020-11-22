using Ex_GunsDI_NET.Infrastructure;
using Ex_GunsDI_NET.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace Ex_GunsDI_NET.Models
{
    class Tank
    {
        private IWeapon cannon;
        private IWeapon antiAircraft;
        private IWeapon machineGun;

        public Tank(IWeapon cannon, IWeapon antiAircraft, IWeapon machineGun)
        {
            this.cannon = cannon;
            this.antiAircraft = antiAircraft;
            this.machineGun = machineGun;
        }

        public void Shoot(string target)
        {
            SelectWeapon().Hit(target);
        }

        private IWeapon SelectWeapon()
        {
            ManageIO manageIO = new ManageIO();
            int option;

            Console.WriteLine("\n-- Armas del tanque --");
            Console.WriteLine("1 - " + this.cannon.GetName());
            Console.WriteLine("2 - " + this.antiAircraft.GetName());
            Console.WriteLine("3 - " + this.machineGun.GetName());
            Console.Write("Escoge una opción: ");
            option = manageIO.inInt(); 


            if (option == 1)
                return this.cannon;
            if (option == 2)
                return this.antiAircraft;
            else
                return this.machineGun;
        }
    }
}
