using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class Mulitplier
    {
        public long Simple(long l1, long l2)
        {
            return l1 * l2;
        }

        public long UsingFor(long f1, long f2)
        {
            return f1 * f2;
        }

        public long While(long left, long right)
        {
            long total = 0;
            long loopWhile = 0;
            while (loopWhile < left)
            {
                total += right;
                loopWhile++;
            }
            return total;
        }
    }
}
