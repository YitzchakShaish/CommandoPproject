using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoProject.Interfaces;

namespace CommandoProject.Weapones
{
    internal class Stone : IColdWeapon

    {
        string name;
        string color;

        public bool IsComplete  => CurrentNumberStrokes <= MaximumNumberStrokes;

        public int MaximumNumberStrokes { get; private set; } = 5;

        public int CurrentNumberStrokes { get; private set; } = 0;

        public void Strike()
        {
            if (IsComplete)
            {
                CurrentNumberStrokes++;
                Console.WriteLine($"The stone named: {name} is now valid");
            }
            else Console.WriteLine($"The stone named: {name} Worn");
        }
        public Stone(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        public override string ToString()
        {
            return $"name: {name}, color: {color}, CurrentNumberStrokes: {CurrentNumberStrokes}, MaximumNumberStrokes: {MaximumNumberStrokes}";
        }
    }
}
