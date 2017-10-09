using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using NewRegTest;

namespace RegExExpressionTests
{
    [TestClass]
    public class EmployeeConverterTests
    {
        [TestMethod]
        public void StringControlCheck()
        {

            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";
            string expected = "Asplund, Mattias (Lön: 35000.00) Telefon: 070 - 6186120 Föddelseår: 1971";
            var sut = new EmployeeConverter();
            var actual = sut.Convert(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
