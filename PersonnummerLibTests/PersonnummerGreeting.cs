using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnummerLib;

namespace PersonnummerLibTests
{
    [TestClass]
    public class PersonnummerGreeting
    {

        [TestMethod]
        public void Gentrit()
        {
            var sut = new Personnummer();
            sut.Process("810927889");
            var expected = "8";
            Assert.AreEqual(expected, sut.LastDigit);
        }

        [TestMethod]
        public void Lina()
        {
            var sut = new Personnummer();
            sut.Process("850217322");
            var expected = "5";
            Assert.AreEqual(expected, sut.LastDigit);
        }
    }
}
