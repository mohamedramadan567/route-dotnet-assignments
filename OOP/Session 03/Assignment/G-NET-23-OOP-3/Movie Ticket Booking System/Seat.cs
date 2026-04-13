using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_3.Movie_Ticket_Booking_System
{
    internal struct Seat
    {
        public char Row { get; set; }

        public int Number { get; set; }

        public Seat(char row, int number)
        {
            Row = row;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Row}-{Number}";
        }
    }
}
