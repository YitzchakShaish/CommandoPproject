using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommandoPproject
{
    internal class SeaCommando : Commando
    {

        public SeaCommando(string name, string codeName, string status) : base(name, codeName, status)
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


