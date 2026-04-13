using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_5.Movie_Ticket_Booking_System
{
    internal class VIPTicket : Ticket, IPrintable
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; private set; } = 50;

        
        public VIPTicket(string movieName, decimal price, bool loungeAccess): base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"  Lounge: {(LoungeAccess ? "Yes" : "No")} | Service Fee: {ServiceFee} EGP | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override Ticket Clone() => new VIPTicket(MovieName, Price, LoungeAccess);
    }
}
