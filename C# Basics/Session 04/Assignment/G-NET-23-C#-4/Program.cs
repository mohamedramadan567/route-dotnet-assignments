using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Reflection.Metadata;
using System.Text;
namespace G_NET_23_C__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //string productList = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList +="PROD-" + i + ",";
            //}
            //(a) Explain why this code is inefficient. Reference what happens in memory
            // Because compiler create 5001 object from string while he need one object only

            //(b) Rewrite this code using StringBuilder to be more efficient.
            //StringBuilder productList = new StringBuilder("");
            //for(int i = 1;  i <= 5000; i++)
            //{
            //    productList.Append($"PROD-{i},");
            //}

            //(c) Add timing code (using Stopwatch) to both versions and report the time difference.

            //Stopwatch sw01 = new Stopwatch();
            //Stopwatch sw02 = new Stopwatch();

            //sw01.Start();
            //string productList01 = "";
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList01 += "PROD-" + i + ",";
            //}
            //sw01.Stop();

            //sw02.Start();
            //StringBuilder productList02 = new StringBuilder("");
            //for (int i = 1; i <= 5000; i++)
            //{
            //    productList02.Append($"PROD-{i},");
            //}
            //sw02.Stop();

            //Console.WriteLine($"String time taken: {sw01.ElapsedMilliseconds} ms");
            //Console.WriteLine($"StringBuilder time taken: {sw02.ElapsedMilliseconds} ms");

            #endregion

            #region Question02
            //Ticket Pricing System
            //int age = 0, day = 0;
            //bool isStudent = false, isWeekend = false;
            //double price = 0, discount = 0;
            //string studentInput;

            //Console.WriteLine("==============================");
            //Console.WriteLine(" Cinema Ticket Pricing System ");
            //Console.WriteLine("==============================");

            //Console.Write("Enter your age: ");
            //age = int.Parse(Console.ReadLine());

            //Console.Write("Enter day of week (1-7) [6=Fri, 7=Sat]: ");
            //day = int.Parse(Console.ReadLine());

            //Console.Write("Do you have a valid student ID? (yes/no): ");
            //studentInput = Console.ReadLine().ToLower();


            //if (studentInput == "yes")
            //    isStudent = true;

            //if (day == 6 || day == 7)
            //    isWeekend = true;

            //if (age < 5)
            //    price += 0;
            //else if (age >= 5 && age <= 12)
            //    price += 30;
            //else if (age >= 13 && age < 60)
            //    price += 50;
            //else
            //    price += 25;


            //Console.WriteLine("\n----- Price Breakdown -----");

            //if (price == 0)
            //{
            //    Console.WriteLine("Base price: Free");
            //    Console.WriteLine("No weekend surcharge applied");
            //    Console.WriteLine("No student discount applied");
            //    Console.WriteLine("Final price: 0 LE");
            //    return;
            //}

            //Console.WriteLine($"Base price: {price} LE");

            //if (isWeekend)
            //{
            //    price += 10;
            //    Console.WriteLine("Weekend surcharge: +10 LE");
            //}
            //else
            //{
            //    Console.WriteLine("No weekend surcharge");
            //}

            //if (isStudent)
            //{
            //    discount = price * 0.20;
            //    price -= discount;
            //    Console.WriteLine($"Student discount (20%): -{discount} LE");
            //}
            //else
            //{
            //    Console.WriteLine("No student discount");
            //}

            //Console.WriteLine($"Final price: {price} LE");

            #endregion

            #region Question03
            //string fileExtension01 = ".pdf"; 
            //string fileType01;

            //if (fileExtension01 == ".pdf")
            //{
            //    fileType01 = "PDF Document";
            //}
            //else if (fileExtension01 == ".docx" || fileExtension01 == ".doc")
            //{
            //    fileType01 = "Word Document";
            //}
            //else if (fileExtension01 == ".xlsx" || fileExtension01 == ".xls")
            //{
            //    fileType01 = "Excel Spreadsheet";
            //}
            //else if (fileExtension01 == ".jpg" || fileExtension01 == ".jpeg" ||
            //         fileExtension01 == ".png" || fileExtension01 == ".gif")
            //{
            //    fileType01 = "Image File";
            //}
            //else
            //{
            //    fileType01 = "Unknown File Type";
            //}

            //string fileExtension = ".docx";  
            //string fileType;

            //switch (fileExtension)
            //{
            //    case ".pdf":
            //        fileType = "PDF Document";
            //        break;

            //    case ".docx":
            //    case ".doc":
            //        fileType = "Word Document";
            //        break;

            //    case ".xlsx":
            //    case ".xls":
            //        fileType = "Excel Spreadsheet";
            //        break;

            //    case ".jpg":
            //    case ".png":
            //    case ".gif":
            //        fileType = "Image File";
            //        break;

            //    default:
            //        fileType = "Unknown File Type";
            //        break;
            //}


            //(b) A switch expression
            //string fileExtension = ".docx";
            //string fileType = fileExtension switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel Spreadsheet",
            //    ".jpg" or ".png" or ".gif" => "Image File",
            //    _  => "Unknown File Type"
            //};
            #endregion

            #region Question04
            //Ternary Operator
            //int temperature = 35;
            //string weatherAdvice;

            //if (temperature < 0)
            //    weatherAdvice = "Freezing! Stay indoors.";
            //else if (temperature < 15)
            //    weatherAdvice = "Cold. Wear a jacket.";
            //else if (temperature < 25)
            //    weatherAdvice = "Pleasant weather.";
            //else if (temperature < 35)
            //    weatherAdvice = "Warm. Stay hydrated.";
            //else
            //    weatherAdvice = "Hot! Avoid sun exposure.";

            //using only ternary operators (no if statements):
            //weatherAdvice = temperature < 0
            //    ? "Freezing! Stay indoors." : temperature < 15
            //    ? "Cold. Wear a jacket." : temperature < 25
            //    ? "Pleasant weather." : temperature < 35
            //    ? "Warm. Stay hydrated." : "Hot! Avoid sun exposure.";
            //Console.WriteLine(weatherAdvice);

            // Is the ternary version more readable? of course no
            //When would you choose one over the other ? 
            //if there is if-else only use Ternary Operator but if code more complex use if-else if-else 
            #endregion

            #region Question05
            //Input Validation with Loops
            //string password;
            //bool valid = false;
            //bool upperletterFound = false, digitFound = false, spaceFound = false;
            //int attempts = 5;
            //do
            //{
            //    attempts--;
            //    valid = false;
            //    upperletterFound = false;
            //    digitFound = false;
            //    spaceFound = false;
            //    Console.Write("Enter Valid Password: ");
            //    password = Console.ReadLine();

            //    foreach (var item in password)
            //    {
            //        if (Char.IsUpper(item))
            //            upperletterFound = true;
            //        if (Char.IsDigit(item))
            //            digitFound = true;
            //        if (item == ' ')
            //        {
            //            spaceFound = true;
            //            break;
            //        }
            //    }
            //    if (upperletterFound && digitFound && !spaceFound && password.Length >= 8)
            //    {
            //        valid = true;
            //        break;
            //    }
            //    if (attempts == 0)
            //        break;
            //    if (password.Length < 8 || !upperletterFound || !digitFound || spaceFound)
            //    {
            //        Console.WriteLine("Please Follow this following instructions: ");
            //        Console.WriteLine("Minimum 8 characters");
            //        Console.WriteLine("At least one uppercase letter");
            //        Console.WriteLine("At least one digit");
            //        Console.WriteLine("No spaces allowed");
            //    }

            //} while (!valid && attempts > 0);
            //if (attempts == 0) Console.WriteLine("Account locked");
            //else
            //    Console.WriteLine("Password accepted!");

            #endregion

            #region Question06
            // Array Processing
            //int[] scores = { 85, 42, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
            //(a)Find and display all failing scores(below 50)
            //Console.WriteLine("Failing scores (below 50):");

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] < 50)
            //        Console.WriteLine(scores[i]);
            //}

            //(b) Find the first score above 90 and stop searching immediately
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] > 90)
            //    {
            //        Console.WriteLine("First score above 90: " + scores[i]);
            //        break;
            //    }
            //}

            //(c) Calculate the class average, excluding any scores below 40 (considered absent)
            //int sum = 0;
            //int count = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] >= 40)
            //    {
            //        sum += scores[i];
            //        count++;
            //    }
            //}

            //double average = (double)sum / count;
            //Console.WriteLine("Class average (excluding absent): " + average);

            //(d) Count how many students scored in each grade range:
            //int A = 0, B = 0, C = 0, D = 0, F = 0;

            //foreach (int score in scores)
            //{
            //    if (score >= 90)
            //        A++;
            //    else if (score >= 80)
            //        B++;
            //    else if (score >= 70)
            //        C++;
            //    else if (score >= 60)
            //        D++;
            //    else
            //        F++;
            //}

            //Console.WriteLine("Grade Distribution:");
            //Console.WriteLine("A (90-100): " + A);
            //Console.WriteLine("B (80-89): " + B);
            //Console.WriteLine("C (70-79): " + C);
            //Console.WriteLine("D (60-69): " + D);
            //Console.WriteLine("F (Below 60): " + F);

            #endregion
        }
    }
}
