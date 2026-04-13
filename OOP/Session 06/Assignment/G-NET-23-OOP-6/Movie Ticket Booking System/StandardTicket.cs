using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_6.Movie_Ticket_Booking_System
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public StandardTicket(string movieName, decimal price, string seatNumber) : base(movieName, price) 
        { 
            SeatNumber = seatNumber;
        }

        public override void Print()
        {
            Console.Write($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {SeatNumber} ");
            Console.WriteLine($"| Price: {Price} | Final: {PriceAfterTax:F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void TypePrice()
        {
            Console.WriteLine($"StandardTicket => Final Price: {PriceAfterTax}");
        }

        //public override Ticket Clone() => new StandardTicket(MovieName, Price, SeatNumber);

    }
}
