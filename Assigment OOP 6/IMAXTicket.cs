using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(string movie, double price, bool is3D)
            : base(movie, price)
        {
            Is3D = is3D;
        }

        public override double FinalPrice()
        {
            return Price * 1.14;
        }

        public override string Type() => "IMAX";

        public override string TicketDetails()
        {
            return $"3D: {(Is3D ? "Yes" : "No")}";
        }
    }
}
