using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersonnummerLibTests
{
    [TestClass]
    public class PersonnummerGreeting
    {

        [TestMethod]
        public void Man()
        {
            var sut = new PersonnummerGreeting();
            var personnummer = "198109278898";
            sut.EnterDetails("Gentrit", "Sahiti", personnummer);
            var var expected = "God morgon her Sahiti";
            Assert.AreEqual(expected, sut.Greeting);

        }
        [TestMethod]
        public void Kvinna()
        {
            var sut = new PersonnummerGreeting();
            var personnummer = "198109278898";
            sut.EnterDetails("Gentrit", "Sahiti", personnummer);
            var var expected = "God morgon her Sahiti";
            Assert.AreEqual(expected, sut.Greeting);

        }
    }
}
