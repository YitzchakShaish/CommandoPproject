using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandoProject.Interfaces;

namespace CommandoProject.Weapones
{
    internal class Knife : IColdWeapon

    {
        string name;
        string color;
        public bool IsComplete => CurrentNumberStrokes <= MaximumNumberStrokes;

        public int MaximumNumberStrokes { get; private set; } = 12;

        public int CurrentNumberStrokes { get; private set; } = 3;

        public void Strike()
        
{       
                if (IsComplete)
                {
                    CurrentNumberStrokes++;
                    Console.WriteLine($"The knife named: {name} is now valid");
                }
                else Console.WriteLine($"The knife named: {name} Worn");
            }
        public Knife(string name, string color)
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
