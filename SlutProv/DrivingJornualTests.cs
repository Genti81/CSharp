using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrivingJornualLIb;

namespace SlutProv
{
    [TestClass]
    public class DrivingJornualTests
    {
        [TestMethod]
        public void MonthlyStatistics()
        {
            var sut = new DrivingJornual();
            sut.AddEntry(2017, 9, 10M, "Fraktade lastpallar till Test AB");
            decimal milesDriven = sut.MilesDriven(2017, 9);
            Assert.AreEqual(0M, milesDriven);
        }
    }
}
