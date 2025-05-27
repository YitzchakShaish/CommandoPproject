using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoPproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando mm= new Commando("moshe","xxx", "Hide");
            mm.Walk();
            Console.WriteLine(mm.Name);
            Weapon ww = new Weapon("gon","refael",3);
            ww.Shoot();
            ww.Shoot();
            ww.Shoot();
            ww.Shoot();



        }
    }
}
