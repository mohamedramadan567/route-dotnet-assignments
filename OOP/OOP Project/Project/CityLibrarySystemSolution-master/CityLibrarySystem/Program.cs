using CityLibrarySystem.Helpers;
using CityLibrarySystem.Models;
using CityLibrarySystem.Services;

namespace CityLibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBranch branch = DataSeeder.Seed();
            var display = new DisplayService();
            var libraryService = new LibraryService(branch, display);

            bool running = true;
            while (running)
            {
                try
                {
                    ConsoleHelper.ShowMenu();
                    string? choice = Console.ReadLine()?.Trim();
                    Console.WriteLine();

                    switch (choice)
                    {
                        case "1": display.ShowBranchInfo(branch); break;
                        case "2": display.ShowAllUsers(branch); break;
                        case "3": display.ShowAvailableCopies(branch); break;
                        case "4": display.ShowAllCopies(branch); break;
                        case "5": libraryService.HandleBorrow(); break;
                        case "6": libraryService.HandleReturn(); break;
                        case "7": libraryService.HandleHistory(); break;
                        case "8": libraryService.HandleRegisterMember(); break;
                        case "0":
                            Console.WriteLine("  Goodbye!");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("  Invalid option. Try again.");
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

                Console.WriteLine("\n  Press Enter to continue...");
                Console.ReadLine();

                Console.Clear();

            }
        }
    }
}
