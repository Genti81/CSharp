using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VarukorgLib
{
    [TestClass]
    public class Produkt
    {
        public string name;

        public Produkt(string name)
        {
            this.name = name;
        }

        public int Pris { get; set; }
    }
}
