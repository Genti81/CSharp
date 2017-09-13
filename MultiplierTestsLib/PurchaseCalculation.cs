using System;

namespace MultiplierTestsLib
{
    internal class PurchaseCalculation
    {
        public PurchaseCalculation()
        {
        }

        internal object Execute(int qty, decimal amount, bool withVAT)
        {
            if (withVAT)
                return qty * amount * 1.25M;
            else
                return qty * amount;
        }
    }
}