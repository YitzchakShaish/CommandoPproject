﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Game game = new Game();
                game.Initialize();
                game.PrintSummary();

            


        }
    }
}
