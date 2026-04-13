using G_NET_23_OOP_6.Movie_Ticket_Booking_System;
using System.Numerics;
using System.Threading;

namespace G_NET_23_OOP_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01
            //Q1 : What is abstraction in OOP? How is it different from 
            //encapsulation? Give a real-world example(not from the
            //session) that shows the difference between the two.

            //Abstraction: means showing only the necessary features to the user while hiding the implementation details.
            //Difference:
            //Abstraction focuses on hiding the implementation details,
            //while encapsulation focuses on protecting and controlling access to data.
            //Real-world example:
            //When using a phone camera, you can take a photo without knowing how the camera works internally (Abstraction).
            //But the phone protects sensitive data like passwords so you cannot access them directly (Encapsulation).



            #endregion

            #region Question02
            //Q2 : What is the difference between an abstract class and an 
            //interface? Give at least four differences. When would you 
            //choose one over the other?

            //Difference:
            //- Abstract class can have implemented and abstract methods, while interface contains only method declarations.
            //- Abstract class can have normal variables, while interface variables are constants.
            //- A class can inherit from only one abstract class, but it can implement multiple interfaces.
            //- Abstract class can have different access modifiers, while interface methods are usually public.

            //When to use:
            //you need multiple inheritance(Encapsualtion).
            //you need classes share common behavior(Abstract).

            #endregion

            #region Question03
            //Q3 : Look at the following code and answer the questions below:
            //public abstract class Appliance 
            //{ 
            //    public string Brand { get; set; } 
            //    protected Appliance(string brand) { Brand = brand; } 
            //    public abstract double PowerConsumption(); 
            //    public virtual string Status() => "Standby"; 
            //    public string Label() => $"{Brand} - {PowerConsumption()}W"; 
            //} 

            //public class WashingMachine : Appliance 
            //{ 
            //    public WashingMachine(string brand) : base(brand) { } 
            //    public override double PowerConsumption() => 500; 
            //    public override string Status() => "Washing"; 
            //} 

            //public class Toaster : Appliance 
            //{ 
            //    public Toaster(string brand) : base(brand) { } 
            //    public override double PowerConsumption() => 800; 
            //}

            //a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not? 
            //Answer: No, because you can't able to make a object from abstract class.

            //b) What is the difference between the three methods: PowerConsumption(), Status(), 
            //and Label()? Why did the designer make each one abstract, virtual, or concrete? 
            //PowerConsumption(): the user make it abstract because it's don't have implementation.
            //Status(): to derived class can override to this method.
            //Label(): To keep the Method inherited as it is.

            //c) If you call Status() on a Toaster object, what will it return? Why?
            //Output: Standby  - because: Toaster class don't override on this method.


            #endregion

            #region Question04
            //Q4 : Look at the following code and answer the questions below:
            // File: Calculator.cs 
            //public partial class Calculator 
            //{ 
            //    public double LastResult { get; private set; } 
            //    partial void OnCalculated(double result); 

            //    public double Add(double a, double b) 
            //    { 
            //        LastResult = a + b; 
            //        OnCalculated(LastResult); 
            //        return LastResult; 
            //    } 
            //} 

            //// File: Calculator.Logging.cs 
            //public partial class Calculator 
            //{ 
            //    partial void OnCalculated(double result) 
            //    { 
            //        Console.WriteLine($"Log: result = {result}"); 
            //    } 
            //} 

            //// File: DoubleExtensions.cs 
            //public static class DoubleExtensions 
            //{ 
            //    public static string ToCurrency(this double value) 
            //        => $"${value:F2}"; 
            //} 

            //a) What is a partial class? Why would a developer split Calculator into two files? 
            //A partial class allows you to split a single class definition across multiple files.
            //developer split Calculator may to organize or to separate the calculator logic from the logging functionality.

            //b) What is a partial method? What happens if the OnCalculated() implementation in 
            //Calculator.Logging.cs is deleted — will the code still compile? Why? 
            //A partial method is declared in one part of a partial class and optionally implemented in another part.
            //the code will compile because partial method make the code safe and compiler ignore the line.

            //c) What is an extension method? What are the three rules for writing one? 
            //an extension method lets you add new methods to an existing type without modifying its source code, without inheritance, and without recompiling.
            //must to be: static class - static method - first parameter begin with "this" keyword 

            //d) What will the following code print?
            //Calculator calc = new Calculator();
            //double result = calc.Add(19.5, 0.5);
            //Console.WriteLine(result.ToCurrency());
            //Output:
            //Log: result = 20
            //20.00


            #endregion

            #endregion

            #region Part02
            Cinema cinema = new Cinema();
            cinema.OpenCinema();
            //Ticket t = new Ticket("Test", 100);
            Console.WriteLine("\n\n// Ticket t = new Ticket(\"Test\", 100);  // ERROR: Cannot create instance of abstract type 'Ticket'");

            StandardTicket standardTicket = new StandardTicket("Inception", 80, "A5");
            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
            IMAXTicket imaxTicket = new IMAXTicket("Dune", 100, true);
            standardTicket.Book();
            vipTicket.Book();
            imaxTicket.Book();

            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.Print();

            vipTicket.Reciept();
            Ticket[] tickets = { standardTicket, vipTicket, imaxTicket };
            tickets.TotalRevenue();

            cinema.CloseCinema();
            #endregion
        }
    }
}
