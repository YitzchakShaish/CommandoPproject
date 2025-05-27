using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoPproject
{
    internal class Commando
    {
        string Name;
        public string CodeName { get; set; }
        List<string> Tools = new List<string> { "hammer", "chisel", "rope", "bag", "water bottle" };
        string Status;
    
    public Commando(string name, string codeName,  string status)
        {
            Name = name;
            CodeName = codeName;
            Status = status;
        }
        
        public void Walk()
        {
            Status = "Walk";
            Console.WriteLine($"The soldier : {Status}ed");
        }
        public void Hide()
        {
            Status = "Hide";
            Console.WriteLine($"The soldier : {Status}ed");
        }
        public virtual void Attack()
        {
            Console.WriteLine($"Commando with Code Name: \"{CodeName}\" is active.");
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank.Equals("GENERAL"))
            {
                Console.WriteLine($"Teh name is: {Name}");
            }
            else if (commanderRank.Equals("COLONEL"))
            {
                Console.WriteLine($"Teh codename is: {CodeName}");
            }
            else Console.WriteLine("It is not possible to show you the information.");
        }
    }

}
