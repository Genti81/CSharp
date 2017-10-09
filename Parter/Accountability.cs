using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
    public class Accountability
    {
        public string roleName;
        public Part Responsible;
        public Part Commissioner;
        private Parter p1;
        private object p2;
        private string v;

        public Accountability(string Name, Part responsible, Part commissioner)
        {
            this.roleName = Name;
            this.Responsible = responsible;
            this.Commissioner = commissioner;
        }

        public Accountability(Parter p1, object p2, string v)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.v = v;
        }

        public override string ToString()
        {
            return $"{Responsible.Name}, {roleName} på {Commissioner.Name}"; 
        }
    }
}
