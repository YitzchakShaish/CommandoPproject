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
            //Commando c1= new Commando("moshe","xxx", "Hide");
            //c1.Walk();
            //c1.SayName("COLONEL");
            //Weapon ww = new Weapon("gon","refael",3);
            //AirCommando a1 = new AirCommando("itzik", "231", " ");
            //SeaCommando s1 = new SeaCommando("chaim", "===", " ");
            //Commando [] nn = { c1, a1, s1 };
            //foreach (var i in nn)
            //{
            //    Console.WriteLine(i.GetType());
            //    i.Attack();
            //}  
            EnemyFactory.GetEnemy(5);
            foreach (Enemy name in EnemyFactory.GetListEnemy())
            {
                name.Shout();
            }





        }
    }
}
