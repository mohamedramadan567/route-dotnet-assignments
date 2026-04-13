using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_5.Movie_Ticket_Booking_System
{
    internal class Cinema: IPrintable
    {
        //Composition
        private Projector _projector = new Projector();
        public string CinemaName { get; set; }

        private Ticket?[] _tickets = new Ticket[20];


        public Ticket? this[int index]
        {
            get
            {
                if (index >= 0 && index < _tickets.Length)
                    return _tickets[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < _tickets.Length)
                    _tickets[index] = value;
            }
        }

        public Ticket? this[string name]
        {
            get
            {
                foreach (var ticket in _tickets)
                {
                    if (ticket?.MovieName == name) return ticket;
                }
                return null;
            }

        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < _tickets.Length; i++)
            {
                if (_tickets[i] == null)
                {
                    _tickets[i] = t;
                    return true;
                }
            }
            return false;
        }


        public void Print()
        {
            Console.WriteLine("\n\n========== All Tickets ==========");

            foreach (IPrintable item in _tickets)
            {
                if (item == null) break;

                item.Print();
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine("========== Cinema Opened ========== ");
            _projector.Open();
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n\n========== Cinema Closed ========== ");
            _projector.Close();
        }

        public int TotalTickets()
        {
            int total = 0;
            for(int i = 0; i < _tickets.Length;i++)
            {
                if (_tickets[i] == null)
                    break;
                total++;
            }
            return total;
        }

    }
}
