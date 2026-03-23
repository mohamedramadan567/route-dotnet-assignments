using SessionDemo.EnumExample;
using SessionDemo.Enums;
using System;

namespace SessionDemo
{
	class Program
	{
		static void Main(string[] args)
		{

			#region Part 01 Enum

			#region  Enum

			#region Example 01

			//Priority prio01 = Priority.High;
			//Console.WriteLine($"First Priority = {prio01}"); // High 

			//Priority defaultPriority = default; // 0
			//Console.WriteLine($"Default Priority = {defaultPriority}"); //Low 
			#endregion

			#region Example 02

			//Task task = new Task();
			//task.Id = 10;
			//task.Title = "First Task";
			//task.Priority = Priority.High;

			#endregion

			#region Example 03

			//int[] propritiesValues = (int[]) Enum.GetValues(typeof(Priority));
			//foreach (var proprity in propritiesValues)
			//	Console.WriteLine(proprity);
			//Console.WriteLine("===============================================");
			//string[] propritiesNames = Enum.GetNames(typeof(Priority));
			//foreach (var proprity in propritiesNames)
			//	Console.WriteLine(proprity);

			#endregion

			#endregion

			#region Using Enum [if , Switch]
			Season currentSeason = Season.Summer;
			Priority taskPriority = Priority.High;

			#region if

			//if (currentSeason == Season.Summer)	
			//	Console.WriteLine("Current Season Is Summer");
			//else
			//	Console.WriteLine("Current Season Is Not Summer");


			//if (taskPriority == Priority.High)
			//{
			//	Console.WriteLine("Urgent task");
			//}

			#endregion

			#region switch 
			//switch (currentSeason)
			//{
			//	case Season.Spring:
			//		Console.WriteLine("Spring");
			//		break;
			//	case Season.Summer:
			//		Console.WriteLine("Summer");
			//		break;
			//	case Season.Autumn:
			//		Console.WriteLine("Autumn");
			//		break;
			//	case Season.Winter:
			//		Console.WriteLine("Winter");
			//		break;
			//}

			//string urgency = taskPriority switch
			//{
			//	Priority.Low => "Can wait",
			//	Priority.Medium => "Soon",
			//	Priority.High => "Immediate!",
			//	_ => "Unknown"
			//};


			#endregion

			#endregion

			#region Enum Casting & Conversion

			#region Enum <-> Int
			////Enum to int
			//Season season = Season.Winter;
			//int seasonNumber = (int)season; // 3
			//Console.WriteLine($"Season Number : {seasonNumber}");

			//// int to Enum 
			//int numValue = 1;
			//Season seasonFromNumber = (Season)numValue; // Summer
			//Console.WriteLine($"Season From Number = {seasonFromNumber}");

			//int numValue = 100;
			//Season seasonFromNumber = (Season)numValue; // 100 Invalid Season
			//Console.WriteLine($"Season From Number = {seasonFromNumber}");


			//bool isDefined = Enum.IsDefined(typeof(Season), numValue);
			//Console.WriteLine($"isDefined : {isDefined}");


			//int numValue = 100;
			//Season seasonFromNumber;

			//if (Enum.IsDefined(typeof(Season), numValue))
			//{
			//	 seasonFromNumber = (Season)numValue;
			//	Console.WriteLine($"Season From Number = {seasonFromNumber}");
			//}
			//else
			//{
			//	seasonFromNumber = Season.Winter;
			//}
			//Console.WriteLine($"Season From Number = {seasonFromNumber}");



			#endregion

			#region Enum <-> String

			#region Enum To String 
			//Season mySeason = Season.Autumn;
			//string seasonName = mySeason.ToString();
			//Console.WriteLine($"Season Name : {seasonName}"); // Autumn
			#endregion

			#region String To Enum 
			#region Parse ()
			//string validInput = "Summer";
			//Season parsedSeason = (Season)Enum.Parse(typeof(Season), validInput);
			//Console.WriteLine($"Result: {parsedSeason}\n");

			//try
			//{
			//	Season invalid = (Season)Enum.Parse(typeof(Season), "InvalidSeason");
			//}
			//catch (ArgumentException ex)
			//{
			//	Console.WriteLine($"ArgumentException: {ex.Message}\n");
			//}
			#endregion

			#region TryParse()

			//string input01 = "Winter";
			//if (Enum.TryParse<Season>(input01, out Season result01))
			//{
			//	Console.WriteLine($"Result: {result01}"); // Winter 
			//}

			//string input02 = "InvalidSeason";
			//if (!Enum.TryParse<Season>(input02, out Season result02))
			//{
			//	Console.WriteLine($"Result: {result02}"); // default value - Spring 
			//}

			//// Case-insensitive parsing
			//if (Enum.TryParse<Season>("SUMMER", out Season caseResult01)) // False
			//{
			//	Console.WriteLine($"Result01: {caseResult01}");
			//}

			//if (Enum.TryParse<Season>("SUMMER", true, out Season caseResult02))
			//{
			//	Console.WriteLine($"Result02: {caseResult02}"); // summer
			//}
			#endregion
			#endregion

			#endregion

			#endregion

			#region Enum Example 
			//Student student = new Student();
			//Console.WriteLine("Please Enter Student Data : ");
			//int Id;
			//bool IsParsed;
			//do
			//{
			//	Console.Write("Id : ");
			//	IsParsed = int.TryParse(Console.ReadLine(), out Id);
			//} while (!IsParsed);
			//student.Id = Id;

			//Console.Write("Name : ");
			//student.Name = Console.ReadLine();

			//Gender StdGender;
			//do
			//{
			//	Console.Write("Gender : ");
			//	IsParsed = Enum.TryParse(Console.ReadLine(), out StdGender);
			//} while (!IsParsed || !Enum.IsDefined(StdGender));

			//student.Gender = StdGender;

			//Branch StdBranch;
			//do
			//{
			//	Console.Write("Branch : ");
			//	IsParsed = Enum.TryParse<Branch>(Console.ReadLine(), out StdBranch);
			//} while (!IsParsed || !Enum.IsDefined(StdBranch));
			//student.Branch = StdBranch;

			//Console.Clear();

			//Console.WriteLine($"Hello {student.Name} , Welcome To Route\nyour Branch Is {student.Branch} ");

			#endregion


			#endregion

			#region Part 02 Array 

			#region 1D Array

			#region Declaration
			//int[] arr1;                    // Declaration
			//arr1 = new int[5];             // Initialization with size
			//arr1[0] = 10;                  // Assign values
			//arr1[1] = 20;
			//arr1[2] = 30;
			//arr1[3] = 40;
			//arr1[4] = 50;

			////  Declaration with size
			//int[] arr2 = new int[5];       // All elements = 0 (default for int)



			//// Initialize with values
			//int[] arr3 = new int[] { 10, 20, 30, 40, 50 };

			//// Shorthand initialization
			//int[] arr4 = { 10, 20, 30, 40, 50 };          // Most concise

			//// Using var keyword
			//var arr5 = new int[] { 1, 2, 3, 4, 5 };  // Type inferred
			//var arr6 = new[] { 1, 2, 3, 4, 5 };      // Type inferred from elements

			#endregion

			#region Example 01

			//int[] scores = { 10, 50, 20, 25, 15, 30 };

			//// Find maximum

			//int maxScore = scores[0];
			//for (int i = 1; i < scores.Length; i++)
			//{
			//	if (scores[i] > maxScore)
			//		maxScore = scores[i];
			//}
			//Console.WriteLine($"Maximum value: {maxScore}");


			#endregion

			#region Example 02
			// Take Numbers From User (Positive Numbers Only are allowed) 
			// Then Print 
			//const int Size = 3;
			//int[] numbers = new int[Size];

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine($"Entry {i + 1} of {numbers.Length}");
			//	// Loop until we get a valid, positive integer
			//	while (true)
			//	{
			//		Console.Write("Please enter a positive number: ");

			//		if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
			//		{
			//			numbers[i] = num;
			//			break;
			//		}
			//		Console.ForegroundColor = ConsoleColor.Red; // Optional 
			//		Console.WriteLine("Invalid input. Please enter a positive number 0 or greater.");
			//		Console.ResetColor();// Optional 
			//	}
			//}

			//Console.Clear();

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine($"Number[{i}] = {numbers[i]}");
			//}

			#endregion

			#endregion

			#region 2D Array 

			//int[,] Marks = { { 50, 75, 64 }, { 100, 95, 97 }, { 86, 95, 75 } };

			#region Nested For

			//for (int row = 0; row < Marks.GetLength(0); row++)
			//{
			//	Console.WriteLine($"Student {row + 1}: ");
			//	for (int col = 0; col < Marks.GetLength(1); col++)
			//	{
			//		Console.Write($"Sub {col + 1} : {Marks[row, col]} , ");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region flat iteration
			//// Using For
			//for (int i = 0; i < Marks.Length; i++)
			//{
			//	Console.Write(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)] + " ");
			//}

			//Console.WriteLine("\n=======================================");

			//// Using foreach
			//foreach (int value in Marks)
			//{
			//	Console.Write(value + " ");
			//}

			#endregion

			#region Sum Of Values

			//int total = 0;
			//foreach (var item in Marks)
			//{
			//	total += item;
			//}
			//Console.WriteLine($"Sum of all elements: {total}");


			//for (int row = 0; row < Marks.GetLength(0); row++)
			//{
			//	int rowSum = 0;
			//	for (int col = 0; col < Marks.GetLength(1); col++)
			//	{
			//		rowSum += Marks[row, col];
			//	}
			//	Console.WriteLine($"Row {row} sum: {rowSum}");
			//}
			#endregion

			#endregion

			#endregion

			#region Part 03 User-Defined Functions
			// 1. Methods 
			// 1.1 Class Member Methods [Static Methods]
			// 1.2 Object Member Methods [Non static Methods]

			#region Function Prototype
			// void method example
			//SayHello(null); // Hello World
			//SayHello("Mohamed"); // Hello Mohamed

			//// Return value method example
			//int result = Add(5, 3);
			//Console.WriteLine($"Result = {result}"); // 8


			//// Method with multiple operations
			//int[] nums = { 10, 20, 30, 40, 50 };
			//double avg = CalculateAverage(nums);
			//Console.WriteLine($"Average = {avg}"); // 30 
			#endregion

			#region Function Parameters Passing By Value

			#region Value Type 
			//int A = 10, B = 5;
			//Console.WriteLine($"A = {A}"); // 10 
			//Console.WriteLine($"B = {B}"); // 5
			//Swap(10, 5); // Passing By Value 
			//Console.WriteLine("After Swapping");
			//Console.WriteLine($"A = {A}"); // 10 
			//Console.WriteLine($"B = {B}"); // 5 
			#endregion

			#region Reference Type
			//int[] numbers = { 1, 2, 3 };
			//Console.WriteLine($"Numbers[0] Before Calling SumArray = {numbers[0]}"); // 1
			//int Result = SumArray(numbers); // Passing By Value [Address]
			//Console.WriteLine($"Result = {Result}"); // 105
			//Console.WriteLine($"Numbers[0] After Calling SumArray = {numbers[0]}"); // 100
			#endregion

			#endregion

			#region Function Parameters Passing By Ref

			#region Value Type 
			//int A = 10, B = 5;
			//Console.WriteLine($"A = {A}"); // 10 
			//Console.WriteLine($"B = {B}"); // 5
			//Swap(ref A, ref B); // Passing By Ref 
			//Console.WriteLine("After Swapping");
			//Console.WriteLine($"A = {A}"); // 5 
			//Console.WriteLine($"B = {B}"); // 10 
			#endregion

			#region Reference Type
			//int[] numbers = { 1, 2, 3 };
			//Console.WriteLine($"Numbers[0] Before Calling SumArray = {numbers[0]}"); // 1
			//int Result = SumArray(ref numbers); // Passing By Ref [Memory] 
			//Console.WriteLine($"Result = {Result}"); // 105
			//Console.WriteLine($"Numbers[0] After Calling SumArray = {numbers[0]}"); // 100
			#endregion

			#endregion

			#region Function Parameters [Reference Type] Example 02 

			#region Passing By Value 

			//int[] numbers = { 1, 2, 3 };
			//Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 1
			//int Result = SumArrayV02(numbers);// Passing By Value [Address]
			//Console.WriteLine($"Sum = {Result}"); // 600
			//Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 1

			#endregion

			#region Passing By Ref 
			//int[] numbers = { 1, 2, 3 };
			//Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 1
			//int Result = SumArrayV02(ref numbers); // Passing By Reference [reference Of array [Numbers]]
			//Console.WriteLine($"Sum = {Result}"); // 600
			//Console.WriteLine($"Numbers[0] = {numbers[0]}"); // 100
			#endregion

			#endregion

			#region Function Parameters [Passing By out]
			//int[] numbers = { 1, 5, 2, 4, 3, 10, 7 };
			//int min, max;
			//GetMinMax(numbers, out min, out max);
			//Console.WriteLine($"Min Value is : {min}");
			//Console.WriteLine($"Max Value is : {max}");

			//// using passing by ref

			//  int[] numbers = { 1, 5, 2, 4, 3, 10, 7 };
			//int min = 0, max = 0;
			//GetMinMaxV02(numbers, ref min, ref max);
			//Console.WriteLine($"Min Value is : {min}");
			//Console.WriteLine($"Max Value is : {max}");
			#endregion

			#region Function Parameters Optional & Named Parameters

			//PrintMessage("Hello"); // Hello

			//PrintMessage("Hi", 3); // Hi Hi Hi

			//PrintMessage("Test", 2, true); // TEST TEST

			//PrintMessage(times: 2, message: "test", upper: true); // TEST TEST

			#endregion

			#region Function Parameters [Params]

			//Console.WriteLine($"Result 1 , 2  = {Sum(1, 2)}"); // 3
			//Console.WriteLine($"Result 1 , 2 , 3 , 4 , 5 =  {Sum(1, 2, 3, 4, 5)}"); // 15
			//Console.WriteLine($"Result 10 , 20 , 30 =  {Sum(10, 20, 30)}"); // 60
			//Console.WriteLine($"Result Nothing  = {Sum()} "); // 0

			//int[] numbers = { 100, 200, 300 };
			//int arraySum = Sum(numbers);  // Can also pass existing array
			//Console.WriteLine($"Result = {arraySum}"); // 600


			//PrintAll("Numbers", 1, 2, 3); // Numbers : 1 2 3

			//PrintAll("Mixed", "Hi", 42, true); // Mixed : Hi 42 True

			#endregion

			#endregion

		}

