namespace ConsoleTheme
{
    public static class ThemeHelper
    {
        public static void PrintHeader(string title)
        {
            int width = 40;
            Console.WriteLine(new string('═', width));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(title.PadLeft((width + title.Length) / 2));
            Console.ResetColor();
            Console.WriteLine(new string('═', width));
        }
        public static void PrintSectionTitle(string title)
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int width = 40;
            int sideWidth = (width - title.Length - 2) / 2;

            string side = new('─', sideWidth);

            Console.WriteLine($"{side} {title} {side}");

            Console.ResetColor();
        }
        public static void PrintOption(string option)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"  {option}");
            Console.ResetColor();
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }

        public static void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }

        public static void PrintWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }
        public static string Prompt(string label)
        {
            string? value;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"\nEnter {label} : ");

                Console.ForegroundColor = ConsoleColor.Green;
                value = Console.ReadLine()?.Trim();

                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(value))
                {
                    PrintWarning($"{label} cannot be empty. Please try again.");
                }

            } while (string.IsNullOrWhiteSpace(value));

            return value!;
        }
    }
}
