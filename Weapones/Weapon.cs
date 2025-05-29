using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommandoProject
{
    internal class Weapon
    {
        string Name;
        string ManuFacturer;
        int NumberPalls;
    
    public Weapon(string name, string manuFacturer, int numberPalls)
        {
            Name = name;
            ManuFacturer = manuFacturer;
            NumberPalls = numberPalls;

        }
    public void Shoot()
        {
            if (NumberPalls > 0)
            {
                Console.WriteLine("One bullet was fired");
                NumberPalls = NumberPalls-1;
            }
            else Console.WriteLine("There is no bullet in the cartridge to fire.");
        }

    }
}
