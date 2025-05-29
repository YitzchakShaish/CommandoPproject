using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Enemy
    {
        string Name;
        int Life = 100;
        bool IsLive = true;

        public Enemy(string name)
        {
            Name = name;
        }
        public void Shout()
        {
            Console.WriteLine($" Hi I'm Enemy, my name is: {Name}");
        }
        public override string ToString()
        {
            return $"name: {Name}, life: {Life}, isLive = {IsLive} ";
        }
    }
}
