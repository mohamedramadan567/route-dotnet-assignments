using ConsoleTheme;

namespace CityLibrarySystem.Helpers
{
    internal static class ConsoleHelper
    {
        public static void ShowMenu()
        {
            ThemeHelper.PrintHeader("      CITY LIBRARY - MAIN MENU         ");
            ThemeHelper.PrintOption("1. Branch Information");
            ThemeHelper.PrintOption("2. Show All Users");
            ThemeHelper.PrintOption("3. Show Available Books");
            ThemeHelper.PrintOption("4. Show All Book Copies");
            ThemeHelper.PrintOption("5. Borrow a Book");
            ThemeHelper.PrintOption("6. Return a Book");
            ThemeHelper.PrintOption("7. Member Borrowing History");
            ThemeHelper.PrintOption("8. Register New Member");
            Console.WriteLine(new string('-', 40));
            ThemeHelper.PrintOption("0. Exit");
            Console.WriteLine(new string('=', 40));
            Console.Write("Enter your choice: ");
        }
    }
}
