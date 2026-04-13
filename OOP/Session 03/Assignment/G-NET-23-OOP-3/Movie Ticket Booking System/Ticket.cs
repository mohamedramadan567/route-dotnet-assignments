//using G_NET_23_OOP_3.Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_3.Movie_Ticket_Booking_System
{
    internal class Ticket
    {
        private string _movieName;
        private decimal _price;
        private static int _ticketCounter = 0;

        public int TicketId { get;}

        public string MovieName
        {
            get
            {
                return _movieName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _movieName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                    _price = value;
            }
        }

        //c. A computed property PriceAfterTax that returns the price with 14% tax.
        public decimal PriceAfterTax
        {
            get
            {
                return Price * 1.14m;
            }
        }


        //1.e
        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }

        //b. A constructor that takes movieName and price.
        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            _ticketCounter++;
            TicketId = _ticketCounter;
        }

        //d. Override ToString() to return the ticket info. 
        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
        }


    }
}
