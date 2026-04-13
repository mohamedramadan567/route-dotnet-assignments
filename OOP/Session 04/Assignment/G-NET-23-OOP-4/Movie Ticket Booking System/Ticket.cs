//using G_NET_23_OOP_3.Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_4.Movie_Ticket_Booking_System
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

        public decimal PriceAfterTax
        {
            get
            {
                return Price * 1.14m;
            }
        }


        public static int GetTotalTickets()
        {
            return _ticketCounter;
        }

        public Ticket(string movieName, decimal price)
        {
            MovieName = movieName;
            Price = price;
            _ticketCounter++;
            TicketId = _ticketCounter;
        }

        //1.a
        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

        //1.b
        public void SetPrice(decimal price)
        {
            Price = price;
            Console.WriteLine($"Setting price directly: {Price}");
        }

        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            Price = basePrice * multiplier;
            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {Price} ");
        }

    }
}
