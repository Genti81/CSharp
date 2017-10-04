using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnummerLib;

namespace PersonnummerLibTests
{
    [TestClass]
    public class PersonnummerGreeting
    {

        [TestMethod]
        public void Man()
        {
            var sut = new Personnummer();
            sut.Process = "8109278898";
            var expected = "1";
            Assert.AreEqual(expected, sut.Greeting);

        }


        [TestMethod]
        public void Kvinna()
        {
            var sut = new Personnummer();
            var personnummer = "198502173225";
            sut.EnterDetails("Adelina", "Sahiti", personnummer);
            var expected = "God morgon her Sahiti";
            Assert.AreEqual(expected, sut.Greeting);

        }
    }
}
