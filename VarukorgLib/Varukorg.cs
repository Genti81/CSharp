using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace VarukorgLib
{
    [TestClass]
    public class Varukorg
    {
        public Kund Kund { get; set; }
        public Orderbekräftelse Orderbekräftelse { get; set; }

        private List<Produkt> Produkter = new List<Produkt>();

        public int Total
        {
            get
            {
                return Produkter.Sum(enProdukt => enProdukt.Pris);
            }
        }

        public void LäggTillProdukt(Produkt enProdukt)
        {
            this.Produkter.Add(enProdukt);
        }

        public void Beställ()
        {
            this.Orderbekräftelse = new Orderbekräftelse
            {
                Meddelande = $"{Kund.FirstName+" "+Kund.LastName} har beställt varor för {this.Total} kr"
            };
        }
    }
}
