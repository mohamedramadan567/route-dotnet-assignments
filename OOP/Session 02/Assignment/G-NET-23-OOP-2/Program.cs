using G_NET_23_OOP_2.Movie_Ticket_Booking_System;
using System;
using System.ComponentModel;

namespace G_NET_23_OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01
            //Q1 : Consider the following class: 
            //public class BankAccount 
            //{ 
            //    public string Owner; 
            //    public double Balance; 
            //    public void Withdraw(double amount) 
            //    { 
            //        Balance -= amount; 
            //    } 
            //} 

            //a) Identify at least two problems with this design from an encapsulation perspective.
            //Aswer: - Lack of Access Control (No Data Hiding).   - No Validation or Business Rules Enforcement.

            //b) Describe how you would fix this class to follow proper encapsulation 
            //principles.You do not need to write the full code. 
            //answer:
            //private string owner;
            //private double balance;

            //public string Owner
            //{
            //    get { return owner; }
            //}

            //public double Balance
            //{
            //    get { return balance; }
            //    private set { balance = value; }
            //}

            //c) Explain why exposing fields directly (as public) is considered a bad 
            //practice in OOP.
            //Answer: because it allows external code to access and modify the object's data without any control or validation.

            #endregion


            #region Question02
            //Q02 : What is the difference between a field and a property in 
            //C#?   
            //Field                             Property
            //Direct data storage               Controlled access
            //No validation                     Can validation
            //Breake encapsulation              Enforce encapsulation

            //Can a property contain logic? Yes, like we can check value is valid or not.

            //Give an example of a read only property that returns a calculated value.
            //private double _width, _height;
            //public double Area
            //{
            //    get { return _width * _height; }
            //}


            #endregion


            #region Question03
            //Q3 : Look at the following code and answer the questions 
            //below: 
            //public class StudentRegister 
            //{ 
            //private string[] names = new string[5]; 
            //} 
            //public string this[int index] 
            //{ 
            //get { return names[index]; } 
            //set { names[index] = value; } 
            //} 
            //a) What is `this[int index]` called? Explain its purpose.
            //answer: it's indexer, it's use to make object as a container and it allows an object to be accessed like an array
            //and provides controlled access to internal data

            //b) What happens if someone writes `register[10] = "Ali";` ? How would you 
            //make the indexer safer?
            //`register[10] = "Ali";` => IndexOutOfRangeException
            //public string this[int index] 
            //{ 
            //get { return names[index]; } 
            //set
            //{
            //  if(index >= 0 && index < names.Length)
            //      names[index] = value;
            //} 
            //}

            //c) Can a class have more than one indexer? If yes, give an example of when 
            //that would be useful.
            //yes, the class can have more than one indexer it's called indexer overloading
            //public string this[int index]
            //{
            //    get { return names[index]; }
            //    set { names[index] = value; }
            //}

            //public string this[string name]
            //{
            //    get
            //    {
            //        foreach (var n in names)
            //            if (n == name)
            //                return n;
            //        return null;
            //    }
            //}
            #endregion

            #region Question04
            //Q4: Consider the following code and answer the questions
            //below:
            //public class Order
            //{
            //    public static int TotalOrders = 0;
            //    public string Item;
            //    public Order(string item)
            //    {
            //        Item = item;
            //        TotalOrders++;
            //    }
            //}
            //a) What does the `static` keyword mean on `TotalOrders`? How is it
            //different from the `Item` field?
            //static keyword means TotalOrders belongs to class 'Order' not to instance and it's shared across all usage.
            //TotalOrders                       Item
            //belongs to class                  belongs to an object
            //one copy shared for all           each object has it's own copy


            //b) Can a static method inside `Order` access the `Item` field directly? Why
            //or why not? 
            //static method can't access item directly because static method belongs to class while item belongs to an object 
            //and change between every object.


            #endregion

            #endregion

            #region Part02
            ReadTickets(3, out Cinema cinema);

            PrintAllTickets(cinema);
            SearchByMovieName(cinema);

            Console.WriteLine($"\n\nTotal tickets sold: {TotalTicketsSold(cinema)}"); ;
            PrintBookingReference(2);

            Console.WriteLine($"\n\nTotal discount for a group of 5 tickets at 80 EGP each of them: {TotalDiscount(5, 80)} EGP");

            #endregion
        }

        public static void ReadTicket(out string? movieName, out myType type, out Seat seat, out double price)
        {
            Console.Write("Movie Name: ");
            movieName = Console.ReadLine();
            


            bool isParsed;

            do
            {
                Console.Write("Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
                isParsed = Enum.TryParse<myType>(Console.ReadLine(), out type);
            }
            while (!isParsed || !Enum.IsDefined(type));
            char row;
            bool isUpper = false;
            do
            {
                Console.Write("Seat Row (A-Z): ");
                isParsed = char.TryParse(Console.ReadLine(), out row);
                isUpper = isParsed && row >= 'A' && row <= 'Z';
            } while (!isUpper);

            int number;
            do
            {
                Console.Write("Seat Number: ");
                isParsed = Int32.TryParse(Console.ReadLine(), out number);
            } while (!isParsed);

            seat = new Seat(row, number);

            do
            {
                Console.Write("Price: ");
                isParsed = double.TryParse(Console.ReadLine(), out price);
            } while (!isParsed);

        }
        
        public static void ReadTickets(int numberofTicket, out Cinema cinema)
        {
            cinema = new Cinema();
            string? movieName;
            myType type;
            Seat seat;
            double price;

            Console.WriteLine("========== Ticket Booking ==========");
            for (int i = 1; i <= numberofTicket; i++)
            {
                Console.WriteLine($"\n\nEnter data for Ticket {i}:");
                ReadTicket(out movieName, out type, out seat, out price);
                cinema.AddTicket(new Ticket(movieName, type, seat, price));
            }

        }
        public static void PrintAllTickets(Cinema cinema)
        {
            Console.WriteLine("\n\n========== All Tickets ==========\n\n");
            foreach(var ticket in cinema)
            {
                Console.WriteLine($"Ticket #{ticket.TicketId} | {ticket.MovieName} | {ticket.type} | Seat: {ticket.seat} | Price: {ticket.Price} EGP | After Tax: {ticket.PriceAfterTax} EGP");
            }
        }

        public static void SearchByMovieName(Cinema cinema)
        {
            string? movieName;
            Console.WriteLine("\n\n========== Search by Movie ========== ");
            Console.Write("Enter movie name to search: ");
            movieName = Console.ReadLine();

            int count = 0;
            foreach(var ticket in cinema)
            {
                count++;
                if(ticket.MovieName?.ToLower() == movieName?.ToLower())
                {
                    Console.WriteLine($"Found: Ticket #{count} | {ticket.MovieName} | {ticket.type} | Seat: {ticket.seat} | Price: {ticket.Price} EGP");
                    return;
                }
            }
            Console.WriteLine("Not Found :-(");
        }
        
        public static void PrintBookingReference(int numberOfReferences)
        {
            Console.WriteLine("\n\n========== Booking References ========== ");
            for (int i = 0; i < numberOfReferences; i++)
            {
                Console.WriteLine($"Reference #{i + 1}: {BookingHelper.GenerateBookingReference()}");
            }
        }

        public static double TotalDiscount(int numberOfTickets, double pricePerTicket)
        {
            double totalPrice = numberOfTickets * pricePerTicket;
            double priceAfterDiscount = BookingHelper.CalcGroupDiscount(numberOfTickets, pricePerTicket);
            return totalPrice -= priceAfterDiscount;
        }

        public static int TotalTicketsSold(Cinema cinema)
        {
            return cinema.Count();
        }
    }
}
