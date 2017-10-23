using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLib
{
    public class Practice
    {
        string name;
        int years;
        string phone;

        public string NamnString
        {
            get
            {
                return name;
            }
        }

        public int YearsString
        {
            get
            {
                return years;
            }
            
        }

        public string Phonestring
        {
            get
            {
                return phone;
            }
        }
        public string getStringValue(string v)
        {
            var stringValue = v.Split(';');
            name = stringValue[0];
            years = DateTime.Now.Year - DateTime.Parse(stringValue[1]).Year;
            var year = DateTime.Parse(stringValue[1]).Year;
            phone = stringValue[2];

            var gatherTotalString = $"{name} är {years} år gammal och har ett telefonnummer {phone}";
            return gatherTotalString;

        }
    }
}
