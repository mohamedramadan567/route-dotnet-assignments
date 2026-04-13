namespace G_NET_23_C__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Q1: What will this print and explain what happens? 
            //double d = 9.99;
            //int x = (int)d; //explicit casting
            //Console.WriteLine(x);

            //output
            //9 because explicit casting truncate value
            #endregion

            #region Q2
            //Q2: This code doesn’t compile. Fix it with the smallest change? 
            //int n = 5;
            //double d2 = (double)n / 2; //change n from intger to double
            //Console.WriteLine(d2);

            #endregion

            #region Q3
            //Q3: You read a number from user input .. Write the correct line to   
            //get age as int. 

            //Console.WriteLine("Enter Your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);
            #endregion

            #region Q4
            //Q4: What happens here and why?   
            //string s = "12a";
            //int x = int.Parse(s); //not allow convert unformat string to integar
            //Console.WriteLine(x); //Exception 

            #endregion

            #region Q5
            //Q5: Complete the code from the previous question so it prints 
            //Invalid if conversion into int  fails, otherwise prints the number 

            //string s = "12a";
            //if(int.TryParse(s, out int x))
            //{
            //    Console.WriteLine(x);
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid conversion");
            //}
            #endregion

            #region Q6
            //Q6: What will this print and explain why ? 
            //object o = 10;
            //int a = (int)o; //unboxing 
            //Console.WriteLine(a + 1); //output: 11 because after unboxing we add 1 to a

            #endregion

            #region Q7
            //Q7: What will this print and explain why and if there is a   
            //problem handle it ? 
            //object o = 10; 
            //long x = (long)o; //invalid unboxing because o defined as int not long
            //Console.WriteLine(x); //InvalidCastException 

            //fix
            //object o = 10;
            //long x = (long)(int)o;
            //Console.WriteLine(x);
            #endregion

            #region Q8
            //Q8: Fix this to avoid exceptions and print -1 if conversion isn’t       
            //possible? 
            //object o = 10;

            //if (o is int i)
            //{
            //    long x = i;
            //    Console.WriteLine(x);
            //}
            //else if (o is long l)
            //{
            //    Console.WriteLine(l);
            //}
            //else
            //{
            //    Console.WriteLine(-1);
            //}


            #endregion

            #region Q9
            //Q9: What will this print and explain why ? 
            //string? name = null;
            //Console.WriteLine(name?.Length); // it prints null (nothing visible) because name?.Length returns null.
            #endregion

            #region Q10
            //Q10: What will this print and explain the process? 
            //string? name2 = null;
            //int length = name2?.Length ?? 0; //output 0 because name2 = null
            #endregion

            #region Q11
            //Q11: What’s wrong with this “safe” code and how can we solve it ? 
            //string? s = null;
            ////int x = int.Parse(s ?? "0"); //not safe because this check nullability only but if s = "mohamed"?
            //int x = int.TryParse(s, out int y) ? y : 0;
            //Console.WriteLine(x);


            #endregion

            #region Q12
            //Q12: What happens here and if there is a problem, handle it  
            //string? s = null;
            ////Console.WriteLine(s!.Length); //Exception (!) tells compiler value is not null 
            //Console.WriteLine(s?.Length); 
            #endregion

            #region Q13
            //Q13: What will this print? 
            //string? s = null;
            //int x = Convert.ToInt32(s);
            //Console.WriteLine(x); //output 0 because Convert.ToInt32 if value null it give default value automatic
            #endregion

            #region Q14
            //Q14: Compare results and explain each result : 
            //string? s = null;

            ////A
            // int a = int.Parse(s); //Exception because Parse does not accept null and expects a valid numeric string.

            ////B
            //int b = Convert.ToInt32(s); //b = 0 because Convert treats null as the default value of int
            //Console.WriteLine(b);
            #endregion

            #region Q15
            //Q15: Complete the line to print "Guest" when user is null,   
            //otherwise print the user name in uppercase: 

            //string? user = null;

            //Console.WriteLine(user?.ToUpper() ?? "Guest");
            #endregion
        }
    }
}
