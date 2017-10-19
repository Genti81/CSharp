using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using CustomerServiceLib;

namespace CustomerServiceTests
{
    [TestClass]
    public class CustomerServiceTests
    {
        [TestMethod]
        public void UserFlow()
        {
            var sut = new CustomerService();
            var ticketID = sut.EnterTicket("gs@gmail.com", "TestString", new DateTime(2017, 9, 10), "My ticket");
            sut.MakeOffer(ticketID, 1000M);
            bool offerExists = false;
            do
            {
                offerExists = sut.OfferExists(ticketID);
            }
            while (!offerExists);
            Debug.WriteLine(sut.OfferedPrice(ticketID));
        }
    }
}
