using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class CommandoFactory
    {
        private List<Commando> listCommando = new List<Commando>();

        public void GetCommando(string tipe ,string name, string codeName)
        {
            switch (tipe) {
                case "commando":
                    listCommando.Add(new Commando(name, codeName));
                    break;
                case "airCommando":
                    listCommando.Add(new AirCommando(name, codeName));
                    break;
                case "seaCommando":
                    listCommando.Add(new SeaCommando(name, codeName));
                    break;
                default:
                    Console.WriteLine("The tipe is not found"); ;
                    break;
            }
        }
            public List<Commando> GetListCommando()
        {
            return listCommando;
        }
    }
}
