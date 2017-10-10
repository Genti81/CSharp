using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLib
{
    public class Account
    {
        public string Code;
        public decimal Amount {
            get;
            set;
        }

        public bool IsSummary
        {
            get; set;
        }
        public List<Account> Children {
            get;
            set;
        }
        public string Description { get; set; }
    }
}
