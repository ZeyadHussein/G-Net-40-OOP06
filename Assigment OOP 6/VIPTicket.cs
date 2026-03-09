using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public class VIPTicket : Ticket
    {
        public bool Lounge { get; set; }
        public double Fee { get; set; }

        public VIPTicket(string movie, double price, bool lounge, double fee)
            : base(movie, price)
        {
            Lounge = lounge;
            Fee = fee;
        }

        public override double FinalPrice()
        {
            return (Price + Fee) * 1.14;
        }

        public override string Type() => "VIP";

        public override string TicketDetails()
        {
            return $"Lounge: {(Lounge ? "Yes" : "No")} | Fee: {Fee}";
        }
    }
}
