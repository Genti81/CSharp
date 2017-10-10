using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtbilbningsLIB;

namespace UtbildningsTestsLib
{
    [TestClass]
    public class UtbildningTest
    {
        [TestMethod]
        public void Utbildning()
        {
            Utbildning utbildning  = new Utbildning("SPO16", new DateTime(2017,09,05, 09,00,00), new DateTime(2018,06,15, 09,00,00), true);
            Utbildning kursen = new Utbildning("C#", new DateTime(2017,09,11, 09,00,00), new DateTime(2017, 11, 11, 09, 00, 00), true);
            Utbildning kursdag = new Utbildning("måndag", new DateTime(2017, 10, 09, 09, 00, 00), new DateTime(2017, 10, 09, 16, 00, 00), false);
            Utbildning timmar = new Utbildning("Antal timmar", new DateTime(2017, 10, 09, 09, 00, 00), new DateTime(2017, 10, 09, 16, 00, 00), false);
                utbildning.Children.Add(kursen);
                kursen.Children.Add(kursdag);
                kursen.Children.Add(timmar);
                Assert.AreEqual(utbildning.Amount, timmar);

        }
    }
}
