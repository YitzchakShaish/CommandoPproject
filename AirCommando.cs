using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CommandoProject
{
    internal class AirCommando : Commando
    {
        public AirCommando(string name, string codeName) : base(name, codeName)
        {
           
        }
      
        public void Parachuting(int mail)
        {
            Console.WriteLine($"The Soldier parachutes {mail} miles."); 
        }
        public override void Attack()
        {
            Console.WriteLine($" Teh \"air Commando\" with Code Name: \"{CodeName}\" is active.");
        }
    }
}
