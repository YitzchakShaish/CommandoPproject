using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandoPproject
{
    internal class Commando
    {
        public string Name;
        string CodeName;
        List<string> Tools = new List<string> { "hammer", "chisel", "rope", "bag", "water bottle" };
        string Status { get; set; }
    
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
        public void Attack()
        {
            Console.WriteLine($"Commando with Code Name: \"{CodeName}\" is active.");
        }

    }

}
