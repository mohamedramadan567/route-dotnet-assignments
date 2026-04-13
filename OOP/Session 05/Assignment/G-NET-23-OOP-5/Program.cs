using G_NET_23_OOP_5.Movie_Ticket_Booking_System;
using System;
using System.Diagnostics.Metrics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Threading;
using System.Xml.Linq;

namespace G_NET_23_OOP_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Question01
            //Q1 : What is an interface in C#? Why do we use interfaces 
            //instead of depending on concrete classes directly? Mention at
            //least three benefits of using interfaces.

            //An interface defines a contract that a class must follow.
            //It specifies what a class can do, not how it does it.
            //benefits:
            //Enable polymorphism without inheritance.
            //Remove tight coupling between classes.
            //Enable multiple inheritance(behavior).

            #endregion

            #region Qustion02
            //Q2 : Look at the following code and answer the questions below: 

            //interface IEnglishSpeaker 
            //{ 
            //    void Greet(); 
            //}
            //interface IArabicSpeaker
            //{
            //    void Greet();
            //}
            //class Translator : IEnglishSpeaker, IArabicSpeaker 
            //{ 
            //    public void Greet() 
            //    { 
            //    Console.WriteLine("Hello / Ahlan"); 
            //    } 
            //} 

            //a) What is the problem with this design? Both interfaces have a method called Greet() how does the class handle it currently? 
            //Problem: Both interfaces define a method with the same name Greet(), handle it using explicit implementation.

            //b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and 
            //IArabicSpeaker.Greet() says "Ahlan" ? What is this technique called ?

            //class Translator : IEnglishSpeaker, IArabicSpeaker 
            //{ 
            //    void IEnglishSpeaker.Greet()
            //    {
            //        Console.WriteLine("Hello"); 
            //    }
            //    void IArabicSpeaker.Greet()
            //    {
            //        Console.WriteLine("Ahlan");
            //    }
            //} 
            //Technique name: Explicit Interface Implementation.


            //c) After applying your fix, can you call Greet() directly on a Translator object(e.g.
            //translator.Greet()) ? Why or why not? How do you call each version ?
            //You can't call directly if you want print "Hello" you must make reference to interface IEnglishSpeaker.
            //if you want print "ahlan" you must make reference to interface IArabicSpeaker.
            //Examples:
            //IEnglishSpeaker ES = new Translator();
            //IArabicSpeaker AS = new Translator();
            //ES.Greet(); //Hello
            //AS.Greet(); //Ahlan
            #endregion

            #region Qestion03
            //Q3 : Explain the difference between a shallow copy and a 
            //deep copy. When would you use each one? What is the risk of 
            //using a shallow copy when the object has reference-type 
            //fields? 
            //Aspect              Shallow Copy    Deep Copy
            //Reference Fields    Shared          Duplicated
            //Safety              Risky           Safe
            //Performance         Fast            Slower
            //Memory Usage        Lower           Higher

            //When to Use?
            //Shallow → object is immutable, no nested reference state, performance is critical
            //Deep → objects must be isolated, modifications should not affect original

            //Risk to use Shallow copy -> If you modify a reference-type field, it will also affect the original object.

            #endregion

            #region Question04
            //Q4 : Look at the following code and determine the output. 
            //Explain why.
            //class Department { public string Name; }
            //class Employee
            //{ 
            //    public string Title;
            //    public Department Dept;
            //    public Employee ShallowCopy() => (Employee)this.MemberwiseClone(); 
            //} 
            //var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            //var e2 = e1.ShallowCopy();
            //e2.Title = "QA"; 
            //e2.Dept.Name = "Testing"; 
            //Console.WriteLine($"{e1.Title} - {e1.Dept.Name}"); 
            //Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");

            //Output: 
            //Dev - Testing
            //QA - Testing
            //Explanation:
            //Because Shallow Copy copies the object but copies references for reference-type fields.
            // Both e1 and e2 reference the same Department object, so changing Dept.Name affects both.

            #endregion

            #endregion

            #region Part02
            Cinema cinema = new Cinema();
            cinema.OpenCinema();

            StandardTicket standardTicket = new StandardTicket("Inception", 80, "A5");
            VIPTicket vipTicket = new VIPTicket("Avengers", 200, true);
            IMAXTicket imaxTicket = new IMAXTicket("Dune", 130, true);
            standardTicket.Book();
            vipTicket.Book();
            imaxTicket.Book();

            cinema.AddTicket(standardTicket);
            cinema.AddTicket(vipTicket);
            cinema.AddTicket(imaxTicket);

            cinema.Print();

            Console.WriteLine("\n\n--- Clone Test --- ");
            VIPTicket vipTicket2 = (VIPTicket)vipTicket.Clone();
            vipTicket2.MovieName = "Interstellar";
            Console.Write("Original: ");
            vipTicket.Print();
            Console.Write("Clone: ");
            vipTicket2.Print();


            standardTicket.Cancel();
            Console.WriteLine("\n\n--- After Cancellation ---");
            standardTicket.Print();


            Console.WriteLine("\n\n--- BookingHelper.PrintAll ---");
            BookingHelper.PrintAll(new IPrintable[]{standardTicket, vipTicket, imaxTicket});

            cinema.CloseCinema();
            #endregion
        }



    }
}
