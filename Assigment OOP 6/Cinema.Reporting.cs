using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public partial class Cinema
    {
        public void PrintTickets()
        {
            Console.WriteLine("\n--- All Tickets (from Cinema.Reporting) ---");

            foreach (var t in tickets)
            {
                Console.WriteLine(
                    $"[Ticket #{t.TicketNumber}] {t.Movie} | {t.Type()} | {t.TicketDetails()} | Price: {t.Price} | Final: {t.FinalPrice():F2} | Booked: {(t.IsBooked ? "Yes" : "No")}"
                );
            }
        }
    }
}
