using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtbilbningsLIB
{
    public class Utbildning
    {
        public DateTime _startTime;
        public DateTime _endTime;

        public Utbildning(string description, DateTime startTime, DateTime endTime, bool isSummary)
        {
            this.Description = description;
            this._startTime = startTime;
            this._endTime = endTime;
            this.IsSummary = isSummary;
            Children = new List<Utbildning>();
        }
        public string Code;
        public decimal amount;
        public string Description { get; set; }

        public decimal Amount
        {

            get
            {
                if (IsSummary)
                    return Children.Sum(child => child.Amount);
                return amount;
            }
        }

        public bool IsSummary { get; set; }
        public List<Utbildning> Children { get; set; }
    }
}
