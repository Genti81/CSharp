using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parter;

namespace PartTests
{
    [TestClass]
    public class PartUnit
    {
        [TestMethod]
        public void CorrectToString()
        {
            var sut = new Part("Gentrit Sahiti", "19810927-8898");

            Assert.AreEqual("Gentrit Sahiti (19810927-8898)", sut.ToString());
        }
    }
}