		#region Helper Methods

		#region Function Prototype
		//void method example
		static void SayHello(string? name)
		{
			if (name is not null)
				Console.WriteLine($"Hello {name}");
			else
				Console.WriteLine("Hello, World!");
		}

		// Return value method example
		static int Add(int a, int b)
		{
			return a + b;
		}

		// Calculate average
		static double CalculateAverage(int[] numbers)
		{
			int sum = 0;
			foreach (int n in numbers)
				sum += n;
			return (double)sum / numbers.Length;
		}

		#endregion

		#region Function Parameters Passing By Value

		static void Swap(int a, int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		static int SumArray(int[] numbers)
		{
			int total = 0;
			numbers[0] = 100;
			foreach (int n in numbers)
				total += n;
			return total;
		}
		#endregion

		#region Function Parameters Passing By Ref
		static void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
		static int SumArray(ref int[] numbers)
		{
			int total = 0;
			numbers[0] = 100;
			foreach (int n in numbers)
				total += n;
			return total;
		}
		#endregion

		#region Function Parameters [Reference Type] Example 02 
		static int SumArrayV02(int[] numbers)
		{
			int total = 0;
			numbers = [100, 200, 300];
			foreach (int n in numbers)
				total += n;
			return total;
		}

		static int SumArrayV02(ref int[] numbers)
		{
			int total = 0;
			numbers = [100, 200, 300];
			foreach (int n in numbers)
				total += n;
			return total;
		}

		#endregion

		#region Function Parameters [Passing By out]
		static void GetMinMax(int[] arr, out int min, out int max)
		{
			min = arr[0];
			max = arr[0];

			foreach (int num in arr)
			{
				if (num < min) min = num;
				if (num > max) max = num;
			}
		}
		static void GetMinMaxV02(int[] arr, ref int min, ref int max)
		{
			min = arr[0];
			max = arr[0];

			foreach (int num in arr)
			{
				if (num < min) min = num;
				if (num > max) max = num;
			}
		}

		#endregion

		#region Function Parameters Optional & Named Parameters
		static void PrintMessage(string message, int times = 1, bool upper = false)
		{
			for (int i = 0; i < times; i++)
			{
				if (upper)
					Console.Write(message.ToUpper() + " ");
				else
					Console.Write(message + " ");
			}
			Console.WriteLine();
		}

		#endregion

		#region Function Parameters [Params]
		static int Sum(params int[] numbers)
		{
			int total = 0;
			foreach (int n in numbers)
				total += n;
			return total;
		}

		static void PrintAll(string label, params object[] items)
		{
			Console.Write($"{label} : ");
			foreach (var item in items)
				Console.Write(item + " ");
		    Console.WriteLine();
		}

        static void PrintAllV02(string label, params List<int> items)
        {
            Console.Write($"{label} : ");
            foreach (var item in items)
                Console.Write(item + " ");
            Console.WriteLine();
        }
        #endregion

        #endregion
    }
}