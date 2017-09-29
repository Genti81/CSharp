using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parter;

namespace PartTests
{

    [TestClass]
    public class AccountabilityTests
    {

        [TestMethod]
        public void CoorectToString()
        {
            var gentritsahiti =
                new Part("Gentrit Sahiti", "19810927-8898");
            var someCompany = new Part("Company AB", "557616-6324");
            var sut = new Accountability("VD", gentritsahiti, someCompany);
            Assert.AreEqual("Gentrit Sahiti, VD på Company AB", sut.ToString());
        }
    }
}
