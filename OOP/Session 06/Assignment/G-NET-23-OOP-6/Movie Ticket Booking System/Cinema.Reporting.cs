using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_6.Movie_Ticket_Booking_System
{
    internal partial class Cinema
    {
        //Composition
        private Projector _projector = new Projector();

        public void Print()
        {
            Console.WriteLine("\n\n--- All Tickets (from Cinema.Reporting) --- ");

            foreach (IPrintable item in _tickets)
            {
                if (item == null) break;

                item.Print();
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("=== Cinema Opened === ");
            _projector.Open();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n\n");
            _projector.Close();
            Console.WriteLine("=== Cinema Closed === ");
        }

    }
}
