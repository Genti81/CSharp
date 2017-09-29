using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
    public class Part
    {
        public string Name;
        public string JuridisktId;

        public Part(string Name, string JuridisktId)
        {
            this.Name = Name;
            this.JuridisktId = JuridisktId;
        }
        public override string ToString()
        {
            return $"{Name} ({JuridisktId})"; 
        }
    }
}
