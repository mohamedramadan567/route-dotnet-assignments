namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //end
            #region Task1
            string s = "Hello";
            string s02 = "";

            Console.WriteLine(s02);
            
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s02 += s[i];
            }
            s = s02;

            Console.WriteLine(s);
            #endregion

            #region Task2

            //for(int i = 1; i <= 50; i++)
            //{
            //    if(i % 3 == 0 && i % 5 == 0)
            //        Console.WriteLine("FizzBuzz");
            //    else if(i % 3 == 0)
            //        Console.WriteLine("Fizz");
            //    else if(i % 5 == 0)
            //        Console.WriteLine("Buzz");
            //}

            #endregion

            #region Task3
            //int score = 90;

            //switch (score)
            //{
            //    case >= 90:
            //        Console.WriteLine("A");
            //        break;
            //    case >= 80:
            //        Console.WriteLine("B");
            //        break;
            //    case >= 70:
            //        Console.WriteLine("C");
            //        break;
            //    case >= 60:
            //        Console.WriteLine("D");
            //        break;
            //    default:
            //        Console.WriteLine("F");
            //        break;
            //}
            #endregion

            #region Task4
            //string name = "Mohamed";
            //int countVowels = 0;
            //string name2 = name.ToLower();
            //foreach (char c in name2)
            //{
            //    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //        countVowels++;
            //}
            //Console.WriteLine($"Number of vowels = {countVowels}");

            #endregion
        }
    }
}
