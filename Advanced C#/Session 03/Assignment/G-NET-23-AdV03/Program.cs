using G_NET_23_AdV03.Helpers;
using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace G_NET_23_AdV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            ////1. Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65
            //List<int> grades = new(8) { 85, 92, 78, 95, 88, 70, 100, 65 };
            ////2. Print the collection, Count, first and last grade 
            //ConsoleHelper.PrintList("Grades", grades);
            //Console.WriteLine($"Count: {grades.Count}");
            //Console.WriteLine($"First grade: {grades[0]}");
            //Console.WriteLine($"Last grade: {grades[^1]}");
            ////3.Sort the grades ascending, then print
            //grades.Sort();
            //ConsoleHelper.PrintList("Grades after sorting ascending", grades);
            ////4. Get the first grade above 90 
            //Console.WriteLine($"First grade above 90: {grades.Find(x => x > 90)}");
            ////5. Get all grades below 75 (failing grades) 
            //List<int> gradesBelow75 = grades.FindAll(x => x < 75);
            //ConsoleHelper.PrintList("All grades below 75", gradesBelow75);
            ////6. Remove all failing grades(below 75)
            //grades.RemoveAll(x => x < 75);
            //ConsoleHelper.PrintList("Grades After removing all grades below 75", grades);
            ////7. Check if any grade equals 100
            //Console.WriteLine($"Contains(100): {grades.Contains(100)}");
            ////8.Create a List<string> where each grade becomes "Grade: X"
            //List<string> stringGrades = grades.ConvertAll(x => $"Grade: {x}");
            //ConsoleHelper.PrintList("Grades become", stringGrades);

            #endregion

            #region Exercise 2: Leaderboard
            ////Create a leaderboard that automatically sorts players by score.
            ////1.Add: 500 = "Ahmed", 200 = "Sara", 800 = "Ali", 350 = "Mona"
            //SortedList<int, string> players = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            ////2.Print all entries(they should be sorted by score automatically)
            //ConsoleHelper.PrintSortedList("Players", players);
            ////3.Access the first key and first value
            //Console.WriteLine($"\nFirst key: {players.Keys[0]} - First value: {players.Values[0]}");
            ////4.Check if score 500 exists
            //Console.WriteLine($"Contains key(500): {players.ContainsKey(500)}");
            ////5.Safely get the player with score 999
            //if(players.TryGetValue(999, out string name))
            //    Console.WriteLine(players[999]);
            ////6.Remove the player with score 200 and print the updated lis
            //players.Remove(200);
            //ConsoleHelper.PrintSortedList("\nPlayers after remove score 200", players);

            #endregion

            #region Exercise 3: Phone Book 
            ////Build a phone book application. 
            ////1. Create a Collection  with 4 contacts (name → phone number) 
            //Dictionary<string, string> contacts = new()
            //{
            //    ["Mohamed"] = "01065575973",
            //    ["Ahmed"] = "01123456789",
            //    ["Sara"] = "01234567890",
            //    ["Laila"] = "01567891234"
            //};
            ////2. Add a new contact using [] syntax (add or update) 
            //contacts["Ramy"] = "01011301670";
            ////3. Try adding a duplicate using .Add() — catch the exception and print the error 
            //try
            //{
            //    contacts.Add("Ramy", "01011301670");
            //}
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine($"Error {ex.Message}");
            //}
            ////4. Try adding a duplicate using .TryAdd() — print whether it succeeded 
            //if(contacts.TryAdd("Ramy", "01011301670"))
            //    Console.WriteLine("Contact added successfuly :-)");
            //else
            //    Console.WriteLine("falied to add contact :-(");
            ////5. Search for a contact that doesn’t exist 
            //Console.WriteLine($"Contains Key(Ramadan): {contacts.ContainsKey("Ramadan")}");
            ////6. Get a contact with a fallback of "Not Found" 
            //if(contacts.TryGetValue("Yasser", out string number))
            //    Console.WriteLine($"{contacts["Yasser"]}");
            //else
            //    Console.WriteLine("Not Found");
            ////7. Print all Keys on one line, then all Values on another line
            //Console.Write("\nKeys of contacts: ");
            //foreach (var item in contacts.Keys)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.Write("\nValues of contacts: ");
            //foreach (var item in contacts.Values)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Exercise 4: Unique Email Validator 
            ////Use Collection to manage unique email addresses.
            ////1.Create a HashSet<string> with a case -insensitive comparer: new
            ////    HashSet<string>(StringComparer.OrdinalIgnoreCase)
            ////2.Add these emails: "ahmed@test.com", "AHMED@test.com", "sara@test.com", "Sara@Test.Com"
            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com", 
            //    "AHMED@test.com", 
            //    "sara@test.com", 
            //    "Sara@Test.Com"
            //};
            ////3.Print Count — how many are actually stored? Explain why.
            //Console.WriteLine($"Count: {emails.Count}"); // 2 because HashSet is a case -insensitive.
            ////4.Create two sets: Set A = { 1, 2, 3, 4, 5 } and Set B = { 4,5,6,7,8}
            //HashSet<int> A = [1, 2, 3, 4, 5];
            //HashSet<int> B = [4, 5, 6, 7, 8];
            //ConsoleHelper.PrintHashSet("A", A);
            //ConsoleHelper.PrintHashSet("B", B);

            ////5.Print the result of: UnionWith, IntersectWith, ExceptWith
            //HashSet<int> unionWith = new(A);
            //unionWith.UnionWith(B);
            //ConsoleHelper.PrintHashSet("A Union B", unionWith);

            //HashSet<int> intersectWith = new(A);
            //intersectWith.IntersectWith(B);
            //ConsoleHelper.PrintHashSet("A Intersect B", intersectWith);

            //HashSet<int> exceptWith = new(A);
            //exceptWith.ExceptWith(B);
            //ConsoleHelper.PrintHashSet("A Except B", exceptWith);
            ////6.Use IsSubsetOf to check if { 1,2} is a subset of Set A
            //HashSet<int> subset = [1, 2];
            //Console.WriteLine($"[1, 2] is subset of A: {subset.IsSubsetOf(A)}");
            #endregion

            #region Exercise 5: Print Queue Simulator
            ////Simulate a printer queue

            ////Create a Queue<string> and enqueue 5 documents: "Report.pdf", "Invoice.pdf", 
            ////"Letter.docx", "Resume.pdf", "Photo.jpg"
            //Queue<string> printer = new Queue<string>(5);
            //printer.Enqueue("Report.pdf");
            //printer.Enqueue("Invoice.pdf");
            //printer.Enqueue("Letter.pdf");
            //printer.Enqueue("Resume.pdf");
            //printer.Enqueue("Photo.pdf");

            ////1.Print the queue contents and Count
            //Console.WriteLine($"Printer Count: {printer.Count}");
            //ConsoleHelper.PrintQueue("Printer", printer);

            ////2.Use Peek to see which document will print next(without removing)
            //Console.WriteLine($"\nDocument will print next: {printer.Peek()}");

            ////3.Process the queue: Dequeue each document and print "Printing: [name]"
            //Console.WriteLine($"\nPrinting: [{printer.Dequeue()}]");
            //Console.WriteLine($"Printing: [{printer.Dequeue()}]");
            //Console.WriteLine($"Printing: [{printer.Dequeue()}]");
            //Console.WriteLine($"Printing: [{printer.Dequeue()}]");
            //Console.WriteLine($"Printing: [{printer.Dequeue()}]");

            ////4.Try TryDequeue on the now-empty queue — what happens?
            //if(printer.TryDequeue(out string document))
            //    Console.WriteLine(document);
            //else
            //    Console.WriteLine("\nQueue is empty!");
            #endregion

            #region Exercise 6: Browser History(Undo)
            ////Simulate browser back / forward
            ////Create a Stack<string> for browser history
            //Stack<string> browser = new(5);

            ////1.Push 5 URLs: "google.com", "github.com", "stackoverflow.com", "youtube.com",
            ////"claude.ai"
            //browser.Push("google.com");
            //browser.Push("github.com");
            //browser.Push("stackoverflow.com");
            //browser.Push("youtube.com");
            //browser.Push("claude.com");

            ////2.Use Peek to see the current page(top of stack)
            //Console.WriteLine($"The current page: {browser.Peek()}\n");

            ////3.Press "back" 3 times using Pop — print each page you leave
            //Console.WriteLine("I will leave this pages: ");
            //Console.WriteLine(browser.Pop());
            //Console.WriteLine(browser.Pop());
            //Console.WriteLine(browser.Pop());

            ////4.Print the current page after going back
            //Console.WriteLine($"\nThe current page: {browser.Peek()}\n");


            ////5.Try TryPop on an empty stack — what happens? 
            //browser.Pop();
            //browser.Pop();// stack now is empty!
            //if(browser.TryPop(out string page))
            //    Console.WriteLine(page);
            //else
            //    Console.WriteLine("Stack is empty!");

            #endregion
        }
    }
}
