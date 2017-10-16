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
            sut.AddEntry(2017, 7, 10M, "Fraktade lastpallar till Test AB");
            sut.AddEntry(2017, 9, 13M, "Fraktade till Schenter AB");
            sut.AddEntry(2017, 10, 20M, "Körde till Uber AB");
            sut.AddEntry(2017, 12, 25M, "Åkte till Ericsson");
            decimal milesDriven = sut.MilesDriven(2017, 9);
            Assert.AreEqual(13M, milesDriven);
        }
    }
}
