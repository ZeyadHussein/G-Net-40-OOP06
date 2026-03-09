using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public class StandardTicket : Ticket
    {
        public string Seat { get; set; }

        public StandardTicket(string movie, double price, string seat)
            : base(movie, price)
        {
            Seat = seat;
        }

        public override double FinalPrice()
        {
            return Price * 1.14;
        }

        public override string Type() => "Standard";

        public override string TicketDetails()
        {
            return $"Seat: {Seat}";
        }
    }
}
