using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AccountLib;

namespace AcoountTestsLib
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void Sum()
        {
            Account assets = new Account { IsSummary = true, Description = "Assets" };
            Account cars = new Account { Description = "Car fleet", Amount = 50000000 };
            assets.Children.Add(cars);
            Assert.AreEqual(assets.Amount, "Summan går här");
        }
    }
}
