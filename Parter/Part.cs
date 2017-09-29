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

        public Part(string name, string juridisktId)
        {
            this.Name = name;
            this.JuridisktId = juridisktId;
        }
        public override string ToString()
        {
            return $"{Name} ({JuridisktId})"; 
        }
    }
}
