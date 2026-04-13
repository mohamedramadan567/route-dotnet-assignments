using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_23_OOP_5.Movie_Ticket_Booking_System
{
    internal class IMAXTicket : Ticket
    {
        private bool _is3D;
        public bool Is3D
        {
            get
            {
                return _is3D;
            }
            set
            {
                if (value && !_is3D)
                    Price += 30;
                else if(!value && _is3D)
                    Price -= 30;

                _is3D = value;

            }
        }

        public IMAXTicket(string movieName, decimal price ,bool is3D) : base(movieName, price)
        {
            Is3D = is3D;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"  IMAX 3D: {(Is3D ? "Yes" : "No")} | Booked: {(IsBooked ? "Yes" : "No")}");
        }

        public override Ticket Clone() => new IMAXTicket(MovieName, Price, Is3D);
        
    }
}
