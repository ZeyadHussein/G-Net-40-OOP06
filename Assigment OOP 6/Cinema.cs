using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket t)
        {
            tickets.Add(t);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }
    }
}
