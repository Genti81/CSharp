using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolLib;

namespace SchoolTests
{
    [TestClass]
    public class SchoolSystemTests
    {


        [TestMethod]
        public void StudentsInTest()
        {
            var sut = new SchoolSystem();
            //sut.NumberOfStudents();
            sut.AddClass("SPO16", 30);
            sut.AddClass("cloud16", 20);
            sut.AddClass("SPO16", 10);
            sut.AddClass("IT16", 15);
            //sut.Add.NewClass(sut.getTotalStudentsAndClasses());
            Assert.AreEqual(75, sut.ClassCount);
            Assert.AreEqual(3, sut.StudentCount);
        }
    }
}
