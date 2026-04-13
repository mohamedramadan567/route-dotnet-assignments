using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_1.Part02
{
    internal class Ticket
    {
        public string? movieName { get; set; }

        public myType type { get; set; }

        public Seat seat { get; set; }

        private double _price;

        public double GetPrice()
        {
            return _price;
        }

        public void SetPrice(double price)
        {
            _price = price;
        }

        public Ticket(string? movieName, myType type, Seat seat, double price)
        {
            this.movieName = movieName;
            this.type = type;
            this.seat = seat;
            this._price = price;
        }
        public Ticket(string? movieName) : this(movieName, myType.Standard, new Seat('A', 1), 50) { }


        public double CalcTotal(double taxPercent)
        {
            double Price = _price;
            return Price + (Price * taxPercent / 100);
        }


        public void ApplyDiscount(ref double discountAmount)
        {
            double discountBefore = discountAmount;
            if (discountAmount > 0 && discountAmount <= _price)
            {
                _price -= discountAmount;
                discountAmount = 0;
            }
            double discountAfter = discountAmount;

            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before : {discountBefore:F2}");
            Console.WriteLine($"Discount After  : {discountAfter:F2}");
            Console.WriteLine($"Movie    : {movieName}");
            Console.WriteLine($"Type     : {type.ToString()}");
        }

        public void PrintTicket()
        {
            Console.WriteLine("\n===== Ticket Info ===== ");
            Console.WriteLine($"Movie    : {movieName}");
            Console.WriteLine($"Type     : {type.ToString()}");
            Console.WriteLine($"Seat     : {seat.ToString()}");
            Console.WriteLine($"Price    : {GetPrice():F2}");
            Console.WriteLine($"Total ({14}% Tax) : {CalcTotal(14):F2}");
        }
    }
}
