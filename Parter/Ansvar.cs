using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
    class Ansvar
    {
        public string Name;
        public Part Ansvarig;
        public Part Kommissionär;

        public Ansvar(string Name, Part Ansvarig, Part Kommissionär)
        {
            this.Name = Name;
            this.Ansvarig = Ansvarig;
            this.Kommissionär = Kommissionär;
        }
    }
}
