using Ex_GunsDI_NET.Infrastructure;
using Ex_GunsDI_NET.Models;
using Ex_GunsDI_NET.Models.Weapons;
using System;

namespace Ex_GunsDI_NET
{
    class Program
    {
        static Soldier soldier = new Soldier(new MachineGun());
        static Tank tank = new Tank(new Cannon(), new AntiAircraftMissile(), new MachineGun());

        static void Main(string[] args)
        {
            SelectCharacter();
        }

        private static void MenuSelectCharacter()
        {
            Console.WriteLine("\n-- Selecció de força de combat --");
            Console.WriteLine("1 - Infanteria.");
            Console.WriteLine("2 - Carros de combat.");
            Console.WriteLine("3 - Sortir.");
            Console.Write("Escull un opció: ");
        }

        private static void SelectCharacter()
        {
            ManageIO manageIO = new ManageIO();
            int option;
            bool keepdoing = true;

            while (keepdoing)
            {
                MenuSelectCharacter();
                option = manageIO.inInt();

                switch (option)
                {
                    case 1:
                        SoldierActions();
                        break;
                    case 2:
                        TankActions();
                        break;
                    case 3:
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("La opció no es válida!");
                            break;
                }
            }
        }

        private static void OptionsSoldier()
        {
            Console.WriteLine("\n-- Menú del soldat --");
            soldier.ShowWeapon();
            Console.WriteLine("1 - Disparar.");
            Console.WriteLine("2 - Cambiar l'arma a un rifle de franctirador.");
            Console.WriteLine("3 - Cambiar l'arma a un llença granades.");
            Console.WriteLine("4 - Sortir.");
            Console.Write("Escull un opció: ");
        }

        private static void SoldierActions()
        {
            ManageIO manageIO = new ManageIO();
            int option;
            bool keepdoing = true;

            while (keepdoing)
            {
                OptionsSoldier();
                option = manageIO.inInt();

                switch (option)
                {
                    case 1:
                        soldier.Shoot("enemigo");
                        break;
                    case 2:
                        soldier.ChangeWeapon(new SniperRifle());
                        break;
                    case 3:
                        soldier.ChangeWeapon(new GranadeLauncher());
                        break;
                    case 4:
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("La opció no es válida!");
                        break;
                }
            }
        }

        private static void OptionsTank()
        {
            Console.WriteLine("\n-- Menu tanc --");
            Console.WriteLine("1 - Disparar.");
            Console.WriteLine("2 - Sortir.");
            Console.Write("Escull un opció: ");
        }

        private static void TankActions()
        {
            ManageIO manageIO = new ManageIO();
            int option;
            bool keepdoing = true;

            while (keepdoing)
            {
                OptionsTank();
                option = manageIO.inInt();

                switch (option)
                {
                    case 1:
                        tank.Shoot("enemigo");
                        break;
                    case 2:
                        keepdoing = false;
                        break;
                    default:
                        Console.WriteLine("La opció no es válida!");
                        break;
                }
            }
        }
    }
}
