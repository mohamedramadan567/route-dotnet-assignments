using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_5.Movie_Ticket_Booking_System
{
    internal class BookingHelper
    {
        private static int _counter = 0;
        public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
            double totalDiscount = totalPrice * 0.1;
            if (numberOfTickets >= 5)
            {
                totalPrice -= totalDiscount;
            }
            return totalPrice;
        }

        public static string GenerateBookingReference()
        {
            _counter++;
            return $"BK-{_counter}";
        }

        public static void PrintAll(IPrintable[] Items)
        {
            foreach (IPrintable Item in Items)
            {
                if (Item == null) break;
                Item.Print();
            }
        }
    }
}
