using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerServiceLib
{
    public class CustomerService
    {
        private List<Ticket> tickets = new List<Ticket>();

        public Guid EnterTicket(string email, string name, DateTime dateTime, string description)
        {
            var id = Guid.NewGuid();
            tickets.Add(new Ticket
            {
                Email = email,
                Name = name,
                CreatedAt = dateTime,
                Description = description,
                Offered = false,
                Resolved = false,
                Paid = false
            });

            return id;
        }

        public void MakeOffer(Guid ticketID, decimal amount)
        {
            throw new NotImplementedException();
        }

        public bool OfferExists(Guid ticketID)
        {
            throw new NotImplementedException();
        }

        public string OfferedPrice(Guid ticketID)
        {
            throw new NotImplementedException();
        }
    }
}
