using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parter
{
    public class PartSystem
    {
        private List<Part> Parts = new List<Part>();
        private List<Accountability> Accountabilities = new List<Accountability>();

        public int NumberOfAccountabilities { get; set; }

        public void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public void AddAccountability(Accountability accountability)
        {
            Accountabilities.Add(accountability);
        }

        public void AddAcountability(Accountability vd)
        {
            throw new NotImplementedException();
        }

        public int NumberOfParts()
        {
            return Parts.Count;
        }
    }
}
