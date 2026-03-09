using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_6
{
    public abstract class Ticket
    {
        public static int Counter = 1;

        public int TicketNumber { get; set; }
        public string Movie { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movie, double price)
        {
            TicketNumber = Counter++;
            Movie = movie;
            Price = price;
        }

        public abstract double FinalPrice();

        public virtual void Book()
        {
            IsBooked = true;
        }

        public void Cancel()
        {
            IsBooked = false;
        }

        public abstract string TicketDetails();

        public abstract string Type();
    }
}
