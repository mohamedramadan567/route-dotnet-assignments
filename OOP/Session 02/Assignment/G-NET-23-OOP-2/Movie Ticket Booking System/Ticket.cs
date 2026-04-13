using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_2.Movie_Ticket_Booking_System
{
    internal class Ticket
    {
        #region Point01

        private string? _movieName;
        public string? MovieName 
        { 
            get
            {
                return _movieName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _movieName = value;
            }
        }

        public myType type { get; set; }

        public Seat seat { get; set; }

        private double _price;

        public double Price 
        { 
            get
            {
                return _price;
            }
            set
            {
                if(value > 0)
                    _price = value;
            }
        }

        public double PriceAfterTax
        {
            get
            {
                return _price + _price * 14 / 100;
            }
        }
        #endregion

        #region Point02
        private static int _ticketCounter = 0;
        public int TicketId { get; private set; }

        public static int GetTotalTicketsSold()
        {
            return _ticketCounter;
        }

        #endregion

        private double _tax { get; set; }
        private double _discountBefore { get; set; }
        private double _discountAfter { get; set; }

        public Ticket(string? movieName, myType type, Seat seat, double price)
        {
            MovieName = movieName;
            this.type = type;
            this.seat = seat;
            Price = price;
            _ticketCounter++;
            TicketId = _ticketCounter;
        }
        public Ticket(string movieName) : this(movieName, myType.Standard, new Seat('A', 1), 50) { }


        public double CalcTotal(double taxPercent)
        {
            _tax = taxPercent;
            return _price + (_price * taxPercent / 100);
        }

        public void ApplyDiscount(ref double discountAmount)
        {
            _discountBefore = discountAmount;
            if (discountAmount > 0 && discountAmount <= _price)
            {
                _price -= discountAmount;
                discountAmount = 0;
            }
            _discountAfter = discountAmount;
        }

        public void PrintTicket(double total)
        {
            Console.WriteLine("\n===== Ticket Info ===== ");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {type.ToString()}");
            Console.WriteLine($"Seat     : {seat.ToString()}");
            Console.WriteLine($"Price    : {_price:F2}");
            Console.WriteLine($"Total ({_tax}% Tax) : {total:F2}");
        }

        public void PrintAfterDiscount()
        {
            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before : {_discountBefore:F2}");
            Console.WriteLine($"Discount After  : {_discountAfter:F2}");
            Console.WriteLine($"Movie    : {MovieName}");
            Console.WriteLine($"Type     : {type.ToString()}");
        }
    }
}
