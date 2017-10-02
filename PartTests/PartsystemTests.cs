using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parter;

namespace PartTests
{
    [TestClass]
    public class PartsystemTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sut = new PartSystem();
            var p1 = new Parter("A", "1");
            var p1 = new Parter("B", "2");
            var vd = new Accountability(p1, p2 "VD");
            var emplyer = new Accountability(p1, p2 "Administratör");
            sut.AddPart(p1);
            sut.AddPart(p2);
            sut.AddAcountability(vd);
            sut.AddAccountability(emplyer);
            int actual = sut.NumberOfParts;
            Assert.AreEqual(2, actual);
            int actual = sut.NumberOfAccountabilities;
            Assert.AreEqual(2, actual);

        }
    }
}
