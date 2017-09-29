using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
    public class Part
    {
        public Part(string name, string juridisktId)
        {
            this.Name = name;
            this.JuridisktId = juridisktId;
        }
        public string Name { get; set; }
        public string JuridisktId { get; set; }

        public override string ToString()
        {
            return $"{Name} ({JuridisktId})"; 
        }
    }
}
