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

        public Accountability(string Name, Part responsible, Part commissioner)
        {
            this.roleName = Name;
            this.Responsible = responsible;
            this.Commissioner = commissioner;
        }
        public override string ToString()
        {
            return $"{Responsible.Name}, {roleName} på {Commissioner.Name}"; 
        }
    }
}
