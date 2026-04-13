using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_5.Movie_Ticket_Booking_System
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
            base.Print();
            Console.WriteLine($"  Seat: {SeatNumber} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override Ticket Clone() => new StandardTicket(MovieName, Price, SeatNumber);

    }
}
