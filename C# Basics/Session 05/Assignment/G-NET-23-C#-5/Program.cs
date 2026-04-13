using G_NET_23_C__5.Enums;
using System.ComponentModel;
using System.Security.Cryptography;

namespace G_NET_23_C__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Q1 : Day of the Week
            //DayOfWeek dayOfWeek;
            //bool isParsed;
            //int dayNumber;
            //do
            //{
            //    Console.Write("Enter a day number (0-6): ");
            //    isParsed = int.TryParse(Console.ReadLine(), out dayNumber);

            //} while (!isParsed || dayNumber < 0 || dayNumber > 6);

            //dayOfWeek = (DayOfWeek)dayNumber;

            //Console.WriteLine($"Day: {dayOfWeek}");

            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Saturday:
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("It's the Weekend");
            //        break;
            //    default:
            //        Console.WriteLine("It's a Workday");
            //        break;
            //}

            #endregion

            #region Part02
            #region Question01
            ////Array Statistics
            //int[] numbers;
            //bool isPasrsed;
            //long sum = 0;
            //double average = 0;
            //int max, min;
            //int size;
            //do
            //{
            //    Console.Write("Enter array size: ");
            //    isPasrsed = (int.TryParse(Console.ReadLine(), out size) && size > 0);


            //} while (!isPasrsed);

            //numbers = new int[size];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter element [{i}]: ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //    sum += numbers[i];
            //}
            //average = (sum * 1.0 / size);
            //max = min = numbers[0];
            //for (int i = 1; i < size; i++)
            //{
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //    if (numbers[i] < min)
            //        min = numbers[i];
            //}

            //////reverse
            //int[] tempNumbers = new int[size];
            ////for (int i = 0; i < size; i++)
            ////{
            ////    int j = size - 1 - i;
            ////    tempNumbers[j] = numbers[i];
            ////    j--;
            ////}
            ////numbers = tempNumbers;


            //////another solution for reverse
            //for (int i = 0; i < size / 2; i++)
            //{
            //    int j = size - 1 - i;
            //    (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
            //}



            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine($"Sum     = {sum}");
            //Console.WriteLine($"Average = {average}");
            //Console.WriteLine($"Max     = {max}");
            //Console.WriteLine($"Min     = {min}");
            //Console.Write("Reverse = ");
            //for (int i = 0; i < size - 1; i++)
            //{
            //    Console.Write($"{numbers[i]}, ");
            //}
            ////to avoid (,) at the end i print the last element separately
            //Console.WriteLine($"{numbers[size - 1]}");

            #endregion

            #region Question02
            //Q2 : Student Grades Matrix
            // You have 3 students, each with 4 subject grades. Store them in a 2D array. 
            //Write a program that: 
            //• Reads grades from the user into a [3, 4] array. 
            //• Prints each student's average grade. 
            //• Prints the overall class average.
            //int[,] students = new int[3, 4];
            //int[] totalGrades = new int[3];
            //for (int i = 0; i < students.GetLength(0); i++)
            //{
            //    totalGrades[i] = 0;
            //    Console.WriteLine($"--Enter subject grades for student {i + 1}");
            //    for(int j = 0; j < students.GetLength(1); j++)
            //    {
            //        bool isPasrsed;
            //        do
            //        {
            //            Console.Write($"Subject {j + 1} Grade: ");
            //            isPasrsed = int.TryParse(Console.ReadLine(), out students[i, j]);
            //        } while (!isPasrsed);
            //        totalGrades[i] += students[i, j];
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("--Students Average:");
            //for(int  i = 0; i < students.GetLength(0);i++)
            //{
            //    Console.WriteLine($"Student {i + 1}: {totalGrades[i] / 4.0}");
            //}
            //Console.WriteLine();

            //Console.Write("Overall students average:");
            //int overallTotalGrades = 0;
            //foreach(int item in students)
            //{
            //    overallTotalGrades += item;
            //}
            //Console.WriteLine((double)overallTotalGrades / students.Length);
            #endregion

            #endregion

            #region Part03

            #region Question01
            ////Q1 : Basic Calculator Functions 
            //double number01, number02;
            //bool isParsed;
            //string? op;
            //Console.WriteLine("Simple Calculator: ");

            //do
            //{
            //    Console.Write("Enter Operation (+, -, *, /): ");
            //    op = Console.ReadLine();
            //} while (op != "+" && op != "-" && op != "*" && op != "/");


            //do
            //{
            //    Console.Write("Enter number 1: ");
            //    isParsed = double.TryParse(Console.ReadLine(), out number01);
            //} while (!isParsed);


            //do
            //{
            //    Console.Write("Enter number 2: ");
            //    isParsed = double.TryParse(Console.ReadLine(), out number02);
            //} while (!isParsed || ((op == "/") && (number02 == 0)));

            //switch (op)
            //{
            //    case "+":
            //        Console.WriteLine($"{number01} + {number02} = {Add(number01, number02)}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{number01} - {number02} = {Subtract(number01, number02)}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{number01} * {number02} = {Multiply(number01, number02)}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{number01} / {number02} = {Divide(number01, number02)}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid");
            //        break;
            //}

            #endregion

            #region Question02
            //double radius;
            //bool isParsed;
            //Console.WriteLine("Circle Calculator:");
            //do
            //{
            //    Console.Write("Enter redius: ");
            //    isParsed = double.TryParse(Console.ReadLine(), out radius);

            //} while (!isParsed);

            //CalculateCircle(radius, out double area, out double circumference);
            //Console.WriteLine($"Area = {area}");
            //Console.WriteLine($"Circumference = {circumference}");
            #endregion

            #endregion

            #region Student Grade Manager Project
            //int[] scores = new int[5];
            //bool isParsed;

            //Console.WriteLine("             Student Grade Manager\n\n");

            //for(int i =  0; i < scores.Length; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Enter score for Student {i + 1}: ");
            //        isParsed = int.TryParse(Console.ReadLine(), out scores[i]);
            //    } while (!isParsed);

            //}

            //Console.WriteLine("\n\n--- Report ---");
            //for(int i = 0;i < scores.Length; i++)
            //{
            //    Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {GetGrade(scores[i])}");
            //}

            //GetMinMax(scores, out int max, out int min);
            //Console.WriteLine($"\n\nAverage: {CalculateAverage(scores)}");
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine($"Highest Score: {max}");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine($"Lowest Score: {min}");
            //Console.ResetColor();

            #endregion
        }

        #region Calculator Methods

        static double Add(double number01, double number02)
        {
            return number01 + number02;
        }

        static double Subtract(double number01, double number02)
        {
            return (number01 - number02);
        }

        static double Multiply(double number01, double number02)
        {
            return number01 * number02;
        }

        static double Divide(double number01, double number02)
        {
            return (number01 / number02);
        }

        #endregion

        static void CalculateCircle(double radius, out double area, out double circumference)
        {
            area = Math.PI * radius * radius;
            circumference = 2 * Math.PI * radius;
        }


        #region Project Methods

        static Grade GetGrade(int score)
        {
            Grade grade;
            switch (score)
            {
                case >= 90:
                    grade = Grade.A; 
                    break;
                case >= 80: 
                    grade = Grade.B;
                    break;
                case >= 70:
                    grade = Grade.C;
                    break;
                case >= 60:
                    grade = Grade.D;
                    break;
                default:
                    grade = Grade.F;
                    break;
            }
            return grade;
        }


        static double CalculateAverage(int[] scores)
        {
            double sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return (sum / scores.Length);
        }

        static void GetMinMax(int[] scores, out int max, out int min)
        {
            max = min = scores[0];
            for(int i = 1; i < scores.Length; i++)
            {
                if(scores[i] > max)
                    max = scores[i];
                if(scores[i] < min) 
                    min = scores[i];
            }
        }

        #endregion

    }

}
