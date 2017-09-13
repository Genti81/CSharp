using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            List.Add("Cesar");
            List.Add("Bertil");
            List.Add("Adam");
            List.Add("Gentrit");
            List.Add("Lina");
        }

        public void RemoveThirdString()
        {
            List.RemoveAt(2);
        }

        public void Sort()
        {
            List.Sort();
        }
    }
}