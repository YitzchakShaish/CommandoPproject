using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoProject.Interfaces
{
    internal interface IColdWeapon
    {
        bool IsComplete { get; } 
        int MaximumNumberStrokes { get; }
        int CurrentNumberStrokes { get; }
        void Strike();
    }
}
