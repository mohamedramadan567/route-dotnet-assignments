using G_NET_23_OOP_3.Movie_Ticket_Booking_System;
using System;
using System.ComponentModel;
using System.Reflection.Metadata;

namespace G_NET_23_OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01
            //Q1 : Identify the type of relationship in each scenario below 
            //(Inheritance, Association, Aggregation, Composition, or 
            //Dependency): 

            //a) A University has Departments. If the university is closed, the
            //departments no longer exist. => (Composition)

            //b) A Driver uses a Car.The driver does not own the car. => (Association)
            //c) A Dog is an Animal. => (Inheritance)
            //d) A Team has Players. If the team is deleted, the players still
            //exist. => (Aggregation)
            //e) A method receives a Logger as a parameter and calls it inside
            //the method only. => (Dependency)
            #endregion

            #region Question02

            //Q2: Answer the following questions about access modifiers and sealed: 

            //a) A parent class has a protected field. Can a child class in a 
            //different assembly access it? => Yes 
            //What about through an object instance from outside? => No

            //b) What is the difference between protected internal and private 
            //protected? 
            // => protected internal: (OR) can access if the same assembly or other assembly but there is Inheritance.
            // => private protected: (AND) must the same assembly and there is Inheritance.

            //c) What does the sealed keyword do when applied to a class? 
            //What about when applied to a method?
            // => class: sealed class prevent inheritance.
            // => method: sealed method prevent override.

            //d) Can you create an object from a sealed class using new? Why 
            //or why not ?
            // => yes, you can becauese sealed prevent inheritance not instantiation.

            #endregion

            #endregion

            #region Part02
            Cinema cinema = new Cinema("StarLight Cinema");
            cinema.OpenCinema();

            StandardTicket standardTicket = new StandardTicket("Inception", 120, "A-5");
            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
            IMAXTicket imaxTicket = new IMAXTicket("Dune", 180, true);
            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.PrintAllTickets();

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

    }
}
