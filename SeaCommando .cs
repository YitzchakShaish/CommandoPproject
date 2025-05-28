using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class SeaCommando : Commando
    {

        public SeaCommando(string name, string codeName) : base(name, codeName)
        {
        }
        public void Whoa(int meter)
        {
            Console.WriteLine($"The soldier swims {meter} meters");
        }
        public override void Attack()
        {
            Console.WriteLine($" Teh \"sea Commando\" with Code Name: \"{CodeName}\" is active.");
        }
    }
}


