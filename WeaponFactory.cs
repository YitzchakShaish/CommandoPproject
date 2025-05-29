using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoProject.Interfaces;
using CommandoProject.Weapones;

namespace CommandoProject
{
    internal class WeaponFactory
    {
        private List<Weapon> listWeapon = new List<Weapon>();
        public void GetWeapon(string name, string manuFacturer, int numberPalls)
        {
            listWeapon.Add(new Weapon(name, manuFacturer,numberPalls));
        }
        public List<Weapon> GetListWeapon()
        {
            return listWeapon;
        }


        private List<IColdWeapon> listColdWeapon = new List<IColdWeapon>();

        public void GetColdWeapon(string tipe ,string name, string color)
        {
            switch (tipe)
            {
                case "knife":
                    listColdWeapon.Add(new Knife (name, color));
                    break;
                case "stone":
                    listColdWeapon.Add(new Stone(name, color));
                    break;
                default:
                    Console.WriteLine("Your type selection is invalid.");
                    break;

            }
        }
        public List<IColdWeapon> GetListColdWeapon()
        {
            return listColdWeapon;
        }
    }
}
