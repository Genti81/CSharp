using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiplierTestsLib
{
    [TestClass]
    public class FileConversionTests
    {
        [TestMethod]
        public void gentrit_sahiti_1981()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("gentrit;sahiti;1981");
            Assert.AreEqual("GENTRIT SAHITI ÄR 36 ÅR GAMMAL", actual);
        }
        [TestMethod]
        public void noel_sahiti_2014()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("noel;sahiti;2014");
            Assert.AreEqual("NOEL SAHITI ÄR 3 ÅR GAMMAL", actual);
        }
        [TestMethod]
        public void lina_sahiti_1985()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("lina;sahiti;1985");
            Assert.AreEqual("LINA SAHITI ÄR 32 ÅR GAMMAL", actual);
        }
    }
}
