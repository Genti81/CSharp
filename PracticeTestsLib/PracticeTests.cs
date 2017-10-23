using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeLib;

namespace PracticeTestsLib
{
    [TestClass]
    public class PracticeTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Practice sut = new Practice();

            var stringResult = sut.getStringValue("Mattias; 1917 - 05 - 01; 0706186120");
            Assert.AreEqual(stringResult, $"{sut.NamnString} är {sut.Phonestring} år gammal och har ett telefonnummer {sut.Phonestring}");
        }
    }
}
