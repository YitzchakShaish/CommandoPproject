using System;
using System.Collections.Generic;

namespace CommandoProject
{
    internal class Game
    {
        private WeaponFactory weaponFactory;
        private CommandoFactory commandoFactory;
        private EnemyFactory enemyFactory;

        public Game()
        {
            weaponFactory = new WeaponFactory();
            commandoFactory = new CommandoFactory();
            enemyFactory = new EnemyFactory();
        }

        public void Initialize()
        {
            // Weapons
            var weapons = new List<(string name, string manufacturer, int numberPalls)>
            {
                ("M4", "Israel", 30),
                ("Uzi", "Israel", 25),
                ("AK-47", "Russia", 30)
            };
            foreach (var (name, manufacturer, numberPalls) in weapons)
            {
                weaponFactory.GetWeapon(name, manufacturer, numberPalls);
            }

            // Commandos
            var commandos = new List<(string type, string name, string codeName)>
            {
                ("commando", "David", "Wolf1"),
                ("airCommando", "Eli", "Eagle1"),
                ("seaCommando", "Ron", "Shark1")
            };
            foreach (var (type, name, codeName) in commandos)
            {
                commandoFactory.GetCommando(type, name, codeName);
            }

            // Enemies
            var enemies = new List<string> { "Mohammed", "Abu", "Sinwar" };
            foreach (var enemyName in enemies)
            {
                enemyFactory.GetEnemy(enemyName);
            }
        }

        public void PrintSummary()
        {
            Console.WriteLine("Weapons:");
            foreach (var weapon in weaponFactory.GetListWeapon())
            {
                Console.WriteLine(weapon);
            }

            Console.WriteLine("\nCommandos:");
            foreach (var commando in commandoFactory.GetListCommando())
            {
                Console.WriteLine(commando);
            }

            Console.WriteLine("\nEnemies:");
            foreach (var enemy in enemyFactory.GetListEnemy())
            {
                Console.WriteLine(enemy);
            }
        }
    }
}
