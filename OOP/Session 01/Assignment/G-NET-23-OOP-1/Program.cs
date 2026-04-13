using G_NET_23_OOP_1.Part01;
using G_NET_23_OOP_1.Part02;

namespace G_NET_23_OOP_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Question01
            //Q1 : Explain with code example how class and struct behave differently
            //Class is reference type (stored in heap) when assignment copy the reference if change value in one the other will change.
            //struct is value type (stored in stack) when assignment copy the data if change value in one the other don't change.

            //TestClass testClass01 = new TestClass();
            //testClass01.prop01 = 1;
            //TestClass testClass02 = testClass01;
            //Console.WriteLine($"before Changing class01: {testClass01.prop01}, class02: {testClass02.prop01}");
            //testClass02.prop01 = 2;
            //Console.WriteLine($"After Changing class01: {testClass01.prop01}, class02: {testClass02.prop01}");

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //TestStruct testStruct01 = new TestStruct();
            //testStruct01.prop01 = 1;
            //TestStruct testStruct02 = testStruct01;
            //Console.WriteLine($"before Changing struct01: {testStruct01.prop01}, struct02: {testStruct02.prop01}");
            //testStruct02.prop01 = 2;
            //Console.WriteLine($"After Changing struct01: {testStruct01.prop01}, struct02: {testStruct02.prop01}");

            #endregion

            #region Question02
            //Q2 : Explain the difference between public and private access 
            //modifiers with an example.  

            //private: The member is only accessible within the class or struct it is defined in. It cannot be accessed from outside the class.
            //public : The member is accessible from anywhere in the application, both within the same project and from other projects.

            //TestClass testClass03 = new TestClass();
            //testClass03.PrintPublicMessage();
            //testClass03.PrintPrivateMessage(); //Error Inaccessible 


            #endregion

            #region Question03
            //Q3 : Describe the steps to create and use a class library in Visual Studio.
            //1. implement the library project and make every thing is public.
            //2. build the project to get .dll file.
            //3. In the other project (must be the same version or project has higher version) add a **project reference** to the class library project (not just the DLL).
            //4. write `using libraryNamespace;` before your namespace in the project to use the classes.            #endregion
            #endregion

            #region Question04
            //Q4 : What is a class library? Why do we use class libraries?
            //class library: is a separate project that contains reusable classes,
            //but has no Main method and cannot run on its own. It compiles into a .dll file

            //#we use it to: Reusability - Organisation - Teamwork - Maintenance.
            //#class libraries also enable versioning, security, and deployment benefits.
            #endregion

            #endregion


            #region Part02
            ReadInputs(out string? movieName, out myType type, out Seat seat, out double price, out double discountAmount);
            Ticket ticket01 = new Ticket(movieName, type, seat, price);
            double total = ticket01.CalcTotal(14);

            ticket01.PrintTicket();

            ticket01.ApplyDiscount(ref discountAmount);
            #endregion

        }
        public static void ReadInputs(out string? movieName, out myType type, out Seat seat, out double price, out double discountAmount)
        {
            Console.Write("Enter Movie Name: ");
            movieName = Console.ReadLine();

            bool isParsed;

            do
            {
                Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
                isParsed = Enum.TryParse<myType>(Console.ReadLine(), out type);
            }
            while (!isParsed || !Enum.IsDefined(type));
            char row;
            do
            {
                Console.Write("Enter Seat Row (A, B, C...): ");
                isParsed = char.TryParse(Console.ReadLine(), out row);
            } while (!isParsed);

            int number;
            do
            {
                Console.Write("Enter Seat Number: ");
                isParsed = Int32.TryParse(Console.ReadLine(), out number);
            } while (!isParsed);

            seat = new Seat(row, number);

            do
            {
                Console.Write("Enter Price: ");
                isParsed = double.TryParse(Console.ReadLine(), out price);
            } while (!isParsed);

            do
            {
                Console.Write("Enter Discount Amount: ");
                isParsed = double.TryParse(Console.ReadLine(), out discountAmount);
            } while (!isParsed);
        }

    }
}
