using G_NET_23_OOP_4.Movie_Ticket_Booking_System;

namespace G_NET_23_OOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //Part 01 : Theoretical Questions

            //Q1: What is the difference between static binding and
            //dynamic binding? When does each one happen?
            // Static binding: means the method call is resolved at compile time based on reference type.
            //      When? Compile time.
            // Dynamic binding:  means the method call is resolved at runtime based on the actual object..
            //      When? Runtime.

            //Q2 :  What is the difference between method overloading and
            //method overriding? 
            // Method overloading: Same method name, different parameter lists  - don't need inheritance to achieve it- static ploymorphism. 
            // Method overriding: Derived class overrides a virtual method from the base class - need inheritance to achieve it - dynamic ploymorphism.


            //Q3: What keywords are used for Method Overriding? What
            //does each one mean ?
            // virtaul: Allows a method in the base class to be overridden in derived classes.
            // override: Provides a new implementation for a virtual method inherited from the base class.


            #endregion

            #region Part02
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");
            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
            IMAXTicket imaxTicket = new IMAXTicket("Dune", 180, false);

            Console.WriteLine("\n\n========== SetPrice Test ========== ");
            standardTicket.SetPrice(150m);
            standardTicket.SetPrice(100m, 1.5m);

            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.PrintAllTickets();

            ProcessTicket(vipTicket);
            Console.WriteLine("\n\n========== Statistics ========== ");
            Console.WriteLine($"Total Tickets Created: {cinema.TotalTickets()}");
            PrintBookingReference(2);
            cinema.CloseCinema();
            #endregion
        }

        public static void PrintBookingReference(int numberOfReferences)
        {
            Console.WriteLine("\n\n========== Booking References ========== ");
            for (int i = 0; i < numberOfReferences; i++)
            {
                Console.WriteLine($"Booking Ref {i + 1}: {BookingHelper.GenerateBookingReference()}");
            }
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n\n========== Process Single Ticket ==========");
            t.PrintTicket();
        }

    }
}
