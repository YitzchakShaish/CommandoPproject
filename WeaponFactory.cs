using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
