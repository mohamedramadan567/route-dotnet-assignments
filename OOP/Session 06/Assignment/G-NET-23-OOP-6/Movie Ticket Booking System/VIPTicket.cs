using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_6.Movie_Ticket_Booking_System
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
            Console.Write($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} ");
            Console.WriteLine($"| Price: {Price} | Final: {PriceAfterTax:F2} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override void TypePrice()
        {
            Console.WriteLine($"VIPTicket => Final Price: {PriceAfterTax}");
        }

        //public override Ticket Clone() => new VIPTicket(MovieName, Price, LoungeAccess);
    }
}
