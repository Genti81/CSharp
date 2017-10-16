using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using CalculatorLib;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestCalculator()
        {
            //Arrange::En konstruktor i Calculator class
            Calculator sut = new Calculator();
            //Act:: Kolla om calvulator är på
            sut.PowerOn();
            //teta att köra Calculator om detta hänger ihop 
            Assert.AreEqual(0, sut.Display);
        }
        [TestMethod]
        public void OndeDigitIDisplay()
        {
            //Arrange::En konstruktor i Calculator class
            Calculator sut = new Calculator();
            //Act:: Kolla om knapp är tryckt
            sut.Press("7");
            //teta att köra Calculator om detta hänger ihop
            Assert.AreEqual(7, sut.Display);
        }
        [TestMethod]
        public void Add12to25()
        {
            //Arrange::En konstruktor i Calculator class
            Calculator sut = new Calculator();
            //Act:: Kolla om knapp är tryckt
            sut.Press("1");
            Debug.WriteLine("KEY=1");
            sut.Press("2");
            Debug.WriteLine("KEY=2");
            sut.Press("+");
            Debug.WriteLine("KEY= +");
            sut.Press("2");
            Debug.WriteLine("KEY=2");
            sut.Press("5");
            Debug.WriteLine("KEY=5");
            sut.Press("=");
            //teta att köra Calculator om detta hänger ihop
            Assert.AreEqual(37, sut.Display);
        }
    }
}
