//using G_NET_23_OOP_3.Movie_Ticket_Booking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_5.Movie_Ticket_Booking_System
{
    internal class Ticket : IPrintable, ICloneable
    {
        //Change from private to protected to can make deep copy in children classes
        protected string _movieName;
        protected decimal _price;
        private static int _ticketCounter = 0;
        protected bool IsBooked { get; private set; }

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
            IsBooked = false;
        }

        public bool Book()
        {
            if(IsBooked)
            {
                Console.WriteLine("Booking failed: Ticket already booked.");
                return false;
            }
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine("Cancellation failed: Ticket is not booked.");
                return false;
            }
            IsBooked = false;
            return true;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP");
        }

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

        public virtual object Clone() => new Ticket(MovieName, Price);
    }
}
