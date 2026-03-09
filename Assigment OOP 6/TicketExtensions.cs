using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public static class TicketExtensions
    {
        public static string Receipt(this Ticket ticket)
        {
            return
    $@"========== RECEIPT ==========
Movie    : {ticket.Movie}
Type     : {ticket.Type()}
Price    : {ticket.Price}
Final    : {ticket.FinalPrice():F2}
Status   : {(ticket.IsBooked ? "Booked" : "Not Booked")}
=============================";
        }

        public static double TotalRevenue(this Ticket[] tickets)
        {
            double total = 0;

            foreach (var t in tickets)
            {
                total += t.FinalPrice();
            }

            return total;
        }
    }
}
